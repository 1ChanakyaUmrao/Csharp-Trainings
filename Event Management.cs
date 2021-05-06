using System;

namespace EventManagement
{
    abstract class Event // Base Class + abstract class
    {
        public string eventName; 
        public string eventType; 
        public string eventDate;

        public int numOfguest; 

        public int package; 

        public int expense; 
        public string venue; 

        public void setEventName(string en)
        {
            eventName = en;  
        }
        
        public void setEventType(string et)
        {
            eventType = et;
        }

        public void setNumOfguest(int ng)
        {
            numOfguest = ng;
        }

        public void setPackage(int p)
        {
            package = p;
        }
        public void setEventDate(string ed)
        {
            eventDate = ed;
        }

        public int getExpense()
        {
            if(package == 1) 
            {
                expense = 1000*numOfguest + 100000;
                return expense;
            }

            else if(package == 2) 
            {
                expense = 500*numOfguest +50000;
                return expense;
            }

            else if(package == 3)  
            {
                expense = 300*numOfguest + 30000;
                return expense;
            }
            
            else
            {
                expense = 0; 
                return expense;
            }
        }

        public void setVenue(string sv)
        {
            venue = sv;
        }
        public abstract void Message();
        
    }
}
namespace EventManagement
{
    interface IPrint //interface
        {
            void Print(); // interface method (does not have a body)
        }
}

namespace EventManagement
{

    class Birthday : Event, IPrint // Derived Class
    {
        public override void Message()
        {
            Console.WriteLine("Thank You!!!!!!!");
        }
        public string songs;
        public void setSongsType(string st)
        {
            songs = st;
        }
        public void Print() 
        {
            Console.WriteLine("-----------------------");
        }
    }
}


namespace EventManagement
{

    class Wedding : Event // Derived Class
    {

        public override void Message()
        {
            Console.WriteLine("Thank You!!!!!!!");
        }
        public void Print() 
        {
            Console.WriteLine("-----------------------");
        }
    }
}

namespace EventManagement
{

    class Farewell : Event // Derived Class
    {
        public override void Message()
        {
            Console.WriteLine("Thank You!!!!!!!");
        }
        public void Print() 
        {
            Console.WriteLine("-----------------------");
        }
    }
}

