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
	public partial class Configurações : Form
	{
		private Usuario usuario;

		public Configurações()
		{
			InitializeComponent();

			usuario = Usuario.GetInstance();
			textNome.Text = usuario.getUsuarioNome();
			comboBoxGenero.Text = usuario.getGeneroUsuarioNome();
			checkBoxNotificacao.Checked = usuario.getAtivaNotificacaoBool();
		}

		private void atualizaUsuario(object sender, EventArgs e) //Clicou para salvar
		{
			string nome = textNome.Text;
			int genero;
			int notificacao = checkBoxNotificacao.Checked ? 1 : 0;

			MySqlConnections mySqlConnections = new MySqlConnections();

			if (comboBoxGenero.Text == "Feminino")
			{
				genero = 1;
			} // genero = 1;

			else if (comboBoxGenero.Text == "Masculino")
			{
				genero = 2;
			} // genero = 2;

			else
			{
				genero = 0;
			} // genero = 0;

			usuario.atualizaDados(nome, genero, notificacao, usuario.getUltimaVerificacaoSemana());
			mySqlConnections.atualizaUsuario(mySqlConnections.obterConexaoBanco(), usuario);

			MessageBox.Show("Usuário atualizado com sucesso!");

			Form1 home = new Form1();
			home.StartPosition = FormStartPosition.Manual;
			home.Location = this.Location;
			this.Hide();
			home.ShowDialog();

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
