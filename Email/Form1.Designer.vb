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
        Me.Tbemail = New System.Windows.Forms.TextBox()
        Me.TbSubject = New System.Windows.Forms.TextBox()
        Me.TbPesan = New System.Windows.Forms.TextBox()
        Me.Btnklik = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Tbemail
        '
        Me.Tbemail.Location = New System.Drawing.Point(181, 59)
        Me.Tbemail.Name = "Tbemail"
        Me.Tbemail.Size = New System.Drawing.Size(177, 20)
        Me.Tbemail.TabIndex = 0
        '
        'TbSubject
        '
        Me.TbSubject.Location = New System.Drawing.Point(181, 85)
        Me.TbSubject.Name = "TbSubject"
        Me.TbSubject.Size = New System.Drawing.Size(177, 20)
        Me.TbSubject.TabIndex = 1
        '
        'TbPesan
        '
        Me.TbPesan.Location = New System.Drawing.Point(181, 111)
        Me.TbPesan.Multiline = True
        Me.TbPesan.Name = "TbPesan"
        Me.TbPesan.Size = New System.Drawing.Size(232, 111)
        Me.TbPesan.TabIndex = 2
        '
        'Btnklik
        '
        Me.Btnklik.Location = New System.Drawing.Point(181, 229)
        Me.Btnklik.Name = "Btnklik"
        Me.Btnklik.Size = New System.Drawing.Size(75, 23)
        Me.Btnklik.TabIndex = 3
        Me.Btnklik.Text = "Button1"
        Me.Btnklik.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Btnklik)
        Me.Controls.Add(Me.TbPesan)
        Me.Controls.Add(Me.TbSubject)
        Me.Controls.Add(Me.Tbemail)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Tbemail As TextBox
    Friend WithEvents TbSubject As TextBox
    Friend WithEvents TbPesan As TextBox
    Friend WithEvents Btnklik As Button
End Class
