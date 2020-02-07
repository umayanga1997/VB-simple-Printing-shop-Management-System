Public Class Form1

    'FormClosing Event
    Private Sub MyForm_Closing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show(" Are you sure you want to quit", "Are you sure?", MessageBoxButtons.YesNoCancel) <> DialogResult.Yes Then
            e.Cancel = True
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cp.Show()
        Button1.Text = "Open"
        If Button1.Text = "Open" Then
            Button2.Enabled = False
        Else
            Button2.Enabled = True
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        cb.Show()
        Button2.Text = "Open"
        If Button2.Text = "Open" Then
            Button1.Enabled = False
        Else
            Button1.Enabled = True
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        about.Show()
    End Sub

  
End Class
