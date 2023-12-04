namespace Organizador
{
	partial class AlterarTarefa
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
			this.buttonSalvar = new System.Windows.Forms.Button();
			this.labelAlterarTarefa = new System.Windows.Forms.Label();
			this.buttonExcluir = new System.Windows.Forms.Button();
			this.labelNomeTarefa = new System.Windows.Forms.Label();
			this.textBoxNomeTarefa = new System.Windows.Forms.TextBox();
			this.labelHorario = new System.Windows.Forms.Label();
			this.labelDiaDaSemana = new System.Windows.Forms.Label();
			this.checkBoxSemanal = new System.Windows.Forms.CheckBox();
			this.checkBoxPomodoro = new System.Windows.Forms.CheckBox();
			this.comboBoxDiaSemana = new System.Windows.Forms.ComboBox();
			this.timePicker = new System.Windows.Forms.DateTimePicker();
			this.labelObs = new System.Windows.Forms.Label();
			this.textBoxObs = new System.Windows.Forms.TextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.inícioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tarefasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.buttonConcluir = new System.Windows.Forms.Button();
			this.buttonIniciar = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonSalvar
			// 
			this.buttonSalvar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonSalvar.BackColor = System.Drawing.Color.MediumSlateBlue;
			this.buttonSalvar.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
			this.buttonSalvar.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSalvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.buttonSalvar.Location = new System.Drawing.Point(422, 349);
			this.buttonSalvar.MaximumSize = new System.Drawing.Size(204, 46);
			this.buttonSalvar.MinimumSize = new System.Drawing.Size(150, 46);
			this.buttonSalvar.Name = "buttonSalvar";
			this.buttonSalvar.Size = new System.Drawing.Size(150, 46);
			this.buttonSalvar.TabIndex = 24;
			this.buttonSalvar.Text = "SALVAR";
			this.buttonSalvar.UseVisualStyleBackColor = false;
			this.buttonSalvar.Click += new System.EventHandler(this.salvarAlteracao);
			// 
			// labelAlterarTarefa
			// 
			this.labelAlterarTarefa.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelAlterarTarefa.AutoSize = true;
			this.labelAlterarTarefa.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelAlterarTarefa.Location = new System.Drawing.Point(321, 60);
			this.labelAlterarTarefa.Name = "labelAlterarTarefa";
			this.labelAlterarTarefa.Size = new System.Drawing.Size(224, 32);
			this.labelAlterarTarefa.TabIndex = 17;
			this.labelAlterarTarefa.Text = "Modificar Tarefa";
			// 
			// buttonExcluir
			// 
			this.buttonExcluir.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonExcluir.BackColor = System.Drawing.Color.Firebrick;
			this.buttonExcluir.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
			this.buttonExcluir.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonExcluir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.buttonExcluir.Location = new System.Drawing.Point(578, 349);
			this.buttonExcluir.MaximumSize = new System.Drawing.Size(204, 46);
			this.buttonExcluir.MinimumSize = new System.Drawing.Size(150, 46);
			this.buttonExcluir.Name = "buttonExcluir";
			this.buttonExcluir.Size = new System.Drawing.Size(150, 46);
			this.buttonExcluir.TabIndex = 29;
			this.buttonExcluir.Text = "EXCLUIR";
			this.buttonExcluir.UseVisualStyleBackColor = false;
			this.buttonExcluir.Click += new System.EventHandler(this.excluirTarefa);
			// 
			// labelNomeTarefa
			// 
			this.labelNomeTarefa.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelNomeTarefa.AutoSize = true;
			this.labelNomeTarefa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNomeTarefa.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelNomeTarefa.Location = new System.Drawing.Point(178, 126);
			this.labelNomeTarefa.Name = "labelNomeTarefa";
			this.labelNomeTarefa.Size = new System.Drawing.Size(176, 25);
			this.labelNomeTarefa.TabIndex = 18;
			this.labelNomeTarefa.Text = "*Nome da Tarefa";
			this.labelNomeTarefa.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// textBoxNomeTarefa
			// 
			this.textBoxNomeTarefa.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textBoxNomeTarefa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxNomeTarefa.Location = new System.Drawing.Point(407, 123);
			this.textBoxNomeTarefa.Name = "textBoxNomeTarefa";
			this.textBoxNomeTarefa.Size = new System.Drawing.Size(211, 30);
			this.textBoxNomeTarefa.TabIndex = 19;
			// 
			// labelHorario
			// 
			this.labelHorario.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelHorario.AutoSize = true;
			this.labelHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelHorario.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelHorario.Location = new System.Drawing.Point(272, 200);
			this.labelHorario.Name = "labelHorario";
			this.labelHorario.Size = new System.Drawing.Size(82, 25);
			this.labelHorario.TabIndex = 20;
			this.labelHorario.Text = "Horário";
			// 
			// labelDiaDaSemana
			// 
			this.labelDiaDaSemana.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelDiaDaSemana.AutoSize = true;
			this.labelDiaDaSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDiaDaSemana.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelDiaDaSemana.Location = new System.Drawing.Point(185, 233);
			this.labelDiaDaSemana.Name = "labelDiaDaSemana";
			this.labelDiaDaSemana.Size = new System.Drawing.Size(169, 25);
			this.labelDiaDaSemana.TabIndex = 21;
			this.labelDiaDaSemana.Text = "*Dia da Semana";
			// 
			// checkBoxSemanal
			// 
			this.checkBoxSemanal.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.checkBoxSemanal.AutoSize = true;
			this.checkBoxSemanal.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxSemanal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBoxSemanal.Location = new System.Drawing.Point(124, 269);
			this.checkBoxSemanal.Name = "checkBoxSemanal";
			this.checkBoxSemanal.Size = new System.Drawing.Size(297, 29);
			this.checkBoxSemanal.TabIndex = 22;
			this.checkBoxSemanal.Text = "Repetir Semanalmente        ";
			this.checkBoxSemanal.UseVisualStyleBackColor = true;
			// 
			// checkBoxPomodoro
			// 
			this.checkBoxPomodoro.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.checkBoxPomodoro.AutoSize = true;
			this.checkBoxPomodoro.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxPomodoro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBoxPomodoro.Location = new System.Drawing.Point(166, 304);
			this.checkBoxPomodoro.Name = "checkBoxPomodoro";
			this.checkBoxPomodoro.Size = new System.Drawing.Size(255, 29);
			this.checkBoxPomodoro.TabIndex = 23;
			this.checkBoxPomodoro.Text = "Método Pomodoro        ";
			this.checkBoxPomodoro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.checkBoxPomodoro.UseVisualStyleBackColor = true;
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
			this.comboBoxDiaSemana.Location = new System.Drawing.Point(407, 231);
			this.comboBoxDiaSemana.Name = "comboBoxDiaSemana";
			this.comboBoxDiaSemana.Size = new System.Drawing.Size(211, 32);
			this.comboBoxDiaSemana.TabIndex = 25;
			// 
			// timePicker
			// 
			this.timePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.timePicker.CustomFormat = "HH:mm";
			this.timePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.timePicker.Location = new System.Drawing.Point(407, 195);
			this.timePicker.Name = "timePicker";
			this.timePicker.ShowUpDown = true;
			this.timePicker.Size = new System.Drawing.Size(211, 30);
			this.timePicker.TabIndex = 26;
			// 
			// labelObs
			// 
			this.labelObs.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelObs.AutoSize = true;
			this.labelObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelObs.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelObs.Location = new System.Drawing.Point(214, 162);
			this.labelObs.Name = "labelObs";
			this.labelObs.Size = new System.Drawing.Size(140, 25);
			this.labelObs.TabIndex = 27;
			this.labelObs.Text = "Observações";
			// 
			// textBoxObs
			// 
			this.textBoxObs.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textBoxObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxObs.Location = new System.Drawing.Point(407, 159);
			this.textBoxObs.Name = "textBoxObs";
			this.textBoxObs.Size = new System.Drawing.Size(211, 30);
			this.textBoxObs.TabIndex = 28;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inícioToolStripMenuItem,
            this.nToolStripMenuItem,
            this.tarefasToolStripMenuItem,
            this.alterarToolStripMenuItem,
            this.configToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(837, 24);
			this.menuStrip1.TabIndex = 30;
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
			this.tarefasToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
			this.tarefasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.tarefasToolStripMenuItem.Name = "tarefasToolStripMenuItem";
			this.tarefasToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
			this.tarefasToolStripMenuItem.Text = "Tarefas";
			this.tarefasToolStripMenuItem.Click += new System.EventHandler(this.visualizaTarefas);
			// 
			// alterarToolStripMenuItem
			// 
			this.alterarToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.alterarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
			this.alterarToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
			this.alterarToolStripMenuItem.Text = "Alterar";
			// 
			// configToolStripMenuItem
			// 
			this.configToolStripMenuItem.Name = "configToolStripMenuItem";
			this.configToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
			this.configToolStripMenuItem.Text = "Config";
			this.configToolStripMenuItem.Click += new System.EventHandler(this.visualizaConfig);
			// 
			// buttonConcluir
			// 
			this.buttonConcluir.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonConcluir.BackColor = System.Drawing.Color.ForestGreen;
			this.buttonConcluir.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
			this.buttonConcluir.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonConcluir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.buttonConcluir.Location = new System.Drawing.Point(266, 349);
			this.buttonConcluir.MaximumSize = new System.Drawing.Size(204, 46);
			this.buttonConcluir.MinimumSize = new System.Drawing.Size(150, 46);
			this.buttonConcluir.Name = "buttonConcluir";
			this.buttonConcluir.Size = new System.Drawing.Size(150, 46);
			this.buttonConcluir.TabIndex = 31;
			this.buttonConcluir.Text = "CONCLUIR";
			this.buttonConcluir.UseVisualStyleBackColor = false;
			this.buttonConcluir.Click += new System.EventHandler(this.concluirTarefa);
			// 
			// buttonIniciar
			// 
			this.buttonIniciar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonIniciar.BackColor = System.Drawing.Color.CadetBlue;
			this.buttonIniciar.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
			this.buttonIniciar.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonIniciar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.buttonIniciar.Location = new System.Drawing.Point(110, 349);
			this.buttonIniciar.MaximumSize = new System.Drawing.Size(204, 46);
			this.buttonIniciar.MinimumSize = new System.Drawing.Size(150, 46);
			this.buttonIniciar.Name = "buttonIniciar";
			this.buttonIniciar.Size = new System.Drawing.Size(150, 46);
			this.buttonIniciar.TabIndex = 32;
			this.buttonIniciar.Text = "INICIAR";
			this.buttonIniciar.UseVisualStyleBackColor = false;
			this.buttonIniciar.Click += new System.EventHandler(this.iniciarTarefa);
			// 
			// AlterarTarefa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(837, 461);
			this.Controls.Add(this.buttonIniciar);
			this.Controls.Add(this.buttonConcluir);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.buttonExcluir);
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
			this.Controls.Add(this.labelAlterarTarefa);
			this.MinimumSize = new System.Drawing.Size(700, 500);
			this.Name = "AlterarTarefa";
			this.Text = "Modificar Tarefa";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button buttonSalvar;
		private System.Windows.Forms.Label labelAlterarTarefa;
		private System.Windows.Forms.Button buttonExcluir;
		private System.Windows.Forms.Label labelNomeTarefa;
		private System.Windows.Forms.TextBox textBoxNomeTarefa;
		private System.Windows.Forms.Label labelHorario;
		private System.Windows.Forms.Label labelDiaDaSemana;
		private System.Windows.Forms.CheckBox checkBoxSemanal;
		private System.Windows.Forms.CheckBox checkBoxPomodoro;
		private System.Windows.Forms.ComboBox comboBoxDiaSemana;
		private System.Windows.Forms.DateTimePicker timePicker;
		private System.Windows.Forms.Label labelObs;
		private System.Windows.Forms.TextBox textBoxObs;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem nToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tarefasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem inícioToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem;
		private System.Windows.Forms.Button buttonConcluir;
		private System.Windows.Forms.Button buttonIniciar;
	}
}