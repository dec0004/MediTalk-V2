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
		public HomePage()
		{
			InitializeComponent();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			((Form1)Owner).LoggedInStatus = false;
			
			
		}

		private void button7_Click(object sender, EventArgs e)
		{
			MessageBox.Show("A nurse will be with you as soon as possible");
		}
	}
}
