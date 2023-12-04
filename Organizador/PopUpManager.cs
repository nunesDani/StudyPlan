using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tulpep.NotificationWindow;
using System.Windows.Forms;
using System.Drawing;
using System.Management.Instrumentation;

namespace Organizador
{
	internal class PopUpManager
	{
		private static PopUpManager instance;
		private Timer timer;
		private List<Tarefa> tarefas;

		private Usuario user = Usuario.GetInstance();

		private MySqlConnections connections = new MySqlConnections();

		private int diaDaSemana = (int)DateTime.Now.DayOfWeek + 1;
		private TimeSpan horarioTarefa;
		private TimeSpan horarioAtual;

		string formato = "hh\\:mm";
		string horarioAtualFormatado;
		string horarioTarefaFormatado;

		private int ultimoMinutoNotificado = -1;

		public PopUpManager()
		{
			timer = new Timer();
			timer.Interval = 3000; // 3 segundos
			timer.Tick += VerificarTarefas;
		}

		public static PopUpManager GetInstance()
		{
			if (instance == null)
			{
				instance = new PopUpManager();
				instance.Iniciar();
			}
			return instance;
		}

		public void Iniciar()
		{
			timer.Start();
		}

		private void VerificarTarefas(object sender, EventArgs e) // adicionado no Tick do timer
		{
			tarefas = connections.listarTarefa(connections.obterConexaoBanco(), diaDaSemana);
			TimeSpan horarioAtual = DateTime.Now.TimeOfDay;
			horarioAtualFormatado = horarioAtual.ToString(formato);

			int minutoAtual = DateTime.Now.Minute;

			
			foreach (var tarefa in tarefas)
			{
				TimeSpan horarioTarefa = TimeSpan.Parse(tarefa.getHorario());
				horarioTarefaFormatado = horarioTarefa.ToString(formato);

				if (horarioTarefaFormatado == horarioAtualFormatado 
					&& !tarefa.getNotificaTarefa() /* tarefa NÃO FOI notificada */
					&& minutoAtual != ultimoMinutoNotificado && user.getAtivaNotificacao() == 1) /* se não foi verificado nesse minuto */ 
				{
					tarefa.notificouTarefa(); /* atualiza tarefa como notificada */
					ExibirNotificacao(tarefa);
					ultimoMinutoNotificado = minutoAtual;
				}
			}
		}

		private void ExibirNotificacao(Tarefa tarefa)
		{
			PopupNotifier popup = new PopupNotifier();
			popup.Image = Properties.Resources.book;
			popup.BodyColor = Color.FromArgb(123, 104, 238);

			popup.TitleText = "Hora de estudar!";
			popup.TitleColor = Color.White;
			popup.TitleFont = new Font("Microsoft Sans Serif", 15, FontStyle.Bold);

			popup.ContentText = "Tarefa: " + tarefa.getNomeTarefa() + "\nÀs " + tarefa.getHorario();
			popup.ContentColor = Color.White;
			popup.ContentFont = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

			popup.Popup();
		}




	}
}
