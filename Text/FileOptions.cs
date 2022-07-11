namespace TextEditor
{
    internal class FileOptions
    {
        public static void OpenFile()
        {
            Console.Clear();
            Console.WriteLine("What's the path of the file you want to open?");
            string path = Console.ReadLine();
            using (StreamReader sr = new(path))
            {
                string text = sr.ReadToEnd(); // reads the entire file in that path
                Console.WriteLine(text);
            }

            Console.WriteLine();
            Console.ReadLine();
            Screen.Menu();
        }

        public static void EditFile()
        {
            Console.Clear();
            Console.WriteLine("Type your text below. Press ESC to exit.");
            Console.WriteLine("---------------------");
            string text = "";

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine; // so the system understands each read line as a new line and doesn't squeeze everything together without break lines 
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            SaveFile(text);
        }

        public static void SaveFile(string text)
        {
            Console.Clear();
            Console.WriteLine("What's the destination path for your file?");
            var path = Console.ReadLine();

            using (StreamWriter sw = new(path)) // using() makes sure the file is closed afterwards
            {
                sw.Write(text);
            }

            Console.WriteLine($"File {path} successfully saved.");
            Console.ReadLine();
            Screen.Menu();

        }
    }
}
