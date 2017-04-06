
Imports Microsoft.VisualBasic
Imports BaseClasses.Utils.DbUtils
  
Namespace ePortalWFApproval.UI

  

    Public Interface IThemeButtonWithArrow

#Region "Interface Properties"
        
        ReadOnly Property Button() As System.Web.UI.WebControls.LinkButton
        ReadOnly Property ArrowImage() As System.Web.UI.WebControls.Image
      Property Visible() as Boolean
         

#End Region

    End Interface

  
End Namespace
  