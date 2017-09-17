using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Cars
    {
        //Vaurabels
        public string name;
        public string color;
        public float cost;
        public int year;
        //Constrcters
       public Cars(string _name,string _color,float _cost,int _year)
        {
            this.name = _name;
            this.cost = _cost;
            this.color = _color;
            this.year = _year;



        }
        public Cars(string _name, string _color)
        {
            this.name = _name;
            this.color = _color;
        }
            //Methods
            public void print()
        {

            Console.WriteLine("Name:" + name);
            Console.WriteLine("Color:" + color);
            Console.WriteLine("Cost:" + cost);
            Console.WriteLine("Year:" + year);

        }


    }
  
   




    class Program
    {
        public static void Main(string[] args)
        {

            Cars MohamadCar = new Cars("Tesla","black",20000,2018);

            MohamadCar.print();
            Console.ReadLine();
            Cars bmw = new Cars("BMW", "Red", 50000, 2018);
            bmw.print();
            Console.ReadLine();
            Cars SosoCar = new Cars("Mazda", "Red", 10000, 2018);
            SosoCar.print();
            Console.ReadLine();
            Cars SafiCar = new Cars("Mercedes","blue");
            SafiCar.print();







            Console.ReadKey();



        }
    }
}
