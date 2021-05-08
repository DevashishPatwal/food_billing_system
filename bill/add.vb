Imports System.Data.OleDb

Public Class add

    Dim con As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim builder As OleDbCommandBuilder
    Dim ds As New DataSet


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        If (txt_item.Text = "" And txt_price.Text = "") Then
            ErrorProvider1.SetError(txt_item, "Field is empty")
            ErrorProvider1.SetError(txt_price, "Field is empty")
            Exit Sub
        ElseIf (txt_item.Text = "") Then
            ErrorProvider1.SetError(txt_item, "Field is empty")
            Exit Sub
        ElseIf (txt_price.Text = "") Then
            ErrorProvider1.SetError(txt_price, "Field is empty")
            Exit Sub
        End If
        If (Not IsNumeric(txt_price.Text)) Then
            ErrorProvider1.SetError(txt_price, "Enter a Numeric Value")
           
            Exit Sub
        Else
            ErrorProvider1.Dispose()
        End If
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=data.accdb")

        da = New OleDbDataAdapter("select * from item", con)
        Dim result As DialogResult = MessageBox.Show("Item : " + txt_item.Text + vbNewLine + "Price : " + txt_price.Text, "Are you Sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (result = Windows.Forms.DialogResult.Yes) Then
            index.ds.Tables(0).Rows.Add(txt_item.Text, txt_price.Text)
            builder = New OleDbCommandBuilder(da)
            da.Update(index.ds, "item")
        End If
        da.Dispose()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub txt_item_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_item.LostFocus


        For i = 0 To index.ds.Tables(0).Rows.Count - 1
            If (txt_item.Text = index.ds.Tables(0).Rows(i).Item(0) Or txt_item.Text = Microsoft.VisualBasic.LCase(index.ds.Tables(0).Rows(i).Item(0)) Or txt_item.Text = Microsoft.VisualBasic.UCase(index.ds.Tables(0).Rows(i).Item(0))) Then
                ErrorProvider1.SetError(txt_item, "Item already present")
                Exit For
            Else
                ErrorProvider1.Dispose()
            End If
        Next
    End Sub

End Class