﻿Namespace ePortalWFApproval.Business
''' <summary>
''' Contains embedded schema and configuration data that is used by the 
''' <see cref="Sel_W_User_W_ModuleView">ePortalWFApproval.Sel_W_User_W_ModuleView</see> class
''' to initialize the class's TableDefinition.
''' </summary>
''' <seealso cref="Sel_W_User_W_ModuleView"></seealso>

Public Class Sel_W_User_W_ModuleDefinition

#Region "Definition (XML) for Sel_W_User_W_ModuleDefinition table"
	'Next 117 lines contain Table Definition (XML) for table "Sel_W_User_W_ModuleDefinition"
	Private Shared _DefinitionString As String = ""
#End Region
	
	''' <summary>
	''' Gets the embedded schema and configuration data for the  
	''' <see cref="Sel_W_User_W_ModuleView"></see>
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
         tbf.Append(      "<columnName>W_U_ID</columnName>")
         tbf.Append(      "<columnUIName Source=""User"">W U</columnUIName>")
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
         tbf.Append(      "<columnNotNull>Y</columnNotNull>")
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
         tbf.Append(      "<applyDFKA>Y</applyDFKA>")
         tbf.Append(      "<readingRecordFormula></readingRecordFormula>")
         tbf.Append(      "<insertingRecordFormula></insertingRecordFormula>")
         tbf.Append(      "<updatingRecordFormula></updatingRecordFormula>")
         tbf.Append(      "<insertingFormula></insertingFormula>")
         tbf.Append(      "<updatingFormula></updatingFormula>")
         tbf.Append(      "<columnVirtualPK Source=""User"">Y</columnVirtualPK>")
         tbf.Append(      "<foreignKey>")
         tbf.Append(        "<columnFKName>VFK_sel_W_User_W_Module_W_U_ID_1</columnFKName>")
         tbf.Append(        "<columnFKTable>ePortalWFApproval.Business.W_UserTable, App_Code</columnFKTable>")
         tbf.Append(        "<columnFKOwner>dbo</columnFKOwner>")
         tbf.Append(        "<columnFKColumn>W_U_ID</columnFKColumn>")
         tbf.Append(        "<columnFKColumnDisplay>= W_User.W_U_User_Name</columnFKColumnDisplay>")
         tbf.Append(        "<foreignKeyType>Implicit</foreignKeyType>")
         tbf.Append(      "</foreignKey>")
         tbf.Append(    "</Column>")
         tbf.Append(    "<Column InternalName=""1"" Priority=""2"" ColumnNum=""1"">")
         tbf.Append(      "<columnName>W_MS_ID</columnName>")
         tbf.Append(      "<columnUIName Source=""User"">W MS</columnUIName>")
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
         tbf.Append(      "<columnNotNull>Y</columnNotNull>")
         tbf.Append(      "<columnCaseSensitive Source=""User"">N</columnCaseSensitive>")
         tbf.Append(      "<columnCollation></columnCollation>")
         tbf.Append(      "<columnFullText Source=""User"">N</columnFullText>")
         tbf.Append(      "<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>")
         tbf.Append(      "<columnTableAliasName></columnTableAliasName>")
         tbf.Append(      "<applyLabelText>Y</applyLabelText>")
         tbf.Append(      "<InternalName>1</InternalName>")
         tbf.Append(      "<columnTableClassName></columnTableClassName>")
         tbf.Append(      "<applyInitializeReadingRecord>N</applyInitializeReadingRecord>")
         tbf.Append(      "<applyInitializeInsertingRecord>N</applyInitializeInsertingRecord>")
         tbf.Append(      "<applyInitializeUpdatingRecord>N</applyInitializeUpdatingRecord>")
         tbf.Append(      "<applyValidateInsertingRecord>N</applyValidateInsertingRecord>")
         tbf.Append(      "<applyValidateUpdatingRecord>N</applyValidateUpdatingRecord>")
         tbf.Append(      "<applyDefaultValue>N</applyDefaultValue>")
         tbf.Append(      "<applyDFKA>Y</applyDFKA>")
         tbf.Append(      "<readingRecordFormula></readingRecordFormula>")
         tbf.Append(      "<insertingRecordFormula></insertingRecordFormula>")
         tbf.Append(      "<updatingRecordFormula></updatingRecordFormula>")
         tbf.Append(      "<insertingFormula></insertingFormula>")
         tbf.Append(      "<updatingFormula></updatingFormula>")
         tbf.Append(      "<foreignKey>")
         tbf.Append(        "<columnFKName>VFK_sel_W_User_W_Module_W_MS_ID_1</columnFKName>")
         tbf.Append(        "<columnFKTable>ePortalWFApproval.Business.W_Module_SourceTable, App_Code</columnFKTable>")
         tbf.Append(        "<columnFKOwner>dbo</columnFKOwner>")
         tbf.Append(        "<columnFKColumn>W_MS_ID</columnFKColumn>")
         tbf.Append(        "<columnFKColumnDisplay>= W_Module_Source.W_MS_Name</columnFKColumnDisplay>")
         tbf.Append(        "<foreignKeyType>Implicit</foreignKeyType>")
         tbf.Append(      "</foreignKey>")
         tbf.Append(      "<columnVirtualPK Source=""User"">Y</columnVirtualPK>")
         tbf.Append(    "</Column>")
         tbf.Append(  "</ColumnDefinition>")
         tbf.Append(  "<TableName>sel_W_User_W_Module</TableName>")
         tbf.Append(  "<Version></Version>")
         tbf.Append(  "<Owner>dbo</Owner>")
         tbf.Append(  "<TableAliasName>sel_W_User_W_Module_</TableAliasName>")
         tbf.Append(  "<ConnectionName>DatabaseANFLO-WASP</ConnectionName>")
         tbf.Append(  "<canCreateRecords Source=""User"">N</canCreateRecords>")
         tbf.Append(  "<canEditRecords Source=""User"">N</canEditRecords>")
         tbf.Append(  "<canDeleteRecords Source=""User"">N</canDeleteRecords>")
         tbf.Append(  "<canViewRecords Source=""Database"">Y</canViewRecords>")
         tbf.Append(  "<AppShortName>ePortalWFApproval</AppShortName>")
         tbf.Append(  "<FolderName>sel_W_User_W_Module</FolderName>")
         tbf.Append(  "<MenuName>W User W Module</MenuName>")
         tbf.Append(  "<QSPath>../sel_W_User_W_Module/Sel-W-User-W-Module-QuickSelector.aspx</QSPath>")
         tbf.Append(  "<TableCodeName>Sel_W_User_W_Module</TableCodeName>")
         tbf.Append(  "<TableStoredProcPrefix>pePortalWFApprovalSel_W_User_W_Module</TableStoredProcPrefix>")
         tbf.Append("</XMLDefinition>")
         _DefinitionString = tbf.ToString()

		End	If	
		Return _DefinitionString		
	End Function

End Class
End Namespace
