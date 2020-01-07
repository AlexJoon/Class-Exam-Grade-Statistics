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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblA = New System.Windows.Forms.Label()
        Me.lblB = New System.Windows.Forms.Label()
        Me.lblC = New System.Windows.Forms.Label()
        Me.lblD = New System.Windows.Forms.Label()
        Me.lblF = New System.Windows.Forms.Label()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.txtC = New System.Windows.Forms.TextBox()
        Me.txtD = New System.Windows.Forms.TextBox()
        Me.txtF = New System.Windows.Forms.TextBox()
        Me.lblHighScore = New System.Windows.Forms.Label()
        Me.lblLowScore = New System.Windows.Forms.Label()
        Me.lblClassAvg = New System.Windows.Forms.Label()
        Me.lblAboveAvg = New System.Windows.Forms.Label()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.txtHS = New System.Windows.Forms.TextBox()
        Me.txtLS = New System.Windows.Forms.TextBox()
        Me.txtAvg = New System.Windows.Forms.TextBox()
        Me.txtGAvg = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.txtStudent = New System.Windows.Forms.TextBox()
        Me.lstPassFail = New System.Windows.Forms.ListBox()
        Me.LtrGradeGroup = New System.Windows.Forms.GroupBox()
        Me.lblPassFail = New System.Windows.Forms.Label()
        Me.lblStudentsAboveAvg = New System.Windows.Forms.Label()
        Me.picVector = New System.Windows.Forms.PictureBox()
        Me.lblLetters = New System.Windows.Forms.Label()
        Me.LtrGradeGroup.SuspendLayout()
        CType(Me.picVector, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(553, 57)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(402, 34)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Class Exam Grade Statistics"
        '
        'lblA
        '
        Me.lblA.AutoSize = True
        Me.lblA.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lblA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblA.Location = New System.Drawing.Point(75, 45)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(25, 24)
        Me.lblA.TabIndex = 1
        Me.lblA.Text = "A"
        '
        'lblB
        '
        Me.lblB.AutoSize = True
        Me.lblB.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lblB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblB.Location = New System.Drawing.Point(75, 138)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(25, 24)
        Me.lblB.TabIndex = 2
        Me.lblB.Text = "B"
        '
        'lblC
        '
        Me.lblC.AutoSize = True
        Me.lblC.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lblC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC.Location = New System.Drawing.Point(75, 231)
        Me.lblC.Name = "lblC"
        Me.lblC.Size = New System.Drawing.Size(26, 24)
        Me.lblC.TabIndex = 3
        Me.lblC.Text = "C"
        '
        'lblD
        '
        Me.lblD.AutoSize = True
        Me.lblD.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lblD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblD.Location = New System.Drawing.Point(75, 317)
        Me.lblD.Name = "lblD"
        Me.lblD.Size = New System.Drawing.Size(26, 24)
        Me.lblD.TabIndex = 4
        Me.lblD.Text = "D"
        '
        'lblF
        '
        Me.lblF.AutoSize = True
        Me.lblF.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lblF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblF.Location = New System.Drawing.Point(77, 402)
        Me.lblF.Name = "lblF"
        Me.lblF.Size = New System.Drawing.Size(24, 24)
        Me.lblF.TabIndex = 5
        Me.lblF.Text = "F"
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(33, 84)
        Me.txtA.Name = "txtA"
        Me.txtA.ReadOnly = True
        Me.txtA.Size = New System.Drawing.Size(107, 32)
        Me.txtA.TabIndex = 6
        Me.txtA.TabStop = False
        Me.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtB
        '
        Me.txtB.Location = New System.Drawing.Point(33, 179)
        Me.txtB.Name = "txtB"
        Me.txtB.ReadOnly = True
        Me.txtB.Size = New System.Drawing.Size(107, 32)
        Me.txtB.TabIndex = 7
        Me.txtB.TabStop = False
        Me.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtC
        '
        Me.txtC.Location = New System.Drawing.Point(33, 263)
        Me.txtC.Name = "txtC"
        Me.txtC.ReadOnly = True
        Me.txtC.Size = New System.Drawing.Size(107, 32)
        Me.txtC.TabIndex = 8
        Me.txtC.TabStop = False
        Me.txtC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtD
        '
        Me.txtD.Location = New System.Drawing.Point(33, 350)
        Me.txtD.Name = "txtD"
        Me.txtD.ReadOnly = True
        Me.txtD.Size = New System.Drawing.Size(107, 32)
        Me.txtD.TabIndex = 9
        Me.txtD.TabStop = False
        Me.txtD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtF
        '
        Me.txtF.Location = New System.Drawing.Point(33, 440)
        Me.txtF.Name = "txtF"
        Me.txtF.ReadOnly = True
        Me.txtF.Size = New System.Drawing.Size(107, 32)
        Me.txtF.TabIndex = 10
        Me.txtF.TabStop = False
        Me.txtF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblHighScore
        '
        Me.lblHighScore.AutoSize = True
        Me.lblHighScore.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lblHighScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHighScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHighScore.Location = New System.Drawing.Point(377, 205)
        Me.lblHighScore.Name = "lblHighScore"
        Me.lblHighScore.Size = New System.Drawing.Size(138, 24)
        Me.lblHighScore.TabIndex = 11
        Me.lblHighScore.Text = "Highest Score"
        '
        'lblLowScore
        '
        Me.lblLowScore.AutoSize = True
        Me.lblLowScore.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lblLowScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLowScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLowScore.Location = New System.Drawing.Point(646, 205)
        Me.lblLowScore.Name = "lblLowScore"
        Me.lblLowScore.Size = New System.Drawing.Size(133, 24)
        Me.lblLowScore.TabIndex = 12
        Me.lblLowScore.Text = "Lowest Score"
        '
        'lblClassAvg
        '
        Me.lblClassAvg.AutoSize = True
        Me.lblClassAvg.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lblClassAvg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblClassAvg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassAvg.Location = New System.Drawing.Point(377, 353)
        Me.lblClassAvg.Name = "lblClassAvg"
        Me.lblClassAvg.Size = New System.Drawing.Size(142, 24)
        Me.lblClassAvg.TabIndex = 13
        Me.lblClassAvg.Text = "Class Average"
        '
        'lblAboveAvg
        '
        Me.lblAboveAvg.AutoSize = True
        Me.lblAboveAvg.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lblAboveAvg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAboveAvg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAboveAvg.Location = New System.Drawing.Point(867, 205)
        Me.lblAboveAvg.Name = "lblAboveAvg"
        Me.lblAboveAvg.Size = New System.Drawing.Size(263, 24)
        Me.lblAboveAvg.TabIndex = 14
        Me.lblAboveAvg.Text = "% of Grades above Average"
        '
        'btnDisplay
        '
        Me.btnDisplay.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplay.Location = New System.Drawing.Point(243, 593)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(177, 57)
        Me.btnDisplay.TabIndex = 15
        Me.btnDisplay.Text = "&Display Statistics"
        Me.btnDisplay.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(742, 593)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(177, 57)
        Me.btnClear.TabIndex = 16
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnEnd
        '
        Me.btnEnd.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnd.Location = New System.Drawing.Point(993, 593)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(177, 57)
        Me.btnEnd.TabIndex = 17
        Me.btnEnd.Text = "&End"
        Me.btnEnd.UseVisualStyleBackColor = False
        '
        'txtHS
        '
        Me.txtHS.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHS.Location = New System.Drawing.Point(377, 250)
        Me.txtHS.Name = "txtHS"
        Me.txtHS.ReadOnly = True
        Me.txtHS.Size = New System.Drawing.Size(142, 32)
        Me.txtHS.TabIndex = 18
        Me.txtHS.TabStop = False
        Me.txtHS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtLS
        '
        Me.txtLS.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLS.Location = New System.Drawing.Point(641, 250)
        Me.txtLS.Name = "txtLS"
        Me.txtLS.ReadOnly = True
        Me.txtLS.Size = New System.Drawing.Size(142, 32)
        Me.txtLS.TabIndex = 19
        Me.txtLS.TabStop = False
        Me.txtLS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAvg
        '
        Me.txtAvg.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAvg.Location = New System.Drawing.Point(377, 413)
        Me.txtAvg.Name = "txtAvg"
        Me.txtAvg.ReadOnly = True
        Me.txtAvg.Size = New System.Drawing.Size(142, 32)
        Me.txtAvg.TabIndex = 20
        Me.txtAvg.TabStop = False
        Me.txtAvg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGAvg
        '
        Me.txtGAvg.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGAvg.Location = New System.Drawing.Point(929, 250)
        Me.txtGAvg.Name = "txtGAvg"
        Me.txtGAvg.ReadOnly = True
        Me.txtGAvg.Size = New System.Drawing.Size(142, 32)
        Me.txtGAvg.TabIndex = 21
        Me.txtGAvg.TabStop = False
        Me.txtGAvg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnImport
        '
        Me.btnImport.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnImport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImport.Location = New System.Drawing.Point(492, 593)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(177, 57)
        Me.btnImport.TabIndex = 22
        Me.btnImport.Text = "&Import Class"
        Me.btnImport.UseVisualStyleBackColor = False
        '
        'txtStudent
        '
        Me.txtStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudent.Location = New System.Drawing.Point(929, 413)
        Me.txtStudent.Name = "txtStudent"
        Me.txtStudent.ReadOnly = True
        Me.txtStudent.Size = New System.Drawing.Size(142, 32)
        Me.txtStudent.TabIndex = 23
        Me.txtStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lstPassFail
        '
        Me.lstPassFail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPassFail.FormattingEnabled = True
        Me.lstPassFail.ItemHeight = 22
        Me.lstPassFail.Location = New System.Drawing.Point(614, 413)
        Me.lstPassFail.Name = "lstPassFail"
        Me.lstPassFail.Size = New System.Drawing.Size(202, 70)
        Me.lstPassFail.TabIndex = 24
        '
        'LtrGradeGroup
        '
        Me.LtrGradeGroup.BackgroundImage = Global.AlekseyP_Lab_3.My.Resources.Resources.Grade_Background
        Me.LtrGradeGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LtrGradeGroup.Controls.Add(Me.lblLetters)
        Me.LtrGradeGroup.Controls.Add(Me.txtF)
        Me.LtrGradeGroup.Controls.Add(Me.txtD)
        Me.LtrGradeGroup.Controls.Add(Me.txtC)
        Me.LtrGradeGroup.Controls.Add(Me.txtB)
        Me.LtrGradeGroup.Controls.Add(Me.txtA)
        Me.LtrGradeGroup.Controls.Add(Me.lblF)
        Me.LtrGradeGroup.Controls.Add(Me.lblD)
        Me.LtrGradeGroup.Controls.Add(Me.lblC)
        Me.LtrGradeGroup.Controls.Add(Me.lblB)
        Me.LtrGradeGroup.Controls.Add(Me.lblA)
        Me.LtrGradeGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LtrGradeGroup.Location = New System.Drawing.Point(60, 57)
        Me.LtrGradeGroup.Name = "LtrGradeGroup"
        Me.LtrGradeGroup.Size = New System.Drawing.Size(176, 503)
        Me.LtrGradeGroup.TabIndex = 25
        Me.LtrGradeGroup.TabStop = False
        '
        'lblPassFail
        '
        Me.lblPassFail.AutoSize = True
        Me.lblPassFail.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lblPassFail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPassFail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassFail.Location = New System.Drawing.Point(660, 353)
        Me.lblPassFail.Name = "lblPassFail"
        Me.lblPassFail.Size = New System.Drawing.Size(95, 24)
        Me.lblPassFail.TabIndex = 26
        Me.lblPassFail.Text = "Pass/Fail"
        '
        'lblStudentsAboveAvg
        '
        Me.lblStudentsAboveAvg.AutoSize = True
        Me.lblStudentsAboveAvg.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lblStudentsAboveAvg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStudentsAboveAvg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentsAboveAvg.Location = New System.Drawing.Point(867, 353)
        Me.lblStudentsAboveAvg.Name = "lblStudentsAboveAvg"
        Me.lblStudentsAboveAvg.Size = New System.Drawing.Size(273, 24)
        Me.lblStudentsAboveAvg.TabIndex = 27
        Me.lblStudentsAboveAvg.Text = "# of Students Above Average"
        '
        'picVector
        '
        Me.picVector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picVector.Image = Global.AlekseyP_Lab_3.My.Resources.Resources.Grade_Vector
        Me.picVector.Location = New System.Drawing.Point(420, 28)
        Me.picVector.Name = "picVector"
        Me.picVector.Size = New System.Drawing.Size(99, 86)
        Me.picVector.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picVector.TabIndex = 28
        Me.picVector.TabStop = False
        '
        'lblLetters
        '
        Me.lblLetters.AutoSize = True
        Me.lblLetters.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lblLetters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLetters.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetters.Location = New System.Drawing.Point(6, 0)
        Me.lblLetters.Name = "lblLetters"
        Me.lblLetters.Size = New System.Drawing.Size(145, 27)
        Me.lblLetters.TabIndex = 29
        Me.lblLetters.Text = "Letter Grades"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AlekseyP_Lab_3.My.Resources.Resources.Grade_Background__2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1229, 700)
        Me.Controls.Add(Me.picVector)
        Me.Controls.Add(Me.lblStudentsAboveAvg)
        Me.Controls.Add(Me.lblPassFail)
        Me.Controls.Add(Me.LtrGradeGroup)
        Me.Controls.Add(Me.lstPassFail)
        Me.Controls.Add(Me.txtStudent)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.txtGAvg)
        Me.Controls.Add(Me.txtAvg)
        Me.Controls.Add(Me.txtLS)
        Me.Controls.Add(Me.txtHS)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.lblAboveAvg)
        Me.Controls.Add(Me.lblClassAvg)
        Me.Controls.Add(Me.lblLowScore)
        Me.Controls.Add(Me.lblHighScore)
        Me.Controls.Add(Me.lblTitle)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.Text = "Class Exam Grade Statistics"
        Me.LtrGradeGroup.ResumeLayout(False)
        Me.LtrGradeGroup.PerformLayout()
        CType(Me.picVector, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblA As Label
    Friend WithEvents lblB As Label
    Friend WithEvents lblC As Label
    Friend WithEvents lblD As Label
    Friend WithEvents lblF As Label
    Friend WithEvents txtA As TextBox
    Friend WithEvents txtB As TextBox
    Friend WithEvents txtC As TextBox
    Friend WithEvents txtD As TextBox
    Friend WithEvents txtF As TextBox
    Friend WithEvents lblHighScore As Label
    Friend WithEvents lblLowScore As Label
    Friend WithEvents lblClassAvg As Label
    Friend WithEvents lblAboveAvg As Label
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnEnd As Button
    Friend WithEvents txtHS As TextBox
    Friend WithEvents txtLS As TextBox
    Friend WithEvents txtAvg As TextBox
    Friend WithEvents txtGAvg As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnImport As Button
    Friend WithEvents txtStudent As TextBox
    Friend WithEvents lstPassFail As ListBox
    Friend WithEvents LtrGradeGroup As GroupBox
    Friend WithEvents lblPassFail As Label
    Friend WithEvents lblStudentsAboveAvg As Label
    Friend WithEvents picVector As PictureBox
    Friend WithEvents lblLetters As Label
End Class
