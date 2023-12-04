using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace Organizador
{
	public partial class Form1 : Form
	{
        private PopUpManager popUpManager;
        private Usuario usuario;

		MySqlConnections connections = new MySqlConnections();

		public Form1()
		{
			InitializeComponent();

			usuario = Usuario.GetInstance();
			labelWelcome.Text = usuario.getBemVindo();

			popUpManager = PopUpManager.GetInstance();
            

			if (usuario.getUltimaVerificacaoSemana() == null || 
				usuario.getUltimaVerificacaoSemana() == DateTime.MinValue)
			{
				//Todos os dias é verificado o número da semana (com relação ao ano)
				//Caso o valor não exista ou seja o mínimo definido pelo software (primeiro acesso)
				// a data da última verificação passa a ser a data atual
				usuario.setUltimaVerificacaoSemana(DateTime.Now);
			}

			else
			{
				if (EhNovaSemana()) // verifica se a data atual é de uma semana diferente da última verificação
				{
					DialogResult resultado = 
						MessageBox.Show("É uma nova semana. Deseja excluir as tarefas não repetíveis?",
						"Nova Semana", MessageBoxButtons.YesNo);
					if (resultado == DialogResult.Yes)
					{// Limpa a tabela e reseta as tarefas como A fazer e Não notificadas
						connections.excluirNaoRepetiveis(connections.obterConexaoBanco());
						MessageBox.Show("Exclusão concluída!");
					}

					else
					{//Reseta todas as tarefas como A fazer e Não notificadas
						connections.resetarTarefasSemana(connections.obterConexaoBanco());
					}

					usuario.setUltimaVerificacaoSemana(DateTime.Now);
				}
			}

		}

		private bool EhNovaSemana()
		{
			DateTime hoje = DateTime.Now;
			Calendar cal = CultureInfo.CurrentCulture.Calendar;

			int semanaAtual = cal.GetWeekOfYear(hoje, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Sunday);
			int semanaUltimaVerificacao = cal.GetWeekOfYear(usuario.getUltimaVerificacaoSemana(), 
				CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Sunday);

			return semanaAtual != semanaUltimaVerificacao;
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
