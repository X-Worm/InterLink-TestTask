namespace InternshipTest
{
    public class Knowledge
    {
        private int KnowleageLevel; // Level of the student knowelage

        public Knowledge(int level) // Constructor with 1 parameter
        {
            this.KnowleageLevel = level;
        }
        
        public int GetLevel() // return student Knowleage level
        {
            return KnowleageLevel;
        }
    }
}
