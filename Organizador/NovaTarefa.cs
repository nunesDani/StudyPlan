using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organizador
{
	public partial class NovaTarefa : Form
	{
		public NovaTarefa()
		{
			InitializeComponent();
		}

        private void visualizaTarefas(object sender, EventArgs e)
        {
            Tarefas tarefas = new Tarefas();
            tarefas.StartPosition = FormStartPosition.Manual;
            tarefas.Location = this.Location;
            this.Hide();
            tarefas.ShowDialog();
        }

        private void visualizaConfig(object sender, EventArgs e)
        {
            Configurações config = new Configurações();
            config.StartPosition = FormStartPosition.Manual;
            config.Location = this.Location;
            this.Hide();
            config.ShowDialog();
        }

		private void CadastraTarefa(object sender, EventArgs e)
		{

			string nomeTarefa = textBoxNomeTarefa.Text;
			string observacao = textBoxObs.Text;
			string horario = timePicker.Text;

			int diaDaSemana;

			//Atribui valor de 1 a 7 dependendo do texto no comboBox
			switch (comboBoxDiaSemana.Text)
			{
				case "Domingo":
					diaDaSemana = 1;
					break;

				case "Segunda-feira":
					diaDaSemana = 2;
					break;


				case "Terça-feira":
					diaDaSemana = 3;
					break;

				case "Quarta-feira":
					diaDaSemana = 4;
					break;

				case "Quinta-feira":
					diaDaSemana = 5;
					break;

				case "Sexta-feira":
					diaDaSemana = 6;
					break;

				case "Sábado":
					diaDaSemana = 7;
					break;

				default:
					diaDaSemana = 0;
					break;
			}

			int repeteSemanal = checkBoxSemanal.Checked ? 1 : 0;
			int ativaPomodoro = checkBoxPomodoro.Checked ? 1 : 0;


			if (nomeTarefa.Length == 0 || comboBoxDiaSemana.Text.Length == 0)
			{
				MessageBox.Show("Preencha os campos obrigatórios!");
			}

			else
			{
				Tarefa tarefa = new Tarefa(nomeTarefa, observacao, horario, diaDaSemana,repeteSemanal,ativaPomodoro);

				MySqlConnections mySqlConnections = new MySqlConnections();

				mySqlConnections.novaTarefa(mySqlConnections.obterConexaoBanco(), tarefa);


				textBoxNomeTarefa.Text = "";
				textBoxObs.Text = "";
				timePicker.Text = "00:00";
				comboBoxDiaSemana.Text = "";
				checkBoxSemanal.Checked = false;
				checkBoxPomodoro.Checked = false;

				MessageBox.Show("Tarefa criada com sucesso!");
				
			}
			//Envia a tarefa para a classe MySqlConnections, onde a tarefa é adicionada ao banco
			// e limpa os dados da tela

		}

		private void telaInicio(object sender, EventArgs e)
		{
			Form1 form = new Form1();
			form.StartPosition = FormStartPosition.Manual;
			form.Location = this.Location;
			this.Hide();
			form.ShowDialog();

		}
	}
}
