Namespace ePortalWFApproval.Business
''' <summary>
''' Contains embedded schema and configuration data that is used by the 
''' <see cref="Vw_WFinRep_DocAttach_FIN_MonthView">ePortalWFApproval.Vw_WFinRep_DocAttach_FIN_MonthView</see> class
''' to initialize the class's TableDefinition.
''' </summary>
''' <seealso cref="Vw_WFinRep_DocAttach_FIN_MonthView"></seealso>

Public Class Vw_WFinRep_DocAttach_FIN_MonthDefinition

#Region "Definition (XML) for Vw_WFinRep_DocAttach_FIN_MonthDefinition table"
	'Next 87 lines contain Table Definition (XML) for table "Vw_WFinRep_DocAttach_FIN_MonthDefinition"
	Private Shared _DefinitionString As String = ""
#End Region
	
	''' <summary>
	''' Gets the embedded schema and configuration data for the  
	''' <see cref="Vw_WFinRep_DocAttach_FIN_MonthView"></see>
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
         tbf.Append(      "<columnName>Mo</columnName>")
         tbf.Append(      "<columnUIName>Month</columnUIName>")
         tbf.Append(      "<columnType>Number</columnType>")
         tbf.Append(      "<columnDBType>int</columnDBType>")
         tbf.Append(      "<columnLengthSet>10.0</columnLengthSet>")
         tbf.Append(      "<columnDefault></columnDefault>")
         tbf.Append(      "<columnDBDefault Source=""User""></columnDBDefault>")
         tbf.Append(      "<columnIndex>N</columnIndex>")
         tbf.Append(      "<columnUnique>N</columnUnique>")
         tbf.Append(      "<columnFunction></columnFunction>")
         tbf.Append(      "<columnDBFormat></columnDBFormat>")
         tbf.Append(      "<columnPK>Y</columnPK>")
         tbf.Append(      "<columnPermanent>N</columnPermanent>")
         tbf.Append(      "<columnComputed Source=""User"">N</columnComputed>")
         tbf.Append(      "<columnIdentity Source=""User"">N</columnIdentity>")
         tbf.Append(      "<columnReadOnly Source=""User"">N</columnReadOnly>")
         tbf.Append(      "<columnRequired>Y</columnRequired>")
         tbf.Append(      "<columnNotNull>N</columnNotNull>")
         tbf.Append(      "<columnCaseSensitive Source=""User"">N</columnCaseSensitive>")
         tbf.Append(      "<columnCollation></columnCollation>")
         tbf.Append(      "<columnFullText Source=""User"">N</columnFullText>")
         tbf.Append(      "<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>")
         tbf.Append(      "<columnTableAliasName></columnTableAliasName>")
         tbf.Append(      "<applyLabelText>Y</applyLabelText>")
         tbf.Append(      "<InternalName>0</InternalName>")
         tbf.Append(      "<columnTableClassName></columnTableClassName>")
         tbf.Append(      "<applyInitializeReadingRecord>N</applyInitializeReadingRecord>")
         tbf.Append(      "<applyInitializeInsertingRecord>N</applyInitializeInsertingRecord>")
         tbf.Append(      "<applyInitializeUpdatingRecord>N</applyInitializeUpdatingRecord>")
         tbf.Append(      "<applyValidateInsertingRecord>N</applyValidateInsertingRecord>")
         tbf.Append(      "<applyValidateUpdatingRecord>N</applyValidateUpdatingRecord>")
         tbf.Append(      "<applyDefaultValue>N</applyDefaultValue>")
         tbf.Append(      "<applyDFKA>N</applyDFKA>")
         tbf.Append(      "<readingRecordFormula></readingRecordFormula>")
         tbf.Append(      "<insertingRecordFormula></insertingRecordFormula>")
         tbf.Append(      "<updatingRecordFormula></updatingRecordFormula>")
         tbf.Append(      "<insertingFormula></insertingFormula>")
         tbf.Append(      "<updatingFormula></updatingFormula>")
         tbf.Append(      "<columnVirtualPK Source=""User"">Y</columnVirtualPK>")
         tbf.Append(    "</Column>")
         tbf.Append(    "<Column InternalName=""1"" Priority=""2"" ColumnNum=""1"">")
         tbf.Append(      "<columnName>MoName</columnName>")
         tbf.Append(      "<columnUIName>Month Name</columnUIName>")
         tbf.Append(      "<columnType>String</columnType>")
         tbf.Append(      "<columnDBType>nvarchar</columnDBType>")
         tbf.Append(      "<columnLengthSet>30</columnLengthSet>")
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
         tbf.Append(  "</ColumnDefinition>")
         tbf.Append(  "<TableName>vw_WFinRep_DocAttach_FIN_Month</TableName>")
         tbf.Append(  "<Version></Version>")
         tbf.Append(  "<Owner>dbo</Owner>")
         tbf.Append(  "<TableAliasName>Vw_WFinRep_DocAttac_671747064_</TableAliasName>")
         tbf.Append(  "<ConnectionName>DatabaseANFLO-WF</ConnectionName>")
         tbf.Append(  "<PagingMethod>RowNum</PagingMethod>")
         tbf.Append(  "<canCreateRecords Source=""User"">Y</canCreateRecords>")
         tbf.Append(  "<canEditRecords Source=""User"">Y</canEditRecords>")
         tbf.Append(  "<canDeleteRecords Source=""User"">Y</canDeleteRecords>")
         tbf.Append(  "<canViewRecords Source=""Database"">Y</canViewRecords>")
         tbf.Append(  "<AppShortName>ePortalWFApproval</AppShortName>")
         tbf.Append(  "<FolderName>vw_WFinRep_DocAttach_FIN_Month</FolderName>")
         tbf.Append(  "<MenuName>WFin Representative Document~Month</MenuName>")
         tbf.Append(  "<QSPath>../vw_WFinRep_DocAttach_FIN_Month/Vw-WFinRep-DocAttach-FIN-Month-QuickSelector.aspx</QSPath>")
         tbf.Append(  "<TableCodeName>Vw_WFinRep_DocAttach_FIN_Month</TableCodeName>")
         tbf.Append(  "<TableStoredProcPrefix>pePortalWFApprovalVw_WFinRep_DocAttach_FIN_Month</TableStoredProcPrefix>")
         tbf.Append("</XMLDefinition>")
         _DefinitionString = tbf.ToString()

		End	If	
		Return _DefinitionString		
	End Function

End Class
End Namespace
