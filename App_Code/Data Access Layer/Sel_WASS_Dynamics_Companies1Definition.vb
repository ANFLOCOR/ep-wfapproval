﻿Namespace ePortalWFApproval.Business
''' <summary>
''' Contains embedded schema and configuration data that is used by the 
''' <see cref="Sel_WASS_Dynamics_Companies1View">ePortalWFApproval.Sel_WASS_Dynamics_Companies1View</see> class
''' to initialize the class's TableDefinition.
''' </summary>
''' <seealso cref="Sel_WASS_Dynamics_Companies1View"></seealso>

Public Class Sel_WASS_Dynamics_Companies1Definition

#Region "Definition (XML) for Sel_WASS_Dynamics_Companies1Definition table"
	'Next 124 lines contain Table Definition (XML) for table "Sel_WASS_Dynamics_Companies1Definition"
	Private Shared _DefinitionString As String = ""
#End Region
	
	''' <summary>
	''' Gets the embedded schema and configuration data for the  
	''' <see cref="Sel_WASS_Dynamics_Companies1View"></see>
	''' class's TableDefinition.
	''' </summary>
	''' <remarks>This function is only called once at runtime.</remarks>
	''' <returns>An XML string.</returns>
	Public Shared Function GetXMLString() As String
		If _DefinitionString = "" Then
			         Dim tbf As System.Text.StringBuilder = New System.Text.StringBuilder()
         tbf.Append("<XMLDefinition Generator=""Iron Speed Designer"" Version=""12.1"" Type=""VIEW"">")
         tbf.Append(  "<ColumnDefinition>")
         tbf.Append(    "<Column InternalName=""0"" Priority=""1"" ColumnNum=""0"">")
         tbf.Append(      "<columnName>SSC_CompanyName</columnName>")
         tbf.Append(      "<columnUIName>SSC Company Name</columnUIName>")
         tbf.Append(      "<columnType>String</columnType>")
         tbf.Append(      "<columnDBType>varchar</columnDBType>")
         tbf.Append(      "<columnLengthSet>50</columnLengthSet>")
         tbf.Append(      "<columnDefault></columnDefault>")
         tbf.Append(      "<columnDBDefault></columnDBDefault>")
         tbf.Append(      "<columnIndex>N</columnIndex>")
         tbf.Append(      "<columnUnique>N</columnUnique>")
         tbf.Append(      "<columnFunction></columnFunction>")
         tbf.Append(      "<columnDBFormat></columnDBFormat>")
         tbf.Append(      "<columnPK>N</columnPK>")
         tbf.Append(      "<columnPermanent>N</columnPermanent>")
         tbf.Append(      "<columnComputed>N</columnComputed>")
         tbf.Append(      "<columnIdentity>N</columnIdentity>")
         tbf.Append(      "<columnReadOnly>N</columnReadOnly>")
         tbf.Append(      "<columnRequired>N</columnRequired>")
         tbf.Append(      "<columnNotNull>N</columnNotNull>")
         tbf.Append(      "<columnCaseSensitive Source=""Database"">N</columnCaseSensitive>")
         tbf.Append(      "<columnCollation>SQL_Latin1_General_CP1_CI_AS</columnCollation>")
         tbf.Append(      "<columnFullText>N</columnFullText>")
         tbf.Append(      "<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>")
         tbf.Append(      "<columnTableAliasName></columnTableAliasName>")
         tbf.Append(      "<applyLabelText>Y</applyLabelText>")
         tbf.Append(    "</Column>")
         tbf.Append(    "<Column InternalName=""1"" Priority=""2"" ColumnNum=""1"">")
         tbf.Append(      "<columnName>SSC_Description</columnName>")
         tbf.Append(      "<columnUIName>SSC Description</columnUIName>")
         tbf.Append(      "<columnType>String</columnType>")
         tbf.Append(      "<columnDBType>varchar</columnDBType>")
         tbf.Append(      "<columnLengthSet>100</columnLengthSet>")
         tbf.Append(      "<columnDefault></columnDefault>")
         tbf.Append(      "<columnDBDefault></columnDBDefault>")
         tbf.Append(      "<columnIndex>N</columnIndex>")
         tbf.Append(      "<columnUnique>N</columnUnique>")
         tbf.Append(      "<columnFunction></columnFunction>")
         tbf.Append(      "<columnDBFormat></columnDBFormat>")
         tbf.Append(      "<columnPK>N</columnPK>")
         tbf.Append(      "<columnPermanent>N</columnPermanent>")
         tbf.Append(      "<columnComputed>N</columnComputed>")
         tbf.Append(      "<columnIdentity>N</columnIdentity>")
         tbf.Append(      "<columnReadOnly>N</columnReadOnly>")
         tbf.Append(      "<columnRequired>N</columnRequired>")
         tbf.Append(      "<columnNotNull>N</columnNotNull>")
         tbf.Append(      "<columnCaseSensitive Source=""Database"">N</columnCaseSensitive>")
         tbf.Append(      "<columnCollation>SQL_Latin1_General_CP1_CI_AS</columnCollation>")
         tbf.Append(      "<columnFullText>N</columnFullText>")
         tbf.Append(      "<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>")
         tbf.Append(      "<columnTableAliasName></columnTableAliasName>")
         tbf.Append(      "<applyLabelText>Y</applyLabelText>")
         tbf.Append(    "</Column>")
         tbf.Append(    "<Column InternalName=""2"" Priority=""3"" ColumnNum=""2"">")
         tbf.Append(      "<columnName>INTERID</columnName>")
         tbf.Append(      "<columnUIName>Inter</columnUIName>")
         tbf.Append(      "<columnType>String</columnType>")
         tbf.Append(      "<columnDBType>varchar</columnDBType>")
         tbf.Append(      "<columnLengthSet>50</columnLengthSet>")
         tbf.Append(      "<columnDefault></columnDefault>")
         tbf.Append(      "<columnDBDefault></columnDBDefault>")
         tbf.Append(      "<columnIndex>N</columnIndex>")
         tbf.Append(      "<columnUnique>N</columnUnique>")
         tbf.Append(      "<columnFunction></columnFunction>")
         tbf.Append(      "<columnDBFormat></columnDBFormat>")
         tbf.Append(      "<columnPK>N</columnPK>")
         tbf.Append(      "<columnPermanent>N</columnPermanent>")
         tbf.Append(      "<columnComputed>N</columnComputed>")
         tbf.Append(      "<columnIdentity>N</columnIdentity>")
         tbf.Append(      "<columnReadOnly>N</columnReadOnly>")
         tbf.Append(      "<columnRequired>N</columnRequired>")
         tbf.Append(      "<columnNotNull>N</columnNotNull>")
         tbf.Append(      "<columnCaseSensitive Source=""Database"">N</columnCaseSensitive>")
         tbf.Append(      "<columnCollation>SQL_Latin1_General_CP1_CI_AS</columnCollation>")
         tbf.Append(      "<columnFullText>N</columnFullText>")
         tbf.Append(      "<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>")
         tbf.Append(      "<columnTableAliasName></columnTableAliasName>")
         tbf.Append(      "<applyLabelText>Y</applyLabelText>")
         tbf.Append(    "</Column>")
         tbf.Append(    "<Column InternalName=""3"" Priority=""4"" ColumnNum=""3"">")
         tbf.Append(      "<columnName>SSC_CompanyID</columnName>")
         tbf.Append(      "<columnUIName>SSC Company</columnUIName>")
         tbf.Append(      "<columnType>Number</columnType>")
         tbf.Append(      "<columnDBType>smallint</columnDBType>")
         tbf.Append(      "<columnLengthSet>5.0</columnLengthSet>")
         tbf.Append(      "<columnDefault></columnDefault>")
         tbf.Append(      "<columnDBDefault></columnDBDefault>")
         tbf.Append(      "<columnIndex>N</columnIndex>")
         tbf.Append(      "<columnUnique>N</columnUnique>")
         tbf.Append(      "<columnFunction></columnFunction>")
         tbf.Append(      "<columnDBFormat></columnDBFormat>")
         tbf.Append(      "<columnPK>N</columnPK>")
         tbf.Append(      "<columnPermanent>N</columnPermanent>")
         tbf.Append(      "<columnComputed>Y</columnComputed>")
         tbf.Append(      "<columnIdentity>Y</columnIdentity>")
         tbf.Append(      "<columnReadOnly>Y</columnReadOnly>")
         tbf.Append(      "<columnRequired>N</columnRequired>")
         tbf.Append(      "<columnNotNull>Y</columnNotNull>")
         tbf.Append(      "<columnCaseSensitive>N</columnCaseSensitive>")
         tbf.Append(      "<columnCollation></columnCollation>")
         tbf.Append(      "<columnFullText>N</columnFullText>")
         tbf.Append(      "<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>")
         tbf.Append(      "<columnTableAliasName></columnTableAliasName>")
         tbf.Append(      "<applyLabelText>Y</applyLabelText>")
         tbf.Append(    "</Column>")
         tbf.Append(  "</ColumnDefinition>")
         tbf.Append(  "<TableName>sel_WASS_Dynamics_Companies</TableName>")
         tbf.Append(  "<Version></Version>")
         tbf.Append(  "<Owner>dbo</Owner>")
         tbf.Append(  "<TableAliasName>sel_WASS_Dynamics_Companies_</TableAliasName>")
         tbf.Append(  "<ConnectionName>DatabaseWASSN</ConnectionName>")
         tbf.Append(  "<PagingMethod>RowNum</PagingMethod>")
         tbf.Append(  "<canCreateRecords Source=""Database"">N</canCreateRecords>")
         tbf.Append(  "<canEditRecords Source=""Database"">N</canEditRecords>")
         tbf.Append(  "<canDeleteRecords Source=""Database"">N</canDeleteRecords>")
         tbf.Append(  "<canViewRecords Source=""Database"">N</canViewRecords>")
         tbf.Append(  "<AppShortName>ePortalWFApproval</AppShortName>")
         tbf.Append(  "<FolderName>sel_WASS_Dynamics_Companies1</FolderName>")
         tbf.Append(  "<MenuName>WASS Dynamics Companies1</MenuName>")
         tbf.Append(  "<QSPath>../sel_WASS_Dynamics_Companies1/Sel-WASS-Dynamics-Companies-QuickSelector1.aspx</QSPath>")
         tbf.Append(  "<TableCodeName>Sel_WASS_Dynamics_Companies1</TableCodeName>")
         tbf.Append(  "<TableStoredProcPrefix>pePortalWFApprovalSel_WASS_Dynamics_Companies1</TableStoredProcPrefix>")
         tbf.Append("</XMLDefinition>")
         _DefinitionString = tbf.ToString()

		End	If	
		Return _DefinitionString		
	End Function

End Class
End Namespace
