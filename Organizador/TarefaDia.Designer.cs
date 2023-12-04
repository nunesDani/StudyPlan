namespace Organizador
{
	partial class TarefaDia
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.nToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tarefasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.labelTarefaDia = new System.Windows.Forms.Label();
			this.inícioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tarefaDiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inícioToolStripMenuItem,
            this.nToolStripMenuItem,
            this.tarefasToolStripMenuItem,
            this.tarefaDiaToolStripMenuItem,
            this.configToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(907, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// nToolStripMenuItem
			// 
			this.nToolStripMenuItem.Name = "nToolStripMenuItem";
			this.nToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
			this.nToolStripMenuItem.Text = "Nova Tarefa";
			this.nToolStripMenuItem.Click += new System.EventHandler(this.novaTarefa);
			// 
			// tarefasToolStripMenuItem
			// 
			this.tarefasToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
			this.tarefasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
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
			// dataGridView
			// 
			this.dataGridView.AllowUserToAddRows = false;
			this.dataGridView.AllowUserToDeleteRows = false;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
			this.dataGridView.Location = new System.Drawing.Point(53, 151);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.ReadOnly = true;
			this.dataGridView.RowHeadersVisible = false;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridView.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView.Size = new System.Drawing.Size(804, 369);
			this.dataGridView.TabIndex = 10;
			this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.alterarTarefa);
			// 
			// labelTarefaDia
			// 
			this.labelTarefaDia.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelTarefaDia.AutoSize = true;
			this.labelTarefaDia.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTarefaDia.Location = new System.Drawing.Point(369, 76);
			this.labelTarefaDia.Name = "labelTarefaDia";
			this.labelTarefaDia.Size = new System.Drawing.Size(211, 32);
			this.labelTarefaDia.TabIndex = 9;
			this.labelTarefaDia.Text = "Minhas Tarefas";
			this.labelTarefaDia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// inícioToolStripMenuItem
			// 
			this.inícioToolStripMenuItem.Name = "inícioToolStripMenuItem";
			this.inícioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.inícioToolStripMenuItem.Text = "Início";
			this.inícioToolStripMenuItem.Click += new System.EventHandler(this.telaInicio);
			// 
			// tarefaDiaToolStripMenuItem
			// 
			this.tarefaDiaToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.tarefaDiaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.tarefaDiaToolStripMenuItem.Name = "tarefaDiaToolStripMenuItem";
			this.tarefaDiaToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
			this.tarefaDiaToolStripMenuItem.Text = "TarefaDia";
			// 
			// TarefaDia
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(907, 576);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.labelTarefaDia);
			this.Controls.Add(this.menuStrip1);
			this.MinimumSize = new System.Drawing.Size(923, 615);
			this.Name = "TarefaDia";
			this.Text = "Minhas Tarefas";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem nToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tarefasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.Label labelTarefaDia;
		private System.Windows.Forms.ToolStripMenuItem inícioToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tarefaDiaToolStripMenuItem;
	}
}