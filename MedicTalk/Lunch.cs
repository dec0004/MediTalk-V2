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
	public partial class Lunch : Form
	{
		public Lunch()
		{
			InitializeComponent();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void button7_Click(object sender, EventArgs e)
		{
			MessageBox.Show("A nurse will be with you as soon as possible");
		}
	}
}