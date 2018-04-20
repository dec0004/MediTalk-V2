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
	public partial class HomePage : Form
	{
		private Form1 form1;
		private Drink _drink;
		private Alarm _alarm;
		private BreakFast _breakfast;
		private Lunch _lunch;
		public Mysql_Connect _connect;
	
		public HomePage(Form1 form1, Mysql_Connect connect)
		{
			this.form1 = form1;
			InitializeComponent();
			_connect = connect;

		}

		//Logout button
		private void button4_Click(object sender, EventArgs e)
		{
			var _confirm = MessageBox.Show("Are you sure you want to log out?", "Confirm logout", MessageBoxButtons.YesNo);

			if (_confirm == DialogResult.Yes)
			{
				this.Hide();
				form1.Logout();
			}
			
		}

		//Emergency Button
		private void button7_Click(object sender, EventArgs e)
		{
			MessageBox.Show("A nurse will be with you as soon as possible");
			_connect.Command("INSERT INTO Requests (Request_id, User_id, Type_of, Choice, First_Name, Last_Name, Section, Room) VALUES (Default, 0, 'Emergency Request', 'None', 'Jordan', 'de Carheil', 'S8', '18')");
			
		}

		//Drinks Icon
		private void button9_Click(object sender, EventArgs e)
		{
			_drink = new MedicTalk.Drink(this);
			this.Hide();
			_drink.Show();
		}

		//Alarm Icon
		private void button6_Click(object sender, EventArgs e)
		{
			_alarm = new MedicTalk.Alarm(this);
			this.Hide();
			_alarm.Show();
		}

		//Breakfast Icon
		private void button2_Click(object sender, EventArgs e)
		{
			_breakfast = new MedicTalk.BreakFast(this);
			this.Hide();
			_breakfast.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			_lunch = new MedicTalk.Lunch(this);
			this.Hide();
			_lunch.Show();
		}
	}
}
