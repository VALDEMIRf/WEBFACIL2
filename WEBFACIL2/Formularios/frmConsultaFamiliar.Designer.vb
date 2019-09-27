<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaFamiliar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaFamiliar))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clienteID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnPesquisar)
        Me.GroupBox1.Controls.Add(Me.txtDescricao)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(745, 75)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pesquisa de Pessoas Vinculadas"
        '
        'btnPesquisar
        '
        Me.btnPesquisar.FlatAppearance.BorderSize = 0
        Me.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPesquisar.Image = CType(resources.GetObject("btnPesquisar.Image"), System.Drawing.Image)
        Me.btnPesquisar.Location = New System.Drawing.Point(597, 16)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(119, 43)
        Me.btnPesquisar.TabIndex = 5
        Me.btnPesquisar.Text = "Pesquisar"
        Me.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(97, 25)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(473, 26)
        Me.txtDescricao.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Descrição:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.clienteID, Me.Nome, Me.CPF, Me.Tipo})
        Me.DataGridView1.Location = New System.Drawing.Point(26, 103)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(745, 229)
        Me.DataGridView1.TabIndex = 1
        '
        'codigo
        '
        Me.codigo.DataPropertyName = "codigo"
        Me.codigo.HeaderText = "codigo"
        Me.codigo.Name = "codigo"
        '
        'clienteID
        '
        Me.clienteID.DataPropertyName = "clienteID"
        Me.clienteID.HeaderText = "clienteID"
        Me.clienteID.Name = "clienteID"
        '
        'Nome
        '
        Me.Nome.DataPropertyName = "Nome"
        Me.Nome.HeaderText = "Nome"
        Me.Nome.Name = "Nome"
        Me.Nome.Width = 300
        '
        'CPF
        '
        Me.CPF.DataPropertyName = "CPF"
        Me.CPF.HeaderText = "CPF"
        Me.CPF.Name = "CPF"
        '
        'Tipo
        '
        Me.Tipo.DataPropertyName = "Tipo"
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        '
        'btnNovo
        '
        Me.btnNovo.FlatAppearance.BorderSize = 0
        Me.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNovo.Image = CType(resources.GetObject("btnNovo.Image"), System.Drawing.Image)
        Me.btnNovo.Location = New System.Drawing.Point(372, 340)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(146, 60)
        Me.btnNovo.TabIndex = 8
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.FlatAppearance.BorderSize = 0
        Me.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlterar.Image = CType(resources.GetObject("btnAlterar.Image"), System.Drawing.Image)
        Me.btnAlterar.Location = New System.Drawing.Point(524, 345)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(117, 53)
        Me.btnAlterar.TabIndex = 7
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.FlatAppearance.BorderSize = 0
        Me.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.Location = New System.Drawing.Point(665, 345)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(87, 51)
        Me.btnSair.TabIndex = 6
        Me.btnSair.Text = "Sair"
        Me.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'frmConsultaFamiliar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(788, 411)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmConsultaFamiliar"
        Me.Text = "Consulta de Pessoas Vinculadas ao Cliente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents btnPesquisar As System.Windows.Forms.Button
    Public WithEvents txtDescricao As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clienteID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nome As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CPF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Public WithEvents btnNovo As System.Windows.Forms.Button
    Public WithEvents btnAlterar As System.Windows.Forms.Button
    Public WithEvents btnSair As System.Windows.Forms.Button
End Class
