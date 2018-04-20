using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace MedicTalk
{
	public partial class Form1 : Form
	{
		private bool valid_Credentials;
		private bool loggedIn;
		Forgot_Password FGot_Pass;
		Forgot_UserName FGot_User;
		HomePage _HomePage;
		private string User_Name;
		private string Password;
		public Mysql_Connect _connect;

		public Form1()
		{
			InitializeComponent();
			valid_Credentials = false;
			loggedIn = false;
			
		}

		private void Forgot_UserName_Click(object sender, EventArgs e)
		{
			FGot_User = new MedicTalk.Forgot_UserName();
			this.Hide();
			FGot_User.Show();
			_connect = new Mysql_Connect();
		}


		private void Forgot_Password_Click(object sender, EventArgs e)
		{
			this.Hide();
			FGot_Pass.Show();

		}

		private void button2_Click(object sender, EventArgs e)
		{
			//Debug.WriteLine("sCFSF");
			loggedIn = true;
			_connect = new Mysql_Connect();
			_HomePage = new MedicTalk.HomePage(this, _connect);
			this.Hide();
			_HomePage.Show();

		}

		public void Logout()
		{
		
				LoggedInStatus = false;
				this.Show();
				_HomePage = null;
			
		}

		public bool LoggedInStatus
		{
			get
			{
				return loggedIn;
			}
			set
			{
				loggedIn = value;
			}
		}

		public string Get_User
		{
			get
			{
				return User_Name;
			}
		}

		public string Get_Password
		{
			get
			{
				return Get_Password;
			}
		}

	}
}
