Partial Public Class _Default
    Inherits System.Web.UI.Page
    Dim count As Integer
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack Then
            count += 1
        Else
            count = 0
        End If
        Label1.Text = "You have clicked " + count.ToString + " times"
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click

    End Sub
End Class