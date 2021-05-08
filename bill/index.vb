Imports System.Data.OleDb

Public Class index

    Dim con As OleDbConnection
    Dim da As OleDbDataAdapter
    Public ds As New DataSet
    Dim wrong As Integer
    Dim cmd As OleDbCommand
    Public ds2 As New DataSet
    Public user As Integer
    Public pass As Integer
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim index As Integer
        Dim j As Integer
        Dim i As Integer

        For i = 0 To DataGridView1.Rows.Count - 1
            If (DataGridView1.Rows(i).Cells(1).Value = ComboBox1.SelectedValue.ToString) Then
                DataGridView1.Rows(i).Cells(2).Value = DataGridView1.Rows(i).Cells(2).Value + 1
                DataGridView1.Rows(i).Cells(4).Value = DataGridView1.Rows(i).Cells(3).Value * DataGridView1.Rows(i).Cells(2).Value
                j = 1

            End If
        Next

        For i = 0 To ds.Tables(0).Rows.Count - 1
            If (ds.Tables(0).Rows(i).Item(0) = ComboBox1.SelectedValue.ToString) Then
                index = i
                Exit For
            End If
        Next

        If (j = 0) Then
            If (ComboBox1.SelectedValue.ToString = "System.Data.DataRowView") Then
            Else
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, ComboBox1.SelectedValue.ToString, 1, ds.Tables(0).Rows(index).Item(1), ds.Tables(0).Rows(index).Item(1))
            End If
        End If
        Dim final As Integer
        For i = 0 To DataGridView1.Rows.Count - 1
            final = final + DataGridView1.Rows(i).Cells(4).Value
        Next
        DataGridView2.Rows(0).Cells(1).Value = final
    End Sub

    Private Sub form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=data.accdb")
        con.Open()
        da = New OleDbDataAdapter("select * from item", con)
        da.Fill(ds, "item")
        ComboBox1.DataSource = ds.Tables(0)
        ComboBox1.DisplayMember = "Item"
        ComboBox1.ValueMember = "Item"
        ComboBox1.Text = "Choose the items"
        da.Dispose()
        con.Close()
        DataGridView2.Rows.Add("TOTAL", 0)
    End Sub

    Private Sub DataGridView1_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        Dim final As Integer
        Dim i As Integer = DataGridView1.CurrentCellAddress.Y

        If (i < 0) Then
        Else
            DataGridView1.Rows(i).Cells(2).ErrorText = Nothing
            If (IsNumeric(DataGridView1.Rows(i).Cells(2).Value)) Then
                If (DataGridView1.Rows(i).Cells(2).Value = 0) Then
                    DataGridView1.Rows.RemoveAt(i)
                Else
                    DataGridView1.Rows(i).Cells(4).Value = DataGridView1.Rows(i).Cells(3).Value * DataGridView1.Rows(i).Cells(2).Value
                End If
                For i = 0 To DataGridView1.Rows.Count - 1
                    final = final + DataGridView1.Rows(i).Cells(4).Value
                Next
                DataGridView2.Rows(0).Cells(1).Value = final
            Else

                DataGridView1.Rows(i).Cells(2).ErrorText = "Enter a numeric value"
                DataGridView2.Rows(0).Cells(1).Value = DataGridView2.Rows(0).Cells(1).Value - DataGridView1.Rows(i).Cells(4).Value
                DataGridView1.Rows(i).Cells(4).Value = 0
            End If
        End If
    End Sub


    Private Sub CloseToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem1.Click
        Me.Close()
    End Sub


    Private Sub DeleteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem1.Click
        DataGridView1.Rows.RemoveAt(DataGridView1.CurrentRow.Index)
        For i = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(i).Cells(0).Value = i + 1
        Next
        Dim final As Integer
        For i = 0 To DataGridView1.Rows.Count - 1
            final = final + DataGridView1.Rows(i).Cells(4).Value
        Next
        DataGridView2.Rows(0).Cells(1).Value = final
    End Sub


    Private Sub ItemToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemToolStripMenuItem2.Click
        add.ShowDialog()
    End Sub


    Private Sub UpdateToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateToolStripMenuItem1.Click
        updates.ShowDialog()
    End Sub


    Private Sub CustomerToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerToolStripMenuItem2.Click
        customer.ShowDialog()
    End Sub


    Public Sub DataGridView1_RowsRemoved(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles DataGridView1.RowsRemoved

        For i = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(i).Cells(0).Value = i + 1
        Next
        Dim final As Integer
        For i = 0 To DataGridView1.Rows.Count - 1
            final = final + DataGridView1.Rows(i).Cells(4).Value
        Next
        DataGridView2.Rows(0).Cells(1).Value = final
    End Sub

    Private Sub history_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles history.Click
        historyy.Show()
    End Sub

    Private Sub history_Hover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles history.MouseHover
        history.BackColor = Color.DodgerBlue
        history.ForeColor = Color.White
    End Sub
    Private Sub history_HoverLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles history.MouseLeave
        history.BackColor = Color.White
        history.ForeColor = Color.Black
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub ToolStripTextBox2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtuserid.TextChanged
        ErrorProvider1.Dispose()
        Dim count As Integer
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=data.accdb")
        con.Open()
        da = New OleDbDataAdapter("select * from users", con)
        da.Fill(ds2, "users")
        Dim cmd As OleDbCommand
        Dim reader As OleDbDataReader
        cmd = New OleDbCommand("select Name from cushis", con)
        reader = cmd.ExecuteReader()
        pass = 0
        For i = 0 To ds2.Tables(0).Rows.Count - 1
            If (ds2.Tables(0).Rows(i).Item(0) = txtuserid.Text) Then
                lbluser.Text = "Customer's Name : " & ds2.Tables(0).Rows(i).Item(1)
                While reader.Read()
                    If (reader.Item("Name") = ds2.Tables("users").Rows(i).Item(1)) Then
                        count += 1
                    End If
                End While

                lblvisit.Text = "Times Visited : " & count
                user = i
                history.Visible = True
                lbluser.Visible = True
                lblvisit.Visible = True
                pass = 1
                da.Dispose()
                con.Close()
                Exit Sub
            End If
        Next
        history.Visible = False
        lbluser.Visible = False
        lblvisit.Visible = False
        da.Dispose()
        con.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles order.Click

        ' Validation for no customer id 
        If (txtuserid.Text = "") Then
            ErrorProvider1.SetError(txtuserid, "Enter a Customer ID")
            Exit Sub

            'validation for wrong customer id
        ElseIf (pass = 0) Then
            ErrorProvider1.SetError(txtuserid, "Enter a valid Customer ID")
            Exit Sub

            ' Validation for order having zero total price
        ElseIf (DataGridView2.Rows(0).Cells(1).Value = 0) Then
            ErrorProvider1.SetError(order, "Order cant be empty")
            Exit Sub

        End If

        finall.Show()
        Me.Hide()
    End Sub

End Class