<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.components = New System.ComponentModel.Container()
        Me.TvDataSet = New WindowsApplication1.tvDataSet()
        Me.KerusakanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New WindowsApplication1.tvDataSetTableAdapters.TableAdapterManager()
        Me.KnowledgeTableAdapter = New WindowsApplication1.tvDataSetTableAdapters.knowledgeTableAdapter()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.KerusakanknowledgeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KerusakanknowledgeBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.KerusakanknowledgeBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.KerusakanknowledgeBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.TvDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KerusakanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.KerusakanknowledgeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KerusakanknowledgeBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KerusakanknowledgeBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KerusakanknowledgeBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TvDataSet
        '
        Me.TvDataSet.DataSetName = "tvDataSet"
        Me.TvDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KerusakanBindingSource
        '
        Me.KerusakanBindingSource.DataMember = "kerusakan"
        Me.KerusakanBindingSource.DataSource = Me.TvDataSet
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.kerusakanTableAdapter = Nothing
        Me.TableAdapterManager.knowledgeTableAdapter = Nothing
        Me.TableAdapterManager.list_userTableAdapter = Nothing
        Me.TableAdapterManager.solusiTableAdapter = Nothing
        Me.TableAdapterManager.tempTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.tvDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'KnowledgeTableAdapter
        '
        Me.KnowledgeTableAdapter.ClearBeforeFill = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(72, 48)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(331, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(10, 31)
        Me.DataGridView1.TabIndex = 1
        Me.DataGridView1.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(202, 89)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Proses"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(124, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 118)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(438, 49)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Error Handling"
        Me.GroupBox1.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(244, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Label5"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(79, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Index"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(79, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "ITEM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(124, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Label2"
        '
        'KerusakanknowledgeBindingSource
        '
        Me.KerusakanknowledgeBindingSource.DataMember = "kerusakanknowledge"
        Me.KerusakanknowledgeBindingSource.DataSource = Me.KerusakanBindingSource
        '
        'KerusakanknowledgeBindingSource1
        '
        Me.KerusakanknowledgeBindingSource1.DataMember = "kerusakanknowledge"
        Me.KerusakanknowledgeBindingSource1.DataSource = Me.KerusakanBindingSource
        '
        'KerusakanknowledgeBindingSource2
        '
        Me.KerusakanknowledgeBindingSource2.DataMember = "kerusakanknowledge"
        Me.KerusakanknowledgeBindingSource2.DataSource = Me.KerusakanBindingSource
        '
        'KerusakanknowledgeBindingSource3
        '
        Me.KerusakanknowledgeBindingSource3.DataMember = "kerusakanknowledge"
        Me.KerusakanknowledgeBindingSource3.DataSource = Me.KerusakanBindingSource
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 170)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.IsMdiContainer = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DIAGNOSA KERUSAKAN"
        CType(Me.TvDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KerusakanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.KerusakanknowledgeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KerusakanknowledgeBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KerusakanknowledgeBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KerusakanknowledgeBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TvDataSet As WindowsApplication1.tvDataSet
    Friend WithEvents KerusakanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterManager As WindowsApplication1.tvDataSetTableAdapters.TableAdapterManager
    Friend WithEvents KerusakanknowledgeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KnowledgeTableAdapter As WindowsApplication1.tvDataSetTableAdapters.knowledgeTableAdapter
    Friend WithEvents KerusakanknowledgeBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents KerusakanknowledgeBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents KerusakanknowledgeBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
