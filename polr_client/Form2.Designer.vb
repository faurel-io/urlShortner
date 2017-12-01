<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
        Me.lblDomain = New System.Windows.Forms.Label()
        Me.lblAPI = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtDomain = New System.Windows.Forms.TextBox()
        Me.txtAPI = New System.Windows.Forms.TextBox()
        Me.lblSettings = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblDomain
        '
        Me.lblDomain.AutoSize = True
        Me.lblDomain.Location = New System.Drawing.Point(0, 63)
        Me.lblDomain.Name = "lblDomain"
        Me.lblDomain.Size = New System.Drawing.Size(111, 13)
        Me.lblDomain.TabIndex = 0
        Me.lblDomain.Text = "URL Shortner Domain"
        '
        'lblAPI
        '
        Me.lblAPI.AutoSize = True
        Me.lblAPI.Location = New System.Drawing.Point(63, 94)
        Me.lblAPI.Name = "lblAPI"
        Me.lblAPI.Size = New System.Drawing.Size(48, 13)
        Me.lblAPI.TabIndex = 1
        Me.lblAPI.Text = "API KEY"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(305, 122)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtDomain
        '
        Me.txtDomain.Location = New System.Drawing.Point(118, 60)
        Me.txtDomain.Name = "txtDomain"
        Me.txtDomain.Size = New System.Drawing.Size(262, 20)
        Me.txtDomain.TabIndex = 3
        '
        'txtAPI
        '
        Me.txtAPI.Location = New System.Drawing.Point(118, 91)
        Me.txtAPI.Name = "txtAPI"
        Me.txtAPI.Size = New System.Drawing.Size(262, 20)
        Me.txtAPI.TabIndex = 4
        '
        'lblSettings
        '
        Me.lblSettings.AutoSize = True
        Me.lblSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSettings.Location = New System.Drawing.Point(88, -3)
        Me.lblSettings.Name = "lblSettings"
        Me.lblSettings.Size = New System.Drawing.Size(237, 51)
        Me.lblSettings.TabIndex = 5
        Me.lblSettings.Text = "SETTINGS"
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 154)
        Me.Controls.Add(Me.lblSettings)
        Me.Controls.Add(Me.txtAPI)
        Me.Controls.Add(Me.txtDomain)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblAPI)
        Me.Controls.Add(Me.lblDomain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSettings"
        Me.ShowInTaskbar = False
        Me.Text = "faurel.io"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDomain As Label
    Friend WithEvents lblAPI As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents txtDomain As TextBox
    Friend WithEvents txtAPI As TextBox
    Friend WithEvents lblSettings As Label
End Class
