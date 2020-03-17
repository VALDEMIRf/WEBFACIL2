<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTarefasCadastro
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTarefa = New System.Windows.Forms.TextBox()
        Me.txtResponsavel = New System.Windows.Forms.TextBox()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.chbAtivo = New System.Windows.Forms.CheckBox()
        Me.txtDtCadastro = New System.Windows.Forms.MaskedTextBox()
        Me.txtDtConclusao = New System.Windows.Forms.MaskedTextBox()
        Me.btSair = New System.Windows.Forms.Button()
        Me.btGravar = New System.Windows.Forms.Button()
        Me.errErro = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.totToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.errErro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tarefa:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Responsável:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Data de Cadastro:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(201, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Data de Conclusão:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(336, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Observações:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDtConclusao)
        Me.GroupBox1.Controls.Add(Me.txtDtCadastro)
        Me.GroupBox1.Controls.Add(Me.chbAtivo)
        Me.GroupBox1.Controls.Add(Me.txtObs)
        Me.GroupBox1.Controls.Add(Me.txtResponsavel)
        Me.GroupBox1.Controls.Add(Me.txtTarefa)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(677, 270)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Descrição daTarefa "
        '
        'txtTarefa
        '
        Me.txtTarefa.Location = New System.Drawing.Point(53, 22)
        Me.txtTarefa.Multiline = True
        Me.txtTarefa.Name = "txtTarefa"
        Me.txtTarefa.Size = New System.Drawing.Size(276, 101)
        Me.txtTarefa.TabIndex = 6
        '
        'txtResponsavel
        '
        Me.txtResponsavel.Location = New System.Drawing.Point(89, 149)
        Me.txtResponsavel.Name = "txtResponsavel"
        Me.txtResponsavel.Size = New System.Drawing.Size(150, 20)
        Me.txtResponsavel.TabIndex = 7
        '
        'txtObs
        '
        Me.txtObs.Location = New System.Drawing.Point(407, 20)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(264, 103)
        Me.txtObs.TabIndex = 8
        '
        'chbAtivo
        '
        Me.chbAtivo.AutoSize = True
        Me.chbAtivo.Location = New System.Drawing.Point(18, 245)
        Me.chbAtivo.Name = "chbAtivo"
        Me.chbAtivo.Size = New System.Drawing.Size(50, 17)
        Me.chbAtivo.TabIndex = 9
        Me.chbAtivo.Text = "Ativo"
        Me.chbAtivo.UseVisualStyleBackColor = True
        '
        'txtDtCadastro
        '
        Me.txtDtCadastro.Location = New System.Drawing.Point(114, 195)
        Me.txtDtCadastro.Mask = "00/00/0000"
        Me.txtDtCadastro.Name = "txtDtCadastro"
        Me.txtDtCadastro.Size = New System.Drawing.Size(71, 20)
        Me.txtDtCadastro.TabIndex = 10
        Me.txtDtCadastro.ValidatingType = GetType(Date)
        '
        'txtDtConclusao
        '
        Me.txtDtConclusao.Location = New System.Drawing.Point(300, 195)
        Me.txtDtConclusao.Mask = "00/00/0000"
        Me.txtDtConclusao.Name = "txtDtConclusao"
        Me.txtDtConclusao.Size = New System.Drawing.Size(71, 20)
        Me.txtDtConclusao.TabIndex = 11
        Me.txtDtConclusao.ValidatingType = GetType(Date)
        '
        'btSair
        '
        Me.btSair.Location = New System.Drawing.Point(533, 288)
        Me.btSair.Name = "btSair"
        Me.btSair.Size = New System.Drawing.Size(75, 23)
        Me.btSair.TabIndex = 9
        Me.btSair.Text = "Sair"
        Me.btSair.UseVisualStyleBackColor = True
        '
        'btGravar
        '
        Me.btGravar.Location = New System.Drawing.Point(614, 288)
        Me.btGravar.Name = "btGravar"
        Me.btGravar.Size = New System.Drawing.Size(75, 23)
        Me.btGravar.TabIndex = 10
        Me.btGravar.Text = "Salvar"
        Me.btGravar.UseVisualStyleBackColor = True
        '
        'errErro
        '
        Me.errErro.ContainerControl = Me
        '
        'frmTarefasCadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 333)
        Me.Controls.Add(Me.btGravar)
        Me.Controls.Add(Me.btSair)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmTarefasCadastro"
        Me.Text = "Cadastro de Tarefas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.errErro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDtConclusao As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtDtCadastro As System.Windows.Forms.MaskedTextBox
    Friend WithEvents chbAtivo As System.Windows.Forms.CheckBox
    Friend WithEvents txtObs As System.Windows.Forms.TextBox
    Friend WithEvents txtResponsavel As System.Windows.Forms.TextBox
    Friend WithEvents txtTarefa As System.Windows.Forms.TextBox
    Friend WithEvents btSair As System.Windows.Forms.Button
    Friend WithEvents btGravar As System.Windows.Forms.Button
    Friend WithEvents errErro As System.Windows.Forms.ErrorProvider
    Friend WithEvents totToolTip As System.Windows.Forms.ToolTip
End Class
