class Funciones
{ 
public static int Random(int desde, int hasta)
		{
			int num;
			Random r = new Random ();
			num = r.Next(desde, hasta+1);
			return num;
		} 
}
