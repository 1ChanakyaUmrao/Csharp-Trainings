using System;
using System.Collections.Generic;
using System.Linq;

namespace To
{
    abstract class ToDo // Base Class + abstract class
    {
        public string TaskName; 
        public string TaskType; 
        public string TaskDate;

        public void setTaskName(string tk)
        {
            TaskName = tk;  
        }
        
        public void setTasktType(string tt)
        {
            TaskType = tt;
        }

        public void setTaskDate(string td)
        {
            TaskDate = td;
        }
        
        public void tasktype()
        {
            Console.WriteLine("Todays Task:");
        }
        public void date()
        {
            string val = DateTime.Now.ToString("d/MM/yyyy");
            Console.WriteLine(val);
        }
        public abstract void Message();
        
    }
}

namespace To
{
    interface IPrint //interface
        {
            void Print(); // interface method (does not have a body)
        }
}

namespace To
{

    class In : ToDo, IPrint // Derived Class
    {
        public override void Message()
        {
            Console.WriteLine("_____________Exit_____________");
        }
        public void Print() 
        {
            Console.WriteLine("-------------------------------");
        }
    }
}

namespace To
{
    class Program
    {
        static void Main(string[] args)
        {   
            
            Console.WriteLine("To Do Console App");
            Console.WriteLine("Press 5 if you want to do some tasks today:");
            int ans = Convert.ToInt32(Console.ReadLine());
            if(ans == 5)
            {
                goto label;
                    
            }
            else
            {
                Console.WriteLine("Quit");
            }

            label:
            In obj1 = new In();
            obj1.tasktype();
            obj1.date();
            List<string> ToDolist = new List<string>();
            Console.WriteLine("Enter the no. of tasks you want to insert in the To Do List:");
            int elements = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Task one by one in the list:");
            for(int i = 0;i< elements; i++)
            {
                string j = Console.ReadLine();
                ToDolist.Add(j);
            }
            Console.WriteLine("\nNo. of tasks you have to do today: " + ToDolist.Count);
            ToDolist.Sort();
            Console.WriteLine("\nTasks in Sorted order :");
            for (int i = 0; i < elements; i++)
            {
            Console.WriteLine(ToDolist[i]);
            }  

            obj1.Print();
            obj1.Message();

        }
    }
}
