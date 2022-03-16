namespace IntroToProgramming_ExtraLabs03
{
    internal class Degree
    {
        private Course _course;
        private string _degreeLevel;

        public string DegreeLevel { get { return _degreeLevel; } set { _degreeLevel = value; } }
        public Course Course { get { return _course; } set { _course = value; } }
    }
}