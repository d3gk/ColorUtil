<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutBox
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btn_ok = New Button()
        l_main = New Label()
        SuspendLayout()
        ' 
        ' btn_ok
        ' 
        btn_ok.Location = New Point(116, 61)
        btn_ok.Name = "btn_ok"
        btn_ok.Size = New Size(75, 23)
        btn_ok.TabIndex = 0
        btn_ok.Text = "OK"
        btn_ok.UseVisualStyleBackColor = True
        ' 
        ' l_main
        ' 
        l_main.Location = New Point(12, 9)
        l_main.Name = "l_main"
        l_main.Size = New Size(179, 49)
        l_main.TabIndex = 1
        l_main.Text = "Color Utility v.1.0" & vbCrLf & "Made by: d3gk" & vbCrLf & "Distributed under GNU GPL v3"
        ' 
        ' AboutBox
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(203, 92)
        Controls.Add(l_main)
        Controls.Add(btn_ok)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "AboutBox"
        ShowIcon = False
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "AboutBox"
        TopMost = True
        ResumeLayout(False)
    End Sub

    Friend WithEvents btn_ok As Button
    Friend WithEvents l_main As Label
End Class
