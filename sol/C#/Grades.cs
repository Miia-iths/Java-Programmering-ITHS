using System;
using System.Linq;
/*this extra Linq is ooonly for the use of Sum,
a little unecassary but i wanted to try it out*/

namespace Grades
{
	class Program
	{
        static void readScores(string[] subject, int[] score)
        //declaring the arrays to use in method
        {
            for (int i = 0; i < subject.Length; i++)
            /*looping until the end of array
            it was a confusing formula to get a grip of first but after seeing it on w3schools
            but I understood it better after asking chatGPT to explain each little part
            and it's a very common one so felt important*/
            {
                Console.Write($"Enter score for {subject[i]}: ");
                score[i] = int.Parse(Console.ReadLine());
                /*I didn't use an error message for wrong input this time,
                since the focus was on the methods and arrays*/
            }
        }

        static void calGrades(int[] score, char[] grade)
        {
            for (int i = 0; i < score.Length; i++)
            {
                if (score[i] >= 90)
                    grade[i] = 'A';
                else if (score[i] >= 80)
                    grade[i] = 'B';
                else if (score[i] >= 70)
                    grade[i] = 'C';
                else if (score[i] >= 60)
                    grade[i] = 'D';
                else if (score[i] >= 50)
                    grade[i] = 'E';
                else
                    grade[i] = 'F';
                /*the use of "i" still confuse me sometimes because I forget it's just a variable
                a useful rule of a variable but it feels like a formula
                The exact score for each grade wasn't specified in the instructions
                but this must be the most logical right?*/
            }
        }
        static void writeGrades(string[] subject, char[] grade)
        {
            Console.WriteLine("Overview of Grades");
            for (int i = 0; i < subject.Length; i++)
            {
                Console.WriteLine($"{subject[i]}: {grade[i]}");
            }
        }

        static void statistics(char[] grade, int[] score)
        {
            int[] gradeCount = new int[6];
            /*creating yet another array so I can count the grades*/

            for (int i = 0; i < grade.Length; i++)
            {
                char result = grade[i];
                if (result == 'A') gradeCount[0]++;
                else if (result == 'B') gradeCount[1]++;
                else if (result == 'C') gradeCount[2]++;
                else if (result == 'D') gradeCount[3]++;
                else if (result == 'E') gradeCount[4]++;
                else if (result == 'F') gradeCount[5]++;
                /*this section feels kinda long which makes me wonder if there are
                more efficient ways to do this that I haven't learned yet*/
            }
            Console.WriteLine("\nGrade statistics");
            Console.WriteLine($"A: {gradeCount[0]}");
            Console.WriteLine($"B: {gradeCount[1]}");
            Console.WriteLine($"C: {gradeCount[2]}");
            Console.WriteLine($"D: {gradeCount[3]}");
            Console.WriteLine($"E: {gradeCount[4]}");
            Console.WriteLine($"F: {gradeCount[5]}\n");

            Console.WriteLine($"The total score comes to {score.Sum()}/500 out of all subjects\n\n");
            //it's not the cleanest version to use Sum but I found it while practising on w3schools and wanted to use it
        }

        static void Main(string[] args)
        {
            while (true)
            /*I put it in an infinite loop because I picture that a teacher would use this
            and there is usually more than one student to grade*/
            {
                Console.WriteLine ("Grades calculator");
                /*I'm being very short here but getting right to the point feels appropriate
                if there are many students to grade a huge welcome message each loop would be annoying*/

                string[] subject = { "Math", "Swedish", "English", "History", "Physics" };
                int[] score = new int[5];
                char[] grade = new char[5];

                readScores(subject, score);
                calGrades(score, grade);
                writeGrades(subject, grade);
                statistics(grade, score);
                /*now the main part feels super short, using the methods only once
                but good practise for methods*/
            }
        }
    }
}