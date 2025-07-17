using System;
namespace SOLID.I
{
	//public interface ILead
	//{
	//	void CreateTask();
	//	void AssignTask();
	//	void WorkOnTask();
	//}

	public interface ICreate
	{
        void CreateTask();
    }
    public interface IAssign
    {
        void AssignTask();
    }
    public interface IWork
    {
        void WorkOnTask();
    }
}

