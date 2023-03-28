internal class Program
{
    private static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.Clear();

        bool richiestaTabellina = true;
        while (richiestaTabellina)
        {
            // impostiamo la base della nostra tabellina
        string richiesta = chiedi("Che tabellina vuoi");
        int richiestaNumero = chiediNumero("Fino a che numero?");

        int baseTabellina = int.Parse(richiesta);
        // decidiamo wquant evolte deve essere eseguita la molitiplicazione
        int volte = richiestaNumero+1;
        for(int numero = 0; numero < volte; numero++)
        {
            int risultato = numero * baseTabellina;
            Console.WriteLine($"{baseTabellina}\t*\t{numero}\t=\t{risultato}");//writeline mette un "a capo in fondo"
            //Console.WriteLine(numero.ToString() +" * "+baseTabellina.ToString()+" = "+risultato.ToString());
        }

            string risposta = chiedi("Vuoi un'altra tabellina? (s/n)");
            richiestaTabellina = risposta == "s";
        }
        Console.WriteLine("Buona giornata!");
    }

    /// <summary>
    /// funzione per porre una domanda all'utente tramite console
    /// </summary>
    /// <param name="domanda">la domanda da oorre al'utente</param>
    /// <returns>quello che l'utente a scritto in console</returns>

    private static string chiedi(string domanda)
    {
        //scrivo la domanda in console
        Console.Write(domanda + ": ");
        //recupero dal buffer la risposta
        string risposta = Console.ReadLine();
        //la restituisco a chi mi ha chiamato
        return risposta;
    }
    public static int chiediNumero(string domanda)
    {
        Console.Write(domanda + ": ");
        int finoA = int.Parse(Console.ReadLine());
        //la restituisco a chi mi ha chiamato
        return finoA;
    }
}