namespace IntroToProgramming_ExtraLabs03
{
    internal class Course
    {
        private Student[] _students;
        private Teacher[] _teachers;
        private string _courseName;
        public Student[] Students { get { return _students; } set { _students = value; } }
        public Teacher[] Teachers { get { return _teachers; } set { _teachers = value; } }
        public string CourseName { get { return _courseName; } set { _courseName = value; } }

        public Course()
        {
            _students = new Student[3];
            _teachers = new Teacher[3];
        }
    }
}
