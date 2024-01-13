namespace Zoo_3
{
    class Animal
    {
        private Random _random = new Random();

        public Animal(string type, string sound)
        {
            Type = type;
            Sound = sound;
            Gender = GetGender();
        }

        public string Type { get; private set; }
        public string Sound { get; private set; }
        public string Gender { get; private set; }

        private string GetGender()
        {
            string[] genders = new string[] { "Самец", "Самка" };
            return genders[_random.Next(genders.Length)];
        }
    }
}