<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registro
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim NOMBRESLabel As System.Windows.Forms.Label
        Dim APELLIDOLabel As System.Windows.Forms.Label
        Dim IDLabel As System.Windows.Forms.Label
        Dim EDADLabel As System.Windows.Forms.Label
        Dim NACIONALIDADLabel As System.Windows.Forms.Label
        Dim ESTADO_CIVILLabel As System.Windows.Forms.Label
        Dim DOMICILIOLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(registro))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NOMBRESTextBox = New System.Windows.Forms.TextBox()
        Me.APELLIDOTextBox = New System.Windows.Forms.TextBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.EDADTextBox = New System.Windows.Forms.TextBox()
        Me.NACIONALIDADTextBox = New System.Windows.Forms.TextBox()
        Me.ESTADO_CIVILTextBox = New System.Windows.Forms.TextBox()
        Me.DOMICILIOTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        NOMBRESLabel = New System.Windows.Forms.Label()
        APELLIDOLabel = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        EDADLabel = New System.Windows.Forms.Label()
        NACIONALIDADLabel = New System.Windows.Forms.Label()
        ESTADO_CIVILLabel = New System.Windows.Forms.Label()
        DOMICILIOLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NOMBRESLabel
        '
        NOMBRESLabel.AutoSize = True
        NOMBRESLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        NOMBRESLabel.ForeColor = System.Drawing.Color.White
        NOMBRESLabel.Location = New System.Drawing.Point(144, 261)
        NOMBRESLabel.Name = "NOMBRESLabel"
        NOMBRESLabel.Size = New System.Drawing.Size(64, 13)
        NOMBRESLabel.TabIndex = 6
        NOMBRESLabel.Text = "NOMBRES:"
        '
        'APELLIDOLabel
        '
        APELLIDOLabel.AutoSize = True
        APELLIDOLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        APELLIDOLabel.ForeColor = System.Drawing.Color.White
        APELLIDOLabel.Location = New System.Drawing.Point(146, 287)
        APELLIDOLabel.Name = "APELLIDOLabel"
        APELLIDOLabel.Size = New System.Drawing.Size(62, 13)
        APELLIDOLabel.TabIndex = 8
        APELLIDOLabel.Text = "APELLIDO:"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        IDLabel.ForeColor = System.Drawing.Color.White
        IDLabel.Location = New System.Drawing.Point(146, 310)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 10
        IDLabel.Text = "ID:"
        '
        'EDADLabel
        '
        EDADLabel.AutoSize = True
        EDADLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        EDADLabel.ForeColor = System.Drawing.Color.White
        EDADLabel.Location = New System.Drawing.Point(146, 335)
        EDADLabel.Name = "EDADLabel"
        EDADLabel.Size = New System.Drawing.Size(40, 13)
        EDADLabel.TabIndex = 12
        EDADLabel.Text = "EDAD:"
        '
        'NACIONALIDADLabel
        '
        NACIONALIDADLabel.AutoSize = True
        NACIONALIDADLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        NACIONALIDADLabel.ForeColor = System.Drawing.Color.White
        NACIONALIDADLabel.Location = New System.Drawing.Point(146, 361)
        NACIONALIDADLabel.Name = "NACIONALIDADLabel"
        NACIONALIDADLabel.Size = New System.Drawing.Size(90, 13)
        NACIONALIDADLabel.TabIndex = 14
        NACIONALIDADLabel.Text = "NACIONALIDAD:"
        '
        'ESTADO_CIVILLabel
        '
        ESTADO_CIVILLabel.AutoSize = True
        ESTADO_CIVILLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        ESTADO_CIVILLabel.ForeColor = System.Drawing.Color.White
        ESTADO_CIVILLabel.Location = New System.Drawing.Point(146, 383)
        ESTADO_CIVILLabel.Name = "ESTADO_CIVILLabel"
        ESTADO_CIVILLabel.Size = New System.Drawing.Size(83, 13)
        ESTADO_CIVILLabel.TabIndex = 16
        ESTADO_CIVILLabel.Text = "ESTADO CIVIL:"
        '
        'DOMICILIOLabel
        '
        DOMICILIOLabel.AutoSize = True
        DOMICILIOLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        DOMICILIOLabel.ForeColor = System.Drawing.Color.White
        DOMICILIOLabel.Location = New System.Drawing.Point(146, 411)
        DOMICILIOLabel.Name = "DOMICILIOLabel"
        DOMICILIOLabel.Size = New System.Drawing.Size(65, 13)
        DOMICILIOLabel.TabIndex = 18
        DOMICILIOLabel.Text = "DOMICILIO:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calisto MT", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(29, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 54)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "APP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calisto MT", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(144, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 54)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Magic"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calisto MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(276, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Free PSD Website Template"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(305, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(196, 107)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Font = New System.Drawing.Font("Calisto MT", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(83, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(356, 54)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "REGISTRATE "
        '
        'NOMBRESTextBox
        '
        Me.NOMBRESTextBox.Location = New System.Drawing.Point(221, 254)
        Me.NOMBRESTextBox.Name = "NOMBRESTextBox"
        Me.NOMBRESTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NOMBRESTextBox.TabIndex = 7
        '
        'APELLIDOTextBox
        '
        Me.APELLIDOTextBox.Location = New System.Drawing.Point(221, 280)
        Me.APELLIDOTextBox.Name = "APELLIDOTextBox"
        Me.APELLIDOTextBox.Size = New System.Drawing.Size(100, 20)
        Me.APELLIDOTextBox.TabIndex = 9
        '
        'IDTextBox
        '
        Me.IDTextBox.Location = New System.Drawing.Point(221, 303)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox.TabIndex = 11
        '
        'EDADTextBox
        '
        Me.EDADTextBox.Location = New System.Drawing.Point(221, 328)
        Me.EDADTextBox.Name = "EDADTextBox"
        Me.EDADTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EDADTextBox.TabIndex = 13
        '
        'NACIONALIDADTextBox
        '
        Me.NACIONALIDADTextBox.Location = New System.Drawing.Point(240, 358)
        Me.NACIONALIDADTextBox.Name = "NACIONALIDADTextBox"
        Me.NACIONALIDADTextBox.Size = New System.Drawing.Size(81, 20)
        Me.NACIONALIDADTextBox.TabIndex = 15
        '
        'ESTADO_CIVILTextBox
        '
        Me.ESTADO_CIVILTextBox.Location = New System.Drawing.Point(233, 383)
        Me.ESTADO_CIVILTextBox.Name = "ESTADO_CIVILTextBox"
        Me.ESTADO_CIVILTextBox.Size = New System.Drawing.Size(88, 20)
        Me.ESTADO_CIVILTextBox.TabIndex = 17
        '
        'DOMICILIOTextBox
        '
        Me.DOMICILIOTextBox.Location = New System.Drawing.Point(215, 408)
        Me.DOMICILIOTextBox.Name = "DOMICILIOTextBox"
        Me.DOMICILIOTextBox.Size = New System.Drawing.Size(106, 20)
        Me.DOMICILIOTextBox.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Font = New System.Drawing.Font("Calisto MT", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(64, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(384, 308)
        Me.Label5.TabIndex = 20
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Maroon
        Me.Button1.Font = New System.Drawing.Font("Calisto MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(200, 484)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 39)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "MENU"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 535)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(DOMICILIOLabel)
        Me.Controls.Add(Me.DOMICILIOTextBox)
        Me.Controls.Add(ESTADO_CIVILLabel)
        Me.Controls.Add(Me.ESTADO_CIVILTextBox)
        Me.Controls.Add(NACIONALIDADLabel)
        Me.Controls.Add(Me.NACIONALIDADTextBox)
        Me.Controls.Add(EDADLabel)
        Me.Controls.Add(Me.EDADTextBox)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(APELLIDOLabel)
        Me.Controls.Add(Me.APELLIDOTextBox)
        Me.Controls.Add(NOMBRESLabel)
        Me.Controls.Add(Me.NOMBRESTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Name = "registro"
        Me.Text = "REGISTRO"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents NOMBRESTextBox As TextBox
    Friend WithEvents APELLIDOTextBox As TextBox
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents EDADTextBox As TextBox
    Friend WithEvents NACIONALIDADTextBox As TextBox
    Friend WithEvents ESTADO_CIVILTextBox As TextBox
    Friend WithEvents DOMICILIOTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
End Class
