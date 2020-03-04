<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadAcessoria
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEmpresa = New System.Windows.Forms.TextBox()
        Me.txtGerente = New System.Windows.Forms.TextBox()
        Me.txtAno = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMes = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chbProlabore = New System.Windows.Forms.CheckBox()
        Me.gbEmpresa = New System.Windows.Forms.GroupBox()
        Me.txtTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtResponsavel = New System.Windows.Forms.TextBox()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chbGRRF = New System.Windows.Forms.CheckBox()
        Me.chbDARF = New System.Windows.Forms.CheckBox()
        Me.chbGRF = New System.Windows.Forms.CheckBox()
        Me.chbGPS = New System.Windows.Forms.CheckBox()
        Me.chbSefip = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chbFolha = New System.Windows.Forms.CheckBox()
        Me.txt13salario = New System.Windows.Forms.TextBox()
        Me.GBsIMPLES = New System.Windows.Forms.GroupBox()
        Me.chbDEFIS = New System.Windows.Forms.CheckBox()
        Me.chbDASZERO = New System.Windows.Forms.CheckBox()
        Me.chbDASN = New System.Windows.Forms.CheckBox()
        Me.chbDAS = New System.Windows.Forms.CheckBox()
        Me.gbDeclaracoes = New System.Windows.Forms.GroupBox()
        Me.chbCAGED = New System.Windows.Forms.CheckBox()
        Me.chbRAISNEGATIVA = New System.Windows.Forms.CheckBox()
        Me.chbGIA = New System.Windows.Forms.CheckBox()
        Me.chbRAIS = New System.Windows.Forms.CheckBox()
        Me.chbEFD = New System.Windows.Forms.CheckBox()
        Me.chbECF = New System.Windows.Forms.CheckBox()
        Me.chbDCTF = New System.Windows.Forms.CheckBox()
        Me.chbIRRF = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.btSalvar = New System.Windows.Forms.Button()
        Me.btAlterar = New System.Windows.Forms.Button()
        Me.errErro = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btAltera = New System.Windows.Forms.Button()
        Me.btAnterior = New System.Windows.Forms.Button()
        Me.btRegistroAnterior = New System.Windows.Forms.Button()
        Me.btProximoRegistro = New System.Windows.Forms.Button()
        Me.btSair = New System.Windows.Forms.Button()
        Me.gbEmpresa.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GBsIMPLES.SuspendLayout()
        Me.gbDeclaracoes.SuspendLayout()
        CType(Me.errErro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Empresa:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(191, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Responsável:"
        '
        'txtEmpresa
        '
        Me.txtEmpresa.Location = New System.Drawing.Point(58, 33)
        Me.txtEmpresa.Name = "txtEmpresa"
        Me.txtEmpresa.Size = New System.Drawing.Size(274, 22)
        Me.txtEmpresa.TabIndex = 3
        '
        'txtGerente
        '
        Me.txtGerente.Location = New System.Drawing.Point(58, 76)
        Me.txtGerente.Name = "txtGerente"
        Me.txtGerente.Size = New System.Drawing.Size(123, 22)
        Me.txtGerente.TabIndex = 5
        '
        'txtAno
        '
        Me.txtAno.Location = New System.Drawing.Point(486, 33)
        Me.txtAno.Name = "txtAno"
        Me.txtAno.Size = New System.Drawing.Size(58, 22)
        Me.txtAno.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(450, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Ano:"
        '
        'txtMes
        '
        Me.txtMes.Location = New System.Drawing.Point(381, 33)
        Me.txtMes.Name = "txtMes"
        Me.txtMes.Size = New System.Drawing.Size(58, 22)
        Me.txtMes.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(344, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Mes:"
        '
        'chbProlabore
        '
        Me.chbProlabore.AutoSize = True
        Me.chbProlabore.Location = New System.Drawing.Point(12, 30)
        Me.chbProlabore.Name = "chbProlabore"
        Me.chbProlabore.Size = New System.Drawing.Size(82, 20)
        Me.chbProlabore.TabIndex = 12
        Me.chbProlabore.Text = "Pro-Labore"
        Me.chbProlabore.UseVisualStyleBackColor = True
        '
        'gbEmpresa
        '
        Me.gbEmpresa.Controls.Add(Me.txtTelefone)
        Me.gbEmpresa.Controls.Add(Me.Label8)
        Me.gbEmpresa.Controls.Add(Me.txtEmpresa)
        Me.gbEmpresa.Controls.Add(Me.Label6)
        Me.gbEmpresa.Controls.Add(Me.txtMes)
        Me.gbEmpresa.Controls.Add(Me.Label2)
        Me.gbEmpresa.Controls.Add(Me.Label5)
        Me.gbEmpresa.Controls.Add(Me.txtGerente)
        Me.gbEmpresa.Controls.Add(Me.txtAno)
        Me.gbEmpresa.Controls.Add(Me.txtResponsavel)
        Me.gbEmpresa.Controls.Add(Me.Label4)
        Me.gbEmpresa.Controls.Add(Me.btnPesquisar)
        Me.gbEmpresa.Controls.Add(Me.Label3)
        Me.gbEmpresa.Location = New System.Drawing.Point(12, 26)
        Me.gbEmpresa.Name = "gbEmpresa"
        Me.gbEmpresa.Size = New System.Drawing.Size(597, 112)
        Me.gbEmpresa.TabIndex = 13
        Me.gbEmpresa.TabStop = False
        Me.gbEmpresa.Text = "Dados da Empresa"
        '
        'txtTelefone
        '
        Me.txtTelefone.Location = New System.Drawing.Point(435, 76)
        Me.txtTelefone.Mask = "(99) 0 0000-0000"
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(95, 22)
        Me.txtTelefone.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(400, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 16)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Tel.:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Gerente:"
        '
        'txtResponsavel
        '
        Me.txtResponsavel.Location = New System.Drawing.Point(270, 76)
        Me.txtResponsavel.Name = "txtResponsavel"
        Me.txtResponsavel.Size = New System.Drawing.Size(123, 22)
        Me.txtResponsavel.TabIndex = 5
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPesquisar.FlatAppearance.BorderSize = 0
        Me.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPesquisar.Image = Global.WEBFACIL2.My.Resources.Resources.lupa
        Me.btnPesquisar.Location = New System.Drawing.Point(550, 27)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(34, 34)
        Me.btnPesquisar.TabIndex = 6
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chbGRRF)
        Me.GroupBox1.Controls.Add(Me.chbDARF)
        Me.GroupBox1.Controls.Add(Me.chbGRF)
        Me.GroupBox1.Controls.Add(Me.chbGPS)
        Me.GroupBox1.Controls.Add(Me.chbSefip)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.chbFolha)
        Me.GroupBox1.Controls.Add(Me.txt13salario)
        Me.GroupBox1.Controls.Add(Me.chbProlabore)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 153)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(393, 104)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Folha de Pagamento"
        '
        'chbGRRF
        '
        Me.chbGRRF.AutoSize = True
        Me.chbGRRF.Location = New System.Drawing.Point(130, 70)
        Me.chbGRRF.Name = "chbGRRF"
        Me.chbGRRF.Size = New System.Drawing.Size(58, 20)
        Me.chbGRRF.TabIndex = 18
        Me.chbGRRF.Text = "GRRF"
        Me.chbGRRF.UseVisualStyleBackColor = True
        '
        'chbDARF
        '
        Me.chbDARF.AutoSize = True
        Me.chbDARF.Location = New System.Drawing.Point(71, 70)
        Me.chbDARF.Name = "chbDARF"
        Me.chbDARF.Size = New System.Drawing.Size(57, 20)
        Me.chbDARF.TabIndex = 17
        Me.chbDARF.Text = "DARF"
        Me.chbDARF.UseVisualStyleBackColor = True
        '
        'chbGRF
        '
        Me.chbGRF.AutoSize = True
        Me.chbGRF.Location = New System.Drawing.Point(325, 70)
        Me.chbGRF.Name = "chbGRF"
        Me.chbGRF.Size = New System.Drawing.Size(50, 20)
        Me.chbGRF.TabIndex = 16
        Me.chbGRF.Text = "GRF"
        Me.chbGRF.UseVisualStyleBackColor = True
        '
        'chbGPS
        '
        Me.chbGPS.AutoSize = True
        Me.chbGPS.Location = New System.Drawing.Point(270, 70)
        Me.chbGPS.Name = "chbGPS"
        Me.chbGPS.Size = New System.Drawing.Size(49, 20)
        Me.chbGPS.TabIndex = 15
        Me.chbGPS.Text = "GPS"
        Me.chbGPS.UseVisualStyleBackColor = True
        '
        'chbSefip
        '
        Me.chbSefip.AutoSize = True
        Me.chbSefip.Location = New System.Drawing.Point(203, 70)
        Me.chbSefip.Name = "chbSefip"
        Me.chbSefip.Size = New System.Drawing.Size(50, 20)
        Me.chbSefip.TabIndex = 14
        Me.chbSefip.Text = "Sefip"
        Me.chbSefip.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(104, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "13° Salario:"
        '
        'chbFolha
        '
        Me.chbFolha.AutoSize = True
        Me.chbFolha.Location = New System.Drawing.Point(12, 70)
        Me.chbFolha.Name = "chbFolha"
        Me.chbFolha.Size = New System.Drawing.Size(54, 20)
        Me.chbFolha.TabIndex = 13
        Me.chbFolha.Text = "Folha"
        Me.chbFolha.UseVisualStyleBackColor = True
        '
        'txt13salario
        '
        Me.txt13salario.Location = New System.Drawing.Point(173, 28)
        Me.txt13salario.Name = "txt13salario"
        Me.txt13salario.Size = New System.Drawing.Size(146, 22)
        Me.txt13salario.TabIndex = 13
        '
        'GBsIMPLES
        '
        Me.GBsIMPLES.Controls.Add(Me.chbDEFIS)
        Me.GBsIMPLES.Controls.Add(Me.chbDASZERO)
        Me.GBsIMPLES.Controls.Add(Me.chbDASN)
        Me.GBsIMPLES.Controls.Add(Me.chbDAS)
        Me.GBsIMPLES.Location = New System.Drawing.Point(411, 153)
        Me.GBsIMPLES.Name = "GBsIMPLES"
        Me.GBsIMPLES.Size = New System.Drawing.Size(198, 104)
        Me.GBsIMPLES.TabIndex = 15
        Me.GBsIMPLES.TabStop = False
        Me.GBsIMPLES.Text = "Simples"
        '
        'chbDEFIS
        '
        Me.chbDEFIS.AutoSize = True
        Me.chbDEFIS.Location = New System.Drawing.Point(112, 70)
        Me.chbDEFIS.Name = "chbDEFIS"
        Me.chbDEFIS.Size = New System.Drawing.Size(59, 20)
        Me.chbDEFIS.TabIndex = 20
        Me.chbDEFIS.Text = "DEFIS"
        Me.chbDEFIS.UseVisualStyleBackColor = True
        '
        'chbDASZERO
        '
        Me.chbDASZERO.AutoSize = True
        Me.chbDASZERO.Location = New System.Drawing.Point(4, 70)
        Me.chbDASZERO.Name = "chbDASZERO"
        Me.chbDASZERO.Size = New System.Drawing.Size(97, 20)
        Me.chbDASZERO.TabIndex = 19
        Me.chbDASZERO.Text = "DAS ZERADO"
        Me.chbDASZERO.UseVisualStyleBackColor = True
        '
        'chbDASN
        '
        Me.chbDASN.AutoSize = True
        Me.chbDASN.Location = New System.Drawing.Point(112, 30)
        Me.chbDASN.Name = "chbDASN"
        Me.chbDASN.Size = New System.Drawing.Size(57, 20)
        Me.chbDASN.TabIndex = 18
        Me.chbDASN.Text = "DASN"
        Me.chbDASN.UseVisualStyleBackColor = True
        '
        'chbDAS
        '
        Me.chbDAS.AutoSize = True
        Me.chbDAS.Location = New System.Drawing.Point(6, 26)
        Me.chbDAS.Name = "chbDAS"
        Me.chbDAS.Size = New System.Drawing.Size(49, 20)
        Me.chbDAS.TabIndex = 17
        Me.chbDAS.Text = "DAS"
        Me.chbDAS.UseVisualStyleBackColor = True
        '
        'gbDeclaracoes
        '
        Me.gbDeclaracoes.Controls.Add(Me.chbCAGED)
        Me.gbDeclaracoes.Controls.Add(Me.chbRAISNEGATIVA)
        Me.gbDeclaracoes.Controls.Add(Me.chbGIA)
        Me.gbDeclaracoes.Controls.Add(Me.chbRAIS)
        Me.gbDeclaracoes.Controls.Add(Me.chbEFD)
        Me.gbDeclaracoes.Controls.Add(Me.chbECF)
        Me.gbDeclaracoes.Controls.Add(Me.chbDCTF)
        Me.gbDeclaracoes.Controls.Add(Me.chbIRRF)
        Me.gbDeclaracoes.Location = New System.Drawing.Point(12, 270)
        Me.gbDeclaracoes.Name = "gbDeclaracoes"
        Me.gbDeclaracoes.Size = New System.Drawing.Size(597, 67)
        Me.gbDeclaracoes.TabIndex = 16
        Me.gbDeclaracoes.TabStop = False
        Me.gbDeclaracoes.Text = "Declarações"
        '
        'chbCAGED
        '
        Me.chbCAGED.AutoSize = True
        Me.chbCAGED.Location = New System.Drawing.Point(503, 32)
        Me.chbCAGED.Name = "chbCAGED"
        Me.chbCAGED.Size = New System.Drawing.Size(65, 20)
        Me.chbCAGED.TabIndex = 20
        Me.chbCAGED.Text = "CAGED"
        Me.chbCAGED.UseVisualStyleBackColor = True
        '
        'chbRAISNEGATIVA
        '
        Me.chbRAISNEGATIVA.AutoSize = True
        Me.chbRAISNEGATIVA.Location = New System.Drawing.Point(192, 32)
        Me.chbRAISNEGATIVA.Name = "chbRAISNEGATIVA"
        Me.chbRAISNEGATIVA.Size = New System.Drawing.Size(109, 20)
        Me.chbRAISNEGATIVA.TabIndex = 20
        Me.chbRAISNEGATIVA.Text = "RAIS NEGATIVA"
        Me.chbRAISNEGATIVA.UseVisualStyleBackColor = True
        '
        'chbGIA
        '
        Me.chbGIA.AutoSize = True
        Me.chbGIA.Location = New System.Drawing.Point(423, 32)
        Me.chbGIA.Name = "chbGIA"
        Me.chbGIA.Size = New System.Drawing.Size(45, 20)
        Me.chbGIA.TabIndex = 19
        Me.chbGIA.Text = "GIA"
        Me.chbGIA.UseVisualStyleBackColor = True
        '
        'chbRAIS
        '
        Me.chbRAIS.AutoSize = True
        Me.chbRAIS.Location = New System.Drawing.Point(136, 32)
        Me.chbRAIS.Name = "chbRAIS"
        Me.chbRAIS.Size = New System.Drawing.Size(52, 20)
        Me.chbRAIS.TabIndex = 19
        Me.chbRAIS.Text = "RAIS"
        Me.chbRAIS.UseVisualStyleBackColor = True
        '
        'chbEFD
        '
        Me.chbEFD.AutoSize = True
        Me.chbEFD.Location = New System.Drawing.Point(368, 32)
        Me.chbEFD.Name = "chbEFD"
        Me.chbEFD.Size = New System.Drawing.Size(49, 20)
        Me.chbEFD.TabIndex = 18
        Me.chbEFD.Text = "EFD"
        Me.chbEFD.UseVisualStyleBackColor = True
        '
        'chbECF
        '
        Me.chbECF.AutoSize = True
        Me.chbECF.Location = New System.Drawing.Point(307, 32)
        Me.chbECF.Name = "chbECF"
        Me.chbECF.Size = New System.Drawing.Size(49, 20)
        Me.chbECF.TabIndex = 17
        Me.chbECF.Text = "ECF"
        Me.chbECF.UseVisualStyleBackColor = True
        '
        'chbDCTF
        '
        Me.chbDCTF.AutoSize = True
        Me.chbDCTF.Location = New System.Drawing.Point(73, 32)
        Me.chbDCTF.Name = "chbDCTF"
        Me.chbDCTF.Size = New System.Drawing.Size(57, 20)
        Me.chbDCTF.TabIndex = 18
        Me.chbDCTF.Text = "DCTF"
        Me.chbDCTF.UseVisualStyleBackColor = True
        '
        'chbIRRF
        '
        Me.chbIRRF.AutoSize = True
        Me.chbIRRF.Location = New System.Drawing.Point(12, 32)
        Me.chbIRRF.Name = "chbIRRF"
        Me.chbIRRF.Size = New System.Drawing.Size(53, 20)
        Me.chbIRRF.TabIndex = 17
        Me.chbIRRF.Text = "IRRF"
        Me.chbIRRF.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(627, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Observações:"
        '
        'txtObs
        '
        Me.txtObs.Location = New System.Drawing.Point(615, 33)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(188, 266)
        Me.txtObs.TabIndex = 13
        '
        'btSalvar
        '
        Me.btSalvar.Location = New System.Drawing.Point(31, 379)
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(75, 23)
        Me.btSalvar.TabIndex = 18
        Me.btSalvar.Text = "Salvar"
        Me.btSalvar.UseVisualStyleBackColor = True
        '
        'btAlterar
        '
        Me.btAlterar.Location = New System.Drawing.Point(125, 379)
        Me.btAlterar.Name = "btAlterar"
        Me.btAlterar.Size = New System.Drawing.Size(75, 23)
        Me.btAlterar.TabIndex = 19
        Me.btAlterar.Text = "Alterar"
        Me.btAlterar.UseVisualStyleBackColor = True
        '
        'errErro
        '
        Me.errErro.ContainerControl = Me
        '
        'btAltera
        '
        Me.btAltera.Location = New System.Drawing.Point(359, 393)
        Me.btAltera.Name = "btAltera"
        Me.btAltera.Size = New System.Drawing.Size(75, 23)
        Me.btAltera.TabIndex = 19
        Me.btAltera.Text = "Alterar"
        Me.btAltera.UseVisualStyleBackColor = True
        '
        'btAnterior
        '
        Me.btAnterior.Location = New System.Drawing.Point(79, 393)
        Me.btAnterior.Name = "btAnterior"
        Me.btAnterior.Size = New System.Drawing.Size(75, 23)
        Me.btAnterior.TabIndex = 21
        Me.btAnterior.Text = "Anterior"
        Me.btAnterior.UseVisualStyleBackColor = True
        '
        'btRegistroAnterior
        '
        Me.btRegistroAnterior.Location = New System.Drawing.Point(232, 379)
        Me.btRegistroAnterior.Name = "btRegistroAnterior"
        Me.btRegistroAnterior.Size = New System.Drawing.Size(112, 39)
        Me.btRegistroAnterior.TabIndex = 20
        Me.btRegistroAnterior.Text = "Registro Anterior"
        Me.btRegistroAnterior.UseVisualStyleBackColor = True
        '
        'btProximoRegistro
        '
        Me.btProximoRegistro.Location = New System.Drawing.Point(359, 376)
        Me.btProximoRegistro.Name = "btProximoRegistro"
        Me.btProximoRegistro.Size = New System.Drawing.Size(107, 42)
        Me.btProximoRegistro.TabIndex = 21
        Me.btProximoRegistro.Text = "Próximo Registro"
        Me.btProximoRegistro.UseVisualStyleBackColor = True
        '
        'btSair
        '
        Me.btSair.Location = New System.Drawing.Point(515, 386)
        Me.btSair.Name = "btSair"
        Me.btSair.Size = New System.Drawing.Size(75, 23)
        Me.btSair.TabIndex = 22
        Me.btSair.Text = "Sair"
        Me.btSair.UseVisualStyleBackColor = True
        '
        'frmCadAcessoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(805, 441)
        Me.Controls.Add(Me.btSair)
        Me.Controls.Add(Me.btProximoRegistro)
        Me.Controls.Add(Me.btRegistroAnterior)
        Me.Controls.Add(Me.btAlterar)
        Me.Controls.Add(Me.btSalvar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtObs)
        Me.Controls.Add(Me.gbDeclaracoes)
        Me.Controls.Add(Me.GBsIMPLES)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbEmpresa)
        Me.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmCadAcessoria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCadAcessoria"
        Me.gbEmpresa.ResumeLayout(False)
        Me.gbEmpresa.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GBsIMPLES.ResumeLayout(False)
        Me.GBsIMPLES.PerformLayout()
        Me.gbDeclaracoes.ResumeLayout(False)
        Me.gbDeclaracoes.PerformLayout()
        CType(Me.errErro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents txtGerente As System.Windows.Forms.TextBox
    Friend WithEvents btnPesquisar As System.Windows.Forms.Button
    Friend WithEvents txtAno As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMes As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chbProlabore As System.Windows.Forms.CheckBox
    Friend WithEvents gbEmpresa As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtResponsavel As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chbGRF As System.Windows.Forms.CheckBox
    Friend WithEvents chbGPS As System.Windows.Forms.CheckBox
    Friend WithEvents chbSefip As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chbFolha As System.Windows.Forms.CheckBox
    Friend WithEvents txt13salario As System.Windows.Forms.TextBox
    Friend WithEvents GBsIMPLES As System.Windows.Forms.GroupBox
    Friend WithEvents chbDASZERO As System.Windows.Forms.CheckBox
    Friend WithEvents chbDASN As System.Windows.Forms.CheckBox
    Friend WithEvents chbDAS As System.Windows.Forms.CheckBox
    Friend WithEvents gbDeclaracoes As System.Windows.Forms.GroupBox
    Friend WithEvents chbRAISNEGATIVA As System.Windows.Forms.CheckBox
    Friend WithEvents chbRAIS As System.Windows.Forms.CheckBox
    Friend WithEvents chbDCTF As System.Windows.Forms.CheckBox
    Friend WithEvents chbIRRF As System.Windows.Forms.CheckBox
    Friend WithEvents chbCAGED As System.Windows.Forms.CheckBox
    Friend WithEvents chbGIA As System.Windows.Forms.CheckBox
    Friend WithEvents chbECF As System.Windows.Forms.CheckBox
    Friend WithEvents chbEFD As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtObs As System.Windows.Forms.TextBox
    Friend WithEvents btSalvar As System.Windows.Forms.Button
    Friend WithEvents btAlterar As System.Windows.Forms.Button
    Friend WithEvents errErro As System.Windows.Forms.ErrorProvider
    Friend WithEvents btAltera As System.Windows.Forms.Button
    Friend WithEvents btAnterior As System.Windows.Forms.Button
    Friend WithEvents btRegistroAnterior As System.Windows.Forms.Button
    Friend WithEvents btProximoRegistro As System.Windows.Forms.Button
    Friend WithEvents btSair As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTelefone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents chbGRRF As System.Windows.Forms.CheckBox
    Friend WithEvents chbDARF As System.Windows.Forms.CheckBox
    Friend WithEvents chbDEFIS As System.Windows.Forms.CheckBox
End Class
