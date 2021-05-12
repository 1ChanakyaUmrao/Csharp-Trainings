using System;
using System.Collections.Generic;
using System.Linq;

namespace list
{
    abstract class ToDo // Base Class + abstract class
    {
        private string TaskName; 
        private string TaskType; 
        private string TaskDate;
        public string taskName
        {
            get{ return TaskName;}
            set{ TaskName = value;}
        }
        public string taskType
        {
            get{ return TaskType;}
            set{ TaskType = value;}
        }
        public string taskDate
        {
            get{ return TaskDate;}
            set{ TaskDate = value;}
        }
        /*
        public void setTaskName(string taskname) //methods
        {
            TaskName = taskname;  
        }
        
        public void setTasktType(string tasktime)
        {
            TaskType = tasktime;
        }

        public void setTaskDate(string taskdate)
        {
            TaskDate = taskdate;
        }
        */
        
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
    interface IPrint //interface
    {
        void Print(); // interface method (does not have a body)
    }
    
    class Second : ToDo, IPrint // Derived Class
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
    class Program
    {
        static void Main(string[] args)
        {   
            
            Console.WriteLine("To Do Console App");
            Console.WriteLine("Press y or Y if you want to do some tasks today:");
            char ans;
            try{
                ans = Convert.ToChar(Console.ReadLine());
                
            if(ans == 'y' || ans == 'Y')
            {
            Second obj1 = new Second();
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
            else
            {
                Console.WriteLine("Quit");
            }
            }
            catch(Exception e)
            {
                Console.WriteLine("Something went wrong");
                Console.WriteLine(e.Message.ToString());
            }
            
        }
    }
}