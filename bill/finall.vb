Imports System.Data.OleDb
Public Class finall
    Dim con As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim cmd As OleDbCommand
    Dim reader As OleDbDataReader
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtprice.Text = index.DataGridView2.Rows(0).Cells(1).Value
        txtfinal.Text = txtprice.Text + 12 / 100 * txtprice.Text
    End Sub
    Private Sub Label3_OnHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.MouseHover
        Label3.BackColor = Color.DodgerBlue
        Label3.ForeColor = Color.White

    End Sub
    Private Sub Label3_HoverLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.MouseLeave
        Label3.BackColor = Color.White
        Label3.ForeColor = Color.Black

    End Sub
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        txtdis.Visible = True
        Label2.Left = 34
        Label2.Top = 164
        txtfinal.Left = 282
        txtfinal.Top = 164
        Label3.Left = 34
        Label3.Top = 97
        txtdis.Left = 282
        txtdis.Top = 97
        Label4.Left = 34
        Label4.Top = 132
        TextBox4.Left = 282
        TextBox4.Top = 132
        TextBox4.Visible = True
        Label4.Visible = True
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdis.TextChanged

        If (txtdis.Text = "") Then
            Exit Sub
        End If
        If (txtdis.Text > 100) Then
            TextBox4.Text = 0
            txtfinal.Text = 0
            Exit Sub
        End If
        TextBox4.Text = txtprice.Text - txtdis.Text / 100 * txtprice.Text
        txtfinal.Text = TextBox4.Text + 12 / 100 * TextBox4.Text

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles order.Click

        Dim items As String = ""
        Dim quantity As String = ""
        For i = 0 To index.DataGridView1.Rows.Count - 1S
            items = items + index.DataGridView1.Rows(i).Cells(1).Value + " "
            quantity = quantity & index.DataGridView1.Rows(i).Cells(2).Value & " "
        Next

        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=data.accdb")
        con.Open()
        cmd = New OleDbCommand("INSERT INTO cushis(Datee,Name,Items,Quantity,Discount,Final) VALUES(@dat,@nme,@itm,@qty,@dis,@f)", con)
        cmd.Parameters.AddWithValue("@dat", LSet(Date.Now, 20))
        cmd.Parameters.AddWithValue("@nme", index.ds2.Tables(0).Rows(index.user).Item(1))
        cmd.Parameters.AddWithValue("@itm", items)
        cmd.Parameters.AddWithValue("@qty", quantity)
        If (txtdis.Text <> "") Then
            cmd.Parameters.AddWithValue("@dis", txtdis.Text)
        Else
            cmd.Parameters.AddWithValue("@dis", "0")
        End If

        cmd.Parameters.AddWithValue("@f", txtfinal.Text)

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        MsgBox("Order Confirmed")
        index.DataGridView1.Rows.Clear()
        index.DataGridView2.Rows.Clear()
        cmd = New OleDbCommand("select Name from cushis", con)
        reader = cmd.ExecuteReader

        ' For updation of time visited counter after ordering 
        Dim count As Integer
        While reader.Read()
            If (reader.Item("Name") = index.ds2.Tables("users").Rows(index.user).Item(1)) Then
                count += 1
            End If
        End While
        index.ErrorProvider1.Dispose()
        index.lblvisit.Text = "Times Visited : " & count
        con.Close()
        index.Show()
        Me.Hide()
    End Sub

    Private Sub back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back.Click
        index.Show()
        Me.Hide()
    End Sub
End Class