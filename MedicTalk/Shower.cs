﻿using System;
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
	public partial class Shower : Form
	{
		public HomePage homePage;
		public Mysql_Connect connect;
		public Form1 form1;
		public string _hour;
		public string _minute;
		public string _time;
		public string _type;
		List<string> Parameters;
		List<string> ParameterValues;
		Request_Emergency _request_emerg;
		public Shower(HomePage _homePage, Mysql_Connect _connect, Form1 _form1, Request_Emergency request_emergency)
		{
			_hour = "";
			_minute = "";
			_time = "";
			_type = "";
			form1 = _form1;
			homePage = _homePage;
			connect = _connect;
			InitializeComponent();
			string[] _hours = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24" };
			this.comboBox1.Items.AddRange(_hours);
			string[] _minutes = new string[] { "05", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55" };
			this.comboBox2.Items.AddRange(_minutes);
			_request_emerg = request_emergency;
		}

		private void button7_Click(object sender, EventArgs e)
		{
			MessageBox.Show("A nurse will be with you as soon as possible");
			_request_emerg.CallRequest();
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			_type = radioButton1.Text;
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			_type = radioButton2.Text;
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			_hour = comboBox1.Text;
		}

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			_minute = comboBox2.Text;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			_time = _hour + ":" + _minute;
			Parameters = new List<string>();
			Parameters.Add("User_id");
			Parameters.Add("Type_of");
			Parameters.Add("Choice");
			Parameters.Add("First_Name");
			Parameters.Add("Last_Name");
			Parameters.Add("Section");
			Parameters.Add("Room");
			ParameterValues = new List<string>();
			ParameterValues.Add(form1.UserIDProperty);
			ParameterValues.Add("Bathing");
			ParameterValues.Add(_type);
			ParameterValues.Add(form1.FirstNameProperty);
			ParameterValues.Add(form1.LastNameProperty);
			ParameterValues.Add(form1.SectionProperty);
			ParameterValues.Add(form1.RoomProperty);
			_time = _hour + ":" + _minute;

			connect.Insert("INSERT INTO Requests (User_id, Type_of, Choice, First_Name, Last_Name, Section, Room) VALUES (@User_id, @Type_of, @Choice, @First_Name, @Last_Name, @Section, @Room);", Parameters, ParameterValues);
			MessageBox.Show("Your request has been acknowledged");

		}

		private void button1_Click(object sender, EventArgs e)
		{
			homePage.Show();
			this.Hide();
		}
	}
}