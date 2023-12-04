using System;
using System.Collections;
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
	public partial class TarefaDia : Form
	{
		ArrayList idsTarefas = new ArrayList();

		public TarefaDia()
		{
			InitializeComponent();
		}


		public void setDiaDaSemana(int diaDaSemana)
		{	
			MySqlConnections mySqlConnections = new MySqlConnections();

			switch(diaDaSemana)
			{
				case 1:
					labelTarefaDia.Text = "Domingo";
					tarefaDiaToolStripMenuItem.Text = "Domingo";
					dataGridView.DataSource = criaGridDia(mySqlConnections,diaDaSemana);
					break;

				case 2:
					labelTarefaDia.Text = "Segunda-feira";
					tarefaDiaToolStripMenuItem.Text = "Segunda-feira";
					dataGridView.DataSource = criaGridDia(mySqlConnections, diaDaSemana);
					break;

				case 3:
					labelTarefaDia.Text = "Terça-feira";
					tarefaDiaToolStripMenuItem.Text = "Terça-feira";
					dataGridView.DataSource = criaGridDia(mySqlConnections, diaDaSemana);
					break;

				case 4:
					labelTarefaDia.Text = "Quarta-feira";
					tarefaDiaToolStripMenuItem.Text = "Quarta-feira";
					dataGridView.DataSource = criaGridDia(mySqlConnections, diaDaSemana);
					break;

				case 5:
					labelTarefaDia.Text = "Quinta-feira";
					tarefaDiaToolStripMenuItem.Text = "Quinta-feira";
					dataGridView.DataSource = criaGridDia(mySqlConnections, diaDaSemana);
					break;

				case 6:
					labelTarefaDia.Text = "Sexta-feira";
					tarefaDiaToolStripMenuItem.Text = "Sexta-feira";
					dataGridView.DataSource = criaGridDia(mySqlConnections, diaDaSemana);
					break;

				case 7:
					labelTarefaDia.Text = "Sábado";
					tarefaDiaToolStripMenuItem.Text = "Sábado-feira";
					dataGridView.DataSource = criaGridDia(mySqlConnections, diaDaSemana);
					break;
				default: break;

			}
		}

		private DataTable criaGridDia(MySqlConnections mySqlConnections, int dia)
		{
			List<Tarefa> listaTarefas = new List<Tarefa>();
			listaTarefas = mySqlConnections.listarTarefa(mySqlConnections.obterConexaoBanco(), dia);

			DataTable dt = new DataTable();
			dt.Columns.Add("Tarefas", typeof(string));

			foreach (Tarefa tarefa in listaTarefas)
			{
				//dt.Rows.Add(tarefa.getNomeTarefa(), tarefa.getHorario());
				dt.Rows.Add("Título da Tarefa: " + tarefa.getNomeTarefa() + tarefa.getStatusText(tarefa.getStatus()) +
					"\nHorário: " + tarefa.getHorario() +
					"\nObservação: " + tarefa.getObsTarefa() +
					"\nTarefa Semanal: " + tarefa.getStringSemanal() +
					"\nPomodoro Ativado: " + tarefa.getStringPomodoro());
				
				idsTarefas.Add(tarefa.getIdTarefa());

			}

			return dt;
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

		private void alterarTarefa(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
			{

				AlterarTarefa alterarTarefa = new AlterarTarefa(Convert.ToInt32(idsTarefas[e.RowIndex]));
				alterarTarefa.StartPosition = FormStartPosition.Manual;
				alterarTarefa.Location = this.Location;
				this.Hide();
				alterarTarefa.ShowDialog();
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
	}
	}
