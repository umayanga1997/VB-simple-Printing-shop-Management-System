Public Class cp


    'FormClosing Event
    Private Sub MyForm_Closing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show(" Are you sure you want to quit", "Are you sure?", MessageBoxButtons.YesNoCancel) <> DialogResult.Yes Then
            e.Cancel = True
            Form1.Button1.Text = "Open"
            Form1.Button2.Enabled = False
        Else
            
            Form1.Button1.Text = "Custemer's Profiles"
            Form1.Button2.Enabled = True
        End If
    End Sub
    Private Sub BillBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.BillBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.JDPDataSet)

    End Sub

    Private Sub cp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JDPDataSet.Bill' table. You can move, or remove it, as needed.
        Me.BillTableAdapter.Fill(Me.JDPDataSet.Bill)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        BillBindingSource.AddNew()
        Button3.Enabled = False
        MsgBox("Please Enter Details....")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Validate()
        Me.BillBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.JDPDataSet)
        MsgBox("Its Saved....")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        BillBindingSource.RemoveCurrent()
        MsgBox("Its Deleted....")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        BillBindingSource.MovePrevious()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        BillBindingSource.MoveNext()
    End Sub

    Private Sub CustemerPhotoPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustemerPhotoPictureBox.Click
        
        Dim OpenFile As New OpenFileDialog()
        Try
            With OpenFile
                .FileName = ""
                .Title = "Custemer Photo"
                .Filter = "Image file (*.jpg)|*.jpg|(*.png)|*.png|(*.jpeg)|*.jpeg|(*.giff)|*.giff| All Files (*.*)|*.*"

                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.CustemerPhotoPictureBox.Image = System.Drawing.Bitmap.FromFile(.FileName)
                Else
                    MsgBox("No Selected Photo")
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
    End Sub
End Class