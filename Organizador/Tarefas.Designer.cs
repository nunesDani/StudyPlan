namespace Organizador
{
	partial class Tarefas
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
			this.nToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tarefasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.labelNovaTarefa = new System.Windows.Forms.Label();
			this.dataGridViewQua = new System.Windows.Forms.DataGridView();
			this.dataGridViewQui = new System.Windows.Forms.DataGridView();
			this.dataGridViewSex = new System.Windows.Forms.DataGridView();
			this.dataGridViewSab = new System.Windows.Forms.DataGridView();
			this.dataGridViewTer = new System.Windows.Forms.DataGridView();
			this.dataGridViewSeg = new System.Windows.Forms.DataGridView();
			this.dataGridViewDom = new System.Windows.Forms.DataGridView();
			this.labelDom = new System.Windows.Forms.Label();
			this.labelSeg = new System.Windows.Forms.Label();
			this.labelTer = new System.Windows.Forms.Label();
			this.labelQua = new System.Windows.Forms.Label();
			this.labelQui = new System.Windows.Forms.Label();
			this.labelSex = new System.Windows.Forms.Label();
			this.labelSab = new System.Windows.Forms.Label();
			this.labelTeste = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonIniciar = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewQua)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewQui)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewSex)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewSab)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTer)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeg)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDom)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inícioToolStripMenuItem,
            this.nToolStripMenuItem,
            this.tarefasToolStripMenuItem,
            this.configToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1350, 24);
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
			// nToolStripMenuItem
			// 
			this.nToolStripMenuItem.Name = "nToolStripMenuItem";
			this.nToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
			this.nToolStripMenuItem.Text = "Nova Tarefa";
			this.nToolStripMenuItem.Click += new System.EventHandler(this.novaTarefa);
			// 
			// tarefasToolStripMenuItem
			// 
			this.tarefasToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.tarefasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.tarefasToolStripMenuItem.Name = "tarefasToolStripMenuItem";
			this.tarefasToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
			this.tarefasToolStripMenuItem.Text = "Tarefas";
			// 
			// configToolStripMenuItem
			// 
			this.configToolStripMenuItem.Name = "configToolStripMenuItem";
			this.configToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
			this.configToolStripMenuItem.Text = "Config";
			this.configToolStripMenuItem.Click += new System.EventHandler(this.visualizaConfig);
			// 
			// labelNovaTarefa
			// 
			this.labelNovaTarefa.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelNovaTarefa.AutoSize = true;
			this.labelNovaTarefa.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNovaTarefa.Location = new System.Drawing.Point(579, 66);
			this.labelNovaTarefa.Name = "labelNovaTarefa";
			this.labelNovaTarefa.Size = new System.Drawing.Size(211, 32);
			this.labelNovaTarefa.TabIndex = 2;
			this.labelNovaTarefa.Text = "Minhas Tarefas";
			this.labelNovaTarefa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dataGridViewQua
			// 
			this.dataGridViewQua.AllowUserToAddRows = false;
			this.dataGridViewQua.AllowUserToDeleteRows = false;
			this.dataGridViewQua.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dataGridViewQua.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
			this.dataGridViewQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewQua.Location = new System.Drawing.Point(588, 172);
			this.dataGridViewQua.Name = "dataGridViewQua";
			this.dataGridViewQua.RowHeadersVisible = false;
			this.dataGridViewQua.Size = new System.Drawing.Size(178, 369);
			this.dataGridViewQua.TabIndex = 1;
			this.dataGridViewQua.Click += new System.EventHandler(this.tarefasQua);
			// 
			// dataGridViewQui
			// 
			this.dataGridViewQui.AllowUserToAddRows = false;
			this.dataGridViewQui.AllowUserToDeleteRows = false;
			this.dataGridViewQui.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dataGridViewQui.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
			this.dataGridViewQui.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewQui.Location = new System.Drawing.Point(777, 172);
			this.dataGridViewQui.Name = "dataGridViewQui";
			this.dataGridViewQui.RowHeadersVisible = false;
			this.dataGridViewQui.Size = new System.Drawing.Size(178, 369);
			this.dataGridViewQui.TabIndex = 3;
			this.dataGridViewQui.Click += new System.EventHandler(this.tarefasQui);
			// 
			// dataGridViewSex
			// 
			this.dataGridViewSex.AllowUserToAddRows = false;
			this.dataGridViewSex.AllowUserToDeleteRows = false;
			this.dataGridViewSex.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dataGridViewSex.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
			this.dataGridViewSex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewSex.Location = new System.Drawing.Point(966, 172);
			this.dataGridViewSex.Name = "dataGridViewSex";
			this.dataGridViewSex.RowHeadersVisible = false;
			this.dataGridViewSex.Size = new System.Drawing.Size(178, 369);
			this.dataGridViewSex.TabIndex = 4;
			this.dataGridViewSex.Click += new System.EventHandler(this.tarefasSex);
			// 
			// dataGridViewSab
			// 
			this.dataGridViewSab.AllowUserToAddRows = false;
			this.dataGridViewSab.AllowUserToDeleteRows = false;
			this.dataGridViewSab.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dataGridViewSab.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
			this.dataGridViewSab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewSab.Location = new System.Drawing.Point(1155, 172);
			this.dataGridViewSab.Name = "dataGridViewSab";
			this.dataGridViewSab.RowHeadersVisible = false;
			this.dataGridViewSab.Size = new System.Drawing.Size(178, 369);
			this.dataGridViewSab.TabIndex = 5;
			this.dataGridViewSab.Click += new System.EventHandler(this.tarefasSab);
			// 
			// dataGridViewTer
			// 
			this.dataGridViewTer.AllowUserToAddRows = false;
			this.dataGridViewTer.AllowUserToDeleteRows = false;
			this.dataGridViewTer.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dataGridViewTer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
			this.dataGridViewTer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewTer.Location = new System.Drawing.Point(399, 172);
			this.dataGridViewTer.Name = "dataGridViewTer";
			this.dataGridViewTer.RowHeadersVisible = false;
			this.dataGridViewTer.Size = new System.Drawing.Size(178, 369);
			this.dataGridViewTer.TabIndex = 6;
			this.dataGridViewTer.Click += new System.EventHandler(this.tarefasTer);
			// 
			// dataGridViewSeg
			// 
			this.dataGridViewSeg.AllowUserToAddRows = false;
			this.dataGridViewSeg.AllowUserToDeleteRows = false;
			this.dataGridViewSeg.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dataGridViewSeg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
			this.dataGridViewSeg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewSeg.Location = new System.Drawing.Point(210, 172);
			this.dataGridViewSeg.Name = "dataGridViewSeg";
			this.dataGridViewSeg.RowHeadersVisible = false;
			this.dataGridViewSeg.Size = new System.Drawing.Size(178, 369);
			this.dataGridViewSeg.TabIndex = 7;
			this.dataGridViewSeg.Click += new System.EventHandler(this.tarefasSeg);
			// 
			// dataGridViewDom
			// 
			this.dataGridViewDom.AllowUserToAddRows = false;
			this.dataGridViewDom.AllowUserToDeleteRows = false;
			this.dataGridViewDom.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dataGridViewDom.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
			this.dataGridViewDom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewDom.Location = new System.Drawing.Point(21, 172);
			this.dataGridViewDom.Name = "dataGridViewDom";
			this.dataGridViewDom.RowHeadersVisible = false;
			this.dataGridViewDom.Size = new System.Drawing.Size(178, 369);
			this.dataGridViewDom.TabIndex = 8;
			this.dataGridViewDom.Click += new System.EventHandler(this.tarefasDom);
			// 
			// labelDom
			// 
			this.labelDom.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelDom.AutoSize = true;
			this.labelDom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDom.Location = new System.Drawing.Point(70, 137);
			this.labelDom.Name = "labelDom";
			this.labelDom.Size = new System.Drawing.Size(80, 20);
			this.labelDom.TabIndex = 9;
			this.labelDom.Text = "Domingo";
			this.labelDom.Click += new System.EventHandler(this.tarefasDom);
			// 
			// labelSeg
			// 
			this.labelSeg.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelSeg.AutoSize = true;
			this.labelSeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelSeg.Location = new System.Drawing.Point(237, 137);
			this.labelSeg.Name = "labelSeg";
			this.labelSeg.Size = new System.Drawing.Size(123, 20);
			this.labelSeg.TabIndex = 10;
			this.labelSeg.Text = "Segunda-feira";
			this.labelSeg.Click += new System.EventHandler(this.tarefasSeg);
			// 
			// labelTer
			// 
			this.labelTer.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelTer.AutoSize = true;
			this.labelTer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTer.Location = new System.Drawing.Point(442, 137);
			this.labelTer.Name = "labelTer";
			this.labelTer.Size = new System.Drawing.Size(96, 20);
			this.labelTer.TabIndex = 11;
			this.labelTer.Text = "Terça-feira";
			this.labelTer.Click += new System.EventHandler(this.tarefasTer);
			// 
			// labelQua
			// 
			this.labelQua.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelQua.AutoSize = true;
			this.labelQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelQua.Location = new System.Drawing.Point(629, 137);
			this.labelQua.Name = "labelQua";
			this.labelQua.Size = new System.Drawing.Size(106, 20);
			this.labelQua.TabIndex = 12;
			this.labelQua.Text = "Quarta-feira";
			this.labelQua.Click += new System.EventHandler(this.tarefasQua);
			// 
			// labelQui
			// 
			this.labelQui.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelQui.AutoSize = true;
			this.labelQui.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelQui.Location = new System.Drawing.Point(818, 137);
			this.labelQui.Name = "labelQui";
			this.labelQui.Size = new System.Drawing.Size(104, 20);
			this.labelQui.TabIndex = 13;
			this.labelQui.Text = "Quinta-feira";
			this.labelQui.Click += new System.EventHandler(this.tarefasQui);
			// 
			// labelSex
			// 
			this.labelSex.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelSex.AutoSize = true;
			this.labelSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelSex.Location = new System.Drawing.Point(1010, 137);
			this.labelSex.Name = "labelSex";
			this.labelSex.Size = new System.Drawing.Size(97, 20);
			this.labelSex.TabIndex = 14;
			this.labelSex.Text = "Sexta-feira";
			this.labelSex.Click += new System.EventHandler(this.tarefasSex);
			// 
			// labelSab
			// 
			this.labelSab.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelSab.AutoSize = true;
			this.labelSab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelSab.Location = new System.Drawing.Point(1215, 137);
			this.labelSab.Name = "labelSab";
			this.labelSab.Size = new System.Drawing.Size(71, 20);
			this.labelSab.TabIndex = 15;
			this.labelSab.Text = "Sábado";
			this.labelSab.Click += new System.EventHandler(this.tarefasSab);
			// 
			// labelTeste
			// 
			this.labelTeste.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelTeste.AutoSize = true;
			this.labelTeste.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTeste.Location = new System.Drawing.Point(1197, 63);
			this.labelTeste.Name = "labelTeste";
			this.labelTeste.Size = new System.Drawing.Size(64, 18);
			this.labelTeste.TabIndex = 17;
			this.labelTeste.Text = "INATIVO";
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(1083, 63);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(108, 19);
			this.label1.TabIndex = 18;
			this.label1.Text = "POMODORO:";
			// 
			// buttonIniciar
			// 
			this.buttonIniciar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonIniciar.BackColor = System.Drawing.Color.CadetBlue;
			this.buttonIniciar.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
			this.buttonIniciar.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonIniciar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.buttonIniciar.Location = new System.Drawing.Point(1112, 84);
			this.buttonIniciar.MaximumSize = new System.Drawing.Size(204, 46);
			this.buttonIniciar.MinimumSize = new System.Drawing.Size(80, 30);
			this.buttonIniciar.Name = "buttonIniciar";
			this.buttonIniciar.Size = new System.Drawing.Size(111, 30);
			this.buttonIniciar.TabIndex = 33;
			this.buttonIniciar.Text = "REINICIAR";
			this.buttonIniciar.UseVisualStyleBackColor = false;
			this.buttonIniciar.Click += new System.EventHandler(this.restartPomodoro);
			// 
			// Tarefas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1350, 586);
			this.Controls.Add(this.buttonIniciar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.labelTeste);
			this.Controls.Add(this.labelSab);
			this.Controls.Add(this.labelSex);
			this.Controls.Add(this.labelQui);
			this.Controls.Add(this.labelQua);
			this.Controls.Add(this.labelTer);
			this.Controls.Add(this.labelSeg);
			this.Controls.Add(this.labelDom);
			this.Controls.Add(this.dataGridViewDom);
			this.Controls.Add(this.dataGridViewSeg);
			this.Controls.Add(this.dataGridViewTer);
			this.Controls.Add(this.dataGridViewSab);
			this.Controls.Add(this.dataGridViewSex);
			this.Controls.Add(this.dataGridViewQui);
			this.Controls.Add(this.labelNovaTarefa);
			this.Controls.Add(this.dataGridViewQua);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new System.Drawing.Size(1347, 545);
			this.Name = "Tarefas";
			this.Text = "Tarefas";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.carregarTarefas);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewQua)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewQui)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewSex)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewSab)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTer)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeg)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDom)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem nToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tarefasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
		private System.Windows.Forms.Label labelNovaTarefa;
		private System.Windows.Forms.DataGridView dataGridViewQua;
		private System.Windows.Forms.DataGridView dataGridViewQui;
		private System.Windows.Forms.DataGridView dataGridViewSex;
		private System.Windows.Forms.DataGridView dataGridViewSab;
		private System.Windows.Forms.DataGridView dataGridViewTer;
		private System.Windows.Forms.DataGridView dataGridViewSeg;
		private System.Windows.Forms.DataGridView dataGridViewDom;
		private System.Windows.Forms.Label labelDom;
		private System.Windows.Forms.Label labelSeg;
		private System.Windows.Forms.Label labelTer;
		private System.Windows.Forms.Label labelQua;
		private System.Windows.Forms.Label labelQui;
		private System.Windows.Forms.Label labelSex;
		private System.Windows.Forms.Label labelSab;
		private System.Windows.Forms.ToolStripMenuItem inícioToolStripMenuItem;
		private System.Windows.Forms.Label labelTeste;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonIniciar;
	}
}