using FileManager.Common.Layer;
using System;
using System.IO;


namespace FileManager.DataAccess.Data.DaoPersistenceTXT
{
    public class DaoStudentTXT
    {
        private static readonly String FileName = "./Students.txt";
        public static Student Create(Student student)
        {

            string line = student.Id.ToString() + ";" + student.Name + ";" + student.AgeOfBirth.ToString();
            using (StreamWriter file = new StreamWriter(FileName, true))
            {
                file.WriteLine(line);
            }

            return student;
        }

        public static void All()
        {

            string[] lines = File.ReadAllLines(FileName);
            foreach (var line in lines)
            {
                var values = line.Split(';');
                Console.WriteLine(values[0] + " " + values[1] + " " + values[2]);

            }

        }
    }
}
