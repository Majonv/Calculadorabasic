<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Interfaz
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Interfaz))
        btSUMAR = New Button()
        TextBox1 = New TextBox()
        Label1 = New Label()
        btDIVIDIR = New Button()
        btMULTIPLICAR = New Button()
        btRESTAR = New Button()
        TextBox2 = New TextBox()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' btSUMAR
        ' 
        btSUMAR.ForeColor = SystemColors.ActiveCaptionText
        btSUMAR.ImageKey = "(ninguna)"
        btSUMAR.Location = New Point(52, 123)
        btSUMAR.Margin = New Padding(4, 3, 4, 3)
        btSUMAR.Name = "btSUMAR"
        btSUMAR.Size = New Size(92, 25)
        btSUMAR.TabIndex = 0
        btSUMAR.Text = "SUMAR"
        btSUMAR.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Cursor = Cursors.PanNorth
        TextBox1.Location = New Point(52, 65)
        TextBox1.Margin = New Padding(4, 3, 4, 3)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(92, 26)
        TextBox1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(158, 269)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 21)
        Label1.TabIndex = 2
        ' 
        ' btDIVIDIR
        ' 
        btDIVIDIR.Location = New Point(183, 198)
        btDIVIDIR.Margin = New Padding(4, 3, 4, 3)
        btDIVIDIR.Name = "btDIVIDIR"
        btDIVIDIR.Size = New Size(92, 25)
        btDIVIDIR.TabIndex = 4
        btDIVIDIR.Text = "DIVIDIR"
        btDIVIDIR.UseVisualStyleBackColor = True
        ' 
        ' btMULTIPLICAR
        ' 
        btMULTIPLICAR.Location = New Point(52, 198)
        btMULTIPLICAR.Margin = New Padding(4, 3, 4, 3)
        btMULTIPLICAR.Name = "btMULTIPLICAR"
        btMULTIPLICAR.Size = New Size(94, 25)
        btMULTIPLICAR.TabIndex = 5
        btMULTIPLICAR.Text = "MULTIPLICAR"
        btMULTIPLICAR.UseVisualStyleBackColor = True
        ' 
        ' btRESTAR
        ' 
        btRESTAR.Location = New Point(183, 123)
        btRESTAR.Margin = New Padding(4, 3, 4, 3)
        btRESTAR.Name = "btRESTAR"
        btRESTAR.Size = New Size(92, 25)
        btRESTAR.TabIndex = 6
        btRESTAR.Text = "RESTAR"
        btRESTAR.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(183, 65)
        TextBox2.Margin = New Padding(4, 3, 4, 3)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(92, 26)
        TextBox2.TabIndex = 7
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Lucida Sans Unicode", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(85, 274)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 16)
        Label2.TabIndex = 8
        Label2.Text = "Resultado:"
        ' 
        ' Interfaz
        ' 
        AutoScaleDimensions = New SizeF(7F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.InactiveCaption
        ClientSize = New Size(335, 321)
        Controls.Add(Label2)
        Controls.Add(TextBox2)
        Controls.Add(btRESTAR)
        Controls.Add(btMULTIPLICAR)
        Controls.Add(btDIVIDIR)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Controls.Add(btSUMAR)
        Cursor = Cursors.Cross
        Font = New Font("Lucida Sans Unicode", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4, 3, 4, 3)
        Name = "Interfaz"
        Text = "CALCULADORA"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btSUMAR As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btDIVIDIR As Button
    Friend WithEvents btMULTIPLICAR As Button
    Friend WithEvents btRESTAR As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
End Class
