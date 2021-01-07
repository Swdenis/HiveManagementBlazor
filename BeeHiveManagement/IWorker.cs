using System;
namespace BeeHiveManagement
{
    public interface IWorker
    {
        string Job { get; }
        void WorkTheNextShift();
    }
}
