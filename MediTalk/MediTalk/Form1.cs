using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MediTalk
{

	public partial class Form1 : Form
	{
		private bool able_To_Login;

		public Form1()
		{
			InitializeComponent();
			able_To_Login = true;
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{
			textBox1.Text = "Enter Username";
			
		}

		void Forgot_UserName_Click(Object sender,
						   EventArgs e)
		{
			Button clickedButton = (Button)sender;
			clickedButton.Enabled = false;
			able_To_Login = false;
			Debug.WriteLine("csc"); 
		}

		


	}
}
