
Imports Microsoft.VisualBasic
Imports BaseClasses.Utils.DbUtils
  
Namespace ePortalWFApproval.UI

  

    Public Interface IEmailFooter

#Region "Interface Properties"
        
        ReadOnly Property Copyright() As System.Web.UI.WebControls.Literal
      Property Visible() as Boolean
         

#End Region

    End Interface

  
End Namespace
  