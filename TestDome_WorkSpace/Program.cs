using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDome_WorkSpace
{
    class Program
    {
        /*public static double Average(int a, int b)
        {
            return (Convert.ToDouble(a) + Convert.ToDouble(b)) / 2;
        }*//*

        static void Main(string[] args)
        {
            *//*Console.WriteLine(Average(2, 1));
            Console.ReadLine();*//*
        }*/

        /*public class Ship<T>
        {
            private readonly Dictionary<int, object> containers;

            public Ship(int containerCount, Func<int, T> fillContainer)
            {
                this.containers = new Dictionary<int, object>();

                for (int i = 0; i < containerCount; i++)
                {
                    this.containers[i] = fillContainer(i);
                }
            }

            public T PeekContainer(int containerIndex)
            {
                return (T)this.containers[containerIndex];
            }
        }
        public int MyProperty { get; set; }

        public class Harbour
        {
            public static void Main(string[] args)
            {

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(yield new Ship<string>(10, containerIndex => "Container: " + containerIndex).PeekContainer(i));
                }
            }
        }*/
        public static void Main(string[] args)
        {
            //      LanguageTeacher teacher = new LanguageTeacher();
            //      teacher.AddLanguage("English");

            //      LanguageStudent student = new LanguageStudent();
            //      teacher.Teach(student, "English");

            //      foreach (var language in student.Languages)
            //          Console.WriteLine(language);
        }

        public class LanguageStudent
        {
            public List<string> Languages { get; set; }
            public void AddLanguage(string language)
            {
                Languages.Add(language);
            }

        }

        public class LanguageTeacher : LanguageStudent
        {
            public bool Teach(LanguageStudent student, string language)
            {
                foreach (var lang in student.Languages)
                {
                    if (lang == language)
                        return true;
                    else
                        return false;
                }
                return false;
        }
        }
        //restucture a class into an Interface
    }

    }
