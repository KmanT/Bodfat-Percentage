<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BodyFat
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
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpSex = New System.Windows.Forms.GroupBox()
        Me.rdbFemale = New System.Windows.Forms.RadioButton()
        Me.rdbMale = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblHips = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.txtNeck = New System.Windows.Forms.TextBox()
        Me.txtWaist = New System.Windows.Forms.TextBox()
        Me.txtHips = New System.Windows.Forms.TextBox()
        Me.txtBodyFat = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.grpMeasurements = New System.Windows.Forms.GroupBox()
        Me.lblEligible = New System.Windows.Forms.Label()
        Me.grpSex.SuspendLayout()
        Me.grpMeasurements.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(13, 225)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(97, 42)
        Me.btnEnter.TabIndex = 4
        Me.btnEnter.Text = "Calculate"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(127, 225)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(92, 42)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(232, 225)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(97, 42)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'grpSex
        '
        Me.grpSex.Controls.Add(Me.rdbFemale)
        Me.grpSex.Controls.Add(Me.rdbMale)
        Me.grpSex.Location = New System.Drawing.Point(13, 13)
        Me.grpSex.Name = "grpSex"
        Me.grpSex.Size = New System.Drawing.Size(96, 86)
        Me.grpSex.TabIndex = 1
        Me.grpSex.TabStop = False
        Me.grpSex.Text = "Sex"
        '
        'rdbFemale
        '
        Me.rdbFemale.AutoSize = True
        Me.rdbFemale.Location = New System.Drawing.Point(6, 48)
        Me.rdbFemale.Name = "rdbFemale"
        Me.rdbFemale.Size = New System.Drawing.Size(75, 21)
        Me.rdbFemale.TabIndex = 1
        Me.rdbFemale.TabStop = True
        Me.rdbFemale.Text = "Female"
        Me.rdbFemale.UseVisualStyleBackColor = True
        '
        'rdbMale
        '
        Me.rdbMale.AutoSize = True
        Me.rdbMale.Location = New System.Drawing.Point(6, 21)
        Me.rdbMale.Name = "rdbMale"
        Me.rdbMale.Size = New System.Drawing.Size(59, 21)
        Me.rdbMale.TabIndex = 0
        Me.rdbMale.TabStop = True
        Me.rdbMale.Text = "Male"
        Me.rdbMale.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Age"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Height (Inches)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Neck (Inches)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Waist (Inches)"
        '
        'lblHips
        '
        Me.lblHips.AutoSize = True
        Me.lblHips.Location = New System.Drawing.Point(6, 110)
        Me.lblHips.Name = "lblHips"
        Me.lblHips.Size = New System.Drawing.Size(91, 17)
        Me.lblHips.TabIndex = 3
        Me.lblHips.Text = "Hips (Inches)"
        Me.lblHips.Visible = False
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(68, 111)
        Me.txtAge.MaxLength = 3
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(41, 22)
        Me.txtAge.TabIndex = 2
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(116, 23)
        Me.txtHeight.MaxLength = 4
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(62, 22)
        Me.txtHeight.TabIndex = 0
        '
        'txtNeck
        '
        Me.txtNeck.Location = New System.Drawing.Point(116, 51)
        Me.txtNeck.MaxLength = 4
        Me.txtNeck.Name = "txtNeck"
        Me.txtNeck.Size = New System.Drawing.Size(62, 22)
        Me.txtNeck.TabIndex = 1
        '
        'txtWaist
        '
        Me.txtWaist.Location = New System.Drawing.Point(116, 79)
        Me.txtWaist.MaxLength = 4
        Me.txtWaist.Name = "txtWaist"
        Me.txtWaist.Size = New System.Drawing.Size(62, 22)
        Me.txtWaist.TabIndex = 2
        '
        'txtHips
        '
        Me.txtHips.Location = New System.Drawing.Point(116, 107)
        Me.txtHips.MaxLength = 4
        Me.txtHips.Name = "txtHips"
        Me.txtHips.Size = New System.Drawing.Size(62, 22)
        Me.txtHips.TabIndex = 3
        Me.txtHips.Visible = False
        '
        'txtBodyFat
        '
        Me.txtBodyFat.Location = New System.Drawing.Point(76, 177)
        Me.txtBodyFat.MaxLength = 10
        Me.txtBodyFat.Name = "txtBodyFat"
        Me.txtBodyFat.ReadOnly = True
        Me.txtBodyFat.Size = New System.Drawing.Size(56, 22)
        Me.txtBodyFat.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 17)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Bodyfat "
        '
        'grpMeasurements
        '
        Me.grpMeasurements.Controls.Add(Me.Label2)
        Me.grpMeasurements.Controls.Add(Me.Label3)
        Me.grpMeasurements.Controls.Add(Me.txtHips)
        Me.grpMeasurements.Controls.Add(Me.Label4)
        Me.grpMeasurements.Controls.Add(Me.txtWaist)
        Me.grpMeasurements.Controls.Add(Me.lblHips)
        Me.grpMeasurements.Controls.Add(Me.txtNeck)
        Me.grpMeasurements.Controls.Add(Me.txtHeight)
        Me.grpMeasurements.Location = New System.Drawing.Point(139, 13)
        Me.grpMeasurements.Name = "grpMeasurements"
        Me.grpMeasurements.Size = New System.Drawing.Size(190, 143)
        Me.grpMeasurements.TabIndex = 3
        Me.grpMeasurements.TabStop = False
        Me.grpMeasurements.Text = "Measurements"
        '
        'lblEligible
        '
        Me.lblEligible.AutoSize = True
        Me.lblEligible.Location = New System.Drawing.Point(157, 180)
        Me.lblEligible.Name = "lblEligible"
        Me.lblEligible.Size = New System.Drawing.Size(62, 17)
        Me.lblEligible.TabIndex = 17
        Me.lblEligible.Text = "Eligibility"
        Me.lblEligible.Visible = False
        '
        'BodyFat
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(342, 278)
        Me.Controls.Add(Me.lblEligible)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grpMeasurements)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtBodyFat)
        Me.Controls.Add(Me.grpSex)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.txtAge)
        Me.Name = "BodyFat"
        Me.Text = "Body Fat Percentage Calculatator"
        Me.grpSex.ResumeLayout(False)
        Me.grpSex.PerformLayout()
        Me.grpMeasurements.ResumeLayout(False)
        Me.grpMeasurements.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEnter As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents grpSex As GroupBox
    Friend WithEvents rdbFemale As RadioButton
    Friend WithEvents rdbMale As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblHips As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents txtNeck As TextBox
    Friend WithEvents txtWaist As TextBox
    Friend WithEvents txtHips As TextBox
    Friend WithEvents txtBodyFat As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents grpMeasurements As GroupBox
    Friend WithEvents lblEligible As Label
End Class
