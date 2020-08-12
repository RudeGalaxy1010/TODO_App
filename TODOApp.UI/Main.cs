using System;
using System.Windows.Forms;
using TODOApp.BL.Controller;

namespace TODOApp.UI
{
    public partial class Main : Form
    {
        public TaskController Controller { get; set; }

        public Main()
        {
            InitializeComponent();
            Controller = new TaskController();
            UpdateData();
        }

        //Обновить список заданий
        private void UpdateData()
        {
            tasksDataGridView.DataSource = Controller.Tasks.ToArray();
        }

        //Добавить новое задание
        private void addButton_Click(object sender, EventArgs e)
        {
            var newTaskForm = new AddTaskForm();
            if (newTaskForm.ShowDialog() == DialogResult.OK)
            {
                Controller.AddTask(newTaskForm.Task);
                UpdateData();
            }
        }

        //Убрать выбранное задание
        private void removeButton_Click(object sender, EventArgs e)
        {
            var taskIndex = tasksDataGridView.CurrentRow.Index;
            var currentTask = Controller.Tasks[taskIndex];
            Controller.RemoveTask(currentTask);
            UpdateData();
        }

        //Отметить задание как выполненное/невыполненное
        private void tasksDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var taskIndex = tasksDataGridView.CurrentRow.Index;
            var currentTask = Controller.Tasks[taskIndex];
            Controller.EditTask(currentTask);
            UpdateData();
        }
    }
}
