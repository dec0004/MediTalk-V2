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

	public partial class Lunch : Form
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
		private HomePage _home;
		private string type;
		public Lunch(HomePage _homePage, Mysql_Connect connect, Form1 _form1)
		{
			InitializeComponent();
			form1 = _form1;
			_connect = connect;
			homePage = _homePage;
			diningChoice = "";
			type = "";
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void button7_Click(object sender, EventArgs e)
		{
			MessageBox.Show("A nurse will be with you as soon as possible");
		}

		private void button1_Click(object sender, EventArgs e)
		{
			_home.Show();
			this.Hide();
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			type = "Lunch_cold";
			checkBox2.Checked = false;
			checkBox3.Checked = false;
			this.comboBox2.Items.Clear();
			Keywords = new List<string>();
			Keywords.Add("Lunch_cold_item");
			Parameters = new List<string>();
			Parameters.Add("");
			ParameterValues = new List<string>();
			ParameterValues.Add("");

			expectedRows = _connect.Count("SELECT COUNT(*) FROM Lunch_cold");

			string _returnedQuery = _connect.Select("SELECT Lunch_cold_item FROM Lunch_cold", expectedRows, Keywords, Parameters, ParameterValues);
			string[] Query_Results;
			string[] Items;
			Query_Results = _returnedQuery.Split('/');
			Items = new string[Query_Results.Length];

			for (int i = 0; i < Query_Results.Length; i++)
			{

				Items[i] = Query_Results[i];
			}

			this.comboBox2.Items.AddRange(Items);

		}

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			type = "Lunch_Warm";
			checkBox1.Checked = false;
			checkBox3.Checked = false;
			this.comboBox2.Items.Clear();
			Keywords = new List<string>();
			Keywords.Add("Lunch_warm_item");
			Parameters = new List<string>();
			Parameters.Add("");
			ParameterValues = new List<string>();
			ParameterValues.Add("");

			expectedRows = _connect.Count("SELECT COUNT(*) FROM Lunch_warm");

			string _returnedQuery = _connect.Select("SELECT Lunch_warm_item FROM Lunch_warm", expectedRows, Keywords, Parameters, ParameterValues);
			string[] Query_Results;
			string[] Items;
			Query_Results = _returnedQuery.Split('/');

			Items = new string[Query_Results.Length];

			for (int i = 0; i < Query_Results.Length; i++)
			{

				Items[i] = Query_Results[i];
			}
			this.comboBox2.Items.AddRange(Items);
		}

		private void checkBox3_CheckedChanged(object sender, EventArgs e)
		{
			type = "Lunch_Hot";
			checkBox2.Checked = false;
			checkBox1.Checked = false;
			this.comboBox2.Items.Clear();
			Keywords = new List<string>();
			Keywords.Add("Lunch_hot_item");
			Parameters = new List<string>();
			Parameters.Add("");
			ParameterValues = new List<string>();
			ParameterValues.Add("");

			expectedRows = _connect.Count("SELECT COUNT(*) FROM Lunch_hot");

			string _returnedQuery = _connect.Select("SELECT Lunch_hot_item FROM Lunch_hot", expectedRows, Keywords, Parameters, ParameterValues);
			string[] Query_Results;
			string[] Items;
			Query_Results = _returnedQuery.Split('/');

			Items = new string[Query_Results.Length];

			for (int i = 0; i < Query_Results.Length; i++)
			{

				Items[i] = Query_Results[i];
			}
			this.comboBox2.Items.AddRange(Items);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Parameters = new List<string>();
			Parameters.Add("User_id");
			Parameters.Add("Type_of");
			Parameters.Add("Choice");
			Parameters.Add("First_Name");
			Parameters.Add("Last_Name");
			Parameters.Add("Section");
			Parameters.Add("Room");
			Parameters.Add("Other_Request");
			ParameterValues = new List<string>();
			ParameterValues.Add(form1.UserIDProperty);
			ParameterValues.Add(type);
			ParameterValues.Add(comboBox1.Text);
			ParameterValues.Add(form1.FirstNameProperty);
			ParameterValues.Add(form1.LastNameProperty);
			ParameterValues.Add(form1.SectionProperty);
			ParameterValues.Add(form1.RoomProperty);
			ParameterValues.Add(textBox1.Text);

			_connect.Insert("INSERT INTO Requests (User_id, Type_of, Choice, First_Name, Last_Name, Section, Room, Other_Requests) VALUES (@User_id, @Type_of, @Choice, @First_Name, @Last_Name, @Section, @Room, @Other_Request);", Parameters, ParameterValues);
			MessageBox.Show("Your request has been acknowledged");
		}

		
	}
}
