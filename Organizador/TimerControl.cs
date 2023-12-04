using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organizador
{
	public partial class TimerControl
	{

		private static TimerControl instance;

		private bool isPomodoro = false;
		private Timer timer;
		private string tempo = "INATIVO";

		private int totalSeconds;

		public TimerControl()
		{
			timer = new Timer();
			timer.Interval = 1000;
			timer.Tick += Timer_Tick;
		}

		public static TimerControl GetInstance()
		{
			if (instance == null)
			{
				instance = new TimerControl();
			}
			return instance;
		}

		public void IniciarPomodoro()
		{
			isPomodoro = true;
			int minutes = 24;
			int seconds = 60;
			totalSeconds = (minutes * 60) + seconds;
			timer.Enabled = true;
			timer.Start();
		}

		public void IniciarPausa()
		{
			isPomodoro = false;
			int minutes = 4;
			int seconds = 60;
			totalSeconds = (minutes * 60) + seconds;
			timer.Enabled = true;
			timer.Start();
		}

		public void PararPomodoro()
		{
			timer.Stop();
			timer.Enabled = false;
			tempo = "INATIVO";
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			if (isPomodoro == true) // Se estiver durante estudo
			{
				if (totalSeconds > 0) // Se houver tempo restante, diminui o tempo
				{
					totalSeconds--;
					int minutes = totalSeconds / 60;
					int seconds = totalSeconds - (minutes * 60);
					tempo = minutes.ToString() + ":" + seconds.ToString();
				}
				else // Se não houver mais tempo, inicia a pausa
				{
					timer.Stop();
					MessageBox.Show("Hora da Pausa!");
					isPomodoro = false;
					IniciarPausa();
				}
			}

			if (isPomodoro == false) //Se estiver em pausa
			{
				if (totalSeconds > 0) // Se houver tempo restante, diminui o tempo
				{
					totalSeconds--;
					int minutes = totalSeconds / 60;
					int seconds = totalSeconds - (minutes * 60);
					tempo = minutes.ToString() + ":" + seconds.ToString();
				}
				else // Se não houver mais tempo, retoma o contador de estudo
				{
					timer.Stop();
					MessageBox.Show("Hora de voltar aos estudos!");
					isPomodoro = true;
					IniciarPomodoro();
				}
			}
		}

		public string atualizaLabel() // Exibe ao usuário o tempo restante formatado em string
		{
			return tempo;
		}

	}
}
