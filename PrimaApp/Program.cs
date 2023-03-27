internal class Program
{
    private static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.Clear();
        // impostiamo la base della nostra tabellina
        int baseTabellina = 2;
        // decidiamo wquant evolte deve essere eseguita la molitiplicazione
        int volte = 11;
        for(int numero = 0; numero < volte; numero++)
        {
            int risultato = numero * baseTabellina;
            Console.WriteLine($"{numero} * {baseTabellina} = {risultato}");
        }
    }
}