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
		List<string> Keywords;
		public string expectedRows;
		private string type;
		Request_Emergency _request_emerg;

        // New parameters

        private string _mealType = "breakfast"; // The type of meal (Lunch, breakfast, etc)
        private string _HotOrCold;
        private string _chosenMealName;



        public BreakFast(HomePage _homePage, Mysql_Connect connect, Form1 _form1, Request_Emergency request_emerg)
		{
			InitializeComponent();
			form1 = _form1;
			_connect = connect;
			homePage = _homePage;
			diningChoice = "";
			type = "";
			_request_emerg = request_emerg;
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
			_request_emerg.CallRequest();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			homePage.Show();
			this.Hide();
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			//type = "Breakfast_Warm";
			//ColdCheckbox.Checked = false;
			//HotCheckbox.Checked = false;
			this.MealSelection.Items.Clear();
			Keywords = new List<string>();
			Keywords.Add("Breakfast_warm_item");
			Parameters = new List<string>();
			Parameters.Add("");
			ParameterValues = new List<string>();
			ParameterValues.Add("");

			expectedRows = _connect.Count("SELECT COUNT(*) FROM Breakfast_warm");

			string _returnedQuery = _connect.Select("SELECT Breakfast_warm_item FROM Breakfast_warm", expectedRows, Keywords, Parameters, ParameterValues);
			string[] Query_Results;
			string[] Items;
			Query_Results = _returnedQuery.Split('/');
			Debug.WriteLine(Query_Results.Length);
			Items = new string[Query_Results.Length];

			for (int i = 0; i < Query_Results.Length; i++)
			{

				Items[i] = Query_Results[i];
			}
			this.MealSelection.Items.AddRange(Items);
		}

        // //////////BLOCKED OUT FOR NOW TODO: REFACTOR OR REMOVE
        #region unused
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
		{

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{/*
			Parameters = new List<string>();
			Parameters.Add("User_id");
			Parameters.Add("Type_of");
			Parameters.Add("Choice");
			Parameters.Add("First_Name");
			Parameters.Add("Last_Name");
			Parameters.Add("Section");
			Parameters.Add("Room");
			Parameters.Add("Other_Request");
			ParameterValues = new List<string>();
			ParameterValues.Add(form1.UserIDProperty);
			ParameterValues.Add(type);
			ParameterValues.Add(MealSelection.Text);
			ParameterValues.Add(form1.FirstNameProperty);
			ParameterValues.Add(form1.LastNameProperty);
			ParameterValues.Add(form1.SectionProperty);
			ParameterValues.Add(form1.RoomProperty);
			ParameterValues.Add(textBox1.Text);

			_connect.Insert("INSERT INTO Requests (User_id, Type_of, Choice, First_Name, Last_Name, Section, Room, Other_Requests) VALUES (@User_id, @Type_of, @Choice, @First_Name, @Last_Name, @Section, @Room, @Other_Request);", Parameters, ParameterValues);
			MessageBox.Show("Your request has been acknowledged");*/
		}

        #endregion

        // Record what meal the resident has chosen
        private void MealSelectionBox_Changed(object sender, EventArgs e)
        {
            _chosenMealName = MealSelection.SelectedItem as string;
        }



        // What to do when cold checkbox is checked
        private void ColdCheckbox_Checked(object sender, EventArgs e)
        {
            _HotOrCold = "cold";
            HotCheckbox.Checked = false;
            WarmCheckbox.Checked = false;

            Update_ComboxBox();
        }


        // What to do when hot checkbox is checked
        private void HotCheckBoxChecked(object sender, EventArgs e)
        {
            _HotOrCold = "hot";
            ColdCheckbox.Checked = false;
            WarmCheckbox.Checked = false;

            Update_ComboxBox();
        }

        // What to do when hot checkbox is checked
        private void WarmCheckbox_Checked(object sender, EventArgs e)
        {
            _HotOrCold = "warm";
            ColdCheckbox.Checked = false;
            HotCheckbox.Checked = false;

            Update_ComboxBox();
        }




        // Update the combobox so that the correct food types are shown

        private void Update_ComboxBox()
        {
            this.MealSelection.Items.Clear();

            //string _returnedQuery = _connect.Select("SELECT Breakfast_warm_item FROM Breakfast_warm", expectedRows, Keywords, Parameters, ParameterValues);

            string THESTATEMENT = "MealType = '" + _mealType + "' AND HotOrCold = '" + _HotOrCold + "';";
            Console.WriteLine("THE STATEMENT IS" + THESTATEMENT);

            List<string> _foods = new List<string>(_connect.Select(
                "NEWFood", "FoodName", THESTATEMENT, 1));

            string[] listOfFoods = _foods.ToArray(); // Convert the list to an array so the combobox can display them

            // Have to remove the '/' in each string
            for (int i = 0; i < listOfFoods.Length; i++)
            {
                listOfFoods[i] = listOfFoods[i].Trim(new Char[] { '/' });
            }

            // Add to combo box
            this.MealSelection.Items.AddRange(listOfFoods);
        }


        private void Submit_Clicked(object sender, EventArgs e)
        {
            Requests_Handler.Add_Food(_chosenMealName, _HotOrCold, _mealType);
        }
    }
}
