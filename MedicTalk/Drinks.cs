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
	public partial class Drinks : Form
	{
		List<string> Parameters;
		List<string> ParameterValues;
		public HomePage homePage;
		public Mysql_Connect _connect;
		public Form1 form1;
		public string Hour;
		public string Minute;
		public string diningChoice;
		List<string> Keywords;
		public string expectedRows;
		private string type;
		private Request_Emergency _request_emerg;
		public Drinks(HomePage _homePage, Mysql_Connect connect, Form1 _form1, Request_Emergency request_emerg)
		{
			InitializeComponent();
			InitializeComponent();
			form1 = _form1;
			_connect = connect;
			homePage = _homePage;
			diningChoice = "";
			type = "";
			_request_emerg = request_emerg;
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			type = "Drink_cold";
			checkBox3.Checked = false;
			this.comboBox1.Items.Clear();
			Keywords = new List<string>();
			Keywords.Add("Drink_cold_item");
			Parameters = new List<string>();
			Parameters.Add("");
			ParameterValues = new List<string>();
			ParameterValues.Add("");

			expectedRows = _connect.Count("SELECT COUNT(*) FROM Drink_cold");

			string _returnedQuery = _connect.Select("SELECT Drink_cold_item FROM Drink_cold", expectedRows, Keywords, Parameters, ParameterValues);
			string[] Query_Results;
			string[] Items;
			Query_Results = _returnedQuery.Split('/');

			Items = new string[Query_Results.Length];

			for (int i = 0; i < Query_Results.Length; i++)
			{

				Items[i] = Query_Results[i];
			}

			this.comboBox1.Items.AddRange(Items);
		}

		private void checkBox3_CheckedChanged(object sender, EventArgs e)
		{
			type = "Drink_hot";
			checkBox1.Checked = false;

			this.comboBox1.Items.Clear();
			Keywords = new List<string>();
			Keywords.Add("Drink_hot_item");
			Parameters = new List<string>();
			Parameters.Add("");
			ParameterValues = new List<string>();
			ParameterValues.Add("");

			expectedRows = _connect.Count("SELECT COUNT(*) FROM Drink_hot");

			string _returnedQuery = _connect.Select("SELECT Drink_hot_item FROM Drink_hot", expectedRows, Keywords, Parameters, ParameterValues);
			string[] Query_Results;
			string[] Items;
			Query_Results = _returnedQuery.Split('/');

			Items = new string[Query_Results.Length];

			for (int i = 0; i < Query_Results.Length; i++)
			{

				Items[i] = Query_Results[i];
			}
			this.comboBox1.Items.AddRange(Items);
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void button7_Click(object sender, EventArgs e)
		{
			_request_emerg.CallRequest();
		}
	}
}
