Public Class SiteMaster
    Inherits MasterPage
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

    End Sub

    Protected Sub BulletedList1_Click(sender As Object, e As BulletedListEventArgs) Handles BulletedList2.Click

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (FileUpload2.HasFile) Then
            FileUpload2.SaveAs("C:\Users\Usuario\source\repos\Tips\upload\" + FileUpload2.FileName)
            HyperLink1.Text = FileUpload2.FileName
            HyperLink1.NavigateUrl = "upload/" + FileUpload2.FileName
        End If
    End Sub



    Protected Sub RadioButtonList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioButtonList1.SelectedIndexChanged
        MultiView1.ActiveViewIndex = Int64.Parse(RadioButtonList1.SelectedValue)
    End Sub
End Class