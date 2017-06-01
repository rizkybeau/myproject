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
    Dim temp As Double = 0
    Sub certain()
        If Val(Label3.Text) <= Val(Label2.Text) Then
            'temp = Val(Label2.Text) << bug logic
            Label3.Text = Val(Label2.Text) 'fix bug logic
            Label2.Text = Val(Label3.Text)
        Else
            Label2.Text = Val(Label3.Text)
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Label2.Text = ComboBox1.SelectedItem
        certain()
        
        Me.Close()


    End Sub

    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class