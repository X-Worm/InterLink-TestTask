namespace InternshipTest.Person
{
    public class Student
    {
        private string StudentName; // Name of the student
        private Knowledge StudentKnowleage; // Student Knowledge level

        

        public Student(string name)
        {
            this.StudentName = name; // Set Student name 
            StudentKnowleage = new Knowledge(0); // Set default student knowledge
        }

        public Student(string name , int level)
        {
            this.StudentName = name; // Set Student name 
            StudentKnowleage = new Knowledge(level); // Set default student knowledge
        }

        public void SetKnowledge(Knowledge knowledge)
        {
            this.StudentKnowleage = knowledge;
        }

        public int GetKnowelageLevel()
        {
            return this.StudentKnowleage.GetLevel();
        }

        public string GetName()
        {
            return StudentName;
        }
    }
}