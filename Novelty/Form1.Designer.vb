<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.nameIputbox = New System.Windows.Forms.TextBox()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.mediumRadioButton = New System.Windows.Forms.RadioButton()
        Me.LargeRadioButton = New System.Windows.Forms.RadioButton()
        Me.SmallRadiobutton = New System.Windows.Forms.RadioButton()
        Me.SexGroupBox = New System.Windows.Forms.GroupBox()
        Me.maleRadioButton = New System.Windows.Forms.RadioButton()
        Me.femaleRadioButton = New System.Windows.Forms.RadioButton()
        Me.colorGroupBox = New System.Windows.Forms.GroupBox()
        Me.whiteRadioButton = New System.Windows.Forms.RadioButton()
        Me.redRadioButton = New System.Windows.Forms.RadioButton()
        Me.yellowRadioButton = New System.Windows.Forms.RadioButton()
        Me.greenRadioButton = New System.Windows.Forms.RadioButton()
        Me.blueRadioButton = New System.Windows.Forms.RadioButton()
        Me.choicesGroupBox = New System.Windows.Forms.GroupBox()
        Me.basicRadioButton = New System.Windows.Forms.RadioButton()
        Me.premiumRadioButton = New System.Windows.Forms.RadioButton()
        Me.standardRadioButton = New System.Windows.Forms.RadioButton()
        Me.priceLabel = New System.Windows.Forms.Label()
        Me.priceTextBox = New System.Windows.Forms.TextBox()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.choice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.women = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.women1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.men = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.men1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.men2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.SexGroupBox.SuspendLayout()
        Me.colorGroupBox.SuspendLayout()
        Me.choicesGroupBox.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(643, 456)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'nameIputbox
        '
        Me.nameIputbox.Location = New System.Drawing.Point(67, 43)
        Me.nameIputbox.Name = "nameIputbox"
        Me.nameIputbox.Size = New System.Drawing.Size(100, 20)
        Me.nameIputbox.TabIndex = 2
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Location = New System.Drawing.Point(26, 43)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(35, 13)
        Me.nameLabel.TabIndex = 3
        Me.nameLabel.Text = "Name"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.mediumRadioButton)
        Me.GroupBox1.Controls.Add(Me.LargeRadioButton)
        Me.GroupBox1.Controls.Add(Me.SmallRadiobutton)
        Me.GroupBox1.Location = New System.Drawing.Point(246, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(73, 96)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Size"
        '
        'mediumRadioButton
        '
        Me.mediumRadioButton.AutoSize = True
        Me.mediumRadioButton.Location = New System.Drawing.Point(5, 42)
        Me.mediumRadioButton.Name = "mediumRadioButton"
        Me.mediumRadioButton.Size = New System.Drawing.Size(62, 17)
        Me.mediumRadioButton.TabIndex = 2
        Me.mediumRadioButton.TabStop = True
        Me.mediumRadioButton.Text = "Medium"
        Me.mediumRadioButton.UseVisualStyleBackColor = True
        '
        'LargeRadioButton
        '
        Me.LargeRadioButton.AutoSize = True
        Me.LargeRadioButton.Location = New System.Drawing.Point(5, 65)
        Me.LargeRadioButton.Name = "LargeRadioButton"
        Me.LargeRadioButton.Size = New System.Drawing.Size(52, 17)
        Me.LargeRadioButton.TabIndex = 1
        Me.LargeRadioButton.TabStop = True
        Me.LargeRadioButton.Text = "Large"
        Me.LargeRadioButton.UseVisualStyleBackColor = True
        '
        'SmallRadiobutton
        '
        Me.SmallRadiobutton.AutoSize = True
        Me.SmallRadiobutton.Location = New System.Drawing.Point(6, 19)
        Me.SmallRadiobutton.Name = "SmallRadiobutton"
        Me.SmallRadiobutton.Size = New System.Drawing.Size(48, 17)
        Me.SmallRadiobutton.TabIndex = 0
        Me.SmallRadiobutton.TabStop = True
        Me.SmallRadiobutton.Text = "small"
        Me.SmallRadiobutton.UseVisualStyleBackColor = True
        '
        'SexGroupBox
        '
        Me.SexGroupBox.Controls.Add(Me.maleRadioButton)
        Me.SexGroupBox.Controls.Add(Me.femaleRadioButton)
        Me.SexGroupBox.Location = New System.Drawing.Point(29, 113)
        Me.SexGroupBox.Name = "SexGroupBox"
        Me.SexGroupBox.Size = New System.Drawing.Size(77, 67)
        Me.SexGroupBox.TabIndex = 5
        Me.SexGroupBox.TabStop = False
        Me.SexGroupBox.Text = "Sex"
        '
        'maleRadioButton
        '
        Me.maleRadioButton.AutoSize = True
        Me.maleRadioButton.Location = New System.Drawing.Point(6, 19)
        Me.maleRadioButton.Name = "maleRadioButton"
        Me.maleRadioButton.Size = New System.Drawing.Size(48, 17)
        Me.maleRadioButton.TabIndex = 1
        Me.maleRadioButton.TabStop = True
        Me.maleRadioButton.Text = "Male"
        Me.maleRadioButton.UseVisualStyleBackColor = True
        '
        'femaleRadioButton
        '
        Me.femaleRadioButton.AutoSize = True
        Me.femaleRadioButton.Location = New System.Drawing.Point(6, 42)
        Me.femaleRadioButton.Name = "femaleRadioButton"
        Me.femaleRadioButton.Size = New System.Drawing.Size(59, 17)
        Me.femaleRadioButton.TabIndex = 0
        Me.femaleRadioButton.TabStop = True
        Me.femaleRadioButton.Text = "Female"
        Me.femaleRadioButton.UseVisualStyleBackColor = True
        '
        'colorGroupBox
        '
        Me.colorGroupBox.Controls.Add(Me.whiteRadioButton)
        Me.colorGroupBox.Controls.Add(Me.redRadioButton)
        Me.colorGroupBox.Controls.Add(Me.yellowRadioButton)
        Me.colorGroupBox.Controls.Add(Me.greenRadioButton)
        Me.colorGroupBox.Controls.Add(Me.blueRadioButton)
        Me.colorGroupBox.Location = New System.Drawing.Point(570, 40)
        Me.colorGroupBox.Name = "colorGroupBox"
        Me.colorGroupBox.Size = New System.Drawing.Size(77, 132)
        Me.colorGroupBox.TabIndex = 6
        Me.colorGroupBox.TabStop = False
        Me.colorGroupBox.Text = "Color"
        '
        'whiteRadioButton
        '
        Me.whiteRadioButton.AutoSize = True
        Me.whiteRadioButton.Location = New System.Drawing.Point(0, 111)
        Me.whiteRadioButton.Name = "whiteRadioButton"
        Me.whiteRadioButton.Size = New System.Drawing.Size(53, 17)
        Me.whiteRadioButton.TabIndex = 4
        Me.whiteRadioButton.TabStop = True
        Me.whiteRadioButton.Text = "White"
        Me.whiteRadioButton.UseVisualStyleBackColor = True
        '
        'redRadioButton
        '
        Me.redRadioButton.AutoSize = True
        Me.redRadioButton.Location = New System.Drawing.Point(0, 19)
        Me.redRadioButton.Name = "redRadioButton"
        Me.redRadioButton.Size = New System.Drawing.Size(45, 17)
        Me.redRadioButton.TabIndex = 3
        Me.redRadioButton.TabStop = True
        Me.redRadioButton.Text = "Red"
        Me.redRadioButton.UseVisualStyleBackColor = True
        '
        'yellowRadioButton
        '
        Me.yellowRadioButton.AutoSize = True
        Me.yellowRadioButton.Location = New System.Drawing.Point(-1, 88)
        Me.yellowRadioButton.Name = "yellowRadioButton"
        Me.yellowRadioButton.Size = New System.Drawing.Size(56, 17)
        Me.yellowRadioButton.TabIndex = 2
        Me.yellowRadioButton.TabStop = True
        Me.yellowRadioButton.Text = "Yellow"
        Me.yellowRadioButton.UseVisualStyleBackColor = True
        '
        'greenRadioButton
        '
        Me.greenRadioButton.AutoSize = True
        Me.greenRadioButton.Location = New System.Drawing.Point(-1, 65)
        Me.greenRadioButton.Name = "greenRadioButton"
        Me.greenRadioButton.Size = New System.Drawing.Size(54, 17)
        Me.greenRadioButton.TabIndex = 1
        Me.greenRadioButton.TabStop = True
        Me.greenRadioButton.Text = "Green"
        Me.greenRadioButton.UseVisualStyleBackColor = True
        '
        'blueRadioButton
        '
        Me.blueRadioButton.AutoSize = True
        Me.blueRadioButton.Location = New System.Drawing.Point(0, 42)
        Me.blueRadioButton.Name = "blueRadioButton"
        Me.blueRadioButton.Size = New System.Drawing.Size(46, 17)
        Me.blueRadioButton.TabIndex = 0
        Me.blueRadioButton.TabStop = True
        Me.blueRadioButton.Text = "Blue"
        Me.blueRadioButton.UseVisualStyleBackColor = True
        '
        'choicesGroupBox
        '
        Me.choicesGroupBox.Controls.Add(Me.basicRadioButton)
        Me.choicesGroupBox.Controls.Add(Me.premiumRadioButton)
        Me.choicesGroupBox.Controls.Add(Me.standardRadioButton)
        Me.choicesGroupBox.Location = New System.Drawing.Point(403, 40)
        Me.choicesGroupBox.Name = "choicesGroupBox"
        Me.choicesGroupBox.Size = New System.Drawing.Size(80, 97)
        Me.choicesGroupBox.TabIndex = 7
        Me.choicesGroupBox.TabStop = False
        Me.choicesGroupBox.Text = "Choice"
        '
        'basicRadioButton
        '
        Me.basicRadioButton.AutoSize = True
        Me.basicRadioButton.Location = New System.Drawing.Point(0, 19)
        Me.basicRadioButton.Name = "basicRadioButton"
        Me.basicRadioButton.Size = New System.Drawing.Size(51, 17)
        Me.basicRadioButton.TabIndex = 2
        Me.basicRadioButton.TabStop = True
        Me.basicRadioButton.Text = "Basic"
        Me.basicRadioButton.UseVisualStyleBackColor = True
        '
        'premiumRadioButton
        '
        Me.premiumRadioButton.AutoSize = True
        Me.premiumRadioButton.Location = New System.Drawing.Point(0, 72)
        Me.premiumRadioButton.Name = "premiumRadioButton"
        Me.premiumRadioButton.Size = New System.Drawing.Size(65, 17)
        Me.premiumRadioButton.TabIndex = 1
        Me.premiumRadioButton.TabStop = True
        Me.premiumRadioButton.Text = "Premium"
        Me.premiumRadioButton.UseVisualStyleBackColor = True
        '
        'standardRadioButton
        '
        Me.standardRadioButton.AutoSize = True
        Me.standardRadioButton.Location = New System.Drawing.Point(0, 47)
        Me.standardRadioButton.Name = "standardRadioButton"
        Me.standardRadioButton.Size = New System.Drawing.Size(68, 17)
        Me.standardRadioButton.TabIndex = 0
        Me.standardRadioButton.TabStop = True
        Me.standardRadioButton.Text = "Standard"
        Me.standardRadioButton.UseVisualStyleBackColor = True
        '
        'priceLabel
        '
        Me.priceLabel.AutoSize = True
        Me.priceLabel.Location = New System.Drawing.Point(88, 459)
        Me.priceLabel.Name = "priceLabel"
        Me.priceLabel.Size = New System.Drawing.Size(31, 13)
        Me.priceLabel.TabIndex = 8
        Me.priceLabel.Text = "Price"
        '
        'priceTextBox
        '
        Me.priceTextBox.Location = New System.Drawing.Point(151, 456)
        Me.priceTextBox.Name = "priceTextBox"
        Me.priceTextBox.ReadOnly = True
        Me.priceTextBox.Size = New System.Drawing.Size(68, 20)
        Me.priceTextBox.TabIndex = 9
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(436, 456)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(75, 23)
        Me.clearButton.TabIndex = 11
        Me.clearButton.Text = "Claer"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.choice, Me.Column1, Me.women, Me.women1, Me.men, Me.men1, Me.men2})
        Me.DataGridView1.Location = New System.Drawing.Point(18, 209)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(743, 157)
        Me.DataGridView1.TabIndex = 12
        '
        'choice
        '
        Me.choice.HeaderText = ""
        Me.choice.Name = "choice"
        Me.choice.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "women's small"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'women
        '
        Me.women.HeaderText = "women's medium"
        Me.women.Name = "women"
        Me.women.ReadOnly = True
        '
        'women1
        '
        Me.women1.HeaderText = "Women's Large"
        Me.women1.Name = "women1"
        Me.women1.ReadOnly = True
        '
        'men
        '
        Me.men.HeaderText = "Men's Small"
        Me.men.Name = "men"
        Me.men.ReadOnly = True
        '
        'men1
        '
        Me.men1.HeaderText = "Men's Medium"
        Me.men1.Name = "men1"
        Me.men1.ReadOnly = True
        '
        'men2
        '
        Me.men2.HeaderText = "Mens's Large"
        Me.men2.Name = "men2"
        Me.men2.ReadOnly = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 507)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.priceTextBox)
        Me.Controls.Add(Me.priceLabel)
        Me.Controls.Add(Me.choicesGroupBox)
        Me.Controls.Add(Me.colorGroupBox)
        Me.Controls.Add(Me.SexGroupBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.nameIputbox)
        Me.Controls.Add(Me.Button2)
        Me.Name = "Form1"
        Me.Text = "Novelty"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.SexGroupBox.ResumeLayout(False)
        Me.SexGroupBox.PerformLayout()
        Me.colorGroupBox.ResumeLayout(False)
        Me.colorGroupBox.PerformLayout()
        Me.choicesGroupBox.ResumeLayout(False)
        Me.choicesGroupBox.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents nameIputbox As TextBox
    Friend WithEvents nameLabel As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents mediumRadioButton As RadioButton
    Friend WithEvents LargeRadioButton As RadioButton
    Friend WithEvents SmallRadiobutton As RadioButton
    Friend WithEvents SexGroupBox As GroupBox
    Friend WithEvents maleRadioButton As RadioButton
    Friend WithEvents femaleRadioButton As RadioButton
    Friend WithEvents colorGroupBox As GroupBox
    Friend WithEvents whiteRadioButton As RadioButton
    Friend WithEvents redRadioButton As RadioButton
    Friend WithEvents yellowRadioButton As RadioButton
    Friend WithEvents greenRadioButton As RadioButton
    Friend WithEvents blueRadioButton As RadioButton
    Friend WithEvents choicesGroupBox As GroupBox
    Friend WithEvents basicRadioButton As RadioButton
    Friend WithEvents premiumRadioButton As RadioButton
    Friend WithEvents standardRadioButton As RadioButton
    Friend WithEvents priceLabel As Label
    Friend WithEvents priceTextBox As TextBox
    Friend WithEvents clearButton As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents choice As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents women As DataGridViewTextBoxColumn
    Friend WithEvents women1 As DataGridViewTextBoxColumn
    Friend WithEvents men As DataGridViewTextBoxColumn
    Friend WithEvents men1 As DataGridViewTextBoxColumn
    Friend WithEvents men2 As DataGridViewTextBoxColumn
End Class
