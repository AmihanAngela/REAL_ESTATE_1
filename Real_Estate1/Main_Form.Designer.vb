<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Form))
        Panel_Menu = New Panel()
        btnLogout = New Button()
        Panel2 = New Panel()
        Button_Owner = New Button()
        SALES = New Button()
        Button2 = New Button()
        Button3 = New Button()
        ButtonIMAGES = New Button()
        Button4 = New Button()
        Panel1 = New Panel()
        PanelLeft = New Panel()
        PanelRight = New Panel()
        ButtonClose = New Button()
        Panel_Menu.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel_Menu
        ' 
        Panel_Menu.BackColor = Color.Maroon
        Panel_Menu.BackgroundImage = CType(resources.GetObject("Panel_Menu.BackgroundImage"), Image)
        Panel_Menu.BackgroundImageLayout = ImageLayout.Stretch
        Panel_Menu.Controls.Add(btnLogout)
        Panel_Menu.Controls.Add(Panel2)
        Panel_Menu.Controls.Add(Panel1)
        Panel_Menu.Dock = DockStyle.Fill
        Panel_Menu.Location = New Point(0, 0)
        Panel_Menu.Name = "Panel_Menu"
        Panel_Menu.Size = New Size(1818, 1050)
        Panel_Menu.TabIndex = 0
        ' 
        ' btnLogout
        ' 
        btnLogout.BackgroundImage = CType(resources.GetObject("btnLogout.BackgroundImage"), Image)
        btnLogout.BackgroundImageLayout = ImageLayout.Stretch
        btnLogout.Location = New Point(1726, 987)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(80, 63)
        btnLogout.TabIndex = 6
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), Image)
        Panel2.Controls.Add(Button_Owner)
        Panel2.Controls.Add(SALES)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Button3)
        Panel2.Controls.Add(ButtonIMAGES)
        Panel2.Controls.Add(Button4)
        Panel2.Location = New Point(130, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1525, 132)
        Panel2.TabIndex = 0
        ' 
        ' Button_Owner
        ' 
        Button_Owner.BackColor = Color.NavajoWhite
        Button_Owner.Font = New Font("Cooper Black", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button_Owner.ForeColor = Color.MidnightBlue
        Button_Owner.Location = New Point(0, 53)
        Button_Owner.Name = "Button_Owner"
        Button_Owner.Size = New Size(231, 81)
        Button_Owner.TabIndex = 0
        Button_Owner.Text = "OWNERS"
        Button_Owner.UseVisualStyleBackColor = False
        ' 
        ' SALES
        ' 
        SALES.BackColor = Color.NavajoWhite
        SALES.Font = New Font("Cooper Black", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SALES.ForeColor = Color.MidnightBlue
        SALES.Location = New Point(1257, 53)
        SALES.Name = "SALES"
        SALES.Size = New Size(245, 81)
        SALES.TabIndex = 6
        SALES.Text = "SALES"
        SALES.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.NavajoWhite
        Button2.Font = New Font("Cooper Black", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.MidnightBlue
        Button2.Location = New Point(237, 54)
        Button2.Name = "Button2"
        Button2.Size = New Size(246, 80)
        Button2.TabIndex = 1
        Button2.Text = "CLIENTS"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.NavajoWhite
        Button3.Font = New Font("Cooper Black", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.MidnightBlue
        Button3.Location = New Point(489, 56)
        Button3.Name = "Button3"
        Button3.Size = New Size(242, 78)
        Button3.TabIndex = 2
        Button3.Text = "PROPERTIES"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' ButtonIMAGES
        ' 
        ButtonIMAGES.BackColor = Color.NavajoWhite
        ButtonIMAGES.Font = New Font("Cooper Black", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ButtonIMAGES.ForeColor = Color.MidnightBlue
        ButtonIMAGES.Location = New Point(997, 55)
        ButtonIMAGES.Name = "ButtonIMAGES"
        ButtonIMAGES.Size = New Size(254, 81)
        ButtonIMAGES.TabIndex = 4
        ButtonIMAGES.Text = "IMAGES"
        ButtonIMAGES.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.NavajoWhite
        Button4.Font = New Font("Cooper Black", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.MidnightBlue
        Button4.Location = New Point(737, 56)
        Button4.Name = "Button4"
        Button4.Size = New Size(254, 81)
        Button4.TabIndex = 3
        Button4.Text = "TYPES"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkGray
        Panel1.Location = New Point(130, 138)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1515, 10)
        Panel1.TabIndex = 5
        ' 
        ' PanelLeft
        ' 
        PanelLeft.BackColor = Color.RosyBrown
        PanelLeft.Location = New Point(0, 0)
        PanelLeft.Name = "PanelLeft"
        PanelLeft.Size = New Size(5, 261)
        PanelLeft.TabIndex = 2
        ' 
        ' PanelRight
        ' 
        PanelRight.BackColor = Color.RosyBrown
        PanelRight.Location = New Point(1813, 0)
        PanelRight.Name = "PanelRight"
        PanelRight.Size = New Size(5, 261)
        PanelRight.TabIndex = 3
        ' 
        ' ButtonClose
        ' 
        ButtonClose.BackColor = Color.White
        ButtonClose.Font = New Font("Castellar", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ButtonClose.Location = New Point(1761, 0)
        ButtonClose.Name = "ButtonClose"
        ButtonClose.Size = New Size(54, 44)
        ButtonClose.TabIndex = 4
        ButtonClose.Text = "X"
        ButtonClose.UseVisualStyleBackColor = False
        ' 
        ' Main_Form
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Maroon
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1818, 1050)
        Controls.Add(ButtonClose)
        Controls.Add(PanelRight)
        Controls.Add(PanelLeft)
        Controls.Add(Panel_Menu)
        Name = "Main_Form"
        StartPosition = FormStartPosition.CenterScreen
        Text = "-"
        WindowState = FormWindowState.Maximized
        Panel_Menu.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel_Menu As Panel
    Friend WithEvents Button_Owner As Button
    Friend WithEvents ButtonIMAGES As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelLeft As Panel
    Friend WithEvents PanelRight As Panel
    Friend WithEvents ButtonClose As Button
    Friend WithEvents SALES As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnLogout As Button
End Class
