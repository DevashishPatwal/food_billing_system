Imports System.Data.OleDb

Public Class customer

    Dim con As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim builder As OleDbCommandBuilder
    Dim ds As New DataSet
    Dim k As Integer

    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=data.accdb")
        con.Open()

        da = New OleDbDataAdapter("select * from users", con)
        da.Fill(ds, "users")
        Dim result As DialogResult = MessageBox.Show("Add : " + txt_user.Text + vbNewLine + " UserID = " & ds.Tables(0).Rows(ds.Tables(0).Rows.Count - 1).Item(0) + 1, "Are you Sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (result = Windows.Forms.DialogResult.Yes) Then
            ds.Tables(0).Rows.Add(ds.Tables(0).Rows(ds.Tables(0).Rows.Count - 1).Item(0) + 1, txt_user.Text)
            builder = New OleDbCommandBuilder(da)
            da.Update(ds, "users")
        End If
        da.Dispose()
        con.Close()
    End Sub

    Private Sub customer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class