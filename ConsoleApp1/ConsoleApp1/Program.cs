using System.Diagnostics;
using ConsoleApp1.Models;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*List<Person> People = new List<Person>();
            Person jake = new Person("Jake", "Muradova", 29);
            Person anar = new Person("Anar", "Amanov", 19);

            People.Add(anar);
            People.Add(jake);
            People.FindAll(p => p.Name.Contains("Anar")).ForEach(p => Console.WriteLine(p.Name));
            bool check = People.Any(person => person.Surname.Contains("ov"));
            Console.WriteLine(check);
            People.FindAll(p=>p.Surname.Contains("ov")).ForEach(p=>Console.WriteLine(p.Surname));
            People.FindAll(p=>p.Age>20).ForEach(p=> Console.WriteLine($"Greater than 20: {p.Name}"));*/








            //2
            /*List<Exam> examlisExams = new List<Exam>();

            Exam math = new();
            Exam chemistry = new();
            Exam computerScience = new();


            examlisExams.Add(math);
            examlisExams.Add(chemistry);
            examlisExams.Add(computerScience);

            computerScience.Start("Computer Science", 250);
            math.Start("Math", 100);
            chemistry.Start("Chemistry", 500);
            /*Exam.ShowLastWeek(examlisExams);
            Console.ReadKey();

            Exam.CheckLength(examlisExams);
            Console.ReadKey();#1#
            /*Console.WriteLine(math.DateEndDate);
            Exam.StillContinue(examlisExams);#1#

            Exam.GetInfo(examlisExams);*/




            //Ulvi muellimin yazdigi
            //Concurrency
            /*Thread t1 = new Thread(Loop1);
            Thread t2 = new Thread(Loop2);
            t1.Start();
            t2.Start();
            t1.Join();
            Console.WriteLine("Salam");*/
            //Paralellisim
            /*Parallel.Invoke(Loop1,Loop2);*/

            //Lock
            /*Thread t1 = new Thread(Increase);
            Thread t2 = new Thread(Decrease);
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
            Console.WriteLine(Num);*/

            //Task
            SeherYemeyiAsync().Wait();

        }

        static async Task SeherYemeyiAsync()
        {
            Stopwatch sw = Stopwatch.StartNew();
            await Task.WhenAll(BoilSausageAsync(), MaketeaAsync(), SufreHazirlaAsync());
            /*await BoilSausageAsync();
            await MaketeaAsync();
            await SufreHazirlaAsync();*/
            Console.WriteLine(sw.ElapsedMilliseconds);
        }

        static async Task BoilSausageAsync()
        {
            await Task.Delay(5000);
            Console.WriteLine("Sausage Boiled");
        }

        static async Task MaketeaAsync()
        {
            Console.WriteLine("Caydani doldur");
            await Task.Delay(300);
            Console.WriteLine("Su qaynadi");
            Console.WriteLine("cay hazirdi");
        }

        static async Task SufreHazirlaAsync()
        {
            await Task.Delay(1500);
            Console.WriteLine("Sufre Hazirdir");
        }






        static int Num;
        private static object Anar = new();
        static void Increase()
        {
            for (int i = 0; i < 100000; i++)
            {
                lock (Anar)  
                {
                    Num++;

                }
            }
        }
        static void Decrease()
        {
            for (int i = 0; i < 100000; i++)
            {
                lock (Anar)
                {
                    Num--;

                }
            }
        }
        static void Loop1()
        {
            for (int i = 0; i < 500; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void Loop2()
        {
            for (int i = -500; i < 0; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
