namespace annee_bissextile;

class Program
{
    static void Main(string[] args)
    {
		// Une application console qui indique si l’année (du calendrier grégorien. Par exemple, 2026) rentrée par l’utilisateur est bissextile ou non.
		// Les années bissextiles sont soit divisibles par 4 mais pas par 100, soit divisibles par 400.


		Console.WriteLine("> Veuillez insérer une année :");

        int reponse = int.Parse(Console.ReadLine());

		if (reponse % 400 == 0 || (reponse % 4 == 0 && reponse % 100 != 0))
		{
			Console.WriteLine(reponse + " est bissextile.");
		}
		else
		{
			Console.WriteLine(reponse + " n'est pas bissextile.");
		}
	}
}