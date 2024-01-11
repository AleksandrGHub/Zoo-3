namespace Zoo_3
{
    class Zoo
    {
        private Random _random = new Random();

        private List<Aviary> _aviarys = new List<Aviary>();

        public Zoo()
        {
            AddAnimals();
        }

        public void ShowAviary(int index)
        {
            if (index >= 0 & index < _aviarys.Count)
            {
                _aviarys[index].ShowInfo();
            }
            else
            {
                Console.WriteLine("Введите номер вольера");
            }

            Console.ReadKey();
        }

        public void ShowInfo()
        {
            Console.WriteLine("{0,13} {1,25}", "Номер вольера", "Название животных");

            for (int i = 0; i < _aviarys.Count; i++)
            {
                Console.WriteLine("{0,13} {1,25}", i + 1, _aviarys[i].GetAnimalType());
            }
        }

        private void AddAnimals()
        {
            int minNumberAnimals = 5;
            int maxNumberAnimals = 10;
            int numberAnimals;

            List<Factory> factorys = new List<Factory>()
            {
                new LionFactory(),
                new BearFactory(),
                new HorseFactory(),
                new TigerFactory(),
                new ElephantFactory()
            };

            Aviary aviary;

            for (int i = 0; i < factorys.Count; i++)
            {
                aviary = new Aviary();

                numberAnimals = _random.Next(minNumberAnimals, maxNumberAnimals);

                for (int j = 0; j < numberAnimals; j++)
                {
                    aviary.AddAnimal(factorys[i].Create());
                }

                _aviarys.Add(aviary);
            }
        }
    }
}