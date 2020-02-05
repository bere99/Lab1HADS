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
        Me.LabelErrors = New System.Windows.Forms.Label()
        Me.IVAPagarBox = New System.Windows.Forms.TextBox()
        Me.PSinIVABox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TipoIVA = New System.Windows.Forms.ComboBox()
        Me.PrecioT = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LabelErrors
        '
        Me.LabelErrors.AutoSize = True
        Me.LabelErrors.Location = New System.Drawing.Point(39, 204)
        Me.LabelErrors.Name = "LabelErrors"
        Me.LabelErrors.Size = New System.Drawing.Size(12, 17)
        Me.LabelErrors.TabIndex = 21
        Me.LabelErrors.Text = " "
        '
        'IVAPagarBox
        '
        Me.IVAPagarBox.Location = New System.Drawing.Point(127, 274)
        Me.IVAPagarBox.Name = "IVAPagarBox"
        Me.IVAPagarBox.ReadOnly = True
        Me.IVAPagarBox.Size = New System.Drawing.Size(100, 22)
        Me.IVAPagarBox.TabIndex = 20
        '
        'PSinIVABox
        '
        Me.PSinIVABox.Location = New System.Drawing.Point(127, 238)
        Me.PSinIVABox.Name = "PSinIVABox"
        Me.PSinIVABox.ReadOnly = True
        Me.PSinIVABox.Size = New System.Drawing.Size(100, 22)
        Me.PSinIVABox.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 274)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 17)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "IVA a pagar: "
        '
        'TipoIVA
        '
        Me.TipoIVA.FormattingEnabled = True
        Me.TipoIVA.Items.AddRange(New Object() {"General", "Reducido", "Superreducido"})
        Me.TipoIVA.Location = New System.Drawing.Point(127, 128)
        Me.TipoIVA.Name = "TipoIVA"
        Me.TipoIVA.Size = New System.Drawing.Size(121, 24)
        Me.TipoIVA.TabIndex = 17
        '
        'PrecioT
        '
        Me.PrecioT.Location = New System.Drawing.Point(127, 89)
        Me.PrecioT.Name = "PrecioT"
        Me.PrecioT.Size = New System.Drawing.Size(100, 22)
        Me.PrecioT.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 17)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Tipo de IVA: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 238)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 17)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Precio sin IVA: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 17)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Precio Total: "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(69, 169)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Calcular"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 17)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Desglose de IVA:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelErrors)
        Me.Controls.Add(Me.IVAPagarBox)
        Me.Controls.Add(Me.PSinIVABox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TipoIVA)
        Me.Controls.Add(Me.PrecioT)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelErrors As Label
    Friend WithEvents IVAPagarBox As TextBox
    Friend WithEvents PSinIVABox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TipoIVA As ComboBox
    Friend WithEvents PrecioT As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
End Class
