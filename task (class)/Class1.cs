using System;
using System.Collections.Generic;
using System.Text;

namespace task__class_
{
    class Engineer
    {
        public string name;
        public string surname;
        public int age;
        public int grade;
        public string address;

        public Engineer()
        {

        }

        public Engineer(string n, string s)
        {
            name = n;
            surname = s;    

        }

        public Engineer(string n, string s,int a):this(n,s)
        {
            
            age = a;
            

        }



        public string Info()
        {
             
            return $"name: {name} surname: {surname}";
        }

        public string FullInfo()
        {
            return $"{Info()} age : {age} grade : {grade} address : {address}";
        }
    }
}