namespace EventManagement
{
    class Program
    {
        static void Main(string[] args)
        {   
           
            Console.WriteLine("EVENT MANAGEMENT");
            Console.WriteLine("Press 5 if you want to organize an event");
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
                Console.WriteLine("Select the event "); 
                Console.WriteLine("Enter 1 for a Birthday Event.");
                Console.WriteLine("Enter 2 for a Wedding Event.");
                Console.WriteLine("Enter 3 for a Farewell Event.");
                Console.WriteLine("Enter your event selection: ");
                int selection = Convert.ToInt32(Console.ReadLine());
            
            if(selection == 1) 
            {
                Birthday obj1 = new Birthday();
                Console.WriteLine("Enter the name of event: "); 
                string name = Console.ReadLine();
                obj1.setEventName(name); 
            
                Console.WriteLine("\n");
                Console.WriteLine("Enter the type of the event: "); 
                string ptype = Console.ReadLine();
                obj1.setEventType(ptype);

                Console.WriteLine("\n");
                Console.WriteLine("Enter the Date of the event: "); 
                string dtype = Console.ReadLine();
                obj1.setEventDate(dtype);

                Console.WriteLine("\n");
                Console.WriteLine("Enter the type of songs you want to play : "); 
                string sttype = Console.ReadLine();
                obj1.setSongsType(sttype);


                
                Console.WriteLine("\n");
                Console.WriteLine("Enter the number of guests: "); 
                int nguest = Convert.ToInt32(Console.ReadLine());
                obj1.setNumOfguest(nguest);

                Console.WriteLine("\n");
                Console.WriteLine("Select the package you want for the event");
                Console.WriteLine("Press 1 for Premium Package");
                Console.WriteLine("Press 2 for Regular Package");
                Console.WriteLine("Press 3 for Budget Package");
                Console.WriteLine("Enter your choice: ");
                int package = Convert.ToInt32(Console.ReadLine()); 
                obj1.setPackage(package);


                Console.WriteLine("\n");
                Console.WriteLine("Enter your venue: "); 
                string ven = Console.ReadLine();
                obj1.setVenue(ven);

                int expenditure = obj1.getExpense(); 

                Console.WriteLine("Here's the details of the event you are planning for:\n");
                Console.WriteLine("Party Name:"+ obj1.eventName); 
                Console.WriteLine("Party Type: "+ obj1.eventType);
                Console.WriteLine("Date: "+ obj1.eventDate);
                Console.WriteLine("Songs Type: "+ obj1.songs);
                Console.WriteLine("Number of guests: "+ obj1.numOfguest);
                Console.WriteLine("Package Selected : "+ obj1.package);
                Console.WriteLine("Venue: "+obj1.venue);
                Console.WriteLine("Expense: "+obj1.expense);
                obj1.Message();
                obj1.Print();
            }

            else if(selection == 2)  
            {
                Wedding obj1 = new Wedding();
                Console.WriteLine("Enter the name of event: "); 
                string name = Console.ReadLine();
                obj1.setEventName(name); 
            
                Console.WriteLine("\n");
                Console.WriteLine("Enter the type of the party: "); 
                string ptype = Console.ReadLine();
                obj1.setEventType(ptype);
                
                Console.WriteLine("\n");
                Console.WriteLine("Enter the Date of the event: "); 
                string dtype = Console.ReadLine();
                obj1.setEventDate(dtype);

                Console.WriteLine("\n");
                Console.WriteLine("Enter the number of guests: "); // Getting estimated number of Guests.
                int nguest = Convert.ToInt32(Console.ReadLine());
                obj1.setNumOfguest(nguest);

                Console.WriteLine("\n");
                Console.WriteLine("Choose one of the following packages: ");
                Console.WriteLine("Press 1 for Premium Package");
                Console.WriteLine("Press 2 for Regular Package");
                Console.WriteLine("Press 3 for Budget Package");
                Console.WriteLine("Enter your choice: ");
                int package = Convert.ToInt32(Console.ReadLine()); 
                obj1.setPackage(package);


                Console.WriteLine("\n");
                Console.WriteLine("Enter your venue: "); 
                string ven = Console.ReadLine();
                obj1.setVenue(ven);



                int expenditure = obj1.getExpense(); 

               
                Console.WriteLine("Here's the details of the event you are planning for:\n");
                Console.WriteLine("Party Name:"+ obj1.eventName);
                Console.WriteLine("Party Type: "+ obj1.eventType);
                Console.WriteLine("Date: "+ obj1.eventDate);
                Console.WriteLine("Number of guests: "+ obj1.numOfguest);
                Console.WriteLine("Package Selected : "+ obj1.package);
                Console.WriteLine("Venue: "+obj1.venue);
                Console.WriteLine("Expense: "+obj1.expense);
                obj1.Message();
                obj1.Print();
               
            }

            else if(selection == 3)  
            {
                Farewell obj1 = new Farewell();
                Console.WriteLine("Enter the name of event: ");
                string name = Console.ReadLine();
                obj1.setEventName(name); 
            
                Console.WriteLine("\n");
                Console.WriteLine("Enter the type of the party: "); 
                string ptype = Console.ReadLine();
                obj1.setEventType(ptype);

                Console.WriteLine("\n");
                Console.WriteLine("Enter the Date of the event: "); 
                string dtype = Console.ReadLine();
                obj1.setEventDate(dtype);


                Console.WriteLine("\n");
                Console.WriteLine("Enter the number of guests: "); 
                int nguest = Convert.ToInt32(Console.ReadLine());
                obj1.setNumOfguest(nguest);

                Console.WriteLine("\n");
                Console.WriteLine("Choose one of the following packages: ");
                Console.WriteLine("Press 1 for Premium Package");
                Console.WriteLine("Press 2 for Regular Package");
                Console.WriteLine("Press 3 for Budget Package");
                Console.WriteLine("Enter your choice: ");
                int package = Convert.ToInt32(Console.ReadLine()); 
                obj1.setPackage(package);


                Console.WriteLine("\n");
                Console.WriteLine("Enter your venue: "); 
                string ven = Console.ReadLine();
                obj1.setVenue(ven);



                int expenditure = obj1.getExpense(); 

                
                Console.WriteLine("Here's the details of the event you are planning for:\n");
                Console.WriteLine("Party Name:"+ obj1.eventName); 
                Console.WriteLine("Party Type: "+ obj1.eventType);
                Console.WriteLine("Date: "+ obj1.eventDate);
                Console.WriteLine("Number of guests: "+ obj1.numOfguest);
                Console.WriteLine("Package Selected : "+ obj1.package);
                Console.WriteLine("Selected Venue: "+obj1.venue);
                Console.WriteLine("Your Total Expense is: "+obj1.expense);
                obj1.Message();
                obj1.Print();
            }

            else
            {
                Console.WriteLine("Quit");
                goto label;
            }


        }
    }
}
