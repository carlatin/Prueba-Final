<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class COMPRA_VENTA
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
        Me.components = New System.ComponentModel.Container()
        Dim NOMBRELabel As System.Windows.Forms.Label
        Dim APELLIDOLabel As System.Windows.Forms.Label
        Dim IDLabel As System.Windows.Forms.Label
        Dim TIPO_PAGOLabel As System.Windows.Forms.Label
        Dim NITLabel As System.Windows.Forms.Label
        Dim CANTIDAD_PRODUCTOLabel As System.Windows.Forms.Label
        Dim VALOR_A_PAGARLabel As System.Windows.Forms.Label
        Dim TOTALLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(COMPRA_VENTA))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BASE1DataSet = New appMagic.BASE1DataSet()
        Me.COMPRAVENTABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.COMPRAVENTATableAdapter = New appMagic.BASE1DataSetTableAdapters.COMPRAVENTATableAdapter()
        Me.TableAdapterManager = New appMagic.BASE1DataSetTableAdapters.TableAdapterManager()
        Me.COMPRAVENTABindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.COMPRAVENTABindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.APELLIDOTextBox = New System.Windows.Forms.TextBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.TIPO_PAGOTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.CANTIDAD_PRODUCTOTextBox = New System.Windows.Forms.TextBox()
        Me.VALOR_A_PAGARTextBox = New System.Windows.Forms.TextBox()
        Me.TOTALTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        NOMBRELabel = New System.Windows.Forms.Label()
        APELLIDOLabel = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        TIPO_PAGOLabel = New System.Windows.Forms.Label()
        NITLabel = New System.Windows.Forms.Label()
        CANTIDAD_PRODUCTOLabel = New System.Windows.Forms.Label()
        VALOR_A_PAGARLabel = New System.Windows.Forms.Label()
        TOTALLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BASE1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COMPRAVENTABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COMPRAVENTABindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.COMPRAVENTABindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'NOMBRELabel
        '
        NOMBRELabel.AutoSize = True
        NOMBRELabel.BackColor = System.Drawing.Color.Black
        NOMBRELabel.ForeColor = System.Drawing.Color.White
        NOMBRELabel.Location = New System.Drawing.Point(181, 311)
        NOMBRELabel.Name = "NOMBRELabel"
        NOMBRELabel.Size = New System.Drawing.Size(57, 13)
        NOMBRELabel.TabIndex = 8
        NOMBRELabel.Text = "NOMBRE:"
        '
        'APELLIDOLabel
        '
        APELLIDOLabel.AutoSize = True
        APELLIDOLabel.BackColor = System.Drawing.Color.Black
        APELLIDOLabel.ForeColor = System.Drawing.Color.White
        APELLIDOLabel.Location = New System.Drawing.Point(181, 336)
        APELLIDOLabel.Name = "APELLIDOLabel"
        APELLIDOLabel.Size = New System.Drawing.Size(62, 13)
        APELLIDOLabel.TabIndex = 9
        APELLIDOLabel.Text = "APELLIDO:"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.BackColor = System.Drawing.Color.Black
        IDLabel.ForeColor = System.Drawing.Color.White
        IDLabel.Location = New System.Drawing.Point(181, 366)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 10
        IDLabel.Text = "ID:"
        '
        'TIPO_PAGOLabel
        '
        TIPO_PAGOLabel.AutoSize = True
        TIPO_PAGOLabel.BackColor = System.Drawing.Color.Black
        TIPO_PAGOLabel.ForeColor = System.Drawing.Color.White
        TIPO_PAGOLabel.Location = New System.Drawing.Point(181, 396)
        TIPO_PAGOLabel.Name = "TIPO_PAGOLabel"
        TIPO_PAGOLabel.Size = New System.Drawing.Size(68, 13)
        TIPO_PAGOLabel.TabIndex = 12
        TIPO_PAGOLabel.Text = "TIPO PAGO:"
        '
        'NITLabel
        '
        NITLabel.AutoSize = True
        NITLabel.BackColor = System.Drawing.Color.Black
        NITLabel.ForeColor = System.Drawing.Color.White
        NITLabel.Location = New System.Drawing.Point(181, 421)
        NITLabel.Name = "NITLabel"
        NITLabel.Size = New System.Drawing.Size(28, 13)
        NITLabel.TabIndex = 14
        NITLabel.Text = "NIT:"
        '
        'CANTIDAD_PRODUCTOLabel
        '
        CANTIDAD_PRODUCTOLabel.AutoSize = True
        CANTIDAD_PRODUCTOLabel.BackColor = System.Drawing.Color.Black
        CANTIDAD_PRODUCTOLabel.ForeColor = System.Drawing.Color.White
        CANTIDAD_PRODUCTOLabel.Location = New System.Drawing.Point(181, 446)
        CANTIDAD_PRODUCTOLabel.Name = "CANTIDAD_PRODUCTOLabel"
        CANTIDAD_PRODUCTOLabel.Size = New System.Drawing.Size(129, 13)
        CANTIDAD_PRODUCTOLabel.TabIndex = 16
        CANTIDAD_PRODUCTOLabel.Text = "CANTIDAD PRODUCTO:"
        '
        'VALOR_A_PAGARLabel
        '
        VALOR_A_PAGARLabel.AutoSize = True
        VALOR_A_PAGARLabel.BackColor = System.Drawing.Color.Black
        VALOR_A_PAGARLabel.ForeColor = System.Drawing.Color.White
        VALOR_A_PAGARLabel.Location = New System.Drawing.Point(181, 472)
        VALOR_A_PAGARLabel.Name = "VALOR_A_PAGARLabel"
        VALOR_A_PAGARLabel.Size = New System.Drawing.Size(96, 13)
        VALOR_A_PAGARLabel.TabIndex = 18
        VALOR_A_PAGARLabel.Text = "VALOR A PAGAR:"
        '
        'TOTALLabel
        '
        TOTALLabel.AutoSize = True
        TOTALLabel.BackColor = System.Drawing.Color.Black
        TOTALLabel.ForeColor = System.Drawing.Color.White
        TOTALLabel.Location = New System.Drawing.Point(181, 500)
        TOTALLabel.Name = "TOTALLabel"
        TOTALLabel.Size = New System.Drawing.Size(45, 13)
        TOTALLabel.TabIndex = 20
        TOTALLabel.Text = "TOTAL:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calisto MT", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(23, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 54)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "APP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calisto MT", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(140, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 54)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Magic"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calisto MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(276, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Free PSD Website Template"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(329, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(196, 91)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Font = New System.Drawing.Font("Calisto MT", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(67, 212)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(434, 54)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "COMPRA VENTA"
        '
        'BASE1DataSet
        '
        Me.BASE1DataSet.DataSetName = "BASE1DataSet"
        Me.BASE1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'COMPRAVENTABindingSource
        '
        Me.COMPRAVENTABindingSource.DataMember = "COMPRAVENTA"
        Me.COMPRAVENTABindingSource.DataSource = Me.BASE1DataSet
        '
        'COMPRAVENTATableAdapter
        '
        Me.COMPRAVENTATableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.COMPRAVENTATableAdapter = Me.COMPRAVENTATableAdapter
        Me.TableAdapterManager.PRODUCTOSTableAdapter = Nothing
        Me.TableAdapterManager.REGISTROTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = appMagic.BASE1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'COMPRAVENTABindingNavigator
        '
        Me.COMPRAVENTABindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.COMPRAVENTABindingNavigator.BindingSource = Me.COMPRAVENTABindingSource
        Me.COMPRAVENTABindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.COMPRAVENTABindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.COMPRAVENTABindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.COMPRAVENTABindingNavigatorSaveItem})
        Me.COMPRAVENTABindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.COMPRAVENTABindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.COMPRAVENTABindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.COMPRAVENTABindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.COMPRAVENTABindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.COMPRAVENTABindingNavigator.Name = "COMPRAVENTABindingNavigator"
        Me.COMPRAVENTABindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.COMPRAVENTABindingNavigator.Size = New System.Drawing.Size(558, 25)
        Me.COMPRAVENTABindingNavigator.TabIndex = 8
        Me.COMPRAVENTABindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'COMPRAVENTABindingNavigatorSaveItem
        '
        Me.COMPRAVENTABindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.COMPRAVENTABindingNavigatorSaveItem.Image = CType(resources.GetObject("COMPRAVENTABindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.COMPRAVENTABindingNavigatorSaveItem.Name = "COMPRAVENTABindingNavigatorSaveItem"
        Me.COMPRAVENTABindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.COMPRAVENTABindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.COMPRAVENTABindingSource, "NOMBRE", True))
        Me.TextBox1.Location = New System.Drawing.Point(316, 304)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 9
        '
        'APELLIDOTextBox
        '
        Me.APELLIDOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.COMPRAVENTABindingSource, "APELLIDO", True))
        Me.APELLIDOTextBox.Location = New System.Drawing.Point(316, 333)
        Me.APELLIDOTextBox.Name = "APELLIDOTextBox"
        Me.APELLIDOTextBox.Size = New System.Drawing.Size(100, 20)
        Me.APELLIDOTextBox.TabIndex = 10
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.COMPRAVENTABindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(316, 363)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox.TabIndex = 11
        '
        'TIPO_PAGOTextBox
        '
        Me.TIPO_PAGOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.COMPRAVENTABindingSource, "TIPO_PAGO", True))
        Me.TIPO_PAGOTextBox.Location = New System.Drawing.Point(316, 389)
        Me.TIPO_PAGOTextBox.Name = "TIPO_PAGOTextBox"
        Me.TIPO_PAGOTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TIPO_PAGOTextBox.TabIndex = 13
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.COMPRAVENTABindingSource, "NIT", True))
        Me.TextBox5.Location = New System.Drawing.Point(316, 418)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 15
        '
        'CANTIDAD_PRODUCTOTextBox
        '
        Me.CANTIDAD_PRODUCTOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.COMPRAVENTABindingSource, "CANTIDAD_PRODUCTO", True))
        Me.CANTIDAD_PRODUCTOTextBox.Location = New System.Drawing.Point(316, 443)
        Me.CANTIDAD_PRODUCTOTextBox.Name = "CANTIDAD_PRODUCTOTextBox"
        Me.CANTIDAD_PRODUCTOTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CANTIDAD_PRODUCTOTextBox.TabIndex = 17
        '
        'VALOR_A_PAGARTextBox
        '
        Me.VALOR_A_PAGARTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.COMPRAVENTABindingSource, "VALOR_A_PAGAR", True))
        Me.VALOR_A_PAGARTextBox.Location = New System.Drawing.Point(316, 469)
        Me.VALOR_A_PAGARTextBox.Name = "VALOR_A_PAGARTextBox"
        Me.VALOR_A_PAGARTextBox.Size = New System.Drawing.Size(100, 20)
        Me.VALOR_A_PAGARTextBox.TabIndex = 19
        '
        'TOTALTextBox
        '
        Me.TOTALTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.COMPRAVENTABindingSource, "TOTAL", True))
        Me.TOTALTextBox.Location = New System.Drawing.Point(316, 497)
        Me.TOTALTextBox.Name = "TOTALTextBox"
        Me.TOTALTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TOTALTextBox.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Font = New System.Drawing.Font("Calisto MT", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(51, 205)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(463, 349)
        Me.Label5.TabIndex = 22
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Maroon
        Me.Button1.Font = New System.Drawing.Font("Calisto MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(154, 557)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 39)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "MENU"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Maroon
        Me.Button2.Font = New System.Drawing.Font("Calisto MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(301, 557)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(141, 39)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "FACTURA"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'COMPRA_VENTA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 602)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(TOTALLabel)
        Me.Controls.Add(Me.TOTALTextBox)
        Me.Controls.Add(VALOR_A_PAGARLabel)
        Me.Controls.Add(Me.VALOR_A_PAGARTextBox)
        Me.Controls.Add(CANTIDAD_PRODUCTOLabel)
        Me.Controls.Add(Me.CANTIDAD_PRODUCTOTextBox)
        Me.Controls.Add(NITLabel)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(TIPO_PAGOLabel)
        Me.Controls.Add(Me.TIPO_PAGOTextBox)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(APELLIDOLabel)
        Me.Controls.Add(Me.APELLIDOTextBox)
        Me.Controls.Add(NOMBRELabel)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.COMPRAVENTABindingNavigator)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Name = "COMPRA_VENTA"
        Me.Text = "COMPRA_VENTA"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BASE1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COMPRAVENTABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COMPRAVENTABindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.COMPRAVENTABindingNavigator.ResumeLayout(False)
        Me.COMPRAVENTABindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BASE1DataSet As BASE1DataSet
    Friend WithEvents COMPRAVENTABindingSource As BindingSource
    Friend WithEvents COMPRAVENTATableAdapter As BASE1DataSetTableAdapters.COMPRAVENTATableAdapter
    Friend WithEvents TableAdapterManager As BASE1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents COMPRAVENTABindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents COMPRAVENTABindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents APELLIDOTextBox As TextBox
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents TIPO_PAGOTextBox As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents CANTIDAD_PRODUCTOTextBox As TextBox
    Friend WithEvents VALOR_A_PAGARTextBox As TextBox
    Friend WithEvents TOTALTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
