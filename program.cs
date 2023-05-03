namespace Part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            int mark;
            string name = "";

            // Loop until user says no 
            while (true)
            {
                Console.Write("Enter student number : ");
                string studentNumber = Console.ReadLine();

                // Check for student number
                if (!IsValidStudentNumber(studentNumber))
                {
                    Console.WriteLine("Invalid student number. Please try again.");
                    continue;
                }


                Console.Write("Name: ");
                name = Console.ReadLine();

                // Check for empty name
                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Name cannot be empty. Please try again.");
                    continue;
                }

                Console.Write("Mark (0-100): ");

                if (!int.TryParse(Console.ReadLine(), out mark) || mark < 0 || mark > 100)
                {
                    Console.WriteLine("Invalid mark. Please try again.");
                    continue;
                }

                // Crete new object 
                Student student = new Student(studentNumber, name, mark);
                students.Add(student);

                Console.Write("Do you want to enter another student? (y/n): ");
                string answer = Console.ReadLine().ToLower();

                // Check if the user wants to enter another student or exit the loop
                if (answer != "y" && answer != "yes")
                {
                    break;
                }
            }

            // array for the grade counter 
            int[] grade = new int[6];
            foreach (Student student in students)
            {
                string studentGrade = student.GetGrade();
                switch (studentGrade)
                {
                    case "F":
                        grade[0]++;
                        break;        // can add another counter for all marks to add up all marks and find average but time cosntraint
                    case "E":
                        grade[1]++;
                        break;
                    case "D":
                        grade[2]++;
                        break;
                    case "C":
                        grade[3]++;
                        break;
                    case "B":
                        grade[4]++;
                        break;
                    case "A":
                        grade[5]++;
                        break;
                }
            }

            // displays the grade report
            Console.WriteLine("Grade report:");
            Console.WriteLine("F: " + grade[0]);
            Console.WriteLine("E: " + grade[1]);
            Console.WriteLine("D: " + grade[2]);
            Console.WriteLine("C: " + grade[3]);
            Console.WriteLine("B: " + grade[4]);
            Console.WriteLine("A: " + grade[5]);

            static bool IsValidStudentNumber(string studentNumber)
            {
                // Check for length 
                if (studentNumber.Length != 5)
                {
                    return false;
                }

                // Check for s
                if (studentNumber[0] != 's' && studentNumber[0] != 'S')
                {
                    return false;
                }

                // Check that the rest are digits 
                for (int i = 1; i < studentNumber.Length; i++)
                {
                    if (!char.IsDigit(studentNumber[i]))
                    {
                        return false;
                    }
                }

                return true;
            }
        }
    }
}
