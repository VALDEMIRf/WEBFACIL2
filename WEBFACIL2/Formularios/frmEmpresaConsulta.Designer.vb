<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpresaConsulta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmpresaConsulta))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btFecharEmpresa = New System.Windows.Forms.Button()
        Me.btEnviarDadosEmpresa = New System.Windows.Forms.Button()
        Me.btPesquisaEmpresa = New System.Windows.Forms.Button()
        Me.txtCPFConsulta = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvGridEmpresa = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Situacao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvGridEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btFecharEmpresa)
        Me.GroupBox1.Controls.Add(Me.btEnviarDadosEmpresa)
        Me.GroupBox1.Controls.Add(Me.btPesquisaEmpresa)
        Me.GroupBox1.Controls.Add(Me.txtCPFConsulta)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(690, 89)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtro de Pesquisa"
        '
        'btFecharEmpresa
        '
        Me.btFecharEmpresa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btFecharEmpresa.FlatAppearance.BorderSize = 0
        Me.btFecharEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btFecharEmpresa.Image = CType(resources.GetObject("btFecharEmpresa.Image"), System.Drawing.Image)
        Me.btFecharEmpresa.Location = New System.Drawing.Point(582, 25)
        Me.btFecharEmpresa.Name = "btFecharEmpresa"
        Me.btFecharEmpresa.Size = New System.Drawing.Size(101, 55)
        Me.btFecharEmpresa.TabIndex = 6
        Me.btFecharEmpresa.Text = "Fechar"
        Me.btFecharEmpresa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btFecharEmpresa.UseVisualStyleBackColor = True
        '
        'btEnviarDadosEmpresa
        '
        Me.btEnviarDadosEmpresa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btEnviarDadosEmpresa.FlatAppearance.BorderSize = 0
        Me.btEnviarDadosEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btEnviarDadosEmpresa.Image = CType(resources.GetObject("btEnviarDadosEmpresa.Image"), System.Drawing.Image)
        Me.btEnviarDadosEmpresa.Location = New System.Drawing.Point(343, 29)
        Me.btEnviarDadosEmpresa.Name = "btEnviarDadosEmpresa"
        Me.btEnviarDadosEmpresa.Size = New System.Drawing.Size(148, 47)
        Me.btEnviarDadosEmpresa.TabIndex = 5
        Me.btEnviarDadosEmpresa.Text = "Enviar Dados"
        Me.btEnviarDadosEmpresa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btEnviarDadosEmpresa.UseVisualStyleBackColor = True
        '
        'btPesquisaEmpresa
        '
        Me.btPesquisaEmpresa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btPesquisaEmpresa.FlatAppearance.BorderSize = 0
        Me.btPesquisaEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btPesquisaEmpresa.Image = CType(resources.GetObject("btPesquisaEmpresa.Image"), System.Drawing.Image)
        Me.btPesquisaEmpresa.Location = New System.Drawing.Point(209, 33)
        Me.btPesquisaEmpresa.Name = "btPesquisaEmpresa"
        Me.btPesquisaEmpresa.Size = New System.Drawing.Size(128, 38)
        Me.btPesquisaEmpresa.TabIndex = 4
        Me.btPesquisaEmpresa.Text = "Pesquisar"
        Me.btPesquisaEmpresa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btPesquisaEmpresa.UseVisualStyleBackColor = True
        '
        'txtCPFConsulta
        '
        Me.txtCPFConsulta.Location = New System.Drawing.Point(62, 40)
        Me.txtCPFConsulta.Mask = "000.000.000-00"
        Me.txtCPFConsulta.Name = "txtCPFConsulta"
        Me.txtCPFConsulta.Size = New System.Drawing.Size(127, 26)
        Me.txtCPFConsulta.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CPF:"
        '
        'dgvGridEmpresa
        '
        Me.dgvGridEmpresa.BackgroundColor = System.Drawing.Color.White
        Me.dgvGridEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGridEmpresa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.CPF, Me.Situacao, Me.RG, Me.Nome})
        Me.dgvGridEmpresa.GridColor = System.Drawing.Color.DarkGray
        Me.dgvGridEmpresa.Location = New System.Drawing.Point(10, 109)
        Me.dgvGridEmpresa.Name = "dgvGridEmpresa"
        Me.dgvGridEmpresa.Size = New System.Drawing.Size(862, 280)
        Me.dgvGridEmpresa.TabIndex = 2
        '
        'codigo
        '
        Me.codigo.DataPropertyName = "codigo"
        Me.codigo.HeaderText = "codigo"
        Me.codigo.Name = "codigo"
        Me.codigo.Width = 60
        '
        'CPF
        '
        Me.CPF.DataPropertyName = "CPF"
        Me.CPF.HeaderText = "CPF"
        Me.CPF.Name = "CPF"
        Me.CPF.Width = 150
        '
        'Situacao
        '
        Me.Situacao.DataPropertyName = "Situacao"
        Me.Situacao.HeaderText = "Situacao"
        Me.Situacao.Name = "Situacao"
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
        'frmEmpresaConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(884, 401)
        Me.Controls.Add(Me.dgvGridEmpresa)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmEmpresaConsulta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Clientes com Empresa "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvGridEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btFecharEmpresa As System.Windows.Forms.Button
    Friend WithEvents btEnviarDadosEmpresa As System.Windows.Forms.Button
    Friend WithEvents btPesquisaEmpresa As System.Windows.Forms.Button
    Friend WithEvents txtCPFConsulta As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvGridEmpresa As System.Windows.Forms.DataGridView
    Friend WithEvents codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CPF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Situacao As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nome As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
