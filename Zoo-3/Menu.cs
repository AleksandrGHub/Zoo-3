namespace Zoo_3
{
    class Menu
    {
        private const string LookLionCommand = "Львы";
        private const string LookBearCommand = "Медведи";
        private const string LookHorseCommand = "Лошади";
        private const string LookTigerCommand = "Тигры";
        private const string LookElephantCommand = "Слоны";
        private const string ExitCommand = "Выход";

        private Zoo _zoo = new Zoo();

        public void Work()
        {
            string userInput;

            do
            {
                Console.Clear();
                Show();
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case LookLionCommand:
                        _zoo.ShowAviary(index: 0);
                        break;

                    case LookBearCommand:
                        _zoo.ShowAviary(index: 1);
                        break;

                    case LookHorseCommand:
                        _zoo.ShowAviary(index: 2);
                        break;

                    case LookTigerCommand:
                        _zoo.ShowAviary(index: 3);
                        break;

                    case LookElephantCommand:
                        _zoo.ShowAviary(index: 4);
                        break;
                }
            } while (userInput != ExitCommand);
        }

        private void Show()
        {
            Console.WriteLine("********************Меню********************");
            Console.WriteLine($"Для просмотра вольера введите тип животного");
            _zoo.ShowInfo();
            Console.WriteLine($"Выйти из меню, команда: {ExitCommand}");
        }
    }
}