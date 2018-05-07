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
    public partial class List_Of_Requests : Form
    {
        private Form1 form1;
        public Mysql_Connect _connect;

        public List_Of_Requests(Form1 form1, Mysql_Connect connect)
        {
            this.form1 = form1;
            InitializeComponent();
            _connect = connect;
        }

        private void List_Of_Requests_Load(object sender, EventArgs e)
        {
            Requests_Handler.Show_Requests();
            RequestsList.DataSource = Requests_Handler.DataTable;
        }

        private void RequestList_Click(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
