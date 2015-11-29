using System;
using System.Text.RegularExpressions;
using Problem1.Prop;
using System.Collections.Generic;
using System.Linq;





namespace Problem1
{

    public class Inheritence
    {
        public static void Main()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Chiflik", "Isterov", "5869898"));
            students.Add(new Student("Minka", "Petrova", "8789755"));
            students.Add(new Student("Sashka", "Ribarova", "1251125"));
            students.Add(new Student("Boiko", "Filipov", "54687563"));
            students.Add(new Student("Cvetan", "Gospodinov", "1234456"));
            students.Add(new Student("Dimitar", "Ganchev", "6668755"));
            students.Add(new Student("Alexander", "Dimitrov", "2222222"));
            students.Add(new Student("Dobrinka", "Ivankova", "552552"));
            students.Add(new Student("Geograf", "Vasilev", "52522"));
            students.Add(new Student("Penka", "Lopatkova", "3332212"));

            foreach (var student in students.OrderBy(student => student.FacultyNumber))
            {
                Console.WriteLine("{0}{1} - Faculty number: {2}", student.FirstName, student.SecondName, student.FacultyNumber);
            }
            Console.WriteLine();

            List<Worker> workers = new List<Worker>();
            workers.Add(new Worker("Chiflik", "Isterov", 500, 8));
            workers.Add(new Worker("Minka", "Petrova", 200, 4));
            workers.Add(new Worker("Marmar", "Vylov", 500, 6));
            workers.Add(new Worker("Petar", "Yanov", 550, 8));
            workers.Add(new Worker("Yonko", "Narov", 650, 7));
            workers.Add(new Worker("Milica", "Dimitrova", 250, 2));
            workers.Add(new Worker("Ognqn", "Serafimov", 850, 8));
            workers.Add(new Worker("Evelina", "Dimitrova", 1050, 10));
            workers.Add(new Worker("Kristina", "Kirilova", 1250, 16));
            workers.Add(new Worker("Korleone", "With Al Kapone", 300, 8));

            foreach (var worker in workers.OrderByDescending(worker => worker.MoneyPerHour()))
            {
                Console.WriteLine("{0} {1} - Money per hour: {2:f2}", worker.FirstName, worker.SecondName, worker.MoneyPerHour());
            }
            Console.WriteLine();

            List<Human> studentsAndWorkers = new List<Human>();
            studentsAndWorkers.AddRange(students);
            studentsAndWorkers.AddRange(workers);

            foreach (var studentOrWorker in studentsAndWorkers.OrderBy(h => h.FirstName).ThenBy(h => h.SecondName))
            {
                Console.WriteLine("{0} {1}", studentOrWorker.FirstName, studentOrWorker.SecondName);
            }


        }
    }
}

