<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PRODUCTOS
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
        Dim TIPOLabel As System.Windows.Forms.Label
        Dim MARCALabel As System.Windows.Forms.Label
        Dim FECHA_ENTRADALabel As System.Windows.Forms.Label
        Dim FECHA_SALIDALabel As System.Windows.Forms.Label
        Dim VALORLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PRODUCTOS))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TIPOTextBox = New System.Windows.Forms.TextBox()
        Me.MARCATextBox = New System.Windows.Forms.TextBox()
        Me.FECHA_ENTRADADateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FECHA_SALIDADateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.VALORTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        TIPOLabel = New System.Windows.Forms.Label()
        MARCALabel = New System.Windows.Forms.Label()
        FECHA_ENTRADALabel = New System.Windows.Forms.Label()
        FECHA_SALIDALabel = New System.Windows.Forms.Label()
        VALORLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TIPOLabel
        '
        TIPOLabel.AutoSize = True
        TIPOLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        TIPOLabel.ForeColor = System.Drawing.Color.White
        TIPOLabel.Location = New System.Drawing.Point(169, 290)
        TIPOLabel.Name = "TIPOLabel"
        TIPOLabel.Size = New System.Drawing.Size(35, 13)
        TIPOLabel.TabIndex = 7
        TIPOLabel.Text = "TIPO:"
        '
        'MARCALabel
        '
        MARCALabel.AutoSize = True
        MARCALabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        MARCALabel.ForeColor = System.Drawing.Color.White
        MARCALabel.Location = New System.Drawing.Point(169, 319)
        MARCALabel.Name = "MARCALabel"
        MARCALabel.Size = New System.Drawing.Size(48, 13)
        MARCALabel.TabIndex = 8
        MARCALabel.Text = "MARCA:"
        '
        'FECHA_ENTRADALabel
        '
        FECHA_ENTRADALabel.AutoSize = True
        FECHA_ENTRADALabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        FECHA_ENTRADALabel.ForeColor = System.Drawing.Color.White
        FECHA_ENTRADALabel.Location = New System.Drawing.Point(169, 345)
        FECHA_ENTRADALabel.Name = "FECHA_ENTRADALabel"
        FECHA_ENTRADALabel.Size = New System.Drawing.Size(100, 13)
        FECHA_ENTRADALabel.TabIndex = 10
        FECHA_ENTRADALabel.Text = "FECHA ENTRADA:"
        '
        'FECHA_SALIDALabel
        '
        FECHA_SALIDALabel.AutoSize = True
        FECHA_SALIDALabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        FECHA_SALIDALabel.ForeColor = System.Drawing.Color.White
        FECHA_SALIDALabel.Location = New System.Drawing.Point(169, 371)
        FECHA_SALIDALabel.Name = "FECHA_SALIDALabel"
        FECHA_SALIDALabel.Size = New System.Drawing.Size(86, 13)
        FECHA_SALIDALabel.TabIndex = 12
        FECHA_SALIDALabel.Text = "FECHA SALIDA:"
        '
        'VALORLabel
        '
        VALORLabel.AutoSize = True
        VALORLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        VALORLabel.ForeColor = System.Drawing.Color.White
        VALORLabel.Location = New System.Drawing.Point(171, 397)
        VALORLabel.Name = "VALORLabel"
        VALORLabel.Size = New System.Drawing.Size(46, 13)
        VALORLabel.TabIndex = 14
        VALORLabel.Text = "VALOR:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calisto MT", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(31, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 54)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "APP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calisto MT", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(141, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 54)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Magic"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calisto MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(276, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Free PSD Website Template"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(328, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(196, 107)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Font = New System.Drawing.Font("Calisto MT", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(107, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(343, 54)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "PRODUCTOS"
        '
        'TIPOTextBox
        '
        Me.TIPOTextBox.Location = New System.Drawing.Point(269, 283)
        Me.TIPOTextBox.Name = "TIPOTextBox"
        Me.TIPOTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TIPOTextBox.TabIndex = 8
        '
        'MARCATextBox
        '
        Me.MARCATextBox.Location = New System.Drawing.Point(269, 312)
        Me.MARCATextBox.Name = "MARCATextBox"
        Me.MARCATextBox.Size = New System.Drawing.Size(100, 20)
        Me.MARCATextBox.TabIndex = 9
        '
        'FECHA_ENTRADADateTimePicker
        '
        Me.FECHA_ENTRADADateTimePicker.Location = New System.Drawing.Point(269, 338)
        Me.FECHA_ENTRADADateTimePicker.Name = "FECHA_ENTRADADateTimePicker"
        Me.FECHA_ENTRADADateTimePicker.Size = New System.Drawing.Size(100, 20)
        Me.FECHA_ENTRADADateTimePicker.TabIndex = 11
        '
        'FECHA_SALIDADateTimePicker
        '
        Me.FECHA_SALIDADateTimePicker.Location = New System.Drawing.Point(269, 365)
        Me.FECHA_SALIDADateTimePicker.Name = "FECHA_SALIDADateTimePicker"
        Me.FECHA_SALIDADateTimePicker.Size = New System.Drawing.Size(100, 20)
        Me.FECHA_SALIDADateTimePicker.TabIndex = 13
        '
        'VALORTextBox
        '
        Me.VALORTextBox.Location = New System.Drawing.Point(269, 394)
        Me.VALORTextBox.Name = "VALORTextBox"
        Me.VALORTextBox.Size = New System.Drawing.Size(100, 20)
        Me.VALORTextBox.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Font = New System.Drawing.Font("Calisto MT", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(93, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(384, 308)
        Me.Label5.TabIndex = 21
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Maroon
        Me.Button1.Font = New System.Drawing.Font("Calisto MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(216, 502)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 39)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "MENU"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PRODUCTOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 568)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(VALORLabel)
        Me.Controls.Add(Me.VALORTextBox)
        Me.Controls.Add(FECHA_SALIDALabel)
        Me.Controls.Add(Me.FECHA_SALIDADateTimePicker)
        Me.Controls.Add(FECHA_ENTRADALabel)
        Me.Controls.Add(Me.FECHA_ENTRADADateTimePicker)
        Me.Controls.Add(MARCALabel)
        Me.Controls.Add(Me.MARCATextBox)
        Me.Controls.Add(TIPOLabel)
        Me.Controls.Add(Me.TIPOTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Name = "PRODUCTOS"
        Me.Text = "PRODUCTOS"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TIPOTextBox As TextBox
    Friend WithEvents MARCATextBox As TextBox
    Friend WithEvents FECHA_ENTRADADateTimePicker As DateTimePicker
    Friend WithEvents FECHA_SALIDADateTimePicker As DateTimePicker
    Friend WithEvents VALORTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
End Class
