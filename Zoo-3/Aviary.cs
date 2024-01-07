namespace Zoo_3
{
    class Aviary
    {
        private List<Animal> _animals = new List<Animal>();

        public void AddAnimal(Animal animal)
        {
            _animals.Add(animal);
        }

        public void ShowInfo()
        {
            Console.WriteLine($"В вольере находятся {_animals[0].Type}, {_animals.Count} особей");

            foreach (var animal in _animals)
            {
                Console.WriteLine($"{animal.Gender}  издаёт звук: {animal.Sound}");
            }
        }

        public string GetAnimalType()
        {
            return _animals[index: 0].Type;
        }
    }
}