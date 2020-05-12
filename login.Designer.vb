<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_login
    Inherits System.Windows.Forms.UserControl

    'Descartar substituições de UserControl1 para limpar lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(f_login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lb_login = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.BTN_login = New System.Windows.Forms.Button()
        Me.BTN_sair = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(43, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuário"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(44, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Senha"
        '
        'lb_login
        '
        Me.lb_login.AutoSize = True
        Me.lb_login.BackColor = System.Drawing.Color.Transparent
        Me.lb_login.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_login.ForeColor = System.Drawing.Color.Gainsboro
        Me.lb_login.Location = New System.Drawing.Point(222, 222)
        Me.lb_login.Name = "lb_login"
        Me.lb_login.Size = New System.Drawing.Size(55, 25)
        Me.lb_login.TabIndex = 2
        Me.lb_login.Text = "info"
        '
        'ToolTip1
        '
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(147, 80)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(217, 26)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox2.Location = New System.Drawing.Point(147, 114)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(217, 26)
        Me.TextBox2.TabIndex = 4
        '
        'BTN_login
        '
        Me.BTN_login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_login.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BTN_login.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray
        Me.BTN_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.BTN_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.BTN_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_login.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_login.ForeColor = System.Drawing.Color.Gainsboro
        Me.BTN_login.Location = New System.Drawing.Point(147, 159)
        Me.BTN_login.Name = "BTN_login"
        Me.BTN_login.Size = New System.Drawing.Size(91, 32)
        Me.BTN_login.TabIndex = 5
        Me.BTN_login.Text = "Login"
        Me.BTN_login.UseVisualStyleBackColor = True
        '
        'BTN_sair
        '
        Me.BTN_sair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_sair.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BTN_sair.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray
        Me.BTN_sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.BTN_sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.BTN_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_sair.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_sair.ForeColor = System.Drawing.Color.Gainsboro
        Me.BTN_sair.Location = New System.Drawing.Point(273, 159)
        Me.BTN_sair.Name = "BTN_sair"
        Me.BTN_sair.Size = New System.Drawing.Size(91, 32)
        Me.BTN_sair.TabIndex = 6
        Me.BTN_sair.Text = "Sair"
        Me.BTN_sair.UseVisualStyleBackColor = True
        '
        'f_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Controls.Add(Me.BTN_sair)
        Me.Controls.Add(Me.BTN_login)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lb_login)
        Me.Controls.Add(Me.Label2)
        Me.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.Name = "f_login"
        Me.Size = New System.Drawing.Size(450, 300)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lb_login As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents BTN_login As Button
    Friend WithEvents BTN_sair As Button
End Class
