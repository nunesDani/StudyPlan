namespace Organizador
{
	partial class NovaTarefa
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
			this.labelNovaTarefa = new System.Windows.Forms.Label();
			this.labelNomeTarefa = new System.Windows.Forms.Label();
			this.textBoxNomeTarefa = new System.Windows.Forms.TextBox();
			this.labelHorario = new System.Windows.Forms.Label();
			this.labelDiaDaSemana = new System.Windows.Forms.Label();
			this.checkBoxSemanal = new System.Windows.Forms.CheckBox();
			this.checkBoxPomodoro = new System.Windows.Forms.CheckBox();
			this.buttonSalvar = new System.Windows.Forms.Button();
			this.comboBoxDiaSemana = new System.Windows.Forms.ComboBox();
			this.timePicker = new System.Windows.Forms.DateTimePicker();
			this.textBoxObs = new System.Windows.Forms.TextBox();
			this.labelObs = new System.Windows.Forms.Label();
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
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
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
			this.novaTarefaToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.novaTarefaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.novaTarefaToolStripMenuItem.Name = "novaTarefaToolStripMenuItem";
			this.novaTarefaToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
			this.novaTarefaToolStripMenuItem.Text = "Nova Tarefa";
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
			// labelNovaTarefa
			// 
			this.labelNovaTarefa.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelNovaTarefa.AutoSize = true;
			this.labelNovaTarefa.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNovaTarefa.Location = new System.Drawing.Point(322, 51);
			this.labelNovaTarefa.Name = "labelNovaTarefa";
			this.labelNovaTarefa.Size = new System.Drawing.Size(170, 32);
			this.labelNovaTarefa.TabIndex = 1;
			this.labelNovaTarefa.Text = "Nova Tarefa";
			// 
			// labelNomeTarefa
			// 
			this.labelNomeTarefa.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelNomeTarefa.AutoSize = true;
			this.labelNomeTarefa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNomeTarefa.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelNomeTarefa.Location = new System.Drawing.Point(179, 117);
			this.labelNomeTarefa.Name = "labelNomeTarefa";
			this.labelNomeTarefa.Size = new System.Drawing.Size(176, 25);
			this.labelNomeTarefa.TabIndex = 2;
			this.labelNomeTarefa.Text = "*Nome da Tarefa";
			this.labelNomeTarefa.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// textBoxNomeTarefa
			// 
			this.textBoxNomeTarefa.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textBoxNomeTarefa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxNomeTarefa.Location = new System.Drawing.Point(408, 114);
			this.textBoxNomeTarefa.Name = "textBoxNomeTarefa";
			this.textBoxNomeTarefa.Size = new System.Drawing.Size(211, 30);
			this.textBoxNomeTarefa.TabIndex = 3;
			// 
			// labelHorario
			// 
			this.labelHorario.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelHorario.AutoSize = true;
			this.labelHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelHorario.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelHorario.Location = new System.Drawing.Point(273, 191);
			this.labelHorario.Name = "labelHorario";
			this.labelHorario.Size = new System.Drawing.Size(82, 25);
			this.labelHorario.TabIndex = 4;
			this.labelHorario.Text = "Horário";
			// 
			// labelDiaDaSemana
			// 
			this.labelDiaDaSemana.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelDiaDaSemana.AutoSize = true;
			this.labelDiaDaSemana.BackColor = System.Drawing.Color.Transparent;
			this.labelDiaDaSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDiaDaSemana.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelDiaDaSemana.Location = new System.Drawing.Point(186, 224);
			this.labelDiaDaSemana.Name = "labelDiaDaSemana";
			this.labelDiaDaSemana.Size = new System.Drawing.Size(169, 25);
			this.labelDiaDaSemana.TabIndex = 6;
			this.labelDiaDaSemana.Text = "*Dia da Semana";
			// 
			// checkBoxSemanal
			// 
			this.checkBoxSemanal.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.checkBoxSemanal.AutoSize = true;
			this.checkBoxSemanal.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxSemanal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBoxSemanal.Location = new System.Drawing.Point(125, 260);
			this.checkBoxSemanal.Name = "checkBoxSemanal";
			this.checkBoxSemanal.Size = new System.Drawing.Size(297, 29);
			this.checkBoxSemanal.TabIndex = 10;
			this.checkBoxSemanal.Text = "Repetir Semanalmente        ";
			this.checkBoxSemanal.UseVisualStyleBackColor = true;
			// 
			// checkBoxPomodoro
			// 
			this.checkBoxPomodoro.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.checkBoxPomodoro.AutoSize = true;
			this.checkBoxPomodoro.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxPomodoro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBoxPomodoro.Location = new System.Drawing.Point(167, 295);
			this.checkBoxPomodoro.Name = "checkBoxPomodoro";
			this.checkBoxPomodoro.Size = new System.Drawing.Size(255, 29);
			this.checkBoxPomodoro.TabIndex = 11;
			this.checkBoxPomodoro.Text = "Método Pomodoro        ";
			this.checkBoxPomodoro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.checkBoxPomodoro.UseVisualStyleBackColor = true;
			// 
			// buttonSalvar
			// 
			this.buttonSalvar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonSalvar.BackColor = System.Drawing.Color.MediumSlateBlue;
			this.buttonSalvar.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
			this.buttonSalvar.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSalvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.buttonSalvar.Location = new System.Drawing.Point(309, 340);
			this.buttonSalvar.MaximumSize = new System.Drawing.Size(204, 46);
			this.buttonSalvar.MinimumSize = new System.Drawing.Size(204, 46);
			this.buttonSalvar.Name = "buttonSalvar";
			this.buttonSalvar.Size = new System.Drawing.Size(204, 46);
			this.buttonSalvar.TabIndex = 12;
			this.buttonSalvar.Text = "SALVAR";
			this.buttonSalvar.UseVisualStyleBackColor = false;
			this.buttonSalvar.Click += new System.EventHandler(this.CadastraTarefa);
			// 
			// comboBoxDiaSemana
			// 
			this.comboBoxDiaSemana.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.comboBoxDiaSemana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxDiaSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBoxDiaSemana.Items.AddRange(new object[] {
            "Domingo",
            "Segunda-feira",
            "Terça-feira",
            "Quarta-feira",
            "Quinta-feira",
            "Sexta-feira",
            "Sábado"});
			this.comboBoxDiaSemana.Location = new System.Drawing.Point(408, 222);
			this.comboBoxDiaSemana.Name = "comboBoxDiaSemana";
			this.comboBoxDiaSemana.Size = new System.Drawing.Size(211, 32);
			this.comboBoxDiaSemana.TabIndex = 13;
			// 
			// timePicker
			// 
			this.timePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.timePicker.CustomFormat = "HH:mm";
			this.timePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.timePicker.Location = new System.Drawing.Point(408, 186);
			this.timePicker.Name = "timePicker";
			this.timePicker.ShowUpDown = true;
			this.timePicker.Size = new System.Drawing.Size(211, 30);
			this.timePicker.TabIndex = 14;
			// 
			// textBoxObs
			// 
			this.textBoxObs.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textBoxObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxObs.Location = new System.Drawing.Point(408, 150);
			this.textBoxObs.Name = "textBoxObs";
			this.textBoxObs.Size = new System.Drawing.Size(211, 30);
			this.textBoxObs.TabIndex = 16;
			// 
			// labelObs
			// 
			this.labelObs.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelObs.AutoSize = true;
			this.labelObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelObs.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelObs.Location = new System.Drawing.Point(215, 153);
			this.labelObs.Name = "labelObs";
			this.labelObs.Size = new System.Drawing.Size(140, 25);
			this.labelObs.TabIndex = 15;
			this.labelObs.Text = "Observações";
			// 
			// NovaTarefa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.textBoxObs);
			this.Controls.Add(this.labelObs);
			this.Controls.Add(this.timePicker);
			this.Controls.Add(this.comboBoxDiaSemana);
			this.Controls.Add(this.buttonSalvar);
			this.Controls.Add(this.checkBoxPomodoro);
			this.Controls.Add(this.checkBoxSemanal);
			this.Controls.Add(this.labelDiaDaSemana);
			this.Controls.Add(this.labelHorario);
			this.Controls.Add(this.textBoxNomeTarefa);
			this.Controls.Add(this.labelNomeTarefa);
			this.Controls.Add(this.labelNovaTarefa);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new System.Drawing.Size(655, 489);
			this.Name = "NovaTarefa";
			this.Text = "NovaTarefa";
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
		private System.Windows.Forms.Label labelNovaTarefa;
		private System.Windows.Forms.Label labelNomeTarefa;
		private System.Windows.Forms.TextBox textBoxNomeTarefa;
		private System.Windows.Forms.Label labelHorario;
		private System.Windows.Forms.Label labelDiaDaSemana;
		private System.Windows.Forms.CheckBox checkBoxSemanal;
		private System.Windows.Forms.CheckBox checkBoxPomodoro;
		private System.Windows.Forms.Button buttonSalvar;
		private System.Windows.Forms.ComboBox comboBoxDiaSemana;
		private System.Windows.Forms.DateTimePicker timePicker;
		private System.Windows.Forms.TextBox textBoxObs;
		private System.Windows.Forms.Label labelObs;
		private System.Windows.Forms.ToolStripMenuItem inícioToolStripMenuItem;
	}
}