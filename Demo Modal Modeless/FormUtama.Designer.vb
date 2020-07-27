<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUtama
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
        Me.listKeluaran = New System.Windows.Forms.ListBox()
        Me.tombolModal = New System.Windows.Forms.Button()
        Me.tombolModeless = New System.Windows.Forms.Button()
        Me.tombolBersih = New System.Windows.Forms.Button()
        Me.tombolKeluar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'listKeluaran
        '
        Me.listKeluaran.FormattingEnabled = True
        Me.listKeluaran.Location = New System.Drawing.Point(13, 13)
        Me.listKeluaran.Name = "listKeluaran"
        Me.listKeluaran.Size = New System.Drawing.Size(251, 225)
        Me.listKeluaran.TabIndex = 0
        '
        'tombolModal
        '
        Me.tombolModal.Location = New System.Drawing.Point(285, 13)
        Me.tombolModal.Name = "tombolModal"
        Me.tombolModal.Size = New System.Drawing.Size(110, 39)
        Me.tombolModal.TabIndex = 1
        Me.tombolModal.Text = "Tampilkan Form &Modal"
        Me.tombolModal.UseVisualStyleBackColor = True
        '
        'tombolModeless
        '
        Me.tombolModeless.Location = New System.Drawing.Point(285, 80)
        Me.tombolModeless.Name = "tombolModeless"
        Me.tombolModeless.Size = New System.Drawing.Size(110, 39)
        Me.tombolModeless.TabIndex = 2
        Me.tombolModeless.Text = "Tampilkan Form Mo&deless"
        Me.tombolModeless.UseVisualStyleBackColor = True
        '
        'tombolBersih
        '
        Me.tombolBersih.Location = New System.Drawing.Point(285, 148)
        Me.tombolBersih.Name = "tombolBersih"
        Me.tombolBersih.Size = New System.Drawing.Size(110, 39)
        Me.tombolBersih.TabIndex = 3
        Me.tombolBersih.Text = "&Bersihkan Kotak List"
        Me.tombolBersih.UseVisualStyleBackColor = True
        '
        'tombolKeluar
        '
        Me.tombolKeluar.Location = New System.Drawing.Point(285, 208)
        Me.tombolKeluar.Name = "tombolKeluar"
        Me.tombolKeluar.Size = New System.Drawing.Size(110, 30)
        Me.tombolKeluar.TabIndex = 4
        Me.tombolKeluar.Text = "&Keluar"
        Me.tombolKeluar.UseVisualStyleBackColor = True
        '
        'FormUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 250)
        Me.Controls.Add(Me.tombolKeluar)
        Me.Controls.Add(Me.tombolBersih)
        Me.Controls.Add(Me.tombolModeless)
        Me.Controls.Add(Me.tombolModal)
        Me.Controls.Add(Me.listKeluaran)
        Me.Name = "FormUtama"
        Me.Text = "Demo Modal Modeless"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents listKeluaran As System.Windows.Forms.ListBox
    Friend WithEvents tombolModal As System.Windows.Forms.Button
    Friend WithEvents tombolModeless As System.Windows.Forms.Button
    Friend WithEvents tombolBersih As System.Windows.Forms.Button
    Friend WithEvents tombolKeluar As System.Windows.Forms.Button

End Class
