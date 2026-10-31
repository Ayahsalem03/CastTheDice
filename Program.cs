namespace CastTheDice;

class Program
{
 
    static readonly Random rnd = new();
    static int game = 1;

    static void Main()
    {
        Console.WriteLine("välkommen till spelet Cast the Dice");

        while (true)
        {
            Console.WriteLine("spelnummer :{0}", game);

            int tärning1=rnd.Next(1,7);
            int tärning2=rnd.Next(1,7);
            
            int total = tärning1 + tärning2;

            Console.WriteLine("Tärning 1 :{0}", tärning1);
            Console.WriteLine("Tärning 2 :{0}", tärning2);
            Console.WriteLine("summan är : {0}", total);

            if (total == 12)
            {
                Console.WriteLine("Grattis du har vunnit!");
            }
            else
            {
                Console.WriteLine("Tyvärr, du vann inte denna gång");
            }

            Console.WriteLine(" Vill du spela en gång till? y / n");
            if (Console.ReadLine()! == "y")
            {
                game++;
                Console.WriteLine("");
                continue;
            }
            else
            {
                Environment.Exit(0);
            }
        }

    }

}
