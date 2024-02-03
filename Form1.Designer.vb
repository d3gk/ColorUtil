<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_MAIN
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_MAIN))
        btn_reset = New Button()
        sb_r = New HScrollBar()
        sb_g = New HScrollBar()
        sb_b = New HScrollBar()
        pb_main = New PictureBox()
        tb_r = New TextBox()
        tb_g = New TextBox()
        tb_b = New TextBox()
        menu_bar = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        CType(pb_main, ComponentModel.ISupportInitialize).BeginInit()
        menu_bar.SuspendLayout()
        SuspendLayout()
        ' 
        ' btn_reset
        ' 
        btn_reset.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btn_reset.Location = New Point(671, 451)
        btn_reset.Name = "btn_reset"
        btn_reset.Size = New Size(117, 23)
        btn_reset.TabIndex = 0
        btn_reset.TabStop = False
        btn_reset.Text = "Reset Values"
        btn_reset.UseVisualStyleBackColor = True
        ' 
        ' sb_r
        ' 
        sb_r.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        sb_r.Location = New Point(9, 397)
        sb_r.Maximum = 255
        sb_r.Name = "sb_r"
        sb_r.Size = New Size(357, 17)
        sb_r.TabIndex = 1
        ' 
        ' sb_g
        ' 
        sb_g.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        sb_g.Location = New Point(9, 425)
        sb_g.Maximum = 255
        sb_g.Name = "sb_g"
        sb_g.Size = New Size(357, 17)
        sb_g.TabIndex = 2
        ' 
        ' sb_b
        ' 
        sb_b.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        sb_b.Location = New Point(9, 453)
        sb_b.Maximum = 255
        sb_b.Name = "sb_b"
        sb_b.Size = New Size(357, 17)
        sb_b.TabIndex = 3
        ' 
        ' pb_main
        ' 
        pb_main.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pb_main.BorderStyle = BorderStyle.Fixed3D
        pb_main.Location = New Point(9, 30)
        pb_main.Name = "pb_main"
        pb_main.Size = New Size(779, 361)
        pb_main.TabIndex = 4
        pb_main.TabStop = False
        ' 
        ' tb_r
        ' 
        tb_r.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        tb_r.Font = New Font("Microsoft Sans Serif", 9F)
        tb_r.Location = New Point(380, 397)
        tb_r.Name = "tb_r"
        tb_r.Size = New Size(100, 21)
        tb_r.TabIndex = 0
        ' 
        ' tb_g
        ' 
        tb_g.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        tb_g.Font = New Font("Microsoft Sans Serif", 9F)
        tb_g.Location = New Point(380, 425)
        tb_g.Name = "tb_g"
        tb_g.Size = New Size(100, 21)
        tb_g.TabIndex = 1
        ' 
        ' tb_b
        ' 
        tb_b.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        tb_b.Font = New Font("Microsoft Sans Serif", 9F)
        tb_b.Location = New Point(380, 453)
        tb_b.Name = "tb_b"
        tb_b.Size = New Size(100, 21)
        tb_b.TabIndex = 2
        ' 
        ' menu_bar
        ' 
        menu_bar.GripStyle = ToolStripGripStyle.Visible
        menu_bar.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, HelpToolStripMenuItem})
        menu_bar.Location = New Point(0, 0)
        menu_bar.Name = "menu_bar"
        menu_bar.RenderMode = ToolStripRenderMode.System
        menu_bar.Size = New Size(800, 24)
        menu_bar.TabIndex = 8
        menu_bar.Text = "Menu"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "&File"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(180, 22)
        ExitToolStripMenuItem.Text = "E&xit"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AboutToolStripMenuItem})
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(44, 20)
        HelpToolStripMenuItem.Text = "&Help"
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(107, 22)
        AboutToolStripMenuItem.Text = "About"
        ' 
        ' F_MAIN
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 482)
        Controls.Add(tb_b)
        Controls.Add(tb_g)
        Controls.Add(tb_r)
        Controls.Add(pb_main)
        Controls.Add(sb_b)
        Controls.Add(sb_g)
        Controls.Add(sb_r)
        Controls.Add(btn_reset)
        Controls.Add(menu_bar)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = menu_bar
        Name = "F_MAIN"
        Text = "ColorUtil"
        CType(pb_main, ComponentModel.ISupportInitialize).EndInit()
        menu_bar.ResumeLayout(False)
        menu_bar.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_reset As Button
    Friend WithEvents sb_r As HScrollBar
    Friend WithEvents sb_g As HScrollBar
    Friend WithEvents sb_b As HScrollBar
    Friend WithEvents pb_main As PictureBox
    Friend WithEvents tb_r As TextBox
    Friend WithEvents tb_g As TextBox
    Friend WithEvents tb_b As TextBox
    Friend WithEvents menu_bar As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem

End Class
