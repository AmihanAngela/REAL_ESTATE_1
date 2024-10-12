<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PropertyForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PropertyForm))
        Panel1 = New Panel()
        Panel3 = New Panel()
        ButtonSEARCHOWNER = New Button()
        ButtonSEARCH = New Button()
        ComboBoxTYPE = New ComboBox()
        Button_ShowPropertyImage = New Button()
        Button_ShowAllProperty = New Button()
        GroupBox1 = New GroupBox()
        CheckBoxELEVATOR = New CheckBox()
        CheckBoxPOOL = New CheckBox()
        CheckBoxFIREPLACE = New CheckBox()
        CheckBoxGARAGE = New CheckBox()
        CheckBoxBACKYARD = New CheckBox()
        CheckBoxBALCONY = New CheckBox()
        NumericUpDownAGE = New NumericUpDown()
        NumericUpDownBATHS = New NumericUpDown()
        NumericUpDownBEDS = New NumericUpDown()
        TextBoxCOMMENTS = New TextBox()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        ButtonCLEARFIELDS = New Button()
        ButtonREMOVE = New Button()
        ButtonEDIT = New Button()
        ButtonADD = New Button()
        TextBoxADDRESS = New TextBox()
        Label7 = New Label()
        TextBoxOWNER_ID = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        TextBoxPRICE = New TextBox()
        Label4 = New Label()
        TextBoxSIZE = New TextBox()
        Label3 = New Label()
        TextBoxID = New TextBox()
        Label2 = New Label()
        Panel2 = New Panel()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(NumericUpDownAGE, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDownBATHS, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDownBEDS, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Thistle
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(43, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1186, 746)
        Panel1.TabIndex = 2
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.LemonChiffon
        Panel3.Controls.Add(ButtonSEARCHOWNER)
        Panel3.Controls.Add(ButtonSEARCH)
        Panel3.Controls.Add(ComboBoxTYPE)
        Panel3.Controls.Add(Button_ShowPropertyImage)
        Panel3.Controls.Add(Button_ShowAllProperty)
        Panel3.Controls.Add(GroupBox1)
        Panel3.Controls.Add(NumericUpDownAGE)
        Panel3.Controls.Add(NumericUpDownBATHS)
        Panel3.Controls.Add(NumericUpDownBEDS)
        Panel3.Controls.Add(TextBoxCOMMENTS)
        Panel3.Controls.Add(Label11)
        Panel3.Controls.Add(Label10)
        Panel3.Controls.Add(Label9)
        Panel3.Controls.Add(Label8)
        Panel3.Controls.Add(ButtonCLEARFIELDS)
        Panel3.Controls.Add(ButtonREMOVE)
        Panel3.Controls.Add(ButtonEDIT)
        Panel3.Controls.Add(ButtonADD)
        Panel3.Controls.Add(TextBoxADDRESS)
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(TextBoxOWNER_ID)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(TextBoxPRICE)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(TextBoxSIZE)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(TextBoxID)
        Panel3.Controls.Add(Label2)
        Panel3.Location = New Point(12, 134)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1169, 561)
        Panel3.TabIndex = 3
        ' 
        ' ButtonSEARCHOWNER
        ' 
        ButtonSEARCHOWNER.BackColor = Color.SeaGreen
        ButtonSEARCHOWNER.ForeColor = Color.White
        ButtonSEARCHOWNER.Location = New Point(950, 65)
        ButtonSEARCHOWNER.Name = "ButtonSEARCHOWNER"
        ButtonSEARCHOWNER.Size = New Size(163, 36)
        ButtonSEARCHOWNER.TabIndex = 46
        ButtonSEARCHOWNER.Text = "Select Owner"
        ButtonSEARCHOWNER.UseVisualStyleBackColor = False
        ' 
        ' ButtonSEARCH
        ' 
        ButtonSEARCH.BackColor = Color.SeaGreen
        ButtonSEARCH.ForeColor = Color.White
        ButtonSEARCH.Location = New Point(405, 22)
        ButtonSEARCH.Name = "ButtonSEARCH"
        ButtonSEARCH.Size = New Size(136, 36)
        ButtonSEARCH.TabIndex = 45
        ButtonSEARCH.Text = "Search"
        ButtonSEARCH.UseVisualStyleBackColor = False
        ' 
        ' ComboBoxTYPE
        ' 
        ComboBoxTYPE.FormattingEnabled = True
        ComboBoxTYPE.Location = New Point(702, 25)
        ComboBoxTYPE.Name = "ComboBoxTYPE"
        ComboBoxTYPE.Size = New Size(242, 33)
        ComboBoxTYPE.TabIndex = 44
        ' 
        ' Button_ShowPropertyImage
        ' 
        Button_ShowPropertyImage.BackColor = Color.DimGray
        Button_ShowPropertyImage.ForeColor = Color.White
        Button_ShowPropertyImage.Location = New Point(621, 499)
        Button_ShowPropertyImage.Name = "Button_ShowPropertyImage"
        Button_ShowPropertyImage.Size = New Size(363, 50)
        Button_ShowPropertyImage.TabIndex = 43
        Button_ShowPropertyImage.Text = "Show This Property Images"
        Button_ShowPropertyImage.UseVisualStyleBackColor = False
        ' 
        ' Button_ShowAllProperty
        ' 
        Button_ShowAllProperty.BackColor = Color.DarkGoldenrod
        Button_ShowAllProperty.ForeColor = Color.White
        Button_ShowAllProperty.Location = New Point(186, 499)
        Button_ShowAllProperty.Name = "Button_ShowAllProperty"
        Button_ShowAllProperty.Size = New Size(429, 50)
        Button_ShowAllProperty.TabIndex = 42
        Button_ShowAllProperty.Text = "Show All Properties"
        Button_ShowAllProperty.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(CheckBoxELEVATOR)
        GroupBox1.Controls.Add(CheckBoxPOOL)
        GroupBox1.Controls.Add(CheckBoxFIREPLACE)
        GroupBox1.Controls.Add(CheckBoxGARAGE)
        GroupBox1.Controls.Add(CheckBoxBACKYARD)
        GroupBox1.Controls.Add(CheckBoxBALCONY)
        GroupBox1.Location = New Point(99, 325)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(962, 112)
        GroupBox1.TabIndex = 41
        GroupBox1.TabStop = False
        GroupBox1.Text = "Features:"
        ' 
        ' CheckBoxELEVATOR
        ' 
        CheckBoxELEVATOR.AutoSize = True
        CheckBoxELEVATOR.FlatAppearance.BorderSize = 0
        CheckBoxELEVATOR.ForeColor = Color.RoyalBlue
        CheckBoxELEVATOR.Location = New Point(821, 49)
        CheckBoxELEVATOR.Name = "CheckBoxELEVATOR"
        CheckBoxELEVATOR.Size = New Size(101, 29)
        CheckBoxELEVATOR.TabIndex = 5
        CheckBoxELEVATOR.Text = "Elevator"
        CheckBoxELEVATOR.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxPOOL
        ' 
        CheckBoxPOOL.AutoSize = True
        CheckBoxPOOL.FlatAppearance.BorderSize = 0
        CheckBoxPOOL.ForeColor = Color.RoyalBlue
        CheckBoxPOOL.Location = New Point(673, 49)
        CheckBoxPOOL.Name = "CheckBoxPOOL"
        CheckBoxPOOL.Size = New Size(73, 29)
        CheckBoxPOOL.TabIndex = 4
        CheckBoxPOOL.Text = "Pool"
        CheckBoxPOOL.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxFIREPLACE
        ' 
        CheckBoxFIREPLACE.AutoSize = True
        CheckBoxFIREPLACE.FlatAppearance.BorderSize = 0
        CheckBoxFIREPLACE.ForeColor = Color.RoyalBlue
        CheckBoxFIREPLACE.Location = New Point(511, 49)
        CheckBoxFIREPLACE.Name = "CheckBoxFIREPLACE"
        CheckBoxFIREPLACE.Size = New Size(107, 29)
        CheckBoxFIREPLACE.TabIndex = 3
        CheckBoxFIREPLACE.Text = "Fireplace"
        CheckBoxFIREPLACE.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxGARAGE
        ' 
        CheckBoxGARAGE.AutoSize = True
        CheckBoxGARAGE.FlatAppearance.BorderSize = 0
        CheckBoxGARAGE.ForeColor = Color.RoyalBlue
        CheckBoxGARAGE.Location = New Point(352, 49)
        CheckBoxGARAGE.Name = "CheckBoxGARAGE"
        CheckBoxGARAGE.Size = New Size(94, 29)
        CheckBoxGARAGE.TabIndex = 2
        CheckBoxGARAGE.Text = "Garage"
        CheckBoxGARAGE.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxBACKYARD
        ' 
        CheckBoxBACKYARD.AutoSize = True
        CheckBoxBACKYARD.FlatAppearance.BorderSize = 0
        CheckBoxBACKYARD.ForeColor = Color.RoyalBlue
        CheckBoxBACKYARD.Location = New Point(191, 49)
        CheckBoxBACKYARD.Name = "CheckBoxBACKYARD"
        CheckBoxBACKYARD.Size = New Size(109, 29)
        CheckBoxBACKYARD.TabIndex = 1
        CheckBoxBACKYARD.Text = "Backyard"
        CheckBoxBACKYARD.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxBALCONY
        ' 
        CheckBoxBALCONY.AutoSize = True
        CheckBoxBALCONY.FlatAppearance.BorderSize = 0
        CheckBoxBALCONY.ForeColor = Color.RoyalBlue
        CheckBoxBALCONY.Location = New Point(43, 49)
        CheckBoxBALCONY.Name = "CheckBoxBALCONY"
        CheckBoxBALCONY.Size = New Size(99, 29)
        CheckBoxBALCONY.TabIndex = 0
        CheckBoxBALCONY.Text = "Balcony"
        CheckBoxBALCONY.UseVisualStyleBackColor = True
        ' 
        ' NumericUpDownAGE
        ' 
        NumericUpDownAGE.Location = New Point(1011, 122)
        NumericUpDownAGE.Name = "NumericUpDownAGE"
        NumericUpDownAGE.Size = New Size(75, 31)
        NumericUpDownAGE.TabIndex = 40
        ' 
        ' NumericUpDownBATHS
        ' 
        NumericUpDownBATHS.Location = New Point(857, 120)
        NumericUpDownBATHS.Name = "NumericUpDownBATHS"
        NumericUpDownBATHS.Size = New Size(75, 31)
        NumericUpDownBATHS.TabIndex = 39
        ' 
        ' NumericUpDownBEDS
        ' 
        NumericUpDownBEDS.Location = New Point(695, 120)
        NumericUpDownBEDS.Name = "NumericUpDownBEDS"
        NumericUpDownBEDS.Size = New Size(75, 31)
        NumericUpDownBEDS.TabIndex = 38
        ' 
        ' TextBoxCOMMENTS
        ' 
        TextBoxCOMMENTS.Location = New Point(695, 180)
        TextBoxCOMMENTS.Multiline = True
        TextBoxCOMMENTS.Name = "TextBoxCOMMENTS"
        TextBoxCOMMENTS.Size = New Size(249, 127)
        TextBoxCOMMENTS.TabIndex = 37
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(577, 180)
        Label11.Name = "Label11"
        Label11.Size = New Size(103, 25)
        Label11.TabIndex = 36
        Label11.Text = "Comments:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(957, 125)
        Label10.Name = "Label10"
        Label10.Size = New Size(48, 25)
        Label10.TabIndex = 35
        Label10.Text = "Age:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(792, 122)
        Label9.Name = "Label9"
        Label9.Size = New Size(59, 25)
        Label9.TabIndex = 34
        Label9.Text = "Baths:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(626, 122)
        Label8.Name = "Label8"
        Label8.Size = New Size(54, 25)
        Label8.TabIndex = 33
        Label8.Text = "Beds:"
        ' 
        ' ButtonCLEARFIELDS
        ' 
        ButtonCLEARFIELDS.BackColor = Color.Gold
        ButtonCLEARFIELDS.ForeColor = Color.Black
        ButtonCLEARFIELDS.Location = New Point(621, 443)
        ButtonCLEARFIELDS.Name = "ButtonCLEARFIELDS"
        ButtonCLEARFIELDS.Size = New Size(363, 50)
        ButtonCLEARFIELDS.TabIndex = 32
        ButtonCLEARFIELDS.Text = "Clear Fields"
        ButtonCLEARFIELDS.UseVisualStyleBackColor = False
        ' 
        ' ButtonREMOVE
        ' 
        ButtonREMOVE.BackColor = Color.Red
        ButtonREMOVE.ForeColor = Color.White
        ButtonREMOVE.Location = New Point(473, 443)
        ButtonREMOVE.Name = "ButtonREMOVE"
        ButtonREMOVE.Size = New Size(151, 50)
        ButtonREMOVE.TabIndex = 31
        ButtonREMOVE.Text = "REMOVE"
        ButtonREMOVE.UseVisualStyleBackColor = False
        ' 
        ' ButtonEDIT
        ' 
        ButtonEDIT.BackColor = Color.DeepSkyBlue
        ButtonEDIT.ForeColor = Color.White
        ButtonEDIT.Location = New Point(328, 443)
        ButtonEDIT.Name = "ButtonEDIT"
        ButtonEDIT.Size = New Size(142, 50)
        ButtonEDIT.TabIndex = 30
        ButtonEDIT.Text = "EDIT"
        ButtonEDIT.UseVisualStyleBackColor = False
        ' 
        ' ButtonADD
        ' 
        ButtonADD.BackColor = Color.YellowGreen
        ButtonADD.ForeColor = Color.White
        ButtonADD.Location = New Point(186, 443)
        ButtonADD.Name = "ButtonADD"
        ButtonADD.Size = New Size(136, 50)
        ButtonADD.TabIndex = 29
        ButtonADD.Text = "ADD"
        ButtonADD.UseVisualStyleBackColor = False
        ' 
        ' TextBoxADDRESS
        ' 
        TextBoxADDRESS.Location = New Point(244, 180)
        TextBoxADDRESS.Multiline = True
        TextBoxADDRESS.Name = "TextBoxADDRESS"
        TextBoxADDRESS.Size = New Size(249, 127)
        TextBoxADDRESS.TabIndex = 28
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(130, 183)
        Label7.Name = "Label7"
        Label7.Size = New Size(81, 25)
        Label7.TabIndex = 27
        Label7.Text = "Address:"
        ' 
        ' TextBoxOWNER_ID
        ' 
        TextBoxOWNER_ID.Location = New Point(702, 68)
        TextBoxOWNER_ID.Name = "TextBoxOWNER_ID"
        TextBoxOWNER_ID.Size = New Size(242, 31)
        TextBoxOWNER_ID.TabIndex = 26
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(612, 71)
        Label6.Name = "Label6"
        Label6.Size = New Size(68, 25)
        Label6.TabIndex = 25
        Label6.Text = "Owner:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(627, 28)
        Label5.Name = "Label5"
        Label5.Size = New Size(53, 25)
        Label5.TabIndex = 23
        Label5.Text = "Type:"
        ' 
        ' TextBoxPRICE
        ' 
        TextBoxPRICE.Location = New Point(242, 125)
        TextBoxPRICE.Name = "TextBoxPRICE"
        TextBoxPRICE.Size = New Size(249, 31)
        TextBoxPRICE.TabIndex = 22
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(167, 131)
        Label4.Name = "Label4"
        Label4.Size = New Size(53, 25)
        Label4.TabIndex = 21
        Label4.Text = "Price:"
        ' 
        ' TextBoxSIZE
        ' 
        TextBoxSIZE.Location = New Point(242, 74)
        TextBoxSIZE.Name = "TextBoxSIZE"
        TextBoxSIZE.Size = New Size(249, 31)
        TextBoxSIZE.TabIndex = 20
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(173, 80)
        Label3.Name = "Label3"
        Label3.Size = New Size(47, 25)
        Label3.TabIndex = 19
        Label3.Text = "Size:"
        ' 
        ' TextBoxID
        ' 
        TextBoxID.Location = New Point(242, 22)
        TextBoxID.Name = "TextBoxID"
        TextBoxID.Size = New Size(157, 31)
        TextBoxID.TabIndex = 18
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(186, 28)
        Label2.Name = "Label2"
        Label2.Size = New Size(34, 25)
        Label2.TabIndex = 17
        Label2.Text = "ID:"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Location = New Point(12, 106)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1585, 10)
        Panel2.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.Font = New Font("Gill Sans Ultra Bold", 26F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(98, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(431, 76)
        Label1.TabIndex = 1
        Label1.Text = "PROPERTIES"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 24)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(89, 76)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.Font = New Font("Castellar", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(1235, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(54, 44)
        Button1.TabIndex = 7
        Button1.Text = "X"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PropertyForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Thistle
        ClientSize = New Size(1290, 1035)
        Controls.Add(Button1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "PropertyForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PropertyForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(NumericUpDownAGE, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDownBATHS, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDownBEDS, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ButtonCLEARFIELDS As Button
    Friend WithEvents ButtonREMOVE As Button
    Friend WithEvents ButtonEDIT As Button
    Friend WithEvents ButtonADD As Button
    Friend WithEvents TextBoxADDRESS As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxOWNER_ID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxPRICE As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxSIZE As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBoxCOMMENTS As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents NumericUpDownAGE As NumericUpDown
    Friend WithEvents NumericUpDownBATHS As NumericUpDown
    Friend WithEvents NumericUpDownBEDS As NumericUpDown
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckBoxELEVATOR As CheckBox
    Friend WithEvents CheckBoxPOOL As CheckBox
    Friend WithEvents CheckBoxFIREPLACE As CheckBox
    Friend WithEvents CheckBoxGARAGE As CheckBox
    Friend WithEvents CheckBoxBACKYARD As CheckBox
    Friend WithEvents CheckBoxBALCONY As CheckBox
    Friend WithEvents Button_ShowPropertyImage As Button
    Friend WithEvents Button_ShowAllProperty As Button
    Friend WithEvents ComboBoxTYPE As ComboBox
    Friend WithEvents ButtonSEARCH As Button
    Friend WithEvents ButtonSEARCHOWNER As Button
End Class
