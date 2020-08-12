using System;

namespace TODOApp.BL.Models
{
    [Serializable]
    public class Task
    {
        public int TaskId { get; set; }
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsDone { get; set; }


        //Создать новое задание
        public Task(string content)
        {
            Content = content;
            IsDone = false;
            CreateDate = DateTime.UtcNow;
        }

        public override string ToString()
        {
            return $"{Content} | {CreateDate}";
        }
    }
}
