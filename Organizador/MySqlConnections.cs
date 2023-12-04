using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql;
using MySql.Data.MySqlClient;


namespace Organizador
{
	internal class MySqlConnections
	{
		public MySqlConnection obterConexaoBanco()
		{
			string connectionString = "server=localhost;user=root;password=1234;database=tarefas;";
			MySqlConnection connection = new MySqlConnection(connectionString);
			return connection;
		}

		public void novaTarefa(MySqlConnection connection, Tarefa tarefa)
		{
			try
			{
				connection.Open();

				if (connection.State == System.Data.ConnectionState.Open)
				{
					Console.WriteLine("Conexão bem-sucedida!");

					String baseQuery = "insert into tb_TAREFA(nomeTarefa, obsTarefa, horarioTarefa, fk_diaDaSemana, repeteSemanal, ativaPomodoro, tarefaConcluida, notificou) values ('";
					String insertQuery = baseQuery + tarefa.getNomeTarefa() + "','" + tarefa.getObsTarefa() + "', '" + tarefa.getHorario() + "'," + tarefa.getDiaDaSemana() + "," + tarefa.getRepeteSemanal() + "," + tarefa.getAtivaPomodoro() + ", 0, 0);";
					MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection);

					int rowsAffected = insertCommand.ExecuteNonQuery();

					if (rowsAffected > 0)
					{
						MySqlCommand getIdCommand = new MySqlCommand("SELECT last_insert_id();", connection);
						tarefa.setIdTarefa(Convert.ToInt32(getIdCommand.ExecuteScalar()));
						Console.WriteLine("Inserção bem-sucedida!");
					}
					else
					{
						Console.WriteLine("Nenhuma linha foi inserida.");
					}

				}
				else
				{
					Console.WriteLine("Falha");
				}
			}

			catch (Exception ex)
			{
				MessageBox.Show("Erro na conexão." + ex.Message);
				Console.WriteLine("Erro: " + ex.Message);
			}
			finally
			{
				connection.Close();
			}
		}


		public List<Tarefa> listarTarefa(MySqlConnection connection, int diaSemana)
		{
			List<Tarefa> listaTarefas = new List<Tarefa>();
			try
			{
				connection.Open();

                if (connection.State == System.Data.ConnectionState.Open)
                {
					String queryConsultar = "SELECT * FROM tb_TAREFA WHERE fk_diaDaSemana = " + diaSemana + " ORDER BY horarioTarefa;";
					MySqlCommand consultarCommand = new MySqlCommand(queryConsultar, connection);
					using (MySqlDataReader  reader = consultarCommand.ExecuteReader())
					{
						while (reader.Read())
						{
							int idTarefa = reader.GetInt32("id_tarefa");
							string nomeTarefa = reader.GetString("nomeTarefa");
							string obsTarefa = reader.GetString("obsTarefa");
							string horarioTarefa = reader.GetString("horarioTarefa");
							string diaDaSemana = reader.GetString("fk_diaDaSemana");
							int repeteSemanal = reader.GetInt32("repeteSemanal");
							int ativaPomodoro = reader.GetInt32("ativaPomodoro");
							int tarefaConcluida = reader.GetInt32("tarefaConcluida");
							int notificou = reader.GetInt32("notificou");

							Tarefa tarefa = new Tarefa(idTarefa,nomeTarefa, obsTarefa, horarioTarefa, diaSemana, repeteSemanal, ativaPomodoro, tarefaConcluida, notificou);
							listaTarefas.Add(tarefa);
						}

						return listaTarefas;
					}
				
				}

				else
				{
					MessageBox.Show("Falha");
				}



            }

			catch (Exception ex)
			{
				MessageBox.Show("Erro: " + ex.Message); 
			}


			return listaTarefas; 
		}

		public Tarefa getTarefaById(MySqlConnection connection, int id)
		{
			Tarefa tarefa = new Tarefa();

			try
			{

				connection.Open();

				if (connection.State == System.Data.ConnectionState.Open)
				{
					String queryConsultar = "SELECT * FROM tb_TAREFA WHERE id_tarefa = " + id + ";";

					MySqlCommand consultarCommand = new MySqlCommand(queryConsultar, connection);

					using (MySqlDataReader reader = consultarCommand.ExecuteReader())
					{
						while (reader.Read())
						{
							int idTarefa = reader.GetInt32("id_tarefa");
							string nomeTarefa = reader.GetString("nomeTarefa");
							string obsTarefa = reader.GetString("obsTarefa");
							string horarioTarefa = reader.GetString("horarioTarefa");
							int diaDaSemana = reader.GetInt32("fk_diaDaSemana");
							int repeteSemanal = reader.GetInt32("repeteSemanal");
							int ativaPomodoro = reader.GetInt32("ativaPomodoro");
							int tarefaConcluida = reader.GetInt32("tarefaConcluida");
							int notificou = reader.GetInt32("notificou");

							tarefa = new Tarefa(idTarefa, nomeTarefa, obsTarefa, horarioTarefa, diaDaSemana, repeteSemanal, ativaPomodoro, tarefaConcluida, notificou);

						}

						return tarefa;
					}

				}

				else
				{
					MessageBox.Show("Falha");
				}



			}

			catch (Exception ex)
			{
				MessageBox.Show("Erro: " + ex.Message);
			}


			return tarefa;
		}

		public void atualizaTarefa(MySqlConnection connection, Tarefa tarefa)
		{
			try
			{
				connection.Open();

				if (connection.State == System.Data.ConnectionState.Open)
				{
					Console.WriteLine("Conexão bem-sucedida!");

					int idTarefa = tarefa.getIdTarefa();
					string nomeTarefa = tarefa.getNomeTarefa();
					string obsTarefa = tarefa.getObsTarefa();
					string horarioTarefa = tarefa.getHorario();
					int diaDaSemana = tarefa.getDiaDaSemana();
					int repeteSemanal = tarefa.getRepeteSemanal();
					int ativaPomodoro = tarefa.getAtivaPomodoro();

					String updateQuery = "UPDATE tb_TAREFA SET nomeTarefa = '" + nomeTarefa +
						"', obsTarefa = '" + obsTarefa + "', horarioTarefa = '" + horarioTarefa + 
						"', fk_diaDaSemana = " + diaDaSemana + ", repeteSemanal = " + repeteSemanal + 
						", ativaPomodoro = " + ativaPomodoro + " WHERE id_tarefa = " + idTarefa + ";";
					MySqlCommand insertCommand = new MySqlCommand(updateQuery, connection);


					int rowsAffected = insertCommand.ExecuteNonQuery();

					if (rowsAffected > 0)
					{
						Console.WriteLine("Alteração bem-sucedida!");
					}
					else
					{
						Console.WriteLine("Nenhuma linha foi alterada.");
					}

				}
				else
				{
					Console.WriteLine("Falha");
				}
			}

			catch (Exception ex)
			{
				MessageBox.Show("Erro na conexão." + ex.Message);
				Console.WriteLine("Erro: " + ex.Message);
			}
			finally
			{
				connection.Close();
			}
		}

		public void excluirTarefa(MySqlConnection connection, int id)
		{
			try
			{
				connection.Open();

				if (connection.State == System.Data.ConnectionState.Open)
				{
					Console.WriteLine("Conexão bem-sucedida!");

					String updateQuery = "DELETE FROM tb_TAREFA WHERE id_tarefa = " + id + ";";
					MySqlCommand insertCommand = new MySqlCommand(updateQuery, connection);

					int rowsAffected = insertCommand.ExecuteNonQuery();

					if (rowsAffected > 0)
					{
						Console.WriteLine("Exclusão bem-sucedida!");
					}
					else
					{
						Console.WriteLine("Nenhuma linha foi alterada.");
					}

				}
				else
				{
					Console.WriteLine("Falha");
				}
			}

			catch (Exception ex)
			{
				MessageBox.Show("Erro na conexão." + ex.Message);
				Console.WriteLine("Erro: " + ex.Message);
			}
			finally
			{
				connection.Close();
			}
		}

		public void concluirTarefa(MySqlConnection connection, int id)
		{
			try
			{
				connection.Open();

				if (connection.State == System.Data.ConnectionState.Open)
				{
					Console.WriteLine("Conexão bem-sucedida!");

					String updateQuery = "UPDATE tb_TAREFA SET tarefaConcluida = 2 WHERE id_tarefa = " + id + ";";
					MySqlCommand insertCommand = new MySqlCommand(updateQuery, connection);


					int rowsAffected = insertCommand.ExecuteNonQuery();

					if (rowsAffected > 0)
					{
						Console.WriteLine("Alteração bem-sucedida!");
					}
					else
					{
						Console.WriteLine("Nenhuma linha foi alterada.");
					}

				}
				else
				{
					Console.WriteLine("Falha");
				}
			}

			catch (Exception ex)
			{
				MessageBox.Show("Erro na conexão." + ex.Message);
				Console.WriteLine("Erro: " + ex.Message);
			}
			finally
			{
				connection.Close();
			}
		}

		public void iniciarTarefa(MySqlConnection connection, int id)
		{
			try
			{
				connection.Open();

				if (connection.State == System.Data.ConnectionState.Open)
				{
					Console.WriteLine("Conexão bem-sucedida!");

					String updateQuery = "UPDATE tb_TAREFA SET tarefaConcluida = 1 WHERE id_tarefa = " + id + ";";
					MySqlCommand insertCommand = new MySqlCommand(updateQuery, connection);


					int rowsAffected = insertCommand.ExecuteNonQuery();

					if (rowsAffected > 0)
					{
						Console.WriteLine("Alteração bem-sucedida!");
					}
					else
					{
						Console.WriteLine("Nenhuma linha foi alterada.");
					}

				}
				else
				{
					Console.WriteLine("Falha");
				}
			}

			catch (Exception ex)
			{
				MessageBox.Show("Erro na conexão." + ex.Message);
				Console.WriteLine("Erro: " + ex.Message);
			}
			finally
			{
				connection.Close();
			}
		}

		public void notificarTarefa(MySqlConnection connection, int id)
		{
			try
			{
				connection.Open();

				if (connection.State == System.Data.ConnectionState.Open)
				{
					Console.WriteLine("Conexão bem-sucedida!");

					String updateQuery = "UPDATE tb_TAREFA SET notificou = 1 WHERE id_tarefa = " + id + ";";
					MySqlCommand insertCommand = new MySqlCommand(updateQuery, connection);


					int rowsAffected = insertCommand.ExecuteNonQuery();

					if (rowsAffected > 0)
					{
						Console.WriteLine("Alteração bem-sucedida!");
					}
					else
					{
						Console.WriteLine("Nenhuma linha foi alterada.");
					}

				}
				else
				{
					Console.WriteLine("Falha");
				}
			}

			catch (Exception ex)
			{
				MessageBox.Show("Erro na conexão." + ex.Message);
				Console.WriteLine("Erro: " + ex.Message);
			}
			finally
			{
				connection.Close();
			}
		}

		public int verificaAndamento(MySqlConnection connection)
		{
			int result = 0;

			try
			{

				connection.Open();

				if (connection.State == System.Data.ConnectionState.Open)
				{
					String queryConsultar = "SELECT count(*) FROM tb_TAREFA WHERE tarefaConcluida = 1;";

					MySqlCommand consultarCommand = new MySqlCommand(queryConsultar, connection);

					result = Convert.ToInt32(consultarCommand.ExecuteScalar());
					return result;
				}

				else
				{
					MessageBox.Show("Falha");
				}



			}

			catch (Exception ex)
			{
				MessageBox.Show("Erro: " + ex.Message);
			}


			return result;
		}

		public Tarefa verificaTarefaAndamento(MySqlConnection connection)
		{
			Tarefa tarefa = new Tarefa();

			try
			{

				connection.Open();

				if (connection.State == System.Data.ConnectionState.Open)
				{
					String queryConsultar = "SELECT * FROM tb_TAREFA WHERE tarefaConcluida = 1;";

					MySqlCommand consultarCommand = new MySqlCommand(queryConsultar, connection);

					using (MySqlDataReader reader = consultarCommand.ExecuteReader())
					{
						while (reader.Read())
						{
							int idTarefa = reader.GetInt32("id_tarefa");
							string nomeTarefa = reader.GetString("nomeTarefa");
							string obsTarefa = reader.GetString("obsTarefa");
							string horarioTarefa = reader.GetString("horarioTarefa");
							int diaDaSemana = reader.GetInt32("fk_diaDaSemana");
							int repeteSemanal = reader.GetInt32("repeteSemanal");
							int ativaPomodoro = reader.GetInt32("ativaPomodoro");
							int tarefaConcluida = reader.GetInt32("tarefaConcluida");
							int notificou = reader.GetInt32("notificou");

							tarefa = new Tarefa(idTarefa, nomeTarefa, obsTarefa, horarioTarefa, diaDaSemana, repeteSemanal, ativaPomodoro, tarefaConcluida, notificou);

						}

						return tarefa;
					}

				}

				else
				{
					MessageBox.Show("Falha");
				}



			}

			catch (Exception ex)
			{
				MessageBox.Show("Erro: " + ex.Message);
			}


			return tarefa;
		} 

		public Usuario getUsuario(MySqlConnection connection)
		{
			Usuario usuario = new Usuario();

			try
			{
				connection.Open();

				if (connection.State == System.Data.ConnectionState.Open)
				{
					String queryConsultar = "SELECT * FROM tb_USUARIO WHERE id_usuario = 1;";

					MySqlCommand consultarCommand = new MySqlCommand(queryConsultar, connection);

					using (MySqlDataReader reader = consultarCommand.ExecuteReader())
					{
						while (reader.Read())
						{
							string nomeUsuario = reader.GetString("nomeUsuario");
							int generoUsuario = reader.GetInt32("generoUsuario");
							int ativaNotificacao = reader.GetInt32("ativaNotificacao");
							DateTime dataUltimaSemana = reader.GetDateTime("dataUltimaSemana");

							usuario.atualizaDados(nomeUsuario, generoUsuario, ativaNotificacao, dataUltimaSemana);
						}

						return usuario;
					}

				}

				else
				{
					MessageBox.Show("Falha");
				}

			}

			catch (Exception ex)
			{
				MessageBox.Show("Erro: " + ex.Message);
			}


			return usuario;
		}

		public void atualizaUsuario(MySqlConnection connection, Usuario usuario)
		{
			try
			{
				connection.Open();

				if (connection.State == System.Data.ConnectionState.Open)
				{
					Console.WriteLine("Conexão bem-sucedida!");

					string nomeUsuario = usuario.getUsuarioNome();
					int generoUsuario = usuario.getGeneroUsuario();
					int ativaNotificacao = usuario.getAtivaNotificacao();

					String updateQuery = "UPDATE tb_USUARIO SET nomeUsuario = '" + nomeUsuario +
						"', generoUsuario = " + generoUsuario + ", ativaNotificacao = " + ativaNotificacao +
						" WHERE id_usuario = 1;";
					MySqlCommand insertCommand = new MySqlCommand(updateQuery, connection);


					int rowsAffected = insertCommand.ExecuteNonQuery();

					if (rowsAffected > 0)
					{
						Console.WriteLine("Alteração bem-sucedida!");
					}
					else
					{
						Console.WriteLine("Nenhuma linha foi alterada.");
					}

				}
				else
				{
					Console.WriteLine("Falha");
				}
			}

			catch (Exception ex)
			{
				MessageBox.Show("Erro na conexão." + ex.Message);
				Console.WriteLine("Erro: " + ex.Message);
			}
			finally
			{
				connection.Close();
			}
		}

		internal void atualizaDataVerificacao(MySqlConnection connection, DateTime now)
		{
			try
			{
				connection.Open();

				if (connection.State == System.Data.ConnectionState.Open)
				{
					Console.WriteLine("Conexão bem-sucedida!");

					String updateQuery = "UPDATE tb_USUARIO SET dataUltimaSemana = '" 
						+ now.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE id_usuario = 1;";
					MySqlCommand insertCommand = new MySqlCommand(updateQuery, connection);


					int rowsAffected = insertCommand.ExecuteNonQuery();

					if (rowsAffected > 0)
					{
						Console.WriteLine("Alteração bem-sucedida!");
					}
					else
					{
						Console.WriteLine("Nenhuma linha foi alterada.");
					}

				}
				else
				{
					Console.WriteLine("Falha");
				}
			}

			catch (Exception ex)
			{
				MessageBox.Show("Erro na conexão." + ex.Message);
				Console.WriteLine("Erro: " + ex.Message);
			}
			finally
			{
				connection.Close();
			}
		}

		public void excluirNaoRepetiveis(MySqlConnection connection)
		{
			try
			{
				connection.Open();

				if (connection.State == System.Data.ConnectionState.Open)
				{
					Console.WriteLine("Conexão bem-sucedida!");

					String deleteQuery = "DELETE FROM tb_TAREFA WHERE repeteSemanal = 0;";
					String updateQuery = "UPDATE tb_TAREFA SET tarefaConcluida = 0, notificou = 0;";

					MySqlCommand insertCommand = new MySqlCommand(deleteQuery, connection);

					int rowsAffected = insertCommand.ExecuteNonQuery();

					if (rowsAffected > 0)
					{
						Console.WriteLine("Exclusão bem-sucedida!");
					}
					else
					{
						Console.WriteLine("Nenhuma linha foi alterada.");
					}

				}
				else
				{
					Console.WriteLine("Falha");
				}
			}

			catch (Exception ex)
			{
				MessageBox.Show("Erro na conexão." + ex.Message);
				Console.WriteLine("Erro: " + ex.Message);
			}
			finally
			{
				connection.Close();
			}
		}

		public void resetarTarefasSemana(MySqlConnection connection)
		{
			try
			{
				connection.Open();

				if (connection.State == System.Data.ConnectionState.Open)
				{
					Console.WriteLine("Conexão bem-sucedida!");

					String updateQuery = "UPDATE tb_TAREFA SET tarefaConcluida = 0, notificou = 0;";

					MySqlCommand insertCommand = new MySqlCommand(updateQuery, connection);

					int rowsAffected = insertCommand.ExecuteNonQuery();

					if (rowsAffected > 0)
					{
						Console.WriteLine("Exclusão bem-sucedida!");
					}
					else
					{
						Console.WriteLine("Nenhuma linha foi alterada.");
					}

				}
				else
				{
					Console.WriteLine("Falha");
				}
			}

			catch (Exception ex)
			{
				MessageBox.Show("Erro na conexão." + ex.Message);
				Console.WriteLine("Erro: " + ex.Message);
			}
			finally
			{
				connection.Close();
			}
		}

	}

}
