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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClienteConsulta))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btFechar = New System.Windows.Forms.Button()
        Me.btEnviarDados = New System.Windows.Forms.Button()
        Me.btPesquisaCliente = New System.Windows.Forms.Button()
        Me.txtCPFNumeros = New System.Windows.Forms.MaskedTextBox()
        Me.txtCPFPesquisa = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvGrid = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btFechar)
        Me.GroupBox1.Controls.Add(Me.btEnviarDados)
        Me.GroupBox1.Controls.Add(Me.btPesquisaCliente)
        Me.GroupBox1.Controls.Add(Me.txtCPFNumeros)
        Me.GroupBox1.Controls.Add(Me.txtCPFPesquisa)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 4)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(690, 89)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtro de Pesquisa"
        '
        'btFechar
        '
        Me.btFechar.FlatAppearance.BorderSize = 0
        Me.btFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btFechar.Image = CType(resources.GetObject("btFechar.Image"), System.Drawing.Image)
        Me.btFechar.Location = New System.Drawing.Point(582, 16)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(101, 55)
        Me.btFechar.TabIndex = 6
        Me.btFechar.Text = "Fechar"
        Me.btFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btFechar.UseVisualStyleBackColor = True
        '
        'btEnviarDados
        '
        Me.btEnviarDados.FlatAppearance.BorderSize = 0
        Me.btEnviarDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btEnviarDados.Image = CType(resources.GetObject("btEnviarDados.Image"), System.Drawing.Image)
        Me.btEnviarDados.Location = New System.Drawing.Point(468, 20)
        Me.btEnviarDados.Name = "btEnviarDados"
        Me.btEnviarDados.Size = New System.Drawing.Size(108, 47)
        Me.btEnviarDados.TabIndex = 5
        Me.btEnviarDados.Text = "Enviar Dados"
        Me.btEnviarDados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btEnviarDados.UseVisualStyleBackColor = True
        '
        'btPesquisaCliente
        '
        Me.btPesquisaCliente.Location = New System.Drawing.Point(265, 33)
        Me.btPesquisaCliente.Name = "btPesquisaCliente"
        Me.btPesquisaCliente.Size = New System.Drawing.Size(128, 38)
        Me.btPesquisaCliente.TabIndex = 4
        Me.btPesquisaCliente.Text = "Pesquisar"
        Me.btPesquisaCliente.UseVisualStyleBackColor = True
        '
        'txtCPFNumeros
        '
        Me.txtCPFNumeros.Location = New System.Drawing.Point(99, 24)
        Me.txtCPFNumeros.Mask = "00000000000"
        Me.txtCPFNumeros.Name = "txtCPFNumeros"
        Me.txtCPFNumeros.Size = New System.Drawing.Size(127, 26)
        Me.txtCPFNumeros.TabIndex = 3
        '
        'txtCPFPesquisa
        '
        Me.txtCPFPesquisa.Location = New System.Drawing.Point(99, 56)
        Me.txtCPFPesquisa.Mask = "000.000.000-00"
        Me.txtCPFPesquisa.Name = "txtCPFPesquisa"
        Me.txtCPFPesquisa.Size = New System.Drawing.Size(127, 26)
        Me.txtCPFPesquisa.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CPF:"
        '
        'dgvGrid
        '
        Me.dgvGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.CPF, Me.RG, Me.Nome})
        Me.dgvGrid.GridColor = System.Drawing.Color.DarkGray
        Me.dgvGrid.Location = New System.Drawing.Point(12, 100)
        Me.dgvGrid.Name = "dgvGrid"
        Me.dgvGrid.Size = New System.Drawing.Size(696, 326)
        Me.dgvGrid.TabIndex = 1
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
        'RG
        '
        Me.RG.DataPropertyName = "RG"
        Me.RG.HeaderText = "RG"
        Me.RG.Name = "RG"
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
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(721, 438)
        Me.Controls.Add(Me.dgvGrid)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmClienteConsulta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Cliente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btPesquisaCliente As System.Windows.Forms.Button
    Friend WithEvents txtCPFNumeros As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtCPFPesquisa As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvGrid As System.Windows.Forms.DataGridView
    Friend WithEvents btFechar As System.Windows.Forms.Button
    Friend WithEvents btEnviarDados As System.Windows.Forms.Button
    Friend WithEvents codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CPF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nome As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
