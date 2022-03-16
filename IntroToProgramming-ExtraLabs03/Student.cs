namespace IntroToProgramming_ExtraLabs03
{
    internal class Student
    {
        private static int _counter;

        public static int Counter { get { return _counter; } }

        public Student()
        {
            _counter++;
        }
    }
}