Public Class Form3

    Private Sub KerusakanBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.KerusakanBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TvDataSet)

    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TvDataSet.kerusakan' table. You can move, or remove it, as needed.
        Me.KerusakanTableAdapter.Fill(Me.TvDataSet.kerusakan)
        Label5.Text = Form1.TextBox2.Text
        Label7.Text = Form1.ComboBox1.SelectedItem
    End Sub

    Private Sub BindingNavigatorMoveNextItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form10.ShowDialog()

    End Sub
    Protected Overrides Sub WndProc(ByRef m As Message)
        If (m.Msg = &H112) AndAlso (m.WParam.ToInt32() = &HF010) Then
            Return
        End If
        If (m.Msg = &HA1) AndAlso (m.WParam.ToInt32() = &H2) Then
            Return
        End If
        MyBase.WndProc(m)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MsgBox("Pembuat Program : Rizki Gushendrawan (NRP:1151400013) .         Special thanks to Google", MsgBoxStyle.Information)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form1.Show()



    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form8.ShowDialog()
    End Sub
End Class