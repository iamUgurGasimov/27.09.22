using System;

namespace task__class_
{
    internal class Program
    {
        static void Main(string[] args)
        {
              
            Engineer eng1=new Engineer();
            eng1.name = "Ugur";
            eng1.surname = "Gasimov";
            eng1.age = 24;
            eng1.grade = 78;
            eng1.address = "Baku";
            




            Engineer eng2 = new Engineer();
            eng2.name = "Sabir";
            eng2.surname = "Gasimov";
            eng2.age = 29;
            eng2.grade = 84;
            eng2.address = "Baku";


            Engineer eng3 = new Engineer("Elmin","Gasimov",27);
            eng3.grade = 91;
            eng3.address = "Gence";
            Console.WriteLine(eng3.FullInfo());
            



        }
    }
}       

           
