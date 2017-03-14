Imports System.Collections.Generic
Imports System.Collections
Imports System.Linq
Imports System.Text
Imports BaseClasses.Data
Imports Newtonsoft.Json
Imports System.Threading.Tasks

Imports BaseClasses.Utils

Namespace ePortalWFApproval.Data

    Public Class RestfulUtils
        Public Shared Sub ParseData(values As List(Of KeyValuePair(Of String, String)), ByRef requestedCols As SqlBuilderColumnSelection, ByRef workingSelCols As SqlBuilderColumnSelection, ByRef distinctSelCols As SqlBuilderColumnSelection, ByRef orderBy As OrderBy, ByRef table As KeylessVirtualTable)
            For Each value As KeyValuePair(Of String, String) In values
                Select Case value.Key
                    Case "SelectColumns"
                        Dim jsonDS As JSONDataSource = JsonConvert.DeserializeObject(Of JSONDataSource)(value.Value)
                        ConstructDataSourceObjectFromPostRequest(jsonDS, requestedCols, workingSelCols, distinctSelCols, orderBy, table)
                        Exit Select
                End Select
            Next
        End Sub

        Public Shared Sub ConstructDataSourceObjectFromPostRequest(jsonDS As JSONDataSource, ByRef requestedCols As SqlBuilderColumnSelection, ByRef workingSelCols As SqlBuilderColumnSelection, ByRef distinctSelCols As SqlBuilderColumnSelection, ByRef orderBy As OrderBy, ByRef table As KeylessVirtualTable)
            Dim ds As New DataSource()
            ds.Initialize(jsonDS.Name, DatabaseObjects.GetTableObject(jsonDS.Table), jsonDS.PageSize, jsonDS.PageIndex, jsonDS.GenerateTotal)

            If (jsonDS.JSelectItems IsNot Nothing) Then
                For Each jsonSItem As JDataSourceSelectItem In jsonDS.JSelectItems
                    ds.AddSelectItem(ConstructSelectItemFromPostRequest(jsonSItem))
                Next
            End If

            requestedCols = New SqlBuilderColumnSelection(jsonDS.ExpandForeignKeyColumns, jsonDS.IsDistinct)
            workingSelCols = New SqlBuilderColumnSelection(jsonDS.ExpandForeignKeyColumns, jsonDS.IsDistinct)
            distinctSelCols = New SqlBuilderColumnSelection(jsonDS.ExpandForeignKeyColumns, jsonDS.IsDistinct)

            Dim columnsList As List(Of BaseColumn) = Nothing
            If jsonDS.isTotalRecordArray Then
                columnsList = ds.CreateColumnSelectionsForTotal(requestedCols, workingSelCols, distinctSelCols)
            Else
                columnsList = ds.CreateColumnSelections(requestedCols, workingSelCols, distinctSelCols)
            End If
            table = ds.CreateVirtualTable(columnsList.ToArray())

            If (jsonDS.JOrderByList IsNot Nothing) Then
                For Each jsonOrderBy As JOrderBy In jsonDS.JOrderByList
                    ds.AddAggregateOrderBy(jsonOrderBy.ColumnName, OrderByItem.ToOrderDir(jsonOrderBy.OrderDirection))
                Next
            End If
            ds.UpdateOrderBy(columnsList)
            orderBy = ds.OrderBy
        End Sub

        Public Shared Function ConstructSelectItemFromPostRequest(jsonSItem As JDataSourceSelectItem) As SelectItem
            Dim sItem As SelectItem = Nothing
            If Not String.IsNullOrEmpty(jsonSItem.ColumnName) AndAlso Not String.IsNullOrEmpty(jsonSItem.TableName) Then
                Dim table As BaseTable = DatabaseObjects.GetTableObject(jsonSItem.TableName)
                sItem = New SelectItem(table.TableDefinition.ColumnList.GetByCodeName(jsonSItem.ColumnName), table, jsonSItem.Distinct, jsonSItem.AsClause, jsonSItem.TableAlias)
            ElseIf Not String.IsNullOrEmpty(jsonSItem.ItemType) AndAlso Not String.IsNullOrEmpty(jsonSItem.TableName) Then
                If Not String.IsNullOrEmpty(jsonSItem.AsClause) Then
                    If Not String.IsNullOrEmpty(jsonSItem.TableAlias) Then
                        sItem = New SelectItem(BaseClasses.Data.SelectItem.ItemTypeDefinition.GetItemType(jsonSItem.ItemType), DatabaseObjects.GetTableObject(jsonSItem.TableName), jsonSItem.AsClause, jsonSItem.TableAlias)
                    Else
                        sItem = New SelectItem(BaseClasses.Data.SelectItem.ItemTypeDefinition.GetItemType(jsonSItem.ItemType), DatabaseObjects.GetTableObject(jsonSItem.TableName), jsonSItem.AsClause)
                    End If
                Else
                    sItem = New SelectItem(BaseClasses.Data.SelectItem.ItemTypeDefinition.GetItemType(jsonSItem.ItemType), DatabaseObjects.GetTableObject(jsonSItem.TableName))
                End If
            Else
                If Not String.IsNullOrEmpty(jsonSItem.Operation) Then
                    If (jsonSItem.LeftItem IsNot Nothing) AndAlso (jsonSItem.RightItem Is Nothing) Then
                        sItem = New SelectItem(jsonSItem.Operation, ConstructSelectItemFromPostRequest(jsonSItem.LeftItem), jsonSItem.AsClause)
                    ElseIf (jsonSItem.LeftItem IsNot Nothing) AndAlso (jsonSItem.RightItem IsNot Nothing) Then
                        sItem = New SelectItem(jsonSItem.Operation, ConstructSelectItemFromPostRequest(jsonSItem.LeftItem), ConstructSelectItemFromPostRequest(jsonSItem.RightItem), jsonSItem.AsClause)
                    End If
                End If
            End If

            Return sItem
        End Function

        Public Shared Function GetRecordCount(jt As JSONTable) As Long
            Dim bt As BaseTable = Nothing
            Dim join As BaseFilter = Nothing
            Dim whereFilter As SqlFilter = Nothing
            Dim orderBy As OrderBy = Nothing
            Dim groupBy As GroupBy = Nothing

            ConstructTableObjectFromPostRequest(jt, bt, whereFilter, join, orderBy, groupBy)

            Dim count As Long = bt.GetRecordListCount(join, whereFilter, groupBy, orderBy)
            Return count
        End Function

        Public Shared Sub ConstructTableObjectFromPostRequest(jt As JSONTable, ByRef bt As BaseTable, ByRef whereFilter As SqlFilter, ByRef join As BaseFilter, ByRef orderBy As OrderBy, ByRef groupBy As GroupBy)
            bt = DirectCast(DatabaseObjects.GetTableObject(jt.TableName), BaseTable)

            Dim selCols As New ColumnList()
            If (jt.JSelectColumns IsNot Nothing) Then
                For Each col As JTableSelectColumn In jt.JSelectColumns
                    selCols.Add(col.ColumnName, True)
                Next

                bt.SelectedColumns.Clear()
                bt.SelectedColumns.AddRange(selCols)
            End If

            If jt.JWhereClause IsNot Nothing AndAlso jt.JWhereClause.Trim() <> "" Then
                whereFilter = New SqlFilter(jt.JWhereClause)
            End If

            If (jt.JOrderByList IsNot Nothing) Then
                For Each jOrderBy As JOrderBy In jt.JOrderByList
                    orderBy = New OrderBy(True, False)
                    orderBy.Add(bt.TableDefinition.ColumnList.GetByCodeName(jOrderBy.ColumnName), OrderByItem.ToOrderDir(jOrderBy.OrderDirection))
                Next
            End If

            If (jt.JGroupByList IsNot Nothing) Then
                For Each jGroupBy As JTableGroupBy In jt.JGroupByList
                    groupBy = New GroupBy(True, False)
                    groupBy.Add(bt.TableDefinition.ColumnList.GetByCodeName(jGroupBy.ColumnName))
                Next
            End If
        End Sub

        Public Shared Function GetRecords(jt As JSONTable) As ArrayList
            Dim bt As BaseTable = Nothing
            Dim pageIndex As Integer = 0
            Dim pageSize As Integer = 0
            Dim totalRows As Integer = 0
            Dim join As BaseFilter = Nothing
            Dim whereFilter As SqlFilter = Nothing
            Dim orderBy As OrderBy = Nothing

            ConstructTableObjectFromPostRequest(jt, bt, pageIndex, pageSize, totalRows, whereFilter, _
                join, orderBy)

            Dim recList As ArrayList = bt.GetRecordList(join, whereFilter, Nothing, orderBy, pageIndex, pageSize, _
                totalRows)
            Return recList
        End Function

        Public Shared Sub ConstructTableObjectFromPostRequest(jt As JSONTable, ByRef bt As BaseTable, ByRef pageIndex As Integer, ByRef pageSize As Integer, ByRef totalRows As Integer, ByRef whereFilter As SqlFilter, _
            ByRef join As BaseFilter, ByRef orderBy As OrderBy)
            pageIndex = jt.PageIndex
            pageSize = jt.PageSize
            totalRows = jt.TotalRows

            bt = DirectCast(DatabaseObjects.GetTableObject(jt.TableName), BaseTable)

            Dim selCols As New ColumnList()
            For Each col As JTableSelectColumn In jt.JSelectColumns
                selCols.Add(bt.TableDefinition.ColumnList.GetByCodeName(col.ColumnName), True)
            Next

            bt.SelectedColumns.Clear()
            bt.SelectedColumns.AddRange(selCols)

            If (jt.JOrderByList IsNot Nothing) Then
                For Each jOrderBy As JOrderBy In jt.JOrderByList
                    orderBy = New OrderBy(True, False)
                    orderBy.Add(bt.TableDefinition.ColumnList.GetByCodeName(jOrderBy.ColumnName), OrderByItem.ToOrderDir(jOrderBy.OrderDirection))
                Next
            End If

            If jt.JWhereClause IsNot Nothing AndAlso jt.JWhereClause.Trim() <> "" Then
                whereFilter = New SqlFilter(jt.JWhereClause)
            End If

        End Sub

        Public Shared Function SaveRecord(jr As JSONRecord, ByRef errMsg As String) As String
            Dim rec As PrimaryKeyRecord = Nothing
            ConstructRecordObjectFromPostSaveRequest(jr, rec)

            Try
                DbUtils.StartTransaction()

                rec.Save()
                DbUtils.CommitTransaction()
            Catch ex As Exception
                DbUtils.RollBackTransaction()
                errMsg = ex.Message

                Return String.Empty
            Finally
                DbUtils.EndTransaction()
            End Try

            Return rec.GetID().ToXmlString()
        End Function

        Public Shared Sub ConstructRecordObjectFromPostSaveRequest(jr As JSONRecord, ByRef rec As PrimaryKeyRecord)
            Dim t As PrimaryKeyTable = DirectCast(DatabaseObjects.GetTableObject(jr.TableName), PrimaryKeyTable)
            t.ResetSelectedColumns()

            rec = New PrimaryKeyRecord(t)
            rec.IsExistsInDatabase = jr.IsExistsInDatabase

            If (jr.JRecordValues IsNot Nothing) Then
                For Each jRecordValue As JRecordValue In jr.JRecordValues
                    Dim bc As BaseColumn = t.TableDefinition.ColumnList.GetByCodeName(jRecordValue.ColumnName)
                    If Not bc.IsValuesReadOnly Then
                        rec.Parse(jRecordValue.ColumnValue, bc)
                    ElseIf t.TableDefinition.IsPrimaryKeyElement(bc) Then
                        Dim kv As New KeyValue()
                        kv.AddElement(jRecordValue.ColumnName, jRecordValue.ColumnValue.ToString())
                        rec.PrimaryKeyValue = kv
                    End If
                Next
            End If
        End Sub

        Public Shared Sub DeleteRecord(jr As JSONRecord, ByRef errMsg As String)
            Dim pk As PrimaryKeyTable = Nothing
            Dim kvList As New List(Of KeyValue)()
            ConstructRecordObjectFromPostDeleteRequest(jr, pk, kvList)

            Try
                For Each kv As KeyValue In kvList
                    DbUtils.StartTransaction()

                    pk.DeleteOneRecord(kv)

                    DbUtils.CommitTransaction()
                Next
            Catch ex As Exception
                DbUtils.RollBackTransaction()
                errMsg = ex.Message
            Finally
                DbUtils.EndTransaction()
            End Try
        End Sub

        Public Shared Sub ConstructRecordObjectFromPostDeleteRequest(jr As JSONRecord, ByRef pk As PrimaryKeyTable, ByRef kvList As List(Of KeyValue))
            pk = DirectCast(DatabaseObjects.GetTableObject(jr.TableName), PrimaryKeyTable)

            If (jr.JRecordValues IsNot Nothing) Then
                For Each jRecordValue As JRecordValue In jr.JRecordValues
                    Dim kv As New KeyValue()
                    kv.AddElement(jRecordValue.ColumnName, jRecordValue.ColumnValue.ToString())

                    kvList.Add(kv)
                Next
            End If
        End Sub
    End Class

End Namespace
