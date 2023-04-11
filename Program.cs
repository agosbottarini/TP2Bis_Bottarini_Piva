int menu;
menu = Funciones.IngresarEntero("1. Cargar Datos Boxeador 1 | 2. Cargar Datos Boxeador 2 | 3. Pelear! | 4. Salir");
Boxeador boxeador1 = new Boxeador();
Boxeador boxeador2 = new Boxeador();
switch(menu)
{
    case 1:
        boxeador1 = CargarDatosBox();
    break;

    case 2:
        boxeador2 = CargarDatosBox();
    break;

    case 3:
        if(boxeador1.Nombre != "" && boxeador2.Nombre != "")
        {
            Pelear();
        }
        else
        {
            Console.WriteLine("Debe Inicializar primero el boxeador 1 y 2");
        }        
        
    break;
}


Boxeador CargarDatosBox()
{
    string nombre = Funciones.IngresarTexto("Ingrese el nombre del boxeador: ");
    string pais = Funciones.IngresarTexto("Ingrese el pais: ");
    int peso = Funciones.IngresarEntero("Ingrese el peso: ");
    int pg = Funciones.IngresarEntero("Ingrese la potencia de los golpes: ");
    int vg = Funciones.IngresarEntero("Ingrese la velocidad de los golpes: ");
    Boxeador boxX = new Boxeador(nombre,pais,peso,pg,vg);
    return  boxX;
}

void Pelear()
{
    string nomGanador = Ganador();
    int diferenciaPuntos;

    diferenciaPuntos = boxeador1.ObtenerSkill() - boxeador2.ObtenerSkill();

    if(diferenciaPuntos >= 30)
    {
        Console.WriteLine($"Ganó {nomGanador} por KO");
    }
    else if(diferenciaPuntos >= 10 && diferenciaPuntos < 30)
    {
        Console.WriteLine($"Ganó {nomGanador} por puntos en fallo unánime");
    }
    else
    {
        Console.WriteLine($"Ganó {nomGanador} por puntos en fallo dividido");
    }
} 

string Ganador()
{
    string ganador;
    if(boxeador1.ObtenerSkill() > boxeador2.ObtenerSkill())
    {
        ganador = boxeador1.Nombre;
    }
    else
    {
        ganador = boxeador2.Nombre;
    }
    return ganador;
}
