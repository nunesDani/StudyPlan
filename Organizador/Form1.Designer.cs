namespace Organizador
{
	partial class Form1
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.inícioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.novaTarefaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tarefasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.labelWelcome = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
			this.menuStrip1.Size = new System.Drawing.Size(954, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// inícioToolStripMenuItem
			// 
			this.inícioToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.inícioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.inícioToolStripMenuItem.Name = "inícioToolStripMenuItem";
			this.inícioToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
			this.inícioToolStripMenuItem.Text = "Início";
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
			this.configToolStripMenuItem.Name = "configToolStripMenuItem";
			this.configToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
			this.configToolStripMenuItem.Text = "Config";
			this.configToolStripMenuItem.Click += new System.EventHandler(this.visualizaConfig);
			// 
			// labelWelcome
			// 
			this.labelWelcome.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelWelcome.AutoSize = true;
			this.labelWelcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(174)))), ((int)(((byte)(235)))));
			this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelWelcome.Location = new System.Drawing.Point(186, 169);
			this.labelWelcome.Name = "labelWelcome";
			this.labelWelcome.Size = new System.Drawing.Size(142, 26);
			this.labelWelcome.TabIndex = 2;
			this.labelWelcome.Text = "Boas vindas";
			this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pictureBox2.Image = global::Organizador.Properties.Resources.home;
			this.pictureBox2.Location = new System.Drawing.Point(12, 56);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(930, 538);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox2.TabIndex = 3;
			this.pictureBox2.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(954, 631);
			this.Controls.Add(this.labelWelcome);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.pictureBox2);
			this.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new System.Drawing.Size(970, 670);
			this.Name = "Form1";
			this.Text = "StudyPlan";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem novaTarefaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tarefasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem inícioToolStripMenuItem;
		private System.Windows.Forms.Label labelWelcome;
		private System.Windows.Forms.PictureBox pictureBox2;
	}
}

