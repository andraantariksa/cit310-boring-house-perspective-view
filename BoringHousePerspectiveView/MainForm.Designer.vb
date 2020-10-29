<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean UP the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.vrpx = New System.Windows.Forms.TextBox()
        Me.vrpy = New System.Windows.Forms.TextBox()
        Me.vrpz = New System.Windows.Forms.TextBox()
        Me.vpnz = New System.Windows.Forms.TextBox()
        Me.vpny = New System.Windows.Forms.TextBox()
        Me.vpnx = New System.Windows.Forms.TextBox()
        Me.copz = New System.Windows.Forms.TextBox()
        Me.copy = New System.Windows.Forms.TextBox()
        Me.copx = New System.Windows.Forms.TextBox()
        Me.vUPz = New System.Windows.Forms.TextBox()
        Me.vUPy = New System.Windows.Forms.TextBox()
        Me.vUPx = New System.Windows.Forms.TextBox()
        Me.umax = New System.Windows.Forms.TextBox()
        Me.vmin = New System.Windows.Forms.TextBox()
        Me.umin = New System.Windows.Forms.TextBox()
        Me.vmax = New System.Windows.Forms.TextBox()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TimerX = New System.Windows.Forms.Timer(Me.components)
        Me.TimerY = New System.Windows.Forms.Timer(Me.components)
        Me.TimerZ = New System.Windows.Forms.Timer(Me.components)
        Me.btnDeflt = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ButtonOpen = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox1.Location = New System.Drawing.Point(248, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(463, 385)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "VRP (WCS)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "VPN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "VUP"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "COP"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Window min "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Window max"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 204)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Front Plane"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 233)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Back Plane"
        '
        'vrpx
        '
        Me.vrpx.Location = New System.Drawing.Point(89, 11)
        Me.vrpx.Name = "vrpx"
        Me.vrpx.Size = New System.Drawing.Size(35, 20)
        Me.vrpx.TabIndex = 1
        Me.vrpx.Text = "0"
        '
        'vrpy
        '
        Me.vrpy.Location = New System.Drawing.Point(142, 11)
        Me.vrpy.Name = "vrpy"
        Me.vrpy.Size = New System.Drawing.Size(35, 20)
        Me.vrpy.TabIndex = 2
        Me.vrpy.Text = "0"
        '
        'vrpz
        '
        Me.vrpz.Location = New System.Drawing.Point(194, 11)
        Me.vrpz.Name = "vrpz"
        Me.vrpz.Size = New System.Drawing.Size(35, 20)
        Me.vrpz.TabIndex = 3
        Me.vrpz.Text = "0"
        '
        'vpnz
        '
        Me.vpnz.Location = New System.Drawing.Point(194, 40)
        Me.vpnz.Name = "vpnz"
        Me.vpnz.Size = New System.Drawing.Size(35, 20)
        Me.vpnz.TabIndex = 6
        Me.vpnz.Text = "1"
        '
        'vpny
        '
        Me.vpny.Location = New System.Drawing.Point(142, 40)
        Me.vpny.Name = "vpny"
        Me.vpny.Size = New System.Drawing.Size(35, 20)
        Me.vpny.TabIndex = 5
        Me.vpny.Text = "0"
        '
        'vpnx
        '
        Me.vpnx.Location = New System.Drawing.Point(89, 40)
        Me.vpnx.Name = "vpnx"
        Me.vpnx.Size = New System.Drawing.Size(35, 20)
        Me.vpnx.TabIndex = 4
        Me.vpnx.Text = "0"
        '
        'copz
        '
        Me.copz.Location = New System.Drawing.Point(194, 105)
        Me.copz.Name = "copz"
        Me.copz.Size = New System.Drawing.Size(35, 20)
        Me.copz.TabIndex = 12
        Me.copz.Text = "4"
        '
        'copy
        '
        Me.copy.Location = New System.Drawing.Point(142, 105)
        Me.copy.Name = "copy"
        Me.copy.Size = New System.Drawing.Size(35, 20)
        Me.copy.TabIndex = 11
        Me.copy.Text = "0"
        '
        'copx
        '
        Me.copx.Location = New System.Drawing.Point(89, 105)
        Me.copx.Name = "copx"
        Me.copx.Size = New System.Drawing.Size(35, 20)
        Me.copx.TabIndex = 10
        Me.copx.Text = "0"
        '
        'vUPz
        '
        Me.vUPz.Location = New System.Drawing.Point(194, 72)
        Me.vUPz.Name = "vUPz"
        Me.vUPz.Size = New System.Drawing.Size(35, 20)
        Me.vUPz.TabIndex = 9
        Me.vUPz.Text = "0"
        '
        'vUPy
        '
        Me.vUPy.Location = New System.Drawing.Point(142, 72)
        Me.vUPy.Name = "vUPy"
        Me.vUPy.Size = New System.Drawing.Size(35, 20)
        Me.vUPy.TabIndex = 8
        Me.vUPy.Text = "1"
        '
        'vUPx
        '
        Me.vUPx.Location = New System.Drawing.Point(89, 72)
        Me.vUPx.Name = "vUPx"
        Me.vUPx.Size = New System.Drawing.Size(35, 20)
        Me.vUPx.TabIndex = 7
        Me.vUPx.Text = "0"
        '
        'umax
        '
        Me.umax.Location = New System.Drawing.Point(89, 166)
        Me.umax.Name = "umax"
        Me.umax.Size = New System.Drawing.Size(35, 20)
        Me.umax.TabIndex = 15
        Me.umax.Text = "2"
        '
        'vmin
        '
        Me.vmin.Location = New System.Drawing.Point(142, 135)
        Me.vmin.Name = "vmin"
        Me.vmin.Size = New System.Drawing.Size(35, 20)
        Me.vmin.TabIndex = 14
        Me.vmin.Text = "-2"
        '
        'umin
        '
        Me.umin.Location = New System.Drawing.Point(89, 135)
        Me.umin.Name = "umin"
        Me.umin.Size = New System.Drawing.Size(35, 20)
        Me.umin.TabIndex = 13
        Me.umin.Text = "-2"
        '
        'vmax
        '
        Me.vmax.Location = New System.Drawing.Point(142, 166)
        Me.vmax.Name = "vmax"
        Me.vmax.Size = New System.Drawing.Size(35, 20)
        Me.vmax.TabIndex = 16
        Me.vmax.Text = "2"
        '
        'TextBox17
        '
        Me.TextBox17.Location = New System.Drawing.Point(89, 230)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(35, 20)
        Me.TextBox17.TabIndex = 18
        Me.TextBox17.Text = "-10"
        '
        'TextBox18
        '
        Me.TextBox18.Location = New System.Drawing.Point(89, 201)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(35, 20)
        Me.TextBox18.TabIndex = 17
        Me.TextBox18.Text = "2"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 256)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(217, 30)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Perspective"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 292)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(217, 30)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "Reset"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnDeflt
        '
        Me.btnDeflt.Location = New System.Drawing.Point(12, 328)
        Me.btnDeflt.Name = "btnDeflt"
        Me.btnDeflt.Size = New System.Drawing.Size(217, 31)
        Me.btnDeflt.TabIndex = 29
        Me.btnDeflt.Text = "Set Clipping"
        Me.btnDeflt.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(717, 15)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(187, 381)
        Me.ListBox1.TabIndex = 30
        '
        'ButtonOpen
        '
        Me.ButtonOpen.Location = New System.Drawing.Point(12, 368)
        Me.ButtonOpen.Name = "ButtonOpen"
        Me.ButtonOpen.Size = New System.Drawing.Size(217, 31)
        Me.ButtonOpen.TabIndex = 31
        Me.ButtonOpen.Text = "Open"
        Me.ButtonOpen.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(916, 411)
        Me.Controls.Add(Me.ButtonOpen)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnDeflt)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox18)
        Me.Controls.Add(Me.TextBox17)
        Me.Controls.Add(Me.vmax)
        Me.Controls.Add(Me.umin)
        Me.Controls.Add(Me.vmin)
        Me.Controls.Add(Me.umax)
        Me.Controls.Add(Me.copz)
        Me.Controls.Add(Me.copy)
        Me.Controls.Add(Me.copx)
        Me.Controls.Add(Me.vUPz)
        Me.Controls.Add(Me.vUPy)
        Me.Controls.Add(Me.vUPx)
        Me.Controls.Add(Me.vpnz)
        Me.Controls.Add(Me.vpny)
        Me.Controls.Add(Me.vpnx)
        Me.Controls.Add(Me.vrpz)
        Me.Controls.Add(Me.vrpy)
        Me.Controls.Add(Me.vrpx)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "MainForm"
        Me.Text = "Boring House Perspective View"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents vrpx As TextBox
    Friend WithEvents vrpy As TextBox
    Friend WithEvents vrpz As TextBox
    Friend WithEvents vpnz As TextBox
    Friend WithEvents vpny As TextBox
    Friend WithEvents vpnx As TextBox
    Friend WithEvents copz As TextBox
    Friend WithEvents copy As TextBox
    Friend WithEvents copx As TextBox
    Friend WithEvents vUPz As TextBox
    Friend WithEvents vUPy As TextBox
    Friend WithEvents vUPx As TextBox
    Friend WithEvents umax As TextBox
    Friend WithEvents vmin As TextBox
    Friend WithEvents umin As TextBox
    Friend WithEvents vmax As TextBox
    Friend WithEvents TextBox17 As TextBox
    Friend WithEvents TextBox18 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TimerX As Timer
    Friend WithEvents TimerY As Timer
    Friend WithEvents TimerZ As Timer
    Friend WithEvents btnDeflt As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ButtonOpen As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
