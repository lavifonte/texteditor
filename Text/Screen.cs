namespace TextEditor
{
    internal class Screen
    {
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Hey! What would you like to do? Type chosen number. Example: 1");
            Console.WriteLine("#0: exit");
            Console.WriteLine("#1: open file");
            Console.WriteLine("#2: create new file");

            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: FileOptions.OpenFile(); break;
                case 2: FileOptions.EditFile(); break;
                default: Menu(); break;
            }
        }


    }
}
