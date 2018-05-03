using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace MedicTalk
{

	public class Mysql_Connect
	{
		private string _myConnectionString;
		private MySqlConnection connection;
		private List<string>[] values;
		private string queryResult;
		private string rows;
		public Mysql_Connect()
		{
			_myConnectionString = "server=192.185.16.222;database=dec0004_MediTalk;uid=dec0004_access; pwd=321xar22j;";
			connection = new MySqlConnection(_myConnectionString);
		}


		public bool OpenConnection()
		{
			try
			{
				connection.Open();
				return true;
			}
			catch (MySqlException ex)
			{
				switch (ex.Number)
				{
					case 0:
						Debug.WriteLine("Cannot connect to server.  Contact administrator");
						break;

					case 1045:
						Debug.WriteLine("Invalid username/password, please try again");
						break;
				}
				return false;
			}
		}

		public bool CloseConnection()
		{
			try
			{
				connection.Close();
				return true;
			}
			catch (MySqlException ex)
			{
				Debug.WriteLine(ex.Message);
				return false;
			}
		}

		public bool Login(string _inputCommand, string user, string pass)
		{
			
				MySqlCommand _command = new MySqlCommand();

			if (this.OpenConnection() == true)
			{
				_command.CommandText = _inputCommand;
				_command.Parameters.AddWithValue("@user", user);
				_command.Parameters.AddWithValue("@password", pass);
				_command.Connection = connection;
				MySqlDataReader login = _command.ExecuteReader();

				if (login.Read())
				{
					login.Close();
					this.CloseConnection();
					return true;
				}
				else
				{
					login.Close();
					this.CloseConnection();
					return false;
				}
			}
			return false;

		}

		public void Insert(string _inputCommand, List<string> parameterKey, List<string> parameterValues)
		{

			MySqlCommand _command = new MySqlCommand();

			if (this.OpenConnection() == true)
			{
				_command.CommandText = _inputCommand;

				for (int i = 0; i < parameterKey.Count; i++)
				{
					//A list of parameters have to be supplied due to an insert statement always having
					//varying parameters

					_command.Parameters.AddWithValue("@" + parameterKey[i], parameterValues[i]);
					
				}

				_command.Connection = connection;

				_command.ExecuteNonQuery();

				this.CloseConnection();
			}
		}

		public string Count(string _inputCommand)
		{
			MySqlCommand _command = new MySqlCommand();
			if (this.OpenConnection() == true)
			{
				_command.CommandText = _inputCommand;
				_command.Connection = connection;
				MySqlDataReader _reader = _command.ExecuteReader();
				while (_reader.Read())
				{
					for (int i = 0; i < 1; i++)
					{
						rows += _reader[0];
					}
					
				}

			}
			this.CloseConnection();
			return rows;
		}
		public void Update()
		{

		}

		public string Select(string _inputCommand, string _expectedRows, List<string> _keywords, List<string> parameterKey, List<string> parameterValues)
		{
			queryResult = "";
			MySqlCommand _command = new MySqlCommand();
			
			if (this.OpenConnection() == true)
			{
				_command.CommandText = _inputCommand;
				
				for (int i = 0; i < parameterKey.Count; i++)
				{
					//A list of parameters have to be supplied due to a select statement always having
					//varying parameters
					if (parameterKey.Count != 0)
					{
						_command.Parameters.AddWithValue("@" + parameterKey[i], parameterValues[i]);
					}
				}
				
				_command.Connection = connection;
				
				//This condition checks if more than one row is expected to be returned so it can return all rows

				//if only one row is expected it returns the row with all the keywords required to be returned
				if (_expectedRows == "1")
				{
					MySqlDataReader _reader = _command.ExecuteReader();

					while (_reader.Read())
					{
							for (int i = 0; i < _keywords.Count(); i++)
							{
								queryResult += _reader[_keywords[i]] + "/";
							}
					}
				}
				else //if more than one row is epected it returns all rows
				{
					MySqlDataReader _reader = _command.ExecuteReader();

					while (_reader.Read())
					{
							for (int i = 0; i < 1; i++)
							{
								queryResult += _reader[_keywords[0]] + "/";
							}

					}
				}

			}
			this.CloseConnection();

			return queryResult.Remove(queryResult.Length - 1); ;
		}

		public void Delete()
		{
		}


	}
}
