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
	public partial class Form1 : Form
	{
		private bool valid_Credentials;
		private bool loggedIn;
		Forgot_Password FGot_Pass;
		Forgot_UserName FGot_User;
		HomePage _HomePage;
		private string User_Name;
		private string Password;
		

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
		}


		private void Forgot_Password_Click(object sender, EventArgs e)
		{
			this.Hide();
			FGot_Pass.Show();

		}

		private void button2_Click(object sender, EventArgs e)
		{
			loggedIn = true;
			_HomePage = new MedicTalk.HomePage(this);
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
