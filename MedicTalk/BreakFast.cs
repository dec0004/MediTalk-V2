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
		private HomePage _home;
		public BreakFast(HomePage _home)
		{
			InitializeComponent();
			this._home = _home;
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
			_home.Show();
			this.Hide();
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{

		}
	}
}
