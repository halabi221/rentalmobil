<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menuutama
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
        Me.btnuser = New System.Windows.Forms.Button()
        Me.btnrental = New System.Windows.Forms.Button()
        Me.btnlaporan = New System.Windows.Forms.Button()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnuser
        '
        Me.btnuser.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnuser.Location = New System.Drawing.Point(74, 51)
        Me.btnuser.Name = "btnuser"
        Me.btnuser.Size = New System.Drawing.Size(75, 23)
        Me.btnuser.TabIndex = 0
        Me.btnuser.Text = "User"
        Me.btnuser.UseVisualStyleBackColor = False
        '
        'btnrental
        '
        Me.btnrental.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnrental.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrental.Location = New System.Drawing.Point(165, 51)
        Me.btnrental.Name = "btnrental"
        Me.btnrental.Size = New System.Drawing.Size(75, 23)
        Me.btnrental.TabIndex = 1
        Me.btnrental.Text = "Rental"
        Me.btnrental.UseVisualStyleBackColor = False
        '
        'btnlaporan
        '
        Me.btnlaporan.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnlaporan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlaporan.Location = New System.Drawing.Point(259, 51)
        Me.btnlaporan.Name = "btnlaporan"
        Me.btnlaporan.Size = New System.Drawing.Size(171, 23)
        Me.btnlaporan.TabIndex = 2
        Me.btnlaporan.Text = "Laporan penyewaan"
        Me.btnlaporan.UseVisualStyleBackColor = False
        '
        'btnlogout
        '
        Me.btnlogout.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnlogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogout.Location = New System.Drawing.Point(464, 51)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(75, 23)
        Me.btnlogout.TabIndex = 3
        Me.btnlogout.Text = "Logout"
        Me.btnlogout.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(64, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(475, 55)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "SELAMAT DATANG"
        '
        'menuutama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 464)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnlogout)
        Me.Controls.Add(Me.btnlaporan)
        Me.Controls.Add(Me.btnrental)
        Me.Controls.Add(Me.btnuser)
        Me.Name = "menuutama"
        Me.Text = "menuutama"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnuser As Button
    Friend WithEvents btnrental As Button
    Friend WithEvents btnlaporan As Button
    Friend WithEvents btnlogout As Button
    Friend WithEvents Label1 As Label
End Class
