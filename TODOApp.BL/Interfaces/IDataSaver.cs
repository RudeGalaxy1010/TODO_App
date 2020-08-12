using System.Collections.Generic;
using TODOApp.BL.Models;

namespace TODOApp.BL.Interfaces
{
    public interface IDataSaver
    {
        void Save(List<Task> tasks);
        List<Task> Load();
    }
}
