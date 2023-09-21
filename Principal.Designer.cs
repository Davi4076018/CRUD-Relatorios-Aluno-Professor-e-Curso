namespace projeto4
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            opçõesToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeAlunoToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeProfessorToolStripMenuItem = new ToolStripMenuItem();
            cadastroCursoToolStripMenuItem = new ToolStripMenuItem();
            relatóriosToolStripMenuItem = new ToolStripMenuItem();
            relatórioDeAlunosToolStripMenuItem = new ToolStripMenuItem();
            relatórioDeProfessoresToolStripMenuItem = new ToolStripMenuItem();
            relatórioDeCursosToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { opçõesToolStripMenuItem, relatóriosToolStripMenuItem });
            menuStrip1.Location = new Point(3, 64);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(794, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            opçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastroDeAlunoToolStripMenuItem, cadastroDeProfessorToolStripMenuItem, cadastroCursoToolStripMenuItem });
            opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            opçõesToolStripMenuItem.Size = new Size(59, 20);
            opçõesToolStripMenuItem.Text = "Opções";
            // 
            // cadastroDeAlunoToolStripMenuItem
            // 
            cadastroDeAlunoToolStripMenuItem.Name = "cadastroDeAlunoToolStripMenuItem";
            cadastroDeAlunoToolStripMenuItem.Size = new Size(189, 22);
            cadastroDeAlunoToolStripMenuItem.Text = "Cadastro de Aluno";
            cadastroDeAlunoToolStripMenuItem.Click += cadastroDeAlunoToolStripMenuItem_Click;
            // 
            // cadastroDeProfessorToolStripMenuItem
            // 
            cadastroDeProfessorToolStripMenuItem.Name = "cadastroDeProfessorToolStripMenuItem";
            cadastroDeProfessorToolStripMenuItem.Size = new Size(189, 22);
            cadastroDeProfessorToolStripMenuItem.Text = "Cadastro de Professor";
            cadastroDeProfessorToolStripMenuItem.Click += cadastroDeProfessorToolStripMenuItem_Click;
            // 
            // cadastroCursoToolStripMenuItem
            // 
            cadastroCursoToolStripMenuItem.Name = "cadastroCursoToolStripMenuItem";
            cadastroCursoToolStripMenuItem.Size = new Size(189, 22);
            cadastroCursoToolStripMenuItem.Text = "Cadastro Curso";
            cadastroCursoToolStripMenuItem.Click += cadastroCursoToolStripMenuItem_Click;
            // 
            // relatóriosToolStripMenuItem
            // 
            relatóriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { relatórioDeAlunosToolStripMenuItem, relatórioDeProfessoresToolStripMenuItem, relatórioDeCursosToolStripMenuItem });
            relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            relatóriosToolStripMenuItem.Size = new Size(71, 20);
            relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // relatórioDeAlunosToolStripMenuItem
            // 
            relatórioDeAlunosToolStripMenuItem.Name = "relatórioDeAlunosToolStripMenuItem";
            relatórioDeAlunosToolStripMenuItem.Size = new Size(200, 22);
            relatórioDeAlunosToolStripMenuItem.Text = "Relatório de Alunos";
            relatórioDeAlunosToolStripMenuItem.Click += relatórioDeAlunosToolStripMenuItem_Click;
            // 
            // relatórioDeProfessoresToolStripMenuItem
            // 
            relatórioDeProfessoresToolStripMenuItem.Name = "relatórioDeProfessoresToolStripMenuItem";
            relatórioDeProfessoresToolStripMenuItem.Size = new Size(200, 22);
            relatórioDeProfessoresToolStripMenuItem.Text = "Relatório de Professores";
            relatórioDeProfessoresToolStripMenuItem.Click += relatórioDeProfessoresToolStripMenuItem_Click;
            // 
            // relatórioDeCursosToolStripMenuItem
            // 
            relatórioDeCursosToolStripMenuItem.Name = "relatórioDeCursosToolStripMenuItem";
            relatórioDeCursosToolStripMenuItem.Size = new Size(200, 22);
            relatórioDeCursosToolStripMenuItem.Text = "Relatório de Cursos";
            relatórioDeCursosToolStripMenuItem.Click += relatórioDeCursosToolStripMenuItem_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Principal";
            Text = "IFSP - Sistema de Gerênciamento Acadêmico";
            WindowState = FormWindowState.Maximized;
            FormClosing += Principal_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem opçõesToolStripMenuItem;
        private ToolStripMenuItem cadastroDeAlunoToolStripMenuItem;
        private ToolStripMenuItem cadastroDeProfessorToolStripMenuItem;
        private ToolStripMenuItem cadastroCursoToolStripMenuItem;
        private ToolStripMenuItem relatóriosToolStripMenuItem;
        private ToolStripMenuItem relatórioDeAlunosToolStripMenuItem;
        private ToolStripMenuItem relatórioDeProfessoresToolStripMenuItem;
        private ToolStripMenuItem relatórioDeCursosToolStripMenuItem;
    }
}