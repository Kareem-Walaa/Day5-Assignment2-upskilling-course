namespace ConsoleApp1
{
    internal class Program
    {
        enum enLevel
        {
            Freshman = 1,
            Sophomore = 2,
            Junior = 3,
            Senior = 4,
        }

        struct stStudent
        {
            public string name;
            public enLevel level;
            public double course_1;
            public double course_2;
            public double course_3;
            public double course_4;
            public double course_5;
            public double avarage;

        }


        static void Main(string[] args)
        {
            stStudent[] student = new stStudent[100];

            //store student data
            int i = 0;                
            bool isOn = true;

            do
            {

                Console.WriteLine($" --> Student {i + 1} <-- ");
                Console.Write(" Enter student name : ");
                student[i].name = Console.ReadLine();
                Console.WriteLine("--------------------");
                int choice = 0;
                do {
                    Console.WriteLine(" choose grade : ");
                    int x = 1;
                    foreach (var item in Enum.GetValues(typeof(enLevel)))
                    {
                        Console.WriteLine($" {x} - {item}");
                        x++;
                    }
                    Console.Write(" choice : ");
                    choice = int.Parse(Console.ReadLine());
                    Console.WriteLine("--------------------");
                } while (choice < 1 || choice > 4);

                student[i].level = (enLevel)choice;

                Console.WriteLine(" enter grades of courses -> ");
                Console.Write(" grade 1 : ");
                student[i].course_1 = int.Parse(Console.ReadLine());
                Console.Write(" grade 2 : ");
                student[i].course_2 = int.Parse(Console.ReadLine());
                Console.Write(" grade 3 : ");
                student[i].course_3 = int.Parse(Console.ReadLine());
                Console.Write(" grade 4 : ");
                student[i].course_4 = int.Parse(Console.ReadLine());
                Console.Write(" grade 5 : ");
                student[i].course_5 = int.Parse(Console.ReadLine());

                Console.WriteLine("-------------------------------------");
                String userChoice = "";


                Console.Write(" Do you want add more student ? [Y,N] > ");
                userChoice = Console.ReadLine();
                if (userChoice.ToUpper() == "N")
                {
                    isOn = false;

                }
                else if (userChoice.ToUpper() == "Y")
                {
                    isOn = true;
                }
                i++;

            }while(isOn);


            // display students detalis 

            Console.WriteLine(" Student grades : ");

            for (int j = 0; j < student.Length; j++)
            {
                 if (!string.IsNullOrEmpty(student[j].name))

                    {
                        Console.WriteLine("---------------------------------");
                    Console.WriteLine($" --> Student {j + 1} <-- ");

                    Console.WriteLine($" - Name : {student[j].name} ");
                    Console.WriteLine($" - Level: {student[j].level}");
                    Console.WriteLine($" - course 1 : {student[j].course_1}");
                    Console.WriteLine($" - course 2 : {student[i].course_2}");
                    Console.WriteLine($" - course 3 : {student[j].course_3}");
                    Console.WriteLine($" - course 4 : {student[i].course_4}");
                    Console.WriteLine($" - course 5 : {student[j].course_5}");
                    double avg = (student[j].course_1 + student[j].course_2 + student[j].course_3 + student[j].course_4 + student[j].course_5) / 5;
                    student[j].avarage = avg;
                    Console.WriteLine($" - Average : {student[j].avarage}");
                    Console.WriteLine("---------------------------------\n");
                }

            }

            //Find The highest student

            double max = 0;
            string name = "";
            for (int j = 0; j < student.Length; j++)
            {
                if (student[j].avarage > max)
                {
                    max = student[j].avarage;
                    name = student[j].name;
                }

            }

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine($" The highest student is {name} - avarage grades : {max} ");
            Console.WriteLine("---------------------------------------------------------");

        }
    }
}





