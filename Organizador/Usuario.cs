using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizador
{
	internal class Usuario
	{
		private static Usuario instance;

		private string NomeUsuario;
		private int GeneroUsuario;
		private int AtivaNotificacao;
		private DateTime DataUltimaSemana;

		public Usuario()
		{
			this.NomeUsuario = "";
			this.GeneroUsuario = 0;
			this.AtivaNotificacao = 1;
		}

		public static Usuario GetInstance()
		{
			MySqlConnections mySqlConnections = new MySqlConnections();

			if(instance == null)
			{
				instance = mySqlConnections.getUsuario(mySqlConnections.obterConexaoBanco());
			}
			return instance;
		}

		public string getUsuarioNome()
		{
			return this.NomeUsuario;
		}

		public int getAtivaNotificacao()
		{
			return this.AtivaNotificacao;
		}

		public int getGeneroUsuario()
		{
			return this.GeneroUsuario;
		}

		public string getGeneroUsuarioNome()
		{
			string genero = "";

			if (this.GeneroUsuario == 0) genero = "Outro";
			else if (this.GeneroUsuario == 1) genero = "Feminino";
			else if (this.GeneroUsuario == 2) genero = "Masculino";

			return genero;
		}

		public string getBemVindo()
		{
			string welcome = "";

			if (this.GeneroUsuario == 0) welcome = "Boas vindas " + this.NomeUsuario;
			else if (this.GeneroUsuario == 1) welcome = "Bem vinda " + this.NomeUsuario;
			else if (this.GeneroUsuario == 2) welcome = "Bem vindo " + this.NomeUsuario;

			return welcome;
		}

		public void atualizaDados(string nomeUsuario, int generoUsuario, int ativaNotificacao, DateTime dataUltimaVerificacaoSemana)
		{
			this.NomeUsuario = nomeUsuario;
			this.GeneroUsuario = generoUsuario;
			this.AtivaNotificacao = ativaNotificacao;
			this.DataUltimaSemana = dataUltimaVerificacaoSemana;
		}

		internal bool getAtivaNotificacaoBool()
		{
			if (this.AtivaNotificacao == 1) return true;
			else return false;
		}

		internal void setUltimaVerificacaoSemana(DateTime now)
		{
			this.DataUltimaSemana = now;
			MySqlConnections connections = new MySqlConnections();

			connections.atualizaDataVerificacao(connections.obterConexaoBanco(), now);
		}

		internal DateTime getUltimaVerificacaoSemana()
		{
			return this.DataUltimaSemana;
		}
	}
}
