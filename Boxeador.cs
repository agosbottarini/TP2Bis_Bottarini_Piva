using System;

class Boxeador
{
    public string Nombre{get;set;}
    public string Pais{get;set;}
    public int Peso{get;set;}
    public int PotenciaGolpes{get;set;}
    public int VelocidadPiernas{get;set;}

    public Boxeador(){}

    public Boxeador(string nombre, string pais, int peso, int pg, int vp )
    {
        Nombre = nombre;
        Pais = pais;
        Peso = peso;
        PotenciaGolpes = pg;
        VelocidadPiernas = vp;
    }

    public int ObtenerSkill()
    {
        double skill;
        int numRandom;
        numRandom = Funciones.Random(1,9);
        skill = PotenciaGolpes * 0.6 + VelocidadPiernas * 0.8 + numRandom;
        return Convert.ToInt32(skill);
    }
}