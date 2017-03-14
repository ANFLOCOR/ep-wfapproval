
Imports Microsoft.VisualBasic
Imports BaseClasses.Utils.DbUtils
  
Namespace ePortalWFApproval.UI

  

    Public Interface IHeader

#Region "Interface Properties"
        
        ReadOnly Property HeaderSettings() As System.Web.UI.WebControls.ImageButton
        ReadOnly Property Logo() As System.Web.UI.WebControls.Image
        ReadOnly Property SignIn() As System.Web.UI.WebControls.LinkButton
        ReadOnly Property SkipNavigationLinks() As System.Web.UI.WebControls.HyperLink
        ReadOnly Property UserStatusLbl() As System.Web.UI.WebControls.Label
      Property Visible() as Boolean
         

#End Region

    End Interface

  
End Namespace
  