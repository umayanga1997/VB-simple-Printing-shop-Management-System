<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cp
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim CustemerNumberLabel As System.Windows.Forms.Label
        Dim IDCardNumberLabel As System.Windows.Forms.Label
        Dim PhoneMobileLabel As System.Windows.Forms.Label
        Dim PhoneHomeLabel As System.Windows.Forms.Label
        Dim RegisterDateLabel As System.Windows.Forms.Label
        Dim CustemerPhotoLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Me.JDPDataSet = New JDP.JDPDataSet()
        Me.BillBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BillTableAdapter = New JDP.JDPDataSetTableAdapters.BillTableAdapter()
        Me.TableAdapterManager = New JDP.JDPDataSetTableAdapters.TableAdapterManager()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.CustemerNumberTextBox = New System.Windows.Forms.TextBox()
        Me.IDCardNumberTextBox = New System.Windows.Forms.TextBox()
        Me.VCheckBox = New System.Windows.Forms.CheckBox()
        Me.XCheckBox = New System.Windows.Forms.CheckBox()
        Me.PhoneMobileTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneHomeTextBox = New System.Windows.Forms.TextBox()
        Me.RegisterDateTextBox = New System.Windows.Forms.TextBox()
        Me.CustemerPhotoPictureBox = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        IDLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        CustemerNumberLabel = New System.Windows.Forms.Label()
        IDCardNumberLabel = New System.Windows.Forms.Label()
        PhoneMobileLabel = New System.Windows.Forms.Label()
        PhoneHomeLabel = New System.Windows.Forms.Label()
        RegisterDateLabel = New System.Windows.Forms.Label()
        CustemerPhotoLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        CType(Me.JDPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BillBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustemerPhotoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(12, 9)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(12, 35)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 3
        NameLabel.Text = "Name:"
        '
        'CustemerNumberLabel
        '
        CustemerNumberLabel.AutoSize = True
        CustemerNumberLabel.Location = New System.Drawing.Point(12, 61)
        CustemerNumberLabel.Name = "CustemerNumberLabel"
        CustemerNumberLabel.Size = New System.Drawing.Size(94, 13)
        CustemerNumberLabel.TabIndex = 5
        CustemerNumberLabel.Text = "Custemer Number:"
        '
        'IDCardNumberLabel
        '
        IDCardNumberLabel.AutoSize = True
        IDCardNumberLabel.Location = New System.Drawing.Point(12, 87)
        IDCardNumberLabel.Name = "IDCardNumberLabel"
        IDCardNumberLabel.Size = New System.Drawing.Size(68, 13)
        IDCardNumberLabel.TabIndex = 7
        IDCardNumberLabel.Text = "NIC Number:"
        '
        'PhoneMobileLabel
        '
        PhoneMobileLabel.AutoSize = True
        PhoneMobileLabel.Location = New System.Drawing.Point(12, 113)
        PhoneMobileLabel.Name = "PhoneMobileLabel"
        PhoneMobileLabel.Size = New System.Drawing.Size(81, 13)
        PhoneMobileLabel.TabIndex = 13
        PhoneMobileLabel.Text = "Phone - Mobile:"
        '
        'PhoneHomeLabel
        '
        PhoneHomeLabel.AutoSize = True
        PhoneHomeLabel.Location = New System.Drawing.Point(12, 139)
        PhoneHomeLabel.Name = "PhoneHomeLabel"
        PhoneHomeLabel.Size = New System.Drawing.Size(78, 13)
        PhoneHomeLabel.TabIndex = 15
        PhoneHomeLabel.Text = "Phone - Home:"
        '
        'RegisterDateLabel
        '
        RegisterDateLabel.AutoSize = True
        RegisterDateLabel.Location = New System.Drawing.Point(12, 165)
        RegisterDateLabel.Name = "RegisterDateLabel"
        RegisterDateLabel.Size = New System.Drawing.Size(75, 13)
        RegisterDateLabel.TabIndex = 17
        RegisterDateLabel.Text = "Register Date:"
        '
        'CustemerPhotoLabel
        '
        CustemerPhotoLabel.AutoSize = True
        CustemerPhotoLabel.Location = New System.Drawing.Point(12, 188)
        CustemerPhotoLabel.Name = "CustemerPhotoLabel"
        CustemerPhotoLabel.Size = New System.Drawing.Size(85, 13)
        CustemerPhotoLabel.TabIndex = 19
        CustemerPhotoLabel.Text = "Custemer Photo:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(296, 165)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(102, 13)
        Label1.TabIndex = 15
        Label1.Text = "( ex : 22/02//2017 )"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(221, 61)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(57, 13)
        Label2.TabIndex = 15
        Label2.Text = "( ex : 001 )"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(296, 113)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(105, 13)
        Label3.TabIndex = 15
        Label3.Text = "( ex : 0772 222 222 )"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(296, 139)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(108, 13)
        Label4.TabIndex = 15
        Label4.Text = "( ex : 057 2 222 222 )"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(133, 386)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(184, 13)
        Label5.TabIndex = 15
        Label5.Text = "Select Custemer Name For Searching"
        '
        'JDPDataSet
        '
        Me.JDPDataSet.DataSetName = "JDPDataSet"
        Me.JDPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BillBindingSource
        '
        Me.BillBindingSource.DataMember = "Bill"
        Me.BillBindingSource.DataSource = Me.JDPDataSet
        '
        'BillTableAdapter
        '
        Me.BillTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BillTableAdapter = Me.BillTableAdapter
        Me.TableAdapterManager.UpdateOrder = JDP.JDPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BillBindingSource, "ID", True))
        Me.IDTextBox.Enabled = False
        Me.IDTextBox.Location = New System.Drawing.Point(112, 6)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(103, 20)
        Me.IDTextBox.TabIndex = 2
        Me.IDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BillBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(112, 32)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(344, 20)
        Me.NameTextBox.TabIndex = 4
        Me.NameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CustemerNumberTextBox
        '
        Me.CustemerNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BillBindingSource, "CustemerNumber", True))
        Me.CustemerNumberTextBox.Location = New System.Drawing.Point(112, 58)
        Me.CustemerNumberTextBox.Name = "CustemerNumberTextBox"
        Me.CustemerNumberTextBox.Size = New System.Drawing.Size(103, 20)
        Me.CustemerNumberTextBox.TabIndex = 6
        Me.CustemerNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'IDCardNumberTextBox
        '
        Me.IDCardNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BillBindingSource, "IDCardNumber", True))
        Me.IDCardNumberTextBox.Location = New System.Drawing.Point(112, 84)
        Me.IDCardNumberTextBox.Name = "IDCardNumberTextBox"
        Me.IDCardNumberTextBox.Size = New System.Drawing.Size(178, 20)
        Me.IDCardNumberTextBox.TabIndex = 8
        Me.IDCardNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'VCheckBox
        '
        Me.VCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.BillBindingSource, "V", True))
        Me.VCheckBox.Location = New System.Drawing.Point(299, 82)
        Me.VCheckBox.Name = "VCheckBox"
        Me.VCheckBox.Size = New System.Drawing.Size(29, 24)
        Me.VCheckBox.TabIndex = 10
        Me.VCheckBox.Text = "V"
        Me.VCheckBox.UseVisualStyleBackColor = True
        '
        'XCheckBox
        '
        Me.XCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.BillBindingSource, "X", True))
        Me.XCheckBox.Location = New System.Drawing.Point(334, 82)
        Me.XCheckBox.Name = "XCheckBox"
        Me.XCheckBox.Size = New System.Drawing.Size(34, 24)
        Me.XCheckBox.TabIndex = 12
        Me.XCheckBox.Text = "X"
        Me.XCheckBox.UseVisualStyleBackColor = True
        '
        'PhoneMobileTextBox
        '
        Me.PhoneMobileTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BillBindingSource, "PhoneMobile", True))
        Me.PhoneMobileTextBox.Location = New System.Drawing.Point(112, 110)
        Me.PhoneMobileTextBox.Name = "PhoneMobileTextBox"
        Me.PhoneMobileTextBox.Size = New System.Drawing.Size(178, 20)
        Me.PhoneMobileTextBox.TabIndex = 14
        Me.PhoneMobileTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PhoneHomeTextBox
        '
        Me.PhoneHomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BillBindingSource, "PhoneHome", True))
        Me.PhoneHomeTextBox.Location = New System.Drawing.Point(112, 136)
        Me.PhoneHomeTextBox.Name = "PhoneHomeTextBox"
        Me.PhoneHomeTextBox.Size = New System.Drawing.Size(178, 20)
        Me.PhoneHomeTextBox.TabIndex = 16
        Me.PhoneHomeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RegisterDateTextBox
        '
        Me.RegisterDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BillBindingSource, "RegisterDate", True))
        Me.RegisterDateTextBox.Location = New System.Drawing.Point(112, 162)
        Me.RegisterDateTextBox.Name = "RegisterDateTextBox"
        Me.RegisterDateTextBox.Size = New System.Drawing.Size(178, 20)
        Me.RegisterDateTextBox.TabIndex = 18
        Me.RegisterDateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CustemerPhotoPictureBox
        '
        Me.CustemerPhotoPictureBox.BackColor = System.Drawing.Color.Gray
        Me.CustemerPhotoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CustemerPhotoPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.BillBindingSource, "CustemerPhoto", True))
        Me.CustemerPhotoPictureBox.Location = New System.Drawing.Point(112, 188)
        Me.CustemerPhotoPictureBox.Name = "CustemerPhotoPictureBox"
        Me.CustemerPhotoPictureBox.Size = New System.Drawing.Size(131, 160)
        Me.CustemerPhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CustemerPhotoPictureBox.TabIndex = 20
        Me.CustemerPhotoPictureBox.TabStop = False
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(381, 205)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Create"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Location = New System.Drawing.Point(381, 234)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Location = New System.Drawing.Point(381, 263)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Location = New System.Drawing.Point(381, 292)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 21
        Me.Button4.Text = "<"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.Location = New System.Drawing.Point(381, 321)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 21
        Me.Button5.Text = ">"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBox1.DataSource = Me.BillBindingSource
        Me.ComboBox1.DisplayMember = "Name"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(76, 363)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(297, 21)
        Me.ComboBox1.TabIndex = 22
        '
        'cp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 403)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(CustemerNumberLabel)
        Me.Controls.Add(Me.CustemerNumberTextBox)
        Me.Controls.Add(IDCardNumberLabel)
        Me.Controls.Add(Me.IDCardNumberTextBox)
        Me.Controls.Add(Me.VCheckBox)
        Me.Controls.Add(Me.XCheckBox)
        Me.Controls.Add(PhoneMobileLabel)
        Me.Controls.Add(Me.PhoneMobileTextBox)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Label1)
        Me.Controls.Add(PhoneHomeLabel)
        Me.Controls.Add(Me.PhoneHomeTextBox)
        Me.Controls.Add(RegisterDateLabel)
        Me.Controls.Add(Me.RegisterDateTextBox)
        Me.Controls.Add(CustemerPhotoLabel)
        Me.Controls.Add(Me.CustemerPhotoPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "cp"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Custemer's Profiles"
        CType(Me.JDPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BillBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustemerPhotoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents JDPDataSet As JDP.JDPDataSet
    Friend WithEvents BillBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BillTableAdapter As JDP.JDPDataSetTableAdapters.BillTableAdapter
    Friend WithEvents TableAdapterManager As JDP.JDPDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CustemerNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IDCardNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents XCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents PhoneMobileTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PhoneHomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RegisterDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CustemerPhotoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
