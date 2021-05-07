using System;
class Car
{
    public string engine;
    public string soundSystem;
    public string tyre;
    static void Engine()
    {
        Console.WriteLine("240-Horse Power Engine");
    }

    static void sound()
    {
        Console.WriteLine(" ");
    }

    static void Tyre()
    {
        Console.WriteLine("Mrf");
    }
}

interface Icolor
{
    public void color();
}

class second: Car, Icolor
{
    public void color()
    {
        Console.WriteLine("Red");
    }
}
namespace que{
    class que: Car
    {
        static void Main(string[] args)
        {
            Car obj1 = new Car();
            Console.WriteLine("Do You want to know about engine");
            int ans = Convert.ToInt32(Console.ReadLine());
            if(ans == 1)
            {
                obj1.Engine();
            }
            else{
                Console.WriteLine("Quit");
            }
            obj1.sound();
            obj1.Tyre();
            
        }

    }

}

        
 