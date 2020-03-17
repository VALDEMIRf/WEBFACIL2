<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTarefasConsulta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTarefasConsulta))
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgdGrid = New System.Windows.Forms.DataGridView()
        Me.btSair = New System.Windows.Forms.Button()
        Me.btExcluir = New System.Windows.Forms.Button()
        Me.btAlterar = New System.Windows.Forms.Button()
        Me.btNovo = New System.Windows.Forms.Button()
        CType(Me.dgdGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPesquisar.FlatAppearance.BorderSize = 0
        Me.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPesquisar.Image = CType(resources.GetObject("btnPesquisar.Image"), System.Drawing.Image)
        Me.btnPesquisar.Location = New System.Drawing.Point(384, 15)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(89, 39)
        Me.btnPesquisar.TabIndex = 5
        Me.btnPesquisar.Text = "Pesquisar"
        Me.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(76, 30)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(297, 20)
        Me.txtDescricao.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Descrição:"
        '
        'dgdGrid
        '
        Me.dgdGrid.BackgroundColor = System.Drawing.Color.White
        Me.dgdGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgdGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdGrid.Location = New System.Drawing.Point(12, 60)
        Me.dgdGrid.Name = "dgdGrid"
        Me.dgdGrid.Size = New System.Drawing.Size(464, 220)
        Me.dgdGrid.TabIndex = 6
        '
        'btSair
        '
        Me.btSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSair.FlatAppearance.BorderSize = 0
        Me.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSair.Image = CType(resources.GetObject("btSair.Image"), System.Drawing.Image)
        Me.btSair.Location = New System.Drawing.Point(384, 293)
        Me.btSair.Name = "btSair"
        Me.btSair.Size = New System.Drawing.Size(87, 37)
        Me.btSair.TabIndex = 7
        Me.btSair.Text = "Sair"
        Me.btSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSair.UseVisualStyleBackColor = True
        '
        'btExcluir
        '
        Me.btExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btExcluir.FlatAppearance.BorderSize = 0
        Me.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btExcluir.Image = CType(resources.GetObject("btExcluir.Image"), System.Drawing.Image)
        Me.btExcluir.Location = New System.Drawing.Point(293, 286)
        Me.btExcluir.Name = "btExcluir"
        Me.btExcluir.Size = New System.Drawing.Size(85, 51)
        Me.btExcluir.TabIndex = 8
        Me.btExcluir.Text = "Excluir"
        Me.btExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btExcluir.UseVisualStyleBackColor = True
        '
        'btAlterar
        '
        Me.btAlterar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btAlterar.FlatAppearance.BorderSize = 0
        Me.btAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAlterar.Image = CType(resources.GetObject("btAlterar.Image"), System.Drawing.Image)
        Me.btAlterar.Location = New System.Drawing.Point(207, 293)
        Me.btAlterar.Name = "btAlterar"
        Me.btAlterar.Size = New System.Drawing.Size(75, 37)
        Me.btAlterar.TabIndex = 9
        Me.btAlterar.Text = "Alterar"
        Me.btAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btAlterar.UseVisualStyleBackColor = True
        '
        'btNovo
        '
        Me.btNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btNovo.FlatAppearance.BorderSize = 0
        Me.btNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btNovo.Image = CType(resources.GetObject("btNovo.Image"), System.Drawing.Image)
        Me.btNovo.Location = New System.Drawing.Point(128, 293)
        Me.btNovo.Name = "btNovo"
        Me.btNovo.Size = New System.Drawing.Size(63, 37)
        Me.btNovo.TabIndex = 10
        Me.btNovo.Text = "Novo"
        Me.btNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btNovo.UseVisualStyleBackColor = True
        '
        'frmTarefasConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(485, 349)
        Me.Controls.Add(Me.btNovo)
        Me.Controls.Add(Me.btAlterar)
        Me.Controls.Add(Me.btExcluir)
        Me.Controls.Add(Me.btSair)
        Me.Controls.Add(Me.dgdGrid)
        Me.Controls.Add(Me.btnPesquisar)
        Me.Controls.Add(Me.txtDescricao)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmTarefasConsulta"
        Me.Text = "Consulta de Tarefas"
        CType(Me.dgdGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents btnPesquisar As System.Windows.Forms.Button
    Friend WithEvents txtDescricao As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents dgdGrid As System.Windows.Forms.DataGridView
    Friend WithEvents btSair As System.Windows.Forms.Button
    Friend WithEvents btExcluir As System.Windows.Forms.Button
    Friend WithEvents btAlterar As System.Windows.Forms.Button
    Friend WithEvents btNovo As System.Windows.Forms.Button
End Class
