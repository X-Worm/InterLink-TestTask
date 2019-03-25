using System.Collections.Generic;
using InternshipTest.Person;

namespace InternshipTest.Institution
{
    public class University
    {
        private string UniversityName; // Name of University
        private List<Student> StudentList; // This container stores students of a certain university
        private int AverageKnowledge = 0; // The average level of students knowledge of the university

        public University(string name)
        {
            this.UniversityName = name;
            this.StudentList = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            this.StudentList.Add(student);
            CalculateAverageKnowLevel(StudentList);
            // every time when adding a new student we calculate the average level of student knowledge of the university
        }

        public void CalculateAverageKnowLevel(List<Student> StudentList) // Calculate average level of students
        {
            this.AverageKnowledge = 0;
            for(int i = 0; i < StudentList.Count; ++i)
            {
                this.AverageKnowledge += StudentList[i].GetKnowelageLevel();
            }
            this.AverageKnowledge /= StudentList.Count;
        }

        public  string GetStudentsWithGoodKnowledge()
        // The method returns a string of students whose level of knowledge is higher than the average
        {
            string StudentsStr = "";
            for(int i = 0; i < StudentList.Count; ++i)
            {
                if(StudentList[i].GetKnowelageLevel() > AverageKnowledge)
                {
                    StudentsStr += StudentList[i].GetName() + "\n";
                }
            }
            return StudentsStr;
        }
    }
}
