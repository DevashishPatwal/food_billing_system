Imports System.Data.OleDb
Public Class historyy
    Dim con As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim builder As OleDbCommandBuilder
    Dim ds As New DataSet
    Dim cmd As OleDbCommand
    Dim reader As OleDbDataReader
    Private Sub historyy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=data.accdb")

        da = New OleDbDataAdapter("select * from cushis", con)

        da.Fill(ds, "cushis")
        For i = 0 To ds.Tables(0).Rows.Count - 1
            If (ds.Tables(0).Rows(i).Item(1) = index.ds2.Tables(0).Rows(index.user).Item(1)) Then
                ListBox1.Items.Add(ds.Tables(0).Rows(i).Item(0))
            End If
        Next


    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Button1.Visible = True
        DataGridView1.Rows.Clear()
        Dim items() As String
        Dim quantity() As String
        Dim index As Integer
        For i = 0 To ds.Tables(0).Rows.Count - 1
            If (ds.Tables(0).Rows(i).Item(0) = ListBox1.SelectedItem) Then
                quantity = Split(ds.Tables(0).Rows(i).Item(3))
                items = Split(ds.Tables(0).Rows(i).Item(2))
                index = i
                Exit For
            End If
        Next

        'Null Value Exception
        Try
            For i = 0 To items.Count - 2
                DataGridView1.Rows.Add(items(i), quantity(i))

            Next
        Catch ex As Exception
            ex.ToString()
        End Try

        DataGridView2.Rows(0).Cells(0).Value = "Total"
        DataGridView2.Rows(0).Cells(1).Value = ds.Tables(0).Rows(index).Item(5)
        Label1.Text = "Discount = " + ds.Tables(0).Rows(index).Item(4) + "%"
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (result = Windows.Forms.DialogResult.Yes) Then

            con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=data.accdb")
            con.Open()
            For i = 0 To ds.Tables(0).Rows.Count - 1
                If (ds.Tables(0).Rows(i).Item(0) = ListBox1.SelectedItem) Then
                    ds.Tables(0).Rows.Add(LSet(Date.Now, 20), ds.Tables(0).Rows(i).Item(1), ds.Tables(0).Rows(i).Item(2), ds.Tables(0).Rows(i).Item(3), ds.Tables(0).Rows(i).Item(4), ds.Tables(0).Rows(i).Item(5))
                    builder = New OleDbCommandBuilder(da)
                    da.Update(ds, "cushis")
                    ListBox1.Items.Add(LSet(Date.Now, 20))
                    Exit For
                End If
            Next
            cmd = New OleDbCommand("select Name from cushis", con)
            reader = cmd.ExecuteReader
            Dim count As Integer
            While reader.Read()
                If (reader.Item("Name") = index.ds2.Tables("users").Rows(index.user).Item(1)) Then
                    count += 1
                End If
            End While
            index.ErrorProvider1.Dispose()
            index.lblvisit.Text = "Times Visited : " & count
            con.Close()
        Else
            Exit Sub
        End If
    End Sub
End Class