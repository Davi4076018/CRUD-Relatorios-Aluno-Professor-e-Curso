namespace projeto4
{
    partial class FormRelatorioProfessor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            cboEstado = new ReaLTaiizor.Controls.MaterialComboBox();
            txtCidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            groupBox2 = new GroupBox();
            cboAgrupamento = new ReaLTaiizor.Controls.MaterialComboBox();
            groupBox3 = new GroupBox();
            cboImpressora = new ReaLTaiizor.Controls.MaterialComboBox();
            btnImprimir = new ReaLTaiizor.Controls.MaterialButton();
            btnVisualizar = new ReaLTaiizor.Controls.MaterialButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboEstado);
            groupBox1.Controls.Add(txtCidade);
            groupBox1.Location = new Point(30, 89);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(470, 90);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // cboEstado
            // 
            cboEstado.AutoResize = false;
            cboEstado.BackColor = Color.FromArgb(255, 255, 255);
            cboEstado.Depth = 0;
            cboEstado.DrawMode = DrawMode.OwnerDrawVariable;
            cboEstado.DropDownHeight = 174;
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.DropDownWidth = 121;
            cboEstado.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboEstado.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboEstado.FormattingEnabled = true;
            cboEstado.Hint = "Estado";
            cboEstado.IntegralHeight = false;
            cboEstado.ItemHeight = 43;
            cboEstado.Items.AddRange(new object[] { "", "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cboEstado.Location = new Point(278, 21);
            cboEstado.MaxDropDownItems = 4;
            cboEstado.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(137, 49);
            cboEstado.StartIndex = 0;
            cboEstado.TabIndex = 1;
            cboEstado.SelectedIndexChanged += cboEstado_SelectedIndexChanged;
            // 
            // txtCidade
            // 
            txtCidade.AnimateReadOnly = false;
            txtCidade.AutoCompleteMode = AutoCompleteMode.None;
            txtCidade.AutoCompleteSource = AutoCompleteSource.None;
            txtCidade.BackgroundImageLayout = ImageLayout.None;
            txtCidade.CharacterCasing = CharacterCasing.Normal;
            txtCidade.Depth = 0;
            txtCidade.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCidade.HideSelection = true;
            txtCidade.Hint = "Cidade";
            txtCidade.LeadingIcon = null;
            txtCidade.Location = new Point(17, 22);
            txtCidade.MaxLength = 32767;
            txtCidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCidade.Name = "txtCidade";
            txtCidade.PasswordChar = '\0';
            txtCidade.PrefixSuffixText = null;
            txtCidade.ReadOnly = false;
            txtCidade.RightToLeft = RightToLeft.No;
            txtCidade.SelectedText = "";
            txtCidade.SelectionLength = 0;
            txtCidade.SelectionStart = 0;
            txtCidade.ShortcutsEnabled = true;
            txtCidade.Size = new Size(240, 48);
            txtCidade.TabIndex = 0;
            txtCidade.TabStop = false;
            txtCidade.TextAlign = HorizontalAlignment.Left;
            txtCidade.TrailingIcon = null;
            txtCidade.UseSystemPasswordChar = false;
            txtCidade.Click += txtCidade_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cboAgrupamento);
            groupBox2.Location = new Point(30, 185);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(470, 87);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Agrupamento";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // cboAgrupamento
            // 
            cboAgrupamento.AutoResize = false;
            cboAgrupamento.BackColor = Color.FromArgb(255, 255, 255);
            cboAgrupamento.Depth = 0;
            cboAgrupamento.DrawMode = DrawMode.OwnerDrawVariable;
            cboAgrupamento.DropDownHeight = 174;
            cboAgrupamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAgrupamento.DropDownWidth = 121;
            cboAgrupamento.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboAgrupamento.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboAgrupamento.FormattingEnabled = true;
            cboAgrupamento.Hint = "Agrupamento";
            cboAgrupamento.IntegralHeight = false;
            cboAgrupamento.ItemHeight = 43;
            cboAgrupamento.Location = new Point(16, 22);
            cboAgrupamento.MaxDropDownItems = 4;
            cboAgrupamento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboAgrupamento.Name = "cboAgrupamento";
            cboAgrupamento.Size = new Size(399, 49);
            cboAgrupamento.StartIndex = 0;
            cboAgrupamento.TabIndex = 0;
            cboAgrupamento.SelectedIndexChanged += cboAgrupamento_SelectedIndexChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cboImpressora);
            groupBox3.Location = new Point(30, 278);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(470, 92);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Impressoras";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // cboImpressora
            // 
            cboImpressora.AutoResize = false;
            cboImpressora.BackColor = Color.FromArgb(255, 255, 255);
            cboImpressora.Depth = 0;
            cboImpressora.DrawMode = DrawMode.OwnerDrawVariable;
            cboImpressora.DropDownHeight = 174;
            cboImpressora.DropDownStyle = ComboBoxStyle.DropDownList;
            cboImpressora.DropDownWidth = 121;
            cboImpressora.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboImpressora.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboImpressora.FormattingEnabled = true;
            cboImpressora.Hint = "Impressora";
            cboImpressora.IntegralHeight = false;
            cboImpressora.ItemHeight = 43;
            cboImpressora.Location = new Point(17, 22);
            cboImpressora.MaxDropDownItems = 4;
            cboImpressora.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboImpressora.Name = "cboImpressora";
            cboImpressora.Size = new Size(398, 49);
            cboImpressora.StartIndex = 0;
            cboImpressora.TabIndex = 0;
            cboImpressora.SelectedIndexChanged += cboImpressora_SelectedIndexChanged;
            // 
            // btnImprimir
            // 
            btnImprimir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnImprimir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnImprimir.Depth = 0;
            btnImprimir.HighEmphasis = true;
            btnImprimir.Icon = null;
            btnImprimir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnImprimir.Location = new Point(285, 389);
            btnImprimir.Margin = new Padding(4, 6, 4, 6);
            btnImprimir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnImprimir.Name = "btnImprimir";
            btnImprimir.NoAccentTextColor = Color.Empty;
            btnImprimir.Size = new Size(87, 36);
            btnImprimir.TabIndex = 3;
            btnImprimir.Text = "IMPRIMIR";
            btnImprimir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnImprimir.UseAccentColor = false;
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // btnVisualizar
            // 
            btnVisualizar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnVisualizar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnVisualizar.Depth = 0;
            btnVisualizar.HighEmphasis = true;
            btnVisualizar.Icon = null;
            btnVisualizar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnVisualizar.Location = new Point(397, 389);
            btnVisualizar.Margin = new Padding(4, 6, 4, 6);
            btnVisualizar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.NoAccentTextColor = Color.Empty;
            btnVisualizar.Size = new Size(103, 36);
            btnVisualizar.TabIndex = 4;
            btnVisualizar.Text = "Visualizar";
            btnVisualizar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnVisualizar.UseAccentColor = false;
            btnVisualizar.UseVisualStyleBackColor = true;
            btnVisualizar.Click += btnVisualizar_Click;
            // 
            // FormRelatorioProfessor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 450);
            Controls.Add(btnVisualizar);
            Controls.Add(btnImprimir);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormRelatorioProfessor";
            Text = "Relatório de Professores";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private ReaLTaiizor.Controls.MaterialButton btnImprimir;
        private ReaLTaiizor.Controls.MaterialButton btnVisualizar;
        private ReaLTaiizor.Controls.MaterialComboBox cboEstado;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCidade;
        private ReaLTaiizor.Controls.MaterialComboBox cboAgrupamento;
        private ReaLTaiizor.Controls.MaterialComboBox cboImpressora;
    }
}