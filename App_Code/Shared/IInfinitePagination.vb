
Imports Microsoft.VisualBasic
Imports BaseClasses.Utils.DbUtils
  
Namespace ePortalWFApproval.UI

  

    Public Interface IInfinitePagination

#Region "Interface Properties"
        
        ReadOnly Property CurrentPage() As System.Web.UI.WebControls.TextBox
        ReadOnly Property FirstPage() As System.Web.UI.WebControls.ImageButton
        ReadOnly Property LastPage() As System.Web.UI.WebControls.ImageButton
        ReadOnly Property NextPage() As System.Web.UI.WebControls.ImageButton
        ReadOnly Property PageSize() As System.Web.UI.WebControls.TextBox
        ReadOnly Property PageSizeButton() As System.Web.UI.WebControls.LinkButton
        ReadOnly Property PreviousPage() As System.Web.UI.WebControls.ImageButton
        ReadOnly Property Summary() As System.Web.UI.WebControls.TextBox
      Property Visible() as Boolean
         
      Function GetCurrentPageSize() As Integer              
        

#End Region

    End Interface

  
End Namespace
  