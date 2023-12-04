using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Organizador
{
	public class Tarefa
	{
		private int IdTarefa;
		private string NomeTarefa;
		private string ObsTarefa;
		private string HorarioTarefa;
		private int FkDiaDaSemana;
		private int RepeteSemanal; // 0 ou 1 - booleano para numérico
		private int AtivaPomodoro; // 0 ou 1 - booleano para numérico
		private int TarefaConcluida; // 0, 1 ou 2 - A fazer, em andamento, concluída
		private int Notificou; // 0 ou 1 - booleano para numérico
		
		public Tarefa()
		{

		}


		public Tarefa(int idTarefa, string nomeTarefa, string observacao, string horario, int diaDaSemana, 
			int repeteSemanal, int ativaPomodoro, int statusTarefa, int notificou)
		{
			//Construtor para resgatar as tarefas do banco
			this.IdTarefa = idTarefa;
			this.NomeTarefa = nomeTarefa;
			this.ObsTarefa = observacao;
			this.HorarioTarefa = horario;
			this.FkDiaDaSemana = diaDaSemana;
			this.RepeteSemanal = repeteSemanal;
			this.AtivaPomodoro = ativaPomodoro;
			this.TarefaConcluida = statusTarefa;
			this.Notificou = notificou;
		}

		public Tarefa(string nomeTarefa, string observacao, string horario, int diaDaSemana, 
			int repeteSemanal, int ativaPomodoro)
		{
			//Construtor para criar (id, tarefaConcluida e notificou tem valor default inseridos via código)
			this.NomeTarefa = nomeTarefa;
			this.ObsTarefa = observacao;
			this.HorarioTarefa = horario;
			this.FkDiaDaSemana = diaDaSemana;
			this.RepeteSemanal = repeteSemanal;
			this.AtivaPomodoro = ativaPomodoro;
		}

		public int getIdTarefa()
		{
			return this.IdTarefa;
		}

		public void setIdTarefa(int id)
		{
			this.IdTarefa = id;
		}

		public string getNomeTarefa()
		{
			return this.NomeTarefa;
		}

		public string getObsTarefa()
		{
			return this.ObsTarefa;
		}

		public string getHorario()
		{
			return this.HorarioTarefa;
		}

		public int getDiaDaSemana()
		{
			return this.FkDiaDaSemana;
		}

		public string getDiaDaSemanaNome()
		{
			string nomeDiaDaSemana;
			switch (this.FkDiaDaSemana)
			{
				case 1:
					nomeDiaDaSemana = "Domingo";
					break;

				case 2:
					nomeDiaDaSemana = "Segunda-feira";
					break;

				case 3:
					nomeDiaDaSemana = "Terça-feira";
					break;

				case 4:
					nomeDiaDaSemana = "Quarta-feira";
					break;

				case 5:
					nomeDiaDaSemana = "Quinta-feira";
					break;

				case 6:
					nomeDiaDaSemana = "Sexta-feira";
					break;

				case 7:
					nomeDiaDaSemana = "Sábado";
					break;

				default:
					nomeDiaDaSemana = "";
					break;
			}

			return nomeDiaDaSemana;
		}

		public int getRepeteSemanal()
		{
			return this.RepeteSemanal;
		}

		public int getAtivaPomodoro()
		{
			return this.AtivaPomodoro;
		}

		public string getStringSemanal()
		{
			if (this.RepeteSemanal == 1)
			{
				return "Sim";
			}

			else return "Não";
		}

		public string getStringPomodoro()
		{
			if (this.AtivaPomodoro == 1)
			{
				return "Sim";
			}

			else return "Não";
		}

		public void atualizaTarefa(string nomeTarefa, string observacao, string horario, int diaDaSemana, int repeteSemanal, int ativaPomodoro)
		{
			//Alterar tarefa
			this.NomeTarefa = nomeTarefa;
			this.ObsTarefa = observacao;
			this.HorarioTarefa = horario;
			this.FkDiaDaSemana = diaDaSemana;
			this.RepeteSemanal = repeteSemanal;
			this.AtivaPomodoro = ativaPomodoro;
		}

		public void notificouTarefa()
		{
			this.Notificou = 1;
			MySqlConnections connections = new MySqlConnections();
			connections.notificarTarefa(connections.obterConexaoBanco(), this.IdTarefa);
		}

		public bool getNotificaTarefa()
		{
			if (this.Notificou == 0)
			{
				return false;
			}
			else return true;
		}

		public int getStatus()
		{
			return this.TarefaConcluida;
		}

		public string getStatusText(int status)
		{
			//Retorna a string para ser concatenada na tela de exibição
			if (status == 1)
			{
				return " -- TAREFA EM ANDAMENTO";
			}

			if(status == 2)
			{
				return " -- TAREFA CONCLUÍDA";
			}

			else return " -- TAREFA A FAZER";
		}

	}
}
