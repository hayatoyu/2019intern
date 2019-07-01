using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        /*
         * 90分以上是A
         * 80分以上是B
         * 70分以上是C
         * 60分以上是D
         * 其餘是E
         */
        static void Main(string[] args)
        {
            Student a = new Student();
            a.Name = "靜香";
            a.score = 83;
            Student b = new Student();
            b.Name = "出木杉";
            b.score = 90;
            Student c = new Student();
            c.Name = "胖虎";
            c.score = 68;
            Student d = new Student();
            d.Name = "葉大雄";
            d.score = 17;

            if (a.score >= 90)
                Console.WriteLine("靜香的成績是 A");
            else if (a.score >= 80)
                Console.WriteLine("靜香的成績是 B");
            else if (a.score >= 70)
                Console.WriteLine("靜香的成績是 C");
            else if (a.score >= 60)
                Console.WriteLine("靜香的成績是 D");
            else
                Console.WriteLine("靜香的成績是 E");

            if (b.score >= 90)
                Console.WriteLine("出木杉的成績是 A");
            else if (b.score >= 80)
                Console.WriteLine("出木杉的成績是 B");
            else if (b.score >= 70)
                Console.WriteLine("出木杉的成績是 C");
            else if (b.score >= 60)
                Console.WriteLine("出木杉的成績是 D");
            else
                Console.WriteLine("出木杉的成績是 E");

            if (c.score >= 90)
                Console.WriteLine("胖虎的成績是 A");
            else if (c.score >= 80)
                Console.WriteLine("胖虎的成績是 B");
            else if (c.score >= 70)
                Console.WriteLine("胖虎的成績是 C");
            else if (c.score >= 60)
                Console.WriteLine("胖虎的成績是 D");
            else
                Console.WriteLine("胖虎的成績是 E");

            if (d.score >= 90)
                Console.WriteLine("葉大雄的成績是 A");
            else if (d.score >= 80)
                Console.WriteLine("葉大雄的成績是 B");
            else if (d.score >= 70)
                Console.WriteLine("葉大雄的成績是 C");
            else if (d.score >= 60)
                Console.WriteLine("葉大雄的成績是 D");
            else
                Console.WriteLine("葉大雄的成績是 E");
        }

        #region 函數解答
        static void getGrade(Student s)
        {
            if (s.score >= 90)
                Console.WriteLine(s.Name + "的成績是 A");
            else if (s.score >= 80)
                Console.WriteLine(s.Name + "的成績是 B");
            else if (s.score >= 70)
                Console.WriteLine(s.Name + "的成績是 C");
            else if (s.score >= 60)
                Console.WriteLine(s.Name + "的成績是 D");
            else
                Console.WriteLine(s.Name + "的成績是 E");
        }
        #endregion

        class Student
        {
            public string Name;
            public int score;            
        }

        #region 屬性(存取子)使用
        class Student2
        {
            public string Name { get; set; }
            public int Score { get; private set; }
            public string Grade
            {
                get
                {
                    if (Score >= 90)
                        return "A";
                    else if (Score >= 80)
                        return "B";
                    else if (Score >= 70)
                        return "C";
                    else if (Score >= 60)
                        return "D";
                    else
                        return "E";
                }
            }

            public Student2(string name,int score)
            {
                Name = name;
                Score = score;
            }
        }
        #endregion


    }
}
