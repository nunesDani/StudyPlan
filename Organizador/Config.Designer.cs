namespace Organizador
{
	partial class Configurações
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.inícioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.novaTarefaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tarefasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.labelConfig = new System.Windows.Forms.Label();
			this.textNome = new System.Windows.Forms.TextBox();
			this.labelNome = new System.Windows.Forms.Label();
			this.comboBoxGenero = new System.Windows.Forms.ComboBox();
			this.checkBoxNotificacao = new System.Windows.Forms.CheckBox();
			this.labelGenero = new System.Windows.Forms.Label();
			this.buttonSalvar = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inícioToolStripMenuItem,
            this.novaTarefaToolStripMenuItem,
            this.tarefasToolStripMenuItem,
            this.configToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(667, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// inícioToolStripMenuItem
			// 
			this.inícioToolStripMenuItem.Name = "inícioToolStripMenuItem";
			this.inícioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.inícioToolStripMenuItem.Text = "Início";
			this.inícioToolStripMenuItem.Click += new System.EventHandler(this.telaInicio);
			// 
			// novaTarefaToolStripMenuItem
			// 
			this.novaTarefaToolStripMenuItem.Name = "novaTarefaToolStripMenuItem";
			this.novaTarefaToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
			this.novaTarefaToolStripMenuItem.Text = "Nova Tarefa";
			this.novaTarefaToolStripMenuItem.Click += new System.EventHandler(this.novaTarefa);
			// 
			// tarefasToolStripMenuItem
			// 
			this.tarefasToolStripMenuItem.Name = "tarefasToolStripMenuItem";
			this.tarefasToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
			this.tarefasToolStripMenuItem.Text = "Tarefas";
			this.tarefasToolStripMenuItem.Click += new System.EventHandler(this.visualizaTarefas);
			// 
			// configToolStripMenuItem
			// 
			this.configToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.configToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.configToolStripMenuItem.Name = "configToolStripMenuItem";
			this.configToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
			this.configToolStripMenuItem.Text = "Config";
			// 
			// labelConfig
			// 
			this.labelConfig.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelConfig.AutoSize = true;
			this.labelConfig.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelConfig.Location = new System.Drawing.Point(230, 63);
			this.labelConfig.Name = "labelConfig";
			this.labelConfig.Size = new System.Drawing.Size(207, 32);
			this.labelConfig.TabIndex = 10;
			this.labelConfig.Text = "Configurações";
			this.labelConfig.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textNome
			// 
			this.textNome.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textNome.Location = new System.Drawing.Point(320, 131);
			this.textNome.Name = "textNome";
			this.textNome.Size = new System.Drawing.Size(211, 30);
			this.textNome.TabIndex = 23;
			// 
			// labelNome
			// 
			this.labelNome.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelNome.AutoSize = true;
			this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNome.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelNome.Location = new System.Drawing.Point(208, 134);
			this.labelNome.Name = "labelNome";
			this.labelNome.Size = new System.Drawing.Size(68, 25);
			this.labelNome.TabIndex = 22;
			this.labelNome.Text = "Nome";
			// 
			// comboBoxGenero
			// 
			this.comboBoxGenero.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.comboBoxGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBoxGenero.Items.AddRange(new object[] {
            "Outro",
            "Feminino",
            "Masculino"});
			this.comboBoxGenero.Location = new System.Drawing.Point(320, 167);
			this.comboBoxGenero.Name = "comboBoxGenero";
			this.comboBoxGenero.Size = new System.Drawing.Size(211, 32);
			this.comboBoxGenero.TabIndex = 20;
			// 
			// checkBoxNotificacao
			// 
			this.checkBoxNotificacao.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.checkBoxNotificacao.AutoSize = true;
			this.checkBoxNotificacao.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxNotificacao.Checked = true;
			this.checkBoxNotificacao.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxNotificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBoxNotificacao.Location = new System.Drawing.Point(80, 205);
			this.checkBoxNotificacao.Name = "checkBoxNotificacao";
			this.checkBoxNotificacao.Size = new System.Drawing.Size(253, 29);
			this.checkBoxNotificacao.TabIndex = 19;
			this.checkBoxNotificacao.Text = "Ativar Notificações       ";
			this.checkBoxNotificacao.UseVisualStyleBackColor = true;
			// 
			// labelGenero
			// 
			this.labelGenero.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelGenero.AutoSize = true;
			this.labelGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelGenero.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelGenero.Location = new System.Drawing.Point(193, 169);
			this.labelGenero.Name = "labelGenero";
			this.labelGenero.Size = new System.Drawing.Size(83, 25);
			this.labelGenero.TabIndex = 18;
			this.labelGenero.Text = "Gênero";
			// 
			// buttonSalvar
			// 
			this.buttonSalvar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonSalvar.BackColor = System.Drawing.Color.MediumSlateBlue;
			this.buttonSalvar.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
			this.buttonSalvar.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSalvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.buttonSalvar.Location = new System.Drawing.Point(213, 271);
			this.buttonSalvar.MaximumSize = new System.Drawing.Size(204, 46);
			this.buttonSalvar.MinimumSize = new System.Drawing.Size(204, 46);
			this.buttonSalvar.Name = "buttonSalvar";
			this.buttonSalvar.Size = new System.Drawing.Size(204, 46);
			this.buttonSalvar.TabIndex = 25;
			this.buttonSalvar.Text = "SALVAR";
			this.buttonSalvar.UseVisualStyleBackColor = false;
			this.buttonSalvar.Click += new System.EventHandler(this.atualizaUsuario);
			// 
			// Configurações
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(667, 406);
			this.Controls.Add(this.buttonSalvar);
			this.Controls.Add(this.textNome);
			this.Controls.Add(this.labelNome);
			this.Controls.Add(this.comboBoxGenero);
			this.Controls.Add(this.checkBoxNotificacao);
			this.Controls.Add(this.labelGenero);
			this.Controls.Add(this.labelConfig);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new System.Drawing.Size(683, 445);
			this.Name = "Configurações";
			this.Text = "Configurações";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem novaTarefaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tarefasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem inícioToolStripMenuItem;
		private System.Windows.Forms.Label labelConfig;
		private System.Windows.Forms.TextBox textNome;
		private System.Windows.Forms.Label labelNome;
		private System.Windows.Forms.ComboBox comboBoxGenero;
		private System.Windows.Forms.CheckBox checkBoxNotificacao;
		private System.Windows.Forms.Label labelGenero;
		private System.Windows.Forms.Button buttonSalvar;
	}
}