class Funciones
{ 
public static int Random(int desde, int hasta)
		{
			int num;
			Random r = new Random ();
			num = r.Next(desde, hasta+1);
			return num;
		} 
public static int IngresarEntero(string msg)
        {
            Console.WriteLine(msg);
            int num = int.Parse(Console.ReadLine());
            return num;
        }

public static string IngresarTexto(string msg)
        {
            Console.WriteLine(msg);
            string a = Console.ReadLine();
            return a;
        }
}
