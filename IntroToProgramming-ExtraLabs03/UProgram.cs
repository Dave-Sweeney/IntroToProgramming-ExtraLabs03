namespace IntroToProgramming_ExtraLabs03
{
    internal class UProgram
    {
        private Degree _degree;
        private string _name;

        public Degree Degree { get; set; }
        public string Name { get { return _name; } set { _name = value; } }

    }
}