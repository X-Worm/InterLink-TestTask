using System.Collections.Generic;
namespace InternshipTest.Institution.InterLink
{
    public class Internship
    {
        private string InterShipName; // Name of Intership
        private List<University> Universities; // List of universities and their students are available for recruitment

        public Internship(string name)
        {
            this.InterShipName = name; // Set name of Intership 
            Universities = new List<University>();
        }

        public void AddUniversity(University university)
        {
            Universities.Add(university);
        }

        public string GetStudents()
        {
            string StudentsStr = "";
            for(int i = 0; i < Universities.Count; i++)
            {
                StudentsStr += Universities[i].GetStudentsWithGoodKnowledge() + "\n";
            }
            return StudentsStr;
        }
    }
}
