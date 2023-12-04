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
	public partial class AlterarTarefa : Form
	{
		private Tarefa tarefa = new Tarefa();
		private MySqlConnections mySqlConnections = new MySqlConnections();
		private int id;

		TimerControl timerControl;

		public AlterarTarefa()
		{
			InitializeComponent();
		}

		public AlterarTarefa(int idTarefa) 
		{	// Resgata os dados do banco e os disponibiliza nos campos para alteração
			InitializeComponent();

			id = idTarefa;
			tarefa = mySqlConnections.getTarefaById(mySqlConnections.obterConexaoBanco(), idTarefa);

			textBoxNomeTarefa.Text = tarefa.getNomeTarefa();
			timePicker.Text = tarefa.getHorario();
			textBoxObs.Text = tarefa.getObsTarefa();
			comboBoxDiaSemana.Text = tarefa.getDiaDaSemanaNome();
			checkBoxSemanal.Checked = (tarefa.getRepeteSemanal() == 1) ? checkBoxSemanal.Checked = true : checkBoxSemanal.Checked = false;
			checkBoxPomodoro.Checked = (tarefa.getAtivaPomodoro() == 1) ? checkBoxPomodoro.Checked = true : checkBoxPomodoro.Checked = false;
		}

		private void salvarAlteracao(object sender, EventArgs e)// Atribuida ao botão Salvar
		{
			if (tarefa.getStatus() == 1)
			{
				MessageBox.Show("Não é possível alterar uma tarefa em andamento.");
			}
			else if ((tarefa.getStatus()) == 2 && (tarefa.getRepeteSemanal() == 0))
			{
				MessageBox.Show("Não é possível alterar uma tarefa concluída e não repetível.");
			}

			else if((tarefa.getStatus() == 0) || ((tarefa.getStatus() == 2) && (tarefa.getRepeteSemanal() == 1))   ){
				string nomeTarefa = textBoxNomeTarefa.Text;
				string observacao = textBoxObs.Text;
				string horario = timePicker.Text;
				int diaDaSemana;

				//Atribui o valor ao diaDaSemana dependendo da opção selecionada no comboBox
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

				tarefa.atualizaTarefa(nomeTarefa, observacao, horario, diaDaSemana, repeteSemanal, ativaPomodoro);

				if (nomeTarefa.Length == 0 || comboBoxDiaSemana.Text.Length == 0)
				{
					MessageBox.Show("Preencha os campos obrigatórios!");
				}
				//Else: Chama a função de atualizar do MySqlConnections e envia a tarefa
				else
				{
					mySqlConnections.atualizaTarefa(mySqlConnections.obterConexaoBanco(), tarefa);

					textBoxNomeTarefa.Text = "";
					textBoxObs.Text = "";
					timePicker.Text = "00:00";
					comboBoxDiaSemana.Text = "";
					checkBoxSemanal.Checked = false;
					checkBoxPomodoro.Checked = false;

					MessageBox.Show("Tarefa atualizada com sucesso!");

					Tarefas tarefas = new Tarefas();
					tarefas.StartPosition = FormStartPosition.Manual;
					tarefas.Location = this.Location;
					this.Hide();
					tarefas.ShowDialog();

				} 
			}

		}

		private void concluirTarefa(object sender, EventArgs e) // Atribuída ao botão concluir
		{
			if (tarefa.getStatus() == 1) // Se a tarefa selecionada estiver em andamento
			{
				mySqlConnections.concluirTarefa(mySqlConnections.obterConexaoBanco(), id);

				if (tarefa.getAtivaPomodoro() == 1) // Se tiver marcada opção de pomodoro
				{
					//PARAR POMODORO
					timerControl = TimerControl.GetInstance();
					timerControl.PararPomodoro();
				}

				MessageBox.Show("Tarefa Concluída!!");

				Tarefas tarefas = new Tarefas();
				tarefas.StartPosition = FormStartPosition.Manual;
				tarefas.Location = this.Location;
				this.Hide();
				tarefas.ShowDialog();
			}
			else if(tarefa.getStatus() == 0) // Se estiver com status A fazer
			{
				MessageBox.Show("Inicie a tarefa primeiro.");
			}

			else if (tarefa.getStatus() == 2) // Se estiver concluída
			{
				MessageBox.Show("Tarefa já concluída.");
			}
		}



		private void iniciarTarefa(object sender, EventArgs e) // Atribuída ao botão Iniciar
		{
			if (mySqlConnections.verificaAndamento(mySqlConnections.obterConexaoBanco()) >= 1)
			{
				MessageBox.Show("Já existe uma tarefa em andamento.");
			}
			else
			{
				if (tarefa.getStatus() == 0) // Se estiver com status A fazer
				{
					mySqlConnections.iniciarTarefa(mySqlConnections.obterConexaoBanco(), id);

					if (tarefa.getAtivaPomodoro() == 1) // Se houver marcado a opção de Pomodoro
					{
						//ATIVAR POMODORO
						timerControl = TimerControl.GetInstance();
						timerControl.IniciarPomodoro();
					}

					MessageBox.Show("Tarefa Iniciada!!");

					Tarefas tarefas = new Tarefas();
					tarefas.StartPosition = FormStartPosition.Manual;
					tarefas.Location = this.Location;
					this.Hide();
					tarefas.ShowDialog();
				}
				else if (tarefa.getStatus() == 1)
				{
					MessageBox.Show("Tarefa já está em andamento.");
				}

				else if (tarefa.getStatus() == 2)
				{
					MessageBox.Show("Não é possível iniciar uma tarefa já concluída.");
				}
			}
		}

		private void excluirTarefa(object sender, EventArgs e) // Atribuída ao botão excluir
		{
			if (tarefa.getStatus() == 1)
			{
				MessageBox.Show("Tarefa em andamento, necessário concluir para que possa ser deletada.");
			}

			else
			{

				DialogResult resultado = MessageBox.Show("Confirmar exclusão da Tarefa: " + tarefa.getNomeTarefa() + "?", 
					"Excluir Tarefa", MessageBoxButtons.YesNo);
				if (resultado == DialogResult.Yes)
				{
					mySqlConnections.excluirTarefa(mySqlConnections.obterConexaoBanco(), tarefa.getIdTarefa());
					MessageBox.Show("Tarefa excluída com sucesso!");

					Tarefas tarefas = new Tarefas();
					tarefas.StartPosition = FormStartPosition.Manual;
					tarefas.Location = this.Location;
					this.Hide();
					tarefas.ShowDialog();
				}
				else
				{
					MessageBox.Show("Ok!");
				}
			}	
		}

		private void telaInicio(object sender, EventArgs e)
		{
			Form1 form = new Form1();
			form.StartPosition = FormStartPosition.Manual;
			form.Location = this.Location;
			this.Hide();
			form.ShowDialog();

		}


		private void novaTarefa(object sender, EventArgs e)
		{
			NovaTarefa novaTarefa = new NovaTarefa();
			novaTarefa.StartPosition = FormStartPosition.Manual;
			novaTarefa.Location = this.Location;
			this.Hide();
			novaTarefa.ShowDialog();
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


	}
}
