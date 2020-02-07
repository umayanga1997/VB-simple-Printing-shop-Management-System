Public Class cb


    'FormClosing Event
    Private Sub MyForm_Closing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show(" Are you sure you want to quit", "Are you sure?", MessageBoxButtons.YesNoCancel) <> DialogResult.Yes Then
            e.Cancel = True
            Form1.Button2.Text = "Open"
            Form1.Button1.Enabled = False
        Else

            Form1.Button2.Text = "Create a New Bill"
            Form1.Button1.Enabled = True
        End If
    End Sub
    Private Sub cb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JDPDataSet.Bill' table. You can move, or remove it, as needed.
        Me.BillTableAdapter.Fill(Me.JDPDataSet.Bill)

    End Sub

    Private Sub BillBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.BillBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.JDPDataSet)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        BillBindingSource.AddNew()
        Button3.Enabled = False
        MsgBox("Please Enter Details....")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Validate()
        Me.BillBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.JDPDataSet)
        MsgBox("Its Saved....")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        BillBindingSource.RemoveCurrent()
        MsgBox("Its Deleted....")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        BillBindingSource.MovePrevious()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        BillBindingSource.MoveNext()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        BillBindingSource.MoveFirst()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        BillBindingSource.MoveLast()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim total As String = 0
        For i As Integer = 0 To BillDataGridView.RowCount - 1
            total += BillDataGridView.Rows(i).Cells(4).Value
            'Change the number 2 to your column index number (The first column has a 0 index column)
            'In this example the column index of Price is 2
        Next
        TextBox2.Text = total

        Dim total1 As String = 0
        For i As Integer = 0 To BillDataGridView.RowCount - 1
            total1 += BillDataGridView.Rows(i).Cells(5).Value
            'Change the number 2 to your column index number (The first column has a 0 index column)
            'In this example the column index of Price is 2
        Next
        TextBox3.Text = total1

        TextBox4.Text = Val(TextBox2.Text) - Val(TextBox3.Text)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

        TextBox1.Text = ComboBox1.Text

    End Sub

    Private Sub NameToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.BillTableAdapter.Name(Me.JDPDataSet.Bill)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Me.BillTableAdapter.Name1(Me.JDPDataSet.Bill, TextBox1.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class