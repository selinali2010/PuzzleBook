<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Intro
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
        Me.PnlMenu = New System.Windows.Forms.Panel()
        Me.BtnLanguage = New System.Windows.Forms.Button()
        Me.LblOMWC = New System.Windows.Forms.Label()
        Me.LlblOMWC = New System.Windows.Forms.LinkLabel()
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.PnlLevel = New System.Windows.Forms.Panel()
        Me.LblLevel = New System.Windows.Forms.Label()
        Me.LblL2 = New System.Windows.Forms.Label()
        Me.LblL1 = New System.Windows.Forms.Label()
        Me.BtnReturn = New System.Windows.Forms.Button()
        Me.PBoxL2 = New System.Windows.Forms.PictureBox()
        Me.PBoxL1 = New System.Windows.Forms.PictureBox()
        Me.PnlSave = New System.Windows.Forms.Panel()
        Me.LblSave = New System.Windows.Forms.Label()
        Me.BtnS3 = New System.Windows.Forms.Button()
        Me.BtnS2 = New System.Windows.Forms.Button()
        Me.BtnS1 = New System.Windows.Forms.Button()
        Me.PnlMenu.SuspendLayout()
        Me.PnlLevel.SuspendLayout()
        CType(Me.PBoxL2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBoxL1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlSave.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlMenu
        '
        Me.PnlMenu.BackgroundImage = Global.PictureBook.My.Resources.Resources.intro
        Me.PnlMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlMenu.Controls.Add(Me.BtnLanguage)
        Me.PnlMenu.Controls.Add(Me.LblOMWC)
        Me.PnlMenu.Controls.Add(Me.LlblOMWC)
        Me.PnlMenu.Controls.Add(Me.BtnStart)
        Me.PnlMenu.Location = New System.Drawing.Point(10, 9)
        Me.PnlMenu.Name = "PnlMenu"
        Me.PnlMenu.Size = New System.Drawing.Size(1028, 572)
        Me.PnlMenu.TabIndex = 1
        '
        'BtnLanguage
        '
        Me.BtnLanguage.BackColor = System.Drawing.Color.White
        Me.BtnLanguage.Location = New System.Drawing.Point(34, 511)
        Me.BtnLanguage.Name = "BtnLanguage"
        Me.BtnLanguage.Size = New System.Drawing.Size(102, 40)
        Me.BtnLanguage.TabIndex = 3
        Me.BtnLanguage.Text = "中文"
        Me.BtnLanguage.UseVisualStyleBackColor = False
        '
        'LblOMWC
        '
        Me.LblOMWC.BackColor = System.Drawing.Color.White
        Me.LblOMWC.Location = New System.Drawing.Point(697, 471)
        Me.LblOMWC.Name = "LblOMWC"
        Me.LblOMWC.Size = New System.Drawing.Size(313, 49)
        Me.LblOMWC.TabIndex = 2
        Me.LblOMWC.Text = "This game was created for the Ottawa Mandarin Wesleyan Church"
        Me.LblOMWC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LlblOMWC
        '
        Me.LlblOMWC.BackColor = System.Drawing.Color.White
        Me.LlblOMWC.Location = New System.Drawing.Point(812, 530)
        Me.LlblOMWC.Name = "LlblOMWC"
        Me.LlblOMWC.Size = New System.Drawing.Size(198, 21)
        Me.LlblOMWC.TabIndex = 1
        Me.LlblOMWC.TabStop = True
        Me.LlblOMWC.Text = "Click here to learn more."
        Me.LlblOMWC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnStart
        '
        Me.BtnStart.BackColor = System.Drawing.Color.White
        Me.BtnStart.Location = New System.Drawing.Point(443, 447)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(134, 42)
        Me.BtnStart.TabIndex = 0
        Me.BtnStart.Text = "Begin"
        Me.BtnStart.UseVisualStyleBackColor = False
        '
        'PnlLevel
        '
        Me.PnlLevel.BackColor = System.Drawing.Color.OldLace
        Me.PnlLevel.BackgroundImage = Global.PictureBook.My.Resources.Resources.simple_background
        Me.PnlLevel.Controls.Add(Me.LblLevel)
        Me.PnlLevel.Controls.Add(Me.LblL2)
        Me.PnlLevel.Controls.Add(Me.LblL1)
        Me.PnlLevel.Controls.Add(Me.BtnReturn)
        Me.PnlLevel.Controls.Add(Me.PBoxL2)
        Me.PnlLevel.Controls.Add(Me.PBoxL1)
        Me.PnlLevel.Location = New System.Drawing.Point(10, 9)
        Me.PnlLevel.Name = "PnlLevel"
        Me.PnlLevel.Size = New System.Drawing.Size(1029, 572)
        Me.PnlLevel.TabIndex = 0
        Me.PnlLevel.Visible = False
        '
        'LblLevel
        '
        Me.LblLevel.AutoSize = True
        Me.LblLevel.BackColor = System.Drawing.Color.Transparent
        Me.LblLevel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLevel.Location = New System.Drawing.Point(142, 106)
        Me.LblLevel.Name = "LblLevel"
        Me.LblLevel.Size = New System.Drawing.Size(188, 30)
        Me.LblLevel.TabIndex = 11
        Me.LblLevel.Text = "Select a Level:"
        '
        'LblL2
        '
        Me.LblL2.BackColor = System.Drawing.Color.Transparent
        Me.LblL2.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblL2.Location = New System.Drawing.Point(583, 393)
        Me.LblL2.Name = "LblL2"
        Me.LblL2.Size = New System.Drawing.Size(312, 31)
        Me.LblL2.TabIndex = 10
        Me.LblL2.Text = "Food from the Garden of Eden"
        '
        'LblL1
        '
        Me.LblL1.BackColor = System.Drawing.Color.Transparent
        Me.LblL1.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblL1.Location = New System.Drawing.Point(228, 393)
        Me.LblL1.Name = "LblL1"
        Me.LblL1.Size = New System.Drawing.Size(223, 21)
        Me.LblL1.TabIndex = 9
        Me.LblL1.Text = "Noah's Ark of Animals"
        '
        'BtnReturn
        '
        Me.BtnReturn.BackColor = System.Drawing.Color.White
        Me.BtnReturn.Location = New System.Drawing.Point(34, 26)
        Me.BtnReturn.Name = "BtnReturn"
        Me.BtnReturn.Size = New System.Drawing.Size(113, 37)
        Me.BtnReturn.TabIndex = 8
        Me.BtnReturn.Text = "Return"
        Me.BtnReturn.UseVisualStyleBackColor = False
        '
        'PBoxL2
        '
        Me.PBoxL2.Location = New System.Drawing.Point(589, 217)
        Me.PBoxL2.Name = "PBoxL2"
        Me.PBoxL2.Size = New System.Drawing.Size(209, 154)
        Me.PBoxL2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBoxL2.TabIndex = 5
        Me.PBoxL2.TabStop = False
        '
        'PBoxL1
        '
        Me.PBoxL1.Location = New System.Drawing.Point(221, 217)
        Me.PBoxL1.Name = "PBoxL1"
        Me.PBoxL1.Size = New System.Drawing.Size(209, 154)
        Me.PBoxL1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBoxL1.TabIndex = 4
        Me.PBoxL1.TabStop = False
        '
        'PnlSave
        '
        Me.PnlSave.BackgroundImage = Global.PictureBook.My.Resources.Resources.simple_background
        Me.PnlSave.Controls.Add(Me.LblSave)
        Me.PnlSave.Controls.Add(Me.BtnS3)
        Me.PnlSave.Controls.Add(Me.BtnS2)
        Me.PnlSave.Controls.Add(Me.BtnS1)
        Me.PnlSave.Location = New System.Drawing.Point(10, 9)
        Me.PnlSave.Name = "PnlSave"
        Me.PnlSave.Size = New System.Drawing.Size(1029, 572)
        Me.PnlSave.TabIndex = 2
        Me.PnlSave.Visible = False
        '
        'LblSave
        '
        Me.LblSave.AutoSize = True
        Me.LblSave.BackColor = System.Drawing.Color.White
        Me.LblSave.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSave.Location = New System.Drawing.Point(61, 56)
        Me.LblSave.Name = "LblSave"
        Me.LblSave.Size = New System.Drawing.Size(203, 23)
        Me.LblSave.TabIndex = 3
        Me.LblSave.Text = "Choose a save slot:"
        '
        'BtnS3
        '
        Me.BtnS3.BackColor = System.Drawing.Color.White
        Me.BtnS3.Location = New System.Drawing.Point(293, 377)
        Me.BtnS3.Name = "BtnS3"
        Me.BtnS3.Size = New System.Drawing.Size(418, 64)
        Me.BtnS3.TabIndex = 2
        Me.BtnS3.Text = "Save 3"
        Me.BtnS3.UseVisualStyleBackColor = False
        '
        'BtnS2
        '
        Me.BtnS2.BackColor = System.Drawing.Color.White
        Me.BtnS2.Location = New System.Drawing.Point(293, 254)
        Me.BtnS2.Name = "BtnS2"
        Me.BtnS2.Size = New System.Drawing.Size(418, 64)
        Me.BtnS2.TabIndex = 1
        Me.BtnS2.Text = "Save 2"
        Me.BtnS2.UseVisualStyleBackColor = False
        '
        'BtnS1
        '
        Me.BtnS1.BackColor = System.Drawing.Color.White
        Me.BtnS1.Location = New System.Drawing.Point(293, 122)
        Me.BtnS1.Name = "BtnS1"
        Me.BtnS1.Size = New System.Drawing.Size(418, 64)
        Me.BtnS1.TabIndex = 0
        Me.BtnS1.Text = "Save 1"
        Me.BtnS1.UseVisualStyleBackColor = False
        '
        'Intro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 592)
        Me.Controls.Add(Me.PnlMenu)
        Me.Controls.Add(Me.PnlLevel)
        Me.Controls.Add(Me.PnlSave)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Intro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.PnlMenu.ResumeLayout(False)
        Me.PnlLevel.ResumeLayout(False)
        Me.PnlLevel.PerformLayout()
        CType(Me.PBoxL2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBoxL1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlSave.ResumeLayout(False)
        Me.PnlSave.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnlLevel As System.Windows.Forms.Panel
    Friend WithEvents PBoxL2 As System.Windows.Forms.PictureBox
    Friend WithEvents PBoxL1 As System.Windows.Forms.PictureBox
    Friend WithEvents PnlMenu As System.Windows.Forms.Panel
    Friend WithEvents BtnStart As System.Windows.Forms.Button
    Friend WithEvents BtnReturn As System.Windows.Forms.Button
    Friend WithEvents PnlSave As System.Windows.Forms.Panel
    Friend WithEvents LblSave As System.Windows.Forms.Label
    Friend WithEvents BtnS3 As System.Windows.Forms.Button
    Friend WithEvents BtnS2 As System.Windows.Forms.Button
    Friend WithEvents BtnS1 As System.Windows.Forms.Button
    Friend WithEvents LblL1 As System.Windows.Forms.Label
    Friend WithEvents LblL2 As System.Windows.Forms.Label
    Friend WithEvents LblLevel As System.Windows.Forms.Label
    Friend WithEvents LlblOMWC As System.Windows.Forms.LinkLabel
    Friend WithEvents BtnLanguage As System.Windows.Forms.Button
    Private WithEvents LblOMWC As System.Windows.Forms.Label
End Class
