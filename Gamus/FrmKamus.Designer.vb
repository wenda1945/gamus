<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmKamus
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmKamus))
        Me.tbxInputEn = New System.Windows.Forms.TextBox()
        Me.tbxOutputIn = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbxInputIn = New System.Windows.Forms.TextBox()
        Me.tbxOutputEn = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataSet1 = New System.Data.DataSet()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbxInputEn
        '
        Me.tbxInputEn.AutoCompleteCustomSource.AddRange(New String() {"Test", "Coba", "AutoComplete", "Suggestion"})
        Me.tbxInputEn.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbxInputEn.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbxInputEn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxInputEn.Location = New System.Drawing.Point(12, 45)
        Me.tbxInputEn.Name = "tbxInputEn"
        Me.tbxInputEn.Size = New System.Drawing.Size(194, 31)
        Me.tbxInputEn.TabIndex = 0
        '
        'tbxOutputIn
        '
        Me.tbxOutputIn.Location = New System.Drawing.Point(12, 83)
        Me.tbxOutputIn.Multiline = True
        Me.tbxOutputIn.Name = "tbxOutputIn"
        Me.tbxOutputIn.ReadOnly = True
        Me.tbxOutputIn.Size = New System.Drawing.Size(359, 180)
        Me.tbxOutputIn.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(212, 45)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(159, 32)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Translate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "English >> Indonesian"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.tbxInputEn)
        Me.Panel1.Controls.Add(Me.tbxOutputIn)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(384, 273)
        Me.Panel1.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.tbxInputIn)
        Me.Panel2.Controls.Add(Me.tbxOutputEn)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Location = New System.Drawing.Point(0, 283)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(384, 273)
        Me.Panel2.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(205, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Indonesia >> Inggris"
        '
        'tbxInputIn
        '
        Me.tbxInputIn.AutoCompleteCustomSource.AddRange(New String() {"Test", "Coba", "AutoComplete", "Suggestion"})
        Me.tbxInputIn.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbxInputIn.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbxInputIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxInputIn.Location = New System.Drawing.Point(12, 45)
        Me.tbxInputIn.Name = "tbxInputIn"
        Me.tbxInputIn.Size = New System.Drawing.Size(194, 31)
        Me.tbxInputIn.TabIndex = 0
        '
        'tbxOutputEn
        '
        Me.tbxOutputEn.Location = New System.Drawing.Point(12, 83)
        Me.tbxOutputEn.Multiline = True
        Me.tbxOutputEn.Name = "tbxOutputEn"
        Me.tbxOutputEn.ReadOnly = True
        Me.tbxOutputEn.Size = New System.Drawing.Size(359, 180)
        Me.tbxOutputEn.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(212, 45)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(159, 32)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Terjemahkan"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        '
        'FrmKamus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 561)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmKamus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kamus"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbxInputEn As TextBox
    Friend WithEvents tbxOutputIn As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents tbxInputIn As TextBox
    Friend WithEvents tbxOutputEn As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents DataSet1 As DataSet
End Class
