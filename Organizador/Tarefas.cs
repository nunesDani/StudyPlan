using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organizador
{
	public partial class Tarefas : Form
	{
		private static Timer labelUpdate;
		TimerControl timerControl;
		MySqlConnections mySqlConnections = new MySqlConnections();

		public Tarefas()
		{
			InitializeComponent();
			
			timerControl = TimerControl.GetInstance();
			
			labelUpdate = new Timer();
			labelUpdate.Interval = 1000;
			labelUpdate.Tick += Timer_Tick;
			labelUpdate.Start();
		}

		public static void StartUpdate()
		{
			labelUpdate.Start();
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			labelTeste.Text = timerControl.atualizaLabel();
		}

		private void novaTarefa(object sender, EventArgs e)
		{
			NovaTarefa novaTarefa = new NovaTarefa();
			novaTarefa.StartPosition = FormStartPosition.Manual;
			novaTarefa.Location = this.Location;
			this.Hide();
			novaTarefa.ShowDialog();
		}

		private void visualizaConfig(object sender, EventArgs e)
		{
			Configurações config = new Configurações();
			config.StartPosition = FormStartPosition.Manual;
			config.Location = this.Location;
			this.Hide();
			config.ShowDialog();
		}

		private void carregarTarefas(object sender, EventArgs e) // Chamado no Load do formulário
		{

			dataGridViewDom.DataSource = criaGridDia(mySqlConnections, 1);
			dataGridViewSeg.DataSource = criaGridDia(mySqlConnections, 2);
			dataGridViewTer.DataSource = criaGridDia(mySqlConnections, 3);
			dataGridViewQua.DataSource = criaGridDia(mySqlConnections, 4);
			dataGridViewQui.DataSource = criaGridDia(mySqlConnections, 5);
			dataGridViewSex.DataSource = criaGridDia(mySqlConnections, 6);
			dataGridViewSab.DataSource = criaGridDia(mySqlConnections, 7);

		}

		private DataTable criaGridDia(MySqlConnections mySqlConnections, int dia)
		{
			List<Tarefa> listaTarefas = new List<Tarefa>();
			listaTarefas = mySqlConnections.listarTarefa(mySqlConnections.obterConexaoBanco(), dia);

			DataTable dt = new DataTable();
			dt.Columns.Add("Nome da Tarefa", typeof(string));
			dt.Columns.Add("Horario", typeof(string));

			foreach (Tarefa tarefa in listaTarefas)
			{
				dt.Rows.Add(tarefa.getNomeTarefa(), tarefa.getHorario());
			}

			return dt;
		}

		private void tarefasDom(object sender, EventArgs e)
		{
			TarefaDia tarefaDia = new TarefaDia();
			tarefaDia.StartPosition = FormStartPosition.Manual;
			tarefaDia.Location = this.Location;
			tarefaDia.setDiaDaSemana(1);
			this.Hide();
			tarefaDia.ShowDialog();

		}

		private void tarefasSeg(object sender, EventArgs e)
		{
			TarefaDia tarefaDia = new TarefaDia();
			tarefaDia.StartPosition = FormStartPosition.Manual;
			tarefaDia.Location = this.Location;
			tarefaDia.setDiaDaSemana(2);
			this.Hide();
			tarefaDia.ShowDialog();
		}

		private void tarefasTer(object sender, EventArgs e)
		{
			TarefaDia tarefaDia = new TarefaDia();
			tarefaDia.StartPosition = FormStartPosition.Manual;
			tarefaDia.Location = this.Location;
			tarefaDia.setDiaDaSemana(3);
			this.Hide();
			tarefaDia.ShowDialog();
		}

		private void tarefasQua(object sender, EventArgs e)
		{
			TarefaDia tarefaDia = new TarefaDia();
			tarefaDia.StartPosition = FormStartPosition.Manual;
			tarefaDia.Location = this.Location;
			tarefaDia.setDiaDaSemana(4);
			this.Hide();
			tarefaDia.ShowDialog();
		}

		private void tarefasQui(object sender, EventArgs e)
		{
			TarefaDia tarefaDia = new TarefaDia();
			tarefaDia.StartPosition = FormStartPosition.Manual;
			tarefaDia.Location = this.Location;
			tarefaDia.setDiaDaSemana(5);
			this.Hide();
			tarefaDia.ShowDialog();
		}

		private void tarefasSex(object sender, EventArgs e)
		{
			TarefaDia tarefaDia = new TarefaDia();
			tarefaDia.StartPosition = FormStartPosition.Manual;
			tarefaDia.Location = this.Location;
			tarefaDia.setDiaDaSemana(6);
			this.Hide();
			tarefaDia.ShowDialog();
		}

		private void tarefasSab(object sender, EventArgs e)
		{
			TarefaDia tarefaDia = new TarefaDia();
			tarefaDia.StartPosition = FormStartPosition.Manual;
			tarefaDia.Location = this.Location;
			tarefaDia.setDiaDaSemana(7);
			this.Hide();
			tarefaDia.ShowDialog();
		}

		private void telaInicio(object sender, EventArgs e)
		{
			Form1 form = new Form1();
			form.StartPosition = FormStartPosition.Manual;
			form.Location = this.Location;	
			this.Hide();
			form.ShowDialog();

		}

		private void restartPomodoro(object sender, EventArgs e)
		{
			if (mySqlConnections.verificaAndamento(mySqlConnections.obterConexaoBanco()) >= 1) // se tiver tarefa em andamento
			{
				Tarefa tarefa = mySqlConnections.verificaTarefaAndamento(mySqlConnections.obterConexaoBanco());
				if (tarefa.getAtivaPomodoro() == 1) // verifica se essa tarefa utilizava metodo pomodoro
				{
					DialogResult resultado = MessageBox.Show("Gostaria de reiniciar o Pomodoro para a Tarefa: " + tarefa.getNomeTarefa() + "?", "Reiniciar Pomodoro", MessageBoxButtons.YesNo);
					if (resultado == DialogResult.Yes)
					{
						TimerControl timerControl;
						timerControl = TimerControl.GetInstance();
						timerControl.IniciarPomodoro();
						MessageBox.Show("Pomodoro reiniciado!");
					}
					else
					{
						MessageBox.Show("Ok, mas não se esqueça de marcar a tarefa como concluída.");
					}
				}
				else
				{
					MessageBox.Show("Não há tarefa ativa que utilize o Método Pomodoro.");
				}
			}
			else
			{
				MessageBox.Show("Não há tarefa em andamento.");
			}
		}
	}
}
