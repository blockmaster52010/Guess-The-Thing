class Program {
    public static void Main(string[] args)
    {

        bool winner = false;
        Console.Write("Pick An Animal: ");
        string animal = Console.ReadLine();

        while (winner == false) {

            Console.Write("Ask A Question: ");
            string choice = Console.ReadLine();
            Console.WriteLine(choice);

            Console.WriteLine("Is It True: ");
            string awnser = Console.ReadLine(); 

            Console.Write("If you thing you know the awnser enter 'y' else 'n': ");
            string isyes = Console.ReadLine();
            if (isyes == "y") {
                Console.Write("What is the Animal: ");
                string what = Console.ReadLine();
                Console.WriteLine("Is That The Awnser y/n: ");
                string istrue = Console.ReadLine();
                if (istrue == "y") {
                    winner = true;
                }
            }
        }
    }
}