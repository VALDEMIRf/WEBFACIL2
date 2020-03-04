<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAcessoriaConsulta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAcessoriaConsulta))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtMes = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAno = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPesquisarCliente = New System.Windows.Forms.TextBox()
        Me.btFechar = New System.Windows.Forms.Button()
        Me.btEnviarDados = New System.Windows.Forms.Button()
        Me.btPesquisarCliente = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvGridAssessoria = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvGridAssessoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtMes)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtAno)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtPesquisarCliente)
        Me.GroupBox1.Controls.Add(Me.btFechar)
        Me.GroupBox1.Controls.Add(Me.btEnviarDados)
        Me.GroupBox1.Controls.Add(Me.btPesquisarCliente)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(706, 122)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtro de Pesquisa"
        '
        'txtMes
        '
        Me.txtMes.Location = New System.Drawing.Point(52, 77)
        Me.txtMes.Name = "txtMes"
        Me.txtMes.Size = New System.Drawing.Size(71, 20)
        Me.txtMes.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Mes:"
        '
        'txtAno
        '
        Me.txtAno.Location = New System.Drawing.Point(176, 77)
        Me.txtAno.Name = "txtAno"
        Me.txtAno.Size = New System.Drawing.Size(51, 20)
        Me.txtAno.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(136, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Ano:"
        '
        'txtPesquisarCliente
        '
        Me.txtPesquisarCliente.Location = New System.Drawing.Point(67, 42)
        Me.txtPesquisarCliente.Name = "txtPesquisarCliente"
        Me.txtPesquisarCliente.Size = New System.Drawing.Size(291, 20)
        Me.txtPesquisarCliente.TabIndex = 2
        '
        'btFechar
        '
        Me.btFechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btFechar.FlatAppearance.BorderSize = 0
        Me.btFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btFechar.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btFechar.Image = CType(resources.GetObject("btFechar.Image"), System.Drawing.Image)
        Me.btFechar.Location = New System.Drawing.Point(608, 25)
        Me.btFechar.Name = "btFechar"
        Me.btFechar.Size = New System.Drawing.Size(90, 55)
        Me.btFechar.TabIndex = 6
        Me.btFechar.Text = "Fechar"
        Me.btFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btFechar.UseVisualStyleBackColor = True
        '
        'btEnviarDados
        '
        Me.btEnviarDados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btEnviarDados.FlatAppearance.BorderSize = 0
        Me.btEnviarDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btEnviarDados.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEnviarDados.Image = CType(resources.GetObject("btEnviarDados.Image"), System.Drawing.Image)
        Me.btEnviarDados.Location = New System.Drawing.Point(488, 33)
        Me.btEnviarDados.Name = "btEnviarDados"
        Me.btEnviarDados.Size = New System.Drawing.Size(114, 47)
        Me.btEnviarDados.TabIndex = 5
        Me.btEnviarDados.Text = "Enviar Dados"
        Me.btEnviarDados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btEnviarDados.UseVisualStyleBackColor = True
        '
        'btPesquisarCliente
        '
        Me.btPesquisarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btPesquisarCliente.FlatAppearance.BorderSize = 0
        Me.btPesquisarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btPesquisarCliente.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btPesquisarCliente.Image = CType(resources.GetObject("btPesquisarCliente.Image"), System.Drawing.Image)
        Me.btPesquisarCliente.Location = New System.Drawing.Point(365, 36)
        Me.btPesquisarCliente.Name = "btPesquisarCliente"
        Me.btPesquisarCliente.Size = New System.Drawing.Size(117, 38)
        Me.btPesquisarCliente.TabIndex = 4
        Me.btPesquisarCliente.Text = "Pesquisar"
        Me.btPesquisarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btPesquisarCliente.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cliente:"
        '
        'dgvGridAssessoria
        '
        Me.dgvGridAssessoria.BackgroundColor = System.Drawing.Color.White
        Me.dgvGridAssessoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGridAssessoria.GridColor = System.Drawing.Color.DarkGray
        Me.dgvGridAssessoria.Location = New System.Drawing.Point(13, 150)
        Me.dgvGridAssessoria.Name = "dgvGridAssessoria"
        Me.dgvGridAssessoria.Size = New System.Drawing.Size(707, 231)
        Me.dgvGridAssessoria.TabIndex = 3
        '
        'frmAcessoriaConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(835, 393)
        Me.Controls.Add(Me.dgvGridAssessoria)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAcessoriaConsulta"
        Me.Text = "frmAcessoriaConsulta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvGridAssessoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtMes As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAno As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPesquisarCliente As System.Windows.Forms.TextBox
    Friend WithEvents btFechar As System.Windows.Forms.Button
    Friend WithEvents btEnviarDados As System.Windows.Forms.Button
    Friend WithEvents btPesquisarCliente As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvGridAssessoria As System.Windows.Forms.DataGridView
End Class
