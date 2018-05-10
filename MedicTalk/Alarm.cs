using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicTalk
{
	public partial class Alarm : Form
	{
		List<string> Parameters;
		List<string> ParameterValues;
		public HomePage homePage;
		public Mysql_Connect _connect;
		public Form1 form1;
		public string Hour;
		public string Minute;
		private Request_Emergency _requestEmerg;

		public Alarm(HomePage _homePage, Mysql_Connect connect, Form1 _form1, Request_Emergency request_emerg)
		{
			InitializeComponent();
			string[] _Hour = new string[24];
			string[] _minutes = new string[60];
			form1 = _form1;
			_connect = connect;
			homePage = _homePage;
			_requestEmerg = request_emerg;

			for (int i = 0; i < _Hour.Length; i++)
			{
				_Hour[i] = i.ToString();
			}
			for (int i = 0; i < _minutes.Length; i++)
			{
				_minutes[i] = i.ToString();
			}

			this.comboBox1.Items.AddRange(_Hour);
			this.comboBox2.Items.AddRange(_minutes);
		}

		private void button7_Click(object sender, EventArgs e)
		{
			MessageBox.Show("A nurse will be with you as soon as possible");
			_requestEmerg.CallRequest();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			homePage.Show();
			this.Hide();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			Hour = comboBox1.Text;
		}

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			Minute = comboBox2.Text;
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			Parameters = new List<string>();
			Parameters.Add("User_id");
			Parameters.Add("Hours");
			Parameters.Add("Minutes");

			ParameterValues = new List<string>();
			ParameterValues.Add(form1.UserIDProperty);
			ParameterValues.Add(Hour);
			ParameterValues.Add(Minute);
	

			_connect.Insert("INSERT INTO Alarms (User_id, Alarm_time, Alarm_date) VALUES (@User_id, @Hours, @Minutes);", Parameters, ParameterValues);
			MessageBox.Show("You have added an alarm");
		}
	}
}
