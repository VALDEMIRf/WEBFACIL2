<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClienteConsulta
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCPFvirgual = New System.Windows.Forms.MaskedTextBox()
        Me.txtCPFNumeros = New System.Windows.Forms.MaskedTextBox()
        Me.btPesquisaCliente = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btPesquisaCliente)
        Me.GroupBox1.Controls.Add(Me.txtCPFNumeros)
        Me.GroupBox1.Controls.Add(Me.txtCPFvirgual)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 4)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(690, 89)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtro de Pesquisa"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CPF:"
        '
        'txtCPFvirgual
        '
        Me.txtCPFvirgual.Location = New System.Drawing.Point(58, 58)
        Me.txtCPFvirgual.Mask = "000.000.000-00"
        Me.txtCPFvirgual.Name = "txtCPFvirgual"
        Me.txtCPFvirgual.Size = New System.Drawing.Size(127, 26)
        Me.txtCPFvirgual.TabIndex = 2
        '
        'txtCPFNumeros
        '
        Me.txtCPFNumeros.Location = New System.Drawing.Point(58, 26)
        Me.txtCPFNumeros.Mask = "00000000000"
        Me.txtCPFNumeros.Name = "txtCPFNumeros"
        Me.txtCPFNumeros.Size = New System.Drawing.Size(127, 26)
        Me.txtCPFNumeros.TabIndex = 3
        '
        'btPesquisaCliente
        '
        Me.btPesquisaCliente.Location = New System.Drawing.Point(218, 33)
        Me.btPesquisaCliente.Name = "btPesquisaCliente"
        Me.btPesquisaCliente.Size = New System.Drawing.Size(97, 23)
        Me.btPesquisaCliente.TabIndex = 4
        Me.btPesquisaCliente.Text = "Pesquisar"
        Me.btPesquisaCliente.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.CPF, Me.Nome})
        Me.dgv.GridColor = System.Drawing.Color.DarkGray
        Me.dgv.Location = New System.Drawing.Point(12, 100)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(696, 194)
        Me.dgv.TabIndex = 1
        '
        'codigo
        '
        Me.codigo.DataPropertyName = "codigo"
        Me.codigo.HeaderText = "codigo"
        Me.codigo.Name = "codigo"
        '
        'CPF
        '
        Me.CPF.DataPropertyName = "CPF"
        Me.CPF.HeaderText = "CPF"
        Me.CPF.Name = "CPF"
        Me.CPF.Width = 150
        '
        'Nome
        '
        Me.Nome.DataPropertyName = "Nome"
        Me.Nome.HeaderText = "Nome"
        Me.Nome.Name = "Nome"
        Me.Nome.Width = 400
        '
        'frmClienteConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 451)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmClienteConsulta"
        Me.Text = "Consulta de Cliente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btPesquisaCliente As System.Windows.Forms.Button
    Friend WithEvents txtCPFNumeros As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtCPFvirgual As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CPF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nome As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
