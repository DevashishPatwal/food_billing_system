Imports System.Data.OleDb
Public Class updates
    Dim con As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim builder As OleDbCommandBuilder
    Dim ds As New DataSet
    Dim k As Integer

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=data.accdb")
        da = New OleDbDataAdapter("select * from item", con)
        DataGridView1.DataSource = index.ds.Tables("item")

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=data.accdb")
        builder = New OleDbCommandBuilder(da)
        da.Update(index.ds, "item")
        MessageBox.Show("Changes Done")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        DataGridView1.Rows.RemoveAt(DataGridView1.CurrentRow.Index)
    End Sub

End Class