using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_LinearSearch
{
    internal class Program
    {
        // Array of 10 names
        static string[] nameList = new string[]
       { "John","Alice","Bob","Emily", "David","Sophia","Michael","Olivia","Daniel",
            "Emma"};

        static void Main(string[] args)
        {
          
          CustomList<string> list = new CustomList<string>();
            //To check number of list
            /*for (int i = 0; i< 20; i++)
             {
                 list.Add("John");
                 list.Add("Ronda");
             }*/
            list.Add("John");
            list.Add("Elsa");
            list.Add("Rocky"); 
            list.Add("Ronda");

            //Lets remove index 2 and replace the next one
            //that shows the name of Rocky
            list.RemoveAt(2);
            list.Displayinformatio();


            //Console.WriteLine(list[3]);
        }//main

        // Tast Code
        public static void LinearCode()
        {
            // Printing the names
            /*foreach (string name in nameList)
            {
               Console.WriteLine(name);
            }*/

            string nameToSearchFor = "Jojo";
            string description = $"Does the name {nameToSearchFor} exist in the list: ";
            //Act
            bool searchResult = ContainsName(nameList, nameToSearchFor);

            //Aseert
            Console.WriteLine(description + searchResult);


            description = $"Where is {nameToSearchFor} on this list: ";
            //Act
            int indexResult = IndexOfName(nameList, nameToSearchFor);

            //Aseert
            Console.WriteLine(description + indexResult);

            if (indexResult < 0)
            {
                Console.WriteLine("The name is not on the list");
            }

            //Student List
            List<Student> students = GenerateStudents(10);

            //display the generated students
            foreach (Student student in students)
            {
                Console.WriteLine($"{student.Name}: {student.Grade}");
            }

            List<Student> studentsWithGrades = AllStudentsWithAGredeHigherThan(students, 70);
            foreach (Student student in studentsWithGrades)
            {
                Console.WriteLine(student.Name);
            }

        }

        //Contains
        // 1. Search storeDirectory for a store - true or false
        public static bool ContainsName(string[] nameList, string searchKey)
        {
            //Loop through my colaction
            

            foreach(string currentName in nameList)
            {
                //compare the current element to our serch key
                if (currentName == searchKey)
                {
                    //If the element muches, return true
                    return true;
                }
            }
            //If it does not exist in the list, return false
            return false;
        }

        // 2. Search for store by category - first store by index or -1 if not found.
         public static int IndexOfName(string[] nameList, string searchKey)
        {
            //Loop through the Array
            for (int i = 0; i < nameList.Length; i++)
            {
                //compare the current item with the searchKey
                string currentName = nameList[i];
                if (currentName == searchKey)
                {
                    return i;
                }
            }
            
            return -1;
        }

        // 3. Search for all stores of a category - List of ints
        // public static List<int> AllStoresOfACategory(string[] storeList, string searchKey);

        //Search for students with a grade higher than 70
        public static List<Student> AllStudentsWithAGredeHigherThan(List<Student> list, int grade)
        {
            List<Student> tempList = new List<Student>();
     
            //Loop
            foreach (Student student in list)
            {
                //Compare
                bool higherThan = student.Grade > grade;

                //Respond
                if (higherThan)
                {
                    tempList.Add(student);
                }
            }
            //Return
            return tempList;
        }

        // 4. Search for all stores on a floor - List of Stores
        //public static List<Store> AllStoresOnLevel(Store[] storeList, string searchKey);

        static List<Student> GenerateStudents(int numStudents)
        {
            List<Student> students = new List<Student>();
            Random random = new Random();

            for (int i = 0; i < numStudents; i++)
            {
                string name = GenerateName();
                //lets generate random grade beetween 0 and 100
                int grade = random.Next(0, 101); 
                students.Add(new Student(name, grade));

            }
            return students;
        }
        static string GenerateName()
        {//code to generate a random name.
            string[] nameList = new string[]
             { "John","Alice","Bob","Emily", "David","Sophia","Michael","Olivia","Daniel",
            "Emma"}; 
            int randomIndex = new Random().Next(nameList.Length);
            return nameList[randomIndex];
        }


    }//class

    class Student
    {
        public string Name
              { get; set; }
        public int Grade 
              { get; set; }

        public Student(string name, int grade) 
        { 
            Name = name;
            Grade = grade;
        }
    }



}//namespace
