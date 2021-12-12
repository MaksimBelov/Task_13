using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MultiBuilding multiBuilding = new MultiBuilding("СПб", 60, 15, 27, 9);
            multiBuilding.Print();
            Console.ReadLine();
        }
    }
    class Building
    {
        private string adress;
        private double length;
        private double width;
        private double height;

        public string Adress
        {
            get
            {
                return adress;
            }
            set
            {
                if (value == "")
                    adress = "не определен";
                else
                    adress = value;
            }

        }

        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                if (value <= 0)
                    length = 0;
                else
                    length = value;
            }
        }

        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value <= 0)
                    width = 0;
                else
                    width = value;
            }
        }

        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value <= 0)
                    height = 0;
                else
                    height = value;
            }
        }

        public Building(string adress, double length, double width, double height)
        {
            Adress = adress;
            Length = length;
            Width = width;
            Height = height;
        }

        public void Print()
        {
            Console.WriteLine("Адрес здания: {0}", Adress);

            if (Length == 0)
            {
                Console.WriteLine("Длина здания: не определена");
            }
            else
            {
                Console.WriteLine("Длина здания: {0}", Length);
            }

            if (Width == 0)
            {
                Console.WriteLine("Ширина здания: не определена");
            }
            else
            {
                Console.WriteLine("Ширина здания: {0}", Width);
            }

            if (Height == 0)
            {
                Console.WriteLine("Высота здания: не определена");
            }
            else
            {
                Console.WriteLine("Высота здания: {0}", Height);
            }
        }
    }
    sealed class MultiBuilding : Building
    {
        private int floors;

        public int Floors
        {
            get
            {
                return floors;
            }
            set
            {
                if (value == 0)
                    floors = 1;
                else
                if (value < 0)
                    floors = Math.Abs(value);
                else
                    floors = value;
            }
        }

        public MultiBuilding(string adress, double length, double width, double height, int floors)
            : base(adress, length, width, height)
        {
            Floors = floors;
        }

        public new void Print()
        {
            base.Print();
            Console.WriteLine("Количество этажей: {0}", Floors);
        }
    }
}
