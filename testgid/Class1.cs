using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struts
{
    public class MyStructClass
    {
        struct student
        {
            public string name;
            public int kurs;
            public int gender;
            public enum stud
            {
                m = 1,
                j,
                n
            }
        }
        student[] studentArray;
        public MyStructClass()
        {
            Console.WriteLine("Введите количество элементов структуры: ");
            studentArray = new student[Convert.ToInt32(Console.ReadLine())];
            Console.Clear();
            for (int i = 0; i < this.studentArray.Length; i++)
            {
                Console.WriteLine("Введите имя студента " + (i + 1) + "-го элемента: ");
                studentArray[i].name = Console.ReadLine();
                Console.WriteLine("Введите курс " + (i + 1) + "-го элемента: ");
                studentArray[i].kurs = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите пол " + (i + 1) + "-го элемента: (1 - муж, 2 - жен, 3 - неопр)");
                int type = Convert.ToInt32(Console.ReadLine());
                if (type == (int)student.stud.m)
                {
                    studentArray[i].gender = 1;
                }
                if (type == (int)student.stud.j)
                {
                    studentArray[i].gender = 2;
                }
                if (type == (int)student.stud.n)
                {
                    studentArray[i].gender = 3;
                }
                Console.Clear();
            }
        }
        public void PrintStruct()
        {
            Console.Clear();
            Console.WriteLine("Имя\tКурс\tПол\t");
            Console.WriteLine();
            for (int i = 0; i < studentArray.Length; i++)
            {
                Console.WriteLine(studentArray[i].name + "\t" + studentArray[i].kurs.ToString() + "\t" + studentArray[i].gender);
            }
        }
        public void SortStruct()
        {
            Console.Clear();
            for (int i = 0; i < studentArray.Length - 1; i++)
            {
                for (int j = 0; j < studentArray.Length - i - 1; j++)
                {
                    if (studentArray[j].kurs.CompareTo(studentArray[j + 1].kurs) != 1)
                    {
                        student kurs = studentArray[j];
                        studentArray[j] = studentArray[j + 1];
                        studentArray[j + 1] = kurs;
                    }

                }
            }
                Console.WriteLine("Нажмите любую кнопку...");
            Console.ReadKey();
            Console.Clear();
        }
     
        

        }
    }
