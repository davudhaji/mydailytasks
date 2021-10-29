using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Day0
            /*
            
            int a,b,c;
                

            Student davud = new Student("evli");
            davud.ad = "Davud";
            davud.soyad = "Haci";
            davud.bal = 350;
            davud.boy = 175;




            davud.fullName();
            
            

            a = 15;
            b = 20;
            c = 25;

            //int lst[5] = new Array();

            Console.WriteLine("Hello World!"+(a+b+c));
            string season = Console.ReadLine();




            //Switch Case Example
            switch (season)
            {
                case "yaz":
                case "yay":
                case "payiz":
                    Console.WriteLine("GGDDSS");
                    break;
                default:
                    break;
            }
            

            int reqem;
            string inpt;

            inpt = Console.ReadLine();
            reqem = Int16.Parse(inpt);

            if (reqem % 2 == 0)
            {
                Console.WriteLine("Eded Cutdur");
            }
            else
            {
                Console.WriteLine("Eded Tekdri");
            }

            */
            #endregion

            #region Day1
            /*
            IList<string> stringlist = new List<string>()
            {
                "Author Davud Haji",
                "Hacking Tools V1",
                "================="
            };

            foreach(var i in stringlist)
            {
                Console.WriteLine(i);
            }


            sbyte [] array = { 1, 5, 14, -2, 3, -25, 22 };



            foreach(var i in array)
            {
                if (i > 0){
                    Console.WriteLine("Musbetdir:"+i);
                }else
                {
                    Console.WriteLine("Menfidir:"+i);
                }
            }
            */
            #endregion

            #region Day2
            /*
            Car bmw = new Car("BMW","Qara");
            string cavab="";
            while (cavab != "cix")
            {
                Console.WriteLine(":");
                cavab = Console.ReadLine();
                if (cavab == "+")
                {
                    Console.WriteLine("Sureti ne qeder artirmaq isdersiniz?: ");
                    bmw.increase_speed(int.Parse(Console.ReadLine()));
                }
                if (cavab == "-")
                {
                    Console.WriteLine("Sureti ne qeder azaltmaq isdersiniz?: ");
                    bmw.decrease_speed(int.Parse(Console.ReadLine()));
                }
                if (cavab == "ss")
                {
                    
                }
                
            }
            */
            #endregion

            #region Day3
            /*int a, b, c;

            Console.WriteLine("1.Reqem: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("2.Reqem: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("3.Reqem: ");
            c = int.Parse(Console.ReadLine());
            int[] array = { a, b, c };
            end(array);
            */

            #endregion

            #region Day3.2
            //Console.WriteLine("1.Eded: ");
            //int reqem1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("2.Eded: ");
            //int reqem2 = int.Parse(Console.ReadLine());

            //end(reqem1, reqem2);
            #endregion

            #region Day3.3
            /*int eded = int.Parse(Console.ReadLine());
            int cem=0;
            while (eded > 1)
            {
                cem += eded % 10;
                eded = (eded - (eded % 10))/10;
                
            }
            Console.WriteLine(cem+1);*/
            #endregion

            #region Day3.4
            /*int eded = int.Parse(Console.ReadLine());
            int qiymet;
            qiymet = factorial_Recursion(eded);
            Console.WriteLine(qiymet);*/
            #endregion

            #region Day3.5
            /*int reqem = int.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());

            int eded = 0,end;

            while (reqem > 1)
            {
                eded++;
                if (eded == index)
                {
                    Console.WriteLine(reqem % 10);
                    break;
                }
                reqem = (reqem - (reqem % 10)) / 10;
                //Console.WriteLine(reqem);
                
            }*/
            #endregion

            #region Day 4
            /*
            IList<Home> homeList = new List<Home>() {
                new Home(2,3,"Xirdalan","+994775790493","Absehron/Xirdalan"),
                new Home(4,1,"Elmler","+994515319396","Baki/Yasamal"),
                


            };
            foreach(var i in homeList)
            {
                Console.WriteLine(i.cap_et());
            }


            Home ev1 = new Home(4,3,"Xirdalan Seher 28 meh","+994775790493","Absehron/Xirdalan");
            Console.WriteLine(ev1.cap_et());
            Console.ReadLine();
            Console.WriteLine("\n");


            Home ev2 = new Home(2, 5, "Masazir Akim Abbasov", "+994515319396", "Absehron/Masazir");
            Console.WriteLine(ev1.cap_et());
            Console.ReadLine();
            Console.WriteLine("\n");



            Home ev3 = new Home(1, 7, "2 ci Alatava", "+994775790493", "Baki/Yasalam");
            Console.WriteLine(ev1.cap_et());
            Console.WriteLine("\n");*/


            // My Math Task



            MyMath math = new MyMath();

            Console.WriteLine(math.pow(2));
            Console.WriteLine(math.pow(2,4));







            #endregion



        }


        #region Methods
        public static void decimal_func(int eded)
        {
            
        }

        public static int factorial_Recursion(int number)
        {
            if (number == 1)
            {
                return 1;
            }
            else
            {
                Console.WriteLine(number+"*"+(number-1));
                return number * factorial_Recursion(number - 1);//1*4+4*3+12*2

            }
        }

        static void end(int reqem1, int reqem2)
        {
            if (reqem1 > reqem2){
                Console.WriteLine("Max number: " + reqem1);
                Console.WriteLine("Min number: " + reqem2);

            }
            else
            {
                Console.WriteLine("Max number: " + reqem2);
                Console.WriteLine("Min number: " + reqem1);
            }
            Console.ReadLine();
            
        }
        #endregion




        #region Day3.1
        /*static void end(int[] array)
        {
            int max = 0;
            foreach (var i in array)
            {
                if (i > max)
                {
                    max = i;
                }
            }
            Console.WriteLine("Cavab: " + max);
        }
        */
        #endregion

    }


    /*
    class Student 
    {
        public int boy;
        public int bal;
        public string ad;
        public string soyad;

        public Student(string durum)
        {
            Console.WriteLine(durum);
        }

        public void fullName()
        {
            Console.WriteLine(ad+" "+soyad);
        }
    
    }

    */
    #region Day2.1

    /*
    public class Car
    {
        private string name;
        private int speed;
        private string color;
        public Car(string name, string color)
        {
            this.name = name;
            this.speed = 0;
            this.color = color;


        }
        public void status()
        {
            IList<string> car_status = new List<string>() 
            { 
                $"{this.name} <-- Car name",
                $"{this.speed} <-- Car speed",
                $"{this.color} <-- Car color"
            };
            Console.WriteLine("\n\n\n");
            foreach (var i in car_status)
            {
                Console.WriteLine(i);
                Console.WriteLine("===========================================");

            }
        }
        public void increase_speed(int spd)
        {
            this.speed += spd;
            status();
        }

        public void decrease_speed(int spd)
        {
            this.speed -= spd;
            status();
        }

        public void change_color(string color)
        {
            this.color = color;
            status();
        }

    }

    */
    #endregion


    public class Home
    {
        int otaqSayi;
        int mertebeSayi;
        string unvan;
        string telefon;
        string seher;
        public Home(int otaqSayi, int mertebeSayi, string unvan, string telefon, string seher)
        {
            this.otaqSayi = otaqSayi;
            this.mertebeSayi = mertebeSayi;
            this.unvan = unvan;
            this.telefon = telefon;
            this.seher = seher;

        }

        public string cap_et()
        {
            return $"Unvan: {unvan}\nTelefon: {telefon}\nSeher: {seher}\n\n";
        }


    }

    public class MyMath
    {
        public int pow(int reqem)
        {

            return reqem*reqem;
        }
        public int pow(int reqem,int quvvet)
        {
            int cem=1;
            for(int i=0; i < quvvet; i++)
            {
                cem = cem * reqem;
            }

            return cem;
        }
        public int pow(int reqem, double quvvet)
        {
            int cem = 1;
            for (int i = 0; i < quvvet; i++)
            {
                cem = cem * reqem;
            }

            return cem;
        }
    }
}