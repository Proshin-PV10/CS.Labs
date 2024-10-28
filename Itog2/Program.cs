using System;
using System.Data.SqlTypes;
using System.Diagnostics.Metrics;
using System.Reflection.Emit;
using Itog;


class Program
{
    static void Main()

    {
    Start:
        
        StartMeny();      
        goto Start;        
    }

    public static void StartMeny()
    {
        List<Person> persons = Personlist();

        Console.WriteLine("Выберите статус:");
        Console.WriteLine("1.Администратор\n2.Менеджер\n3.Студент\n4.Преподаватель\n5.Коллекция");

        int m = int.Parse(Console.ReadLine());

        switch (m)
        {
            case 1:
                {
                    string name, dateBD, Lab;
                    InputAdmin(out name, out dateBD, out Lab);
                    Admin AD = new Admin(Lab, name, dateBD);
                    AD.Show();
                    AD.PS();
                    
                    break;

                }
            case 2:
                {
                    string name, dateBD, fac, dol;

                    InputManager(out name, out dateBD, out fac, out dol);
                    Manager MG = new Manager(fac, dol, name, dateBD);
                    MG.Show();
                    MG.PS();

                    break;

                }
            case 3:
                {
                    string name, dateBD, fac, gruppa;
                    InputStudent(out name, out dateBD, out fac, out gruppa);
                    Student ST = new Student(fac, gruppa, name, dateBD);
                    ST.Show();
                    ST.Status = true;
                    ST.PS();

                    break;

                }
            case 4:
                {
                    string name, dataBD, fac, dol, stage;
                    InputTeacher(out name, out dataBD, out fac, out dol, out stage);
                    Teacher TCH = new Teacher(fac, dol, stage, name, dataBD);
                    TCH.Show();
                    TCH.Status = true;
                    TCH.PS();

                    break;
                }
            case 5:
                {
                    ShowAllPersons(persons);
                    break;
                }
        }
    }

    private static List<Person> Personlist()
    {
        List<Person> persons = new List<Person>();
        persons.Add(new Admin("Lab1", "Иванов", "01.01.1990"));
        persons.Add(new Manager("Факультет 1", "Должность1", "Петров", "02.02.1991"));
        persons.Add(new Student("Факультет 2", "Группа1", "Сидоров", "03.03.1992"));
        persons.Add(new Teacher("Факультет 3", "Должность2", "5 лет", "Козлов", "04.04.1993"));
        persons.Add(new Admin("Lab2", "Антонов", "05.05.1994"));
        persons.Add(new Manager("Факультет 4", "Должность3", "Смирнов", "06.06.1995"));
        persons.Add(new Student("Факультет 1", "Группа2", "Кузнецов", "07.07.1996"));
        persons.Add(new Teacher("Факультет 2", "Должность4", "3 года", "Зайцев", "08.08.1997"));
        persons.Add(new Admin("Lab3", "Федоров", "09.09.1998"));
        persons.Add(new Manager("Факультет 3", "Должность5", "Морозов", "10.10.1999"));
        return persons;
    }

    public static void ShowAllPersons(List<Person> persons)
    {
        foreach (var person in persons)
        {
            person.Show();
            person.PS();
        }
    }


    private static void InputManager(out string name, out string dateBD, out string fac, out string dol)
    {
        Console.WriteLine("Введите фамилию");
        name = (Console.ReadLine());
        Console.WriteLine("Введите дату рождения");
        dateBD = (Console.ReadLine());
        Console.WriteLine("Введите названия факультета");
        fac = (Console.ReadLine());
        Console.WriteLine("Введите названия должность");
        dol = (Console.ReadLine());
    


    }

    private static void InputStudent(out string name, out string dateBD, out string fac, out string gruppa)
    {
        Console.WriteLine("Введите фамилию");
        name = (Console.ReadLine());
        Console.WriteLine("Введите дату рождения");
        dateBD = (Console.ReadLine());
        Console.WriteLine("Введите названия факультета");
        fac = (Console.ReadLine());
        Console.WriteLine("Введите названия должность");
        gruppa = (Console.ReadLine());
    }

    private static void InputTeacher(out string name, out string dateBD, out string fac, out string dol, out string stage)
    {
        Console.WriteLine("Введите фамилию");
        name = (Console.ReadLine());
        Console.WriteLine("Введите дату рождения");
        dateBD = (Console.ReadLine());
        Console.WriteLine("Введите названия факультета");
        fac = (Console.ReadLine());
        Console.WriteLine("Введите названия должность");
        dol = (Console.ReadLine());
        Console.WriteLine("Введите стаж работы");
        stage = (Console.ReadLine());
    }
    private static void InputAdmin(out string name, out string dateBD, out string Lab)
    {
        Console.WriteLine("Введите фамилию");
        name = (Console.ReadLine());
        Console.WriteLine("Введите дату рождения");
        dateBD = (Console.ReadLine());
        Console.WriteLine("Введите названия лаборатории");
        Lab = (Console.ReadLine());
    }

}

