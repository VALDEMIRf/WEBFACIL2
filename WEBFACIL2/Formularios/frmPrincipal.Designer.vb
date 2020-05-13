<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbAtivo = New System.Windows.Forms.RadioButton()
        Me.btCarregaGrid = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPesquisa = New System.Windows.Forms.ComboBox()
        Me.dgvTarefas = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbMes = New System.Windows.Forms.ComboBox()
        Me.dgvAniversariantes = New System.Windows.Forms.DataGridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SobreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormuláriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatórioGeralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TarefasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroDeTarefasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaDeTarefasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AssessoriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvTarefas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvAniversariantes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1012, 65)
        Me.Panel3.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(178, 63)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(371, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(289, 29)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Manutenção de Clientes"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.GroupBox2)
        Me.Panel5.Controls.Add(Me.GroupBox1)
        Me.Panel5.Controls.Add(Me.Panel4)
        Me.Panel5.Controls.Add(Me.MenuStrip1)
        Me.Panel5.Controls.Add(Me.MenuStrip2)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 65)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1012, 501)
        Me.Panel5.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbAtivo)
        Me.GroupBox2.Controls.Add(Me.btCarregaGrid)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtPesquisa)
        Me.GroupBox2.Controls.Add(Me.dgvTarefas)
        Me.GroupBox2.Location = New System.Drawing.Point(515, 107)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(485, 311)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tarefas"
        '
        'rbAtivo
        '
        Me.rbAtivo.AutoSize = True
        Me.rbAtivo.Location = New System.Drawing.Point(143, 27)
        Me.rbAtivo.Name = "rbAtivo"
        Me.rbAtivo.Size = New System.Drawing.Size(57, 21)
        Me.rbAtivo.TabIndex = 6
        Me.rbAtivo.TabStop = True
        Me.rbAtivo.Text = "Ativo"
        Me.rbAtivo.UseVisualStyleBackColor = True
        '
        'btCarregaGrid
        '
        Me.btCarregaGrid.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btCarregaGrid.FlatAppearance.BorderSize = 0
        Me.btCarregaGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCarregaGrid.Image = CType(resources.GetObject("btCarregaGrid.Image"), System.Drawing.Image)
        Me.btCarregaGrid.Location = New System.Drawing.Point(446, 19)
        Me.btCarregaGrid.Name = "btCarregaGrid"
        Me.btCarregaGrid.Size = New System.Drawing.Size(29, 29)
        Me.btCarregaGrid.TabIndex = 11
        Me.btCarregaGrid.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Lista de Tarefas:"
        '
        'txtPesquisa
        '
        Me.txtPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtPesquisa.DropDownWidth = 191
        Me.txtPesquisa.FormattingEnabled = True
        Me.txtPesquisa.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtPesquisa.Items.AddRange(New Object() {"<Selecione a Atividade>", "Ativo"})
        Me.txtPesquisa.Location = New System.Drawing.Point(6, 23)
        Me.txtPesquisa.Name = "txtPesquisa"
        Me.txtPesquisa.Size = New System.Drawing.Size(10, 25)
        Me.txtPesquisa.TabIndex = 4
        Me.txtPesquisa.Visible = False
        '
        'dgvTarefas
        '
        Me.dgvTarefas.BackgroundColor = System.Drawing.Color.White
        Me.dgvTarefas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvTarefas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTarefas.Location = New System.Drawing.Point(6, 54)
        Me.dgvTarefas.Name = "dgvTarefas"
        Me.dgvTarefas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTarefas.Size = New System.Drawing.Size(473, 251)
        Me.dgvTarefas.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmbMes)
        Me.GroupBox1.Controls.Add(Me.dgvAniversariantes)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 107)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(490, 311)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Aniversariantes"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Mês:"
        '
        'cmbMes
        '
        Me.cmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMes.DropDownWidth = 191
        Me.cmbMes.FormattingEnabled = True
        Me.cmbMes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmbMes.Items.AddRange(New Object() {"<Selecione o Mês>", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.cmbMes.Location = New System.Drawing.Point(55, 23)
        Me.cmbMes.Name = "cmbMes"
        Me.cmbMes.Size = New System.Drawing.Size(153, 25)
        Me.cmbMes.TabIndex = 1
        '
        'dgvAniversariantes
        '
        Me.dgvAniversariantes.BackgroundColor = System.Drawing.Color.White
        Me.dgvAniversariantes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvAniversariantes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvAniversariantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAniversariantes.Location = New System.Drawing.Point(6, 54)
        Me.dgvAniversariantes.Name = "dgvAniversariantes"
        Me.dgvAniversariantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAniversariantes.Size = New System.Drawing.Size(477, 253)
        Me.dgvAniversariantes.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 457)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1012, 44)
        Me.Panel4.TabIndex = 7
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.CadetBlue
        Me.MenuStrip1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SobreToolStripMenuItem, Me.ClientsToolStripMenuItem, Me.FormuláriosToolStripMenuItem, Me.TarefasToolStripMenuItem, Me.AssessoriaToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 24)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1012, 61)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SobreToolStripMenuItem
        '
        Me.SobreToolStripMenuItem.BackColor = System.Drawing.Color.CadetBlue
        Me.SobreToolStripMenuItem.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.SobreToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SobreToolStripMenuItem.Image = CType(resources.GetObject("SobreToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SobreToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SobreToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.SobreToolStripMenuItem.Name = "SobreToolStripMenuItem"
        Me.SobreToolStripMenuItem.Size = New System.Drawing.Size(94, 52)
        Me.SobreToolStripMenuItem.Text = "Sobre"
        '
        'ClientsToolStripMenuItem
        '
        Me.ClientsToolStripMenuItem.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientsToolStripMenuItem.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ClientsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ClientsToolStripMenuItem.Image = CType(resources.GetObject("ClientsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ClientsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ClientsToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.ClientsToolStripMenuItem.Name = "ClientsToolStripMenuItem"
        Me.ClientsToolStripMenuItem.Size = New System.Drawing.Size(110, 47)
        Me.ClientsToolStripMenuItem.Text = "Clientes"
        '
        'FormuláriosToolStripMenuItem
        '
        Me.FormuláriosToolStripMenuItem.BackColor = System.Drawing.Color.CadetBlue
        Me.FormuláriosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RelatórioGeralToolStripMenuItem})
        Me.FormuláriosToolStripMenuItem.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.FormuláriosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.FormuláriosToolStripMenuItem.Image = CType(resources.GetObject("FormuláriosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FormuláriosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FormuláriosToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.FormuláriosToolStripMenuItem.Name = "FormuláriosToolStripMenuItem"
        Me.FormuláriosToolStripMenuItem.Size = New System.Drawing.Size(140, 52)
        Me.FormuláriosToolStripMenuItem.Text = "Relatórios"
        '
        'RelatórioGeralToolStripMenuItem
        '
        Me.RelatórioGeralToolStripMenuItem.BackColor = System.Drawing.Color.CadetBlue
        Me.RelatórioGeralToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.RelatórioGeralToolStripMenuItem.Name = "RelatórioGeralToolStripMenuItem"
        Me.RelatórioGeralToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.RelatórioGeralToolStripMenuItem.Text = "Relatório Geral"
        '
        'TarefasToolStripMenuItem
        '
        Me.TarefasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroDeTarefasToolStripMenuItem, Me.ConsultaDeTarefasToolStripMenuItem})
        Me.TarefasToolStripMenuItem.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TarefasToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.TarefasToolStripMenuItem.Image = CType(resources.GetObject("TarefasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TarefasToolStripMenuItem.Name = "TarefasToolStripMenuItem"
        Me.TarefasToolStripMenuItem.Size = New System.Drawing.Size(82, 57)
        Me.TarefasToolStripMenuItem.Text = "Tarefas"
        '
        'CadastroDeTarefasToolStripMenuItem
        '
        Me.CadastroDeTarefasToolStripMenuItem.Name = "CadastroDeTarefasToolStripMenuItem"
        Me.CadastroDeTarefasToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.CadastroDeTarefasToolStripMenuItem.Text = "Cadastro de Tarefas"
        '
        'ConsultaDeTarefasToolStripMenuItem
        '
        Me.ConsultaDeTarefasToolStripMenuItem.Name = "ConsultaDeTarefasToolStripMenuItem"
        Me.ConsultaDeTarefasToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.ConsultaDeTarefasToolStripMenuItem.Text = "Consulta de Tarefas"
        '
        'AssessoriaToolStripMenuItem
        '
        Me.AssessoriaToolStripMenuItem.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AssessoriaToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AssessoriaToolStripMenuItem.Image = CType(resources.GetObject("AssessoriaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AssessoriaToolStripMenuItem.Name = "AssessoriaToolStripMenuItem"
        Me.AssessoriaToolStripMenuItem.Size = New System.Drawing.Size(115, 57)
        Me.AssessoriaToolStripMenuItem.Text = "Assessoria"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.BackColor = System.Drawing.Color.CadetBlue
        Me.SairToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SairToolStripMenuItem.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SairToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SairToolStripMenuItem.Image = CType(resources.GetObject("SairToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SairToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(80, 57)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(1012, 24)
        Me.MenuStrip2.TabIndex = 9
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1012, 566)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip2
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvTarefas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvAniversariantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelCabecalho As System.Windows.Forms.Panel
    Friend WithEvents btnFechar As System.Windows.Forms.Button
    Friend WithEvents btnMaximizar As System.Windows.Forms.Button
    Friend WithEvents btnRestaurar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnFormularios As System.Windows.Forms.Button
    Friend WithEvents btnSobre As System.Windows.Forms.Button
    Friend WithEvents btnClientes As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ClientsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormuláriosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SobreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RelatórioGeralToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbMes As System.Windows.Forms.ComboBox
    Friend WithEvents dgvAniversariantes As System.Windows.Forms.DataGridView
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvTarefas As System.Windows.Forms.DataGridView
    Friend WithEvents TarefasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CadastroDeTarefasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaDeTarefasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AssessoriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btCarregaGrid As System.Windows.Forms.Button
    Friend WithEvents rbAtivo As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPesquisa As System.Windows.Forms.ComboBox

End Class
