using System.Collections.Generic;
using TODOApp.BL.Interfaces;
using TODOApp.BL.Models;

namespace TODOApp.BL.Controller
{
    public class TaskController
    {
        public List<Task> Tasks { get; set; }
        private IDataSaver _saver { get; set; }


        //Загрузка данных
        public TaskController()
        {
            _saver = new FileDataSaver();
            Tasks = _saver.Load();
        }

        //Добавить новое задание
        public void AddTask(Task task)
        {
            task.TaskId = Tasks.Count;
            Tasks.Add(task);
            _saver.Save(Tasks);
        }

        //Отметить задание как выполненное/невыполненное
        public void EditTask(Task task)
        {
            task.IsDone = !task.IsDone;
            _saver.Save(Tasks);
        }

        //Убрать задание
        public void RemoveTask(Task task)
        {
            if (Tasks.Contains(task))
            {
                Tasks.Remove(task);
                _saver.Save(Tasks);
            }
        }
    }
}
