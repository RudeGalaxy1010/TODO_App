using System;
using System.Windows.Forms;
using TODOApp.BL.Models;

namespace TODOApp.UI
{
    public partial class AddTaskForm : Form
    {
        public Task Task { get; set; }

        public AddTaskForm()
        {
            InitializeComponent();
        }

        //Закончить редактирование нового задания
        private void addButton_Click(object sender, EventArgs e)
        {
            Task = new Task(TODOtextBox.Text);
            Close();
        }
    }
}
