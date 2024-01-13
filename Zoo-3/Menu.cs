namespace Zoo_3
{
    class Menu
    {
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

                if (int.TryParse(userInput, out int number))
                {
                    _zoo.ShowAviary(number - 1);
                }
            } while (userInput != ExitCommand);
        }

        private void Show()
        {
            Console.WriteLine("******************Меню*****************");
            Console.WriteLine($"Для просмотра вольера введите его номер\n");
            _zoo.ShowInfo();
            Console.WriteLine($"\nВыйти из меню, команда: {ExitCommand}");
        }
    }
}