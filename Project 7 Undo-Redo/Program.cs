namespace Project_7_Undo_Redo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\n\n\t\t\t\t\t\t Undo/Redo Project\n");

            clsMyString s1 = new clsMyString();

            Console.WriteLine("\nS1 = " + s1.Value);

            s1.Value = "Abdelrahman";
            Console.WriteLine("S1 = " + s1.Value);
            
            s1.Value = "Abdelrahman2";
            Console.WriteLine("S1 = " + s1.Value);
            
            s1.Value = "Abdelrahman3";
            Console.WriteLine("S1 = " + s1.Value);

            Console.WriteLine("\n________________");

            s1.Undo();
            Console.WriteLine("\nS1 after undo = " + s1.Value);

            s1.Undo();
            Console.WriteLine("S1 after undo = " + s1.Value);
            
            s1.Undo();
            Console.WriteLine("S1 after undo = " + s1.Value);

            Console.WriteLine("\n________________");

            s1.Redo();
            Console.WriteLine("\nS1 after Redo = " + s1.Value);

            s1.Redo();
            Console.WriteLine("S1 after Redo = " + s1.Value);

            s1.Redo();
            Console.WriteLine("S1 after Redo = " + s1.Value);

        }
    }
}