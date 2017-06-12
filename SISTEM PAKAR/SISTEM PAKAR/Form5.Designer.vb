<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblpertanyaan = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblid = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Labelfaktaya = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Labelfaktatidak = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblpertanyaan
        '
        Me.lblpertanyaan.AutoSize = True
        Me.lblpertanyaan.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpertanyaan.Location = New System.Drawing.Point(13, 23)
        Me.lblpertanyaan.Name = "lblpertanyaan"
        Me.lblpertanyaan.Size = New System.Drawing.Size(98, 22)
        Me.lblpertanyaan.TabIndex = 0
        Me.lblpertanyaan.Text = "Apakah ?"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 61)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 46)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "&Ya"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(160, 61)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 46)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "&Tidak"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblid.Location = New System.Drawing.Point(28, 83)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(21, 24)
        Me.lblid.TabIndex = 3
        Me.lblid.Text = "0"
        Me.lblid.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(690, 392)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Batas Pemakaian : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(795, 393)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "6"
        '
        'Labelfaktaya
        '
        Me.Labelfaktaya.AutoSize = True
        Me.Labelfaktaya.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelfaktaya.Location = New System.Drawing.Point(226, 16)
        Me.Labelfaktaya.Name = "Labelfaktaya"
        Me.Labelfaktaya.Size = New System.Drawing.Size(112, 24)
        Me.Labelfaktaya.TabIndex = 9
        Me.Labelfaktaya.Text = "Labelfaktaya"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lblid)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Labelfaktatidak)
        Me.GroupBox1.Controls.Add(Me.Labelfaktaya)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 140)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(805, 249)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Keterangan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 24)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "-"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(113, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 24)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Fakta Tidak"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(114, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 24)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Fakta Ya"
        '
        'Labelfaktatidak
        '
        Me.Labelfaktatidak.AutoSize = True
        Me.Labelfaktatidak.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelfaktatidak.Location = New System.Drawing.Point(226, 40)
        Me.Labelfaktatidak.Name = "Labelfaktatidak"
        Me.Labelfaktatidak.Size = New System.Drawing.Size(131, 24)
        Me.Labelfaktatidak.TabIndex = 10
        Me.Labelfaktatidak.Text = "Labelfaktatidak"
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 414)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblpertanyaan)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Diagnosa Kerusakan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblpertanyaan As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lblid As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Labelfaktaya As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Labelfaktatidak As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
