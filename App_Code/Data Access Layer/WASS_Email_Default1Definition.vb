Namespace ePortalWFApproval.Business
''' <summary>
''' Contains embedded schema and configuration data that is used by the 
''' <see cref="WASS_Email_Default1Table">ePortalWFApproval.WASS_Email_Default1Table</see> class
''' to initialize the class's TableDefinition.
''' </summary>
''' <seealso cref="WASS_Email_Default1Table"></seealso>

Public Class WASS_Email_Default1Definition

#Region "Definition (XML) for WASS_Email_Default1Definition table"
	'Next 99 lines contain Table Definition (XML) for table "WASS_Email_Default1Definition"
	Private Shared _DefinitionString As String = ""
#End Region
	
	''' <summary>
	''' Gets the embedded schema and configuration data for the  
	''' <see cref="WASS_Email_Default1Table"></see>
	''' class's TableDefinition.
	''' </summary>
	''' <remarks>This function is only called once at runtime.</remarks>
	''' <returns>An XML string.</returns>
	Public Shared Function GetXMLString() As String
		If _DefinitionString = "" Then
			         Dim tbf As System.Text.StringBuilder = New System.Text.StringBuilder()
         tbf.Append("<XMLDefinition Generator=""Iron Speed Designer"" Version=""12.1"" Type=""GENERIC"">")
         tbf.Append(  "<ColumnDefinition>")
         tbf.Append(    "<Column InternalName=""0"" Priority=""1"" ColumnNum=""0"">")
         tbf.Append(      "<columnName>WED_ID</columnName>")
         tbf.Append(      "<columnUIName>Wed</columnUIName>")
         tbf.Append(      "<columnType>Number</columnType>")
         tbf.Append(      "<columnDBType>int</columnDBType>")
         tbf.Append(      "<columnLengthSet>10.0</columnLengthSet>")
         tbf.Append(      "<columnDefault></columnDefault>")
         tbf.Append(      "<columnDBDefault></columnDBDefault>")
         tbf.Append(      "<columnIndex>Y</columnIndex>")
         tbf.Append(      "<columnUnique>Y</columnUnique>")
         tbf.Append(      "<columnFunction>notrim</columnFunction>")
         tbf.Append(      "<columnDBFormat></columnDBFormat>")
         tbf.Append(      "<columnPK>Y</columnPK>")
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
         tbf.Append(    "<Column InternalName=""1"" Priority=""2"" ColumnNum=""1"">")
         tbf.Append(      "<columnName>WED_Type</columnName>")
         tbf.Append(      "<columnUIName>WED Type</columnUIName>")
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
         tbf.Append(    "<Column InternalName=""2"" Priority=""3"" ColumnNum=""2"">")
         tbf.Append(      "<columnName>WED_Template</columnName>")
         tbf.Append(      "<columnUIName>WED Template</columnUIName>")
         tbf.Append(      "<columnType>Very Large String</columnType>")
         tbf.Append(      "<columnDBType>text</columnDBType>")
         tbf.Append(      "<columnLengthSet>2147483647</columnLengthSet>")
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
         tbf.Append(  "<TableName>WASS_Email_Default</TableName>")
         tbf.Append(  "<Version></Version>")
         tbf.Append(  "<Owner>dbo</Owner>")
         tbf.Append(  "<TableAliasName>WASS_Email_Default_</TableAliasName>")
         tbf.Append(  "<ConnectionName>DatabaseWASSN</ConnectionName>")
         tbf.Append(  "<PagingMethod>RowNum</PagingMethod>")
         tbf.Append(  "<canCreateRecords Source=""Database"">Y</canCreateRecords>")
         tbf.Append(  "<canEditRecords Source=""Database"">Y</canEditRecords>")
         tbf.Append(  "<canDeleteRecords Source=""Database"">Y</canDeleteRecords>")
         tbf.Append(  "<canViewRecords Source=""Database"">Y</canViewRecords>")
         tbf.Append(  "<ConcurrencyMethod>BinaryChecksum</ConcurrencyMethod>")
         tbf.Append(  "<AppShortName>ePortalWFApproval</AppShortName>")
         tbf.Append(  "<FolderName>WASS_Email_Default1</FolderName>")
         tbf.Append(  "<MenuName>WASS Email Default1</MenuName>")
         tbf.Append(  "<QSPath>../WASS_Email_Default1/WASS-Email-Default-QuickSelector1.aspx</QSPath>")
         tbf.Append(  "<TableCodeName>WASS_Email_Default1</TableCodeName>")
         tbf.Append(  "<TableStoredProcPrefix>pePortalWFApprovalWASS_Email_Default1</TableStoredProcPrefix>")
         tbf.Append("</XMLDefinition>")
         _DefinitionString = tbf.ToString()

		End	If	
		Return _DefinitionString		
	End Function

End Class
End Namespace
