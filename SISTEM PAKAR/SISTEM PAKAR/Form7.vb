Public Class Form7
    Protected Overrides Sub WndProc(ByRef m As Message)
        If (m.Msg = &H112) AndAlso (m.WParam.ToInt32() = &HF010) Then
            Return
        End If
        If (m.Msg = &HA1) AndAlso (m.WParam.ToInt32() = &H2) Then
            Return
        End If
        MyBase.WndProc(m)
    End Sub
    Dim temp As Integer
    Sub certain()
        If Label2.Text = 0 Then
            Label2.Text = ComboBox1.SelectedItem
        Else
            If Label2.Text < ComboBox1.SelectedItem Then

            Else
                Label2.Text = ComboBox1.SelectedItem


            End If
        End If


        'label 2  = pilih item
        
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.SelectedItem = "" Then
            MsgBox("isi dengan benar", MsgBoxStyle.Critical)
        Else
            certain()

            Me.Close()
        End If
        'Label2.Text = ComboBox1.SelectedItem
        


    End Sub

    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class