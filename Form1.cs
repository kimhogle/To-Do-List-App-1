using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_List_App_1
{
    public partial class ToDoList : Form
    {
        public ToDoList()
        {
            InitializeComponent();
        }

        DataTable todoList = new DataTable();
        bool isEditing = false;



        private void Form1_Load(object sender, EventArgs e)
        {
            // Create Columns
            todoList.Columns.Add("Title");
            todoList.Columns.Add("Description");


            // Point out datagridview to our datasource
            toDoListView.DataSource = todoList;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void newButton_Click(object sender, EventArgs e)
        {
            TitleTextBox.Text = "";
            DescriptionTextBox.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            isEditing = true;
            // Fill text fields with data from table
            TitleTextBox.Text = todoList.Rows[toDoListView.CurrentCell.RowIndex].ItemArray[0].ToString();
            DescriptionTextBox.Text = todoList.Rows[toDoListView.CurrentCell.RowIndex].ItemArray[1].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                todoList.Rows[toDoListView.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                todoList.Rows[toDoListView.CurrentCell.RowIndex]["Title"] = TitleTextBox.Text;
                todoList.Rows[toDoListView.CurrentCell.RowIndex]["Description"] = DescriptionTextBox.Text;
            }
            else
            {
                todoList.Rows.Add(TitleTextBox.Text, DescriptionTextBox.Text);
            }
            // Clear fields
            TitleTextBox.Text = "";
            DescriptionTextBox.Text = "";
            isEditing = false;
        }
    }
}
