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
	
	public partial class BreakFast : Form
	{
		List<string> Parameters;
		List<string> ParameterValues;
		public HomePage homePage;
		public Mysql_Connect _connect;
		public Form1 form1;
		public string Hour;
		public string Minute;
		public string diningChoice;
		public string[] coldItems;
		List<string> Keywords;
		public BreakFast(HomePage _homePage, Mysql_Connect connect, Form1 _form1)
		{
			InitializeComponent();
			form1 = _form1;
			_connect = connect;
			homePage = _homePage;
			diningChoice = "";
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click_1(object sender, EventArgs e)
		{

		}

		private void button7_Click(object sender, EventArgs e)
		{
			MessageBox.Show("A nurse will be with you as soon as possible");
		}

		private void button1_Click(object sender, EventArgs e)
		{
			homePage.Show();
			this.Hide();
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			Keywords = new List<string>();
			Keywords.Add("Breakfast_cold_item");
			Parameters = new List<string>();
			Parameters.Add("");
			ParameterValues = new List<string>();
			ParameterValues.Add("");

			string _returnedQuery = _connect.Select("SELECT Breakfast_cold_item FROM Breakfast_cold", 2, Keywords, Parameters, ParameterValues);
			string[] Query_Results;
			Query_Results = _returnedQuery.Split('/');

			for (int i = 0; i < Query_Results.Length; i++)
			{
				MessageBox.Show(Query_Results[i]);
				coldItems[i] = Query_Results[i];
			}
			
			
			this.comboBox1.Items.AddRange(coldItems);
		}

		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			diningChoice = "Warm";
		}

		private void checkBox3_CheckedChanged(object sender, EventArgs e)
		{
			diningChoice = "Hot";
		}

		private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
