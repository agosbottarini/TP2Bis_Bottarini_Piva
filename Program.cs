int menu;
Boxeador boxeador1 = new Boxeador();
Boxeador boxeador2 = new Boxeador();

bool salir = false;
while(!salir)
{
     menu = Funciones.IngresarEntero("1. Cargar Datos Boxeador 1 | 2. Cargar Datos Boxeador 2 | 3. Pelear! | 4. Salir"); 
        switch(menu)
    {
        case 1:
            boxeador1 = CargarDatosBox();
        break;

        case 2:
            boxeador2 = CargarDatosBox();
        break;

        case 3:
            if(boxeador1.Peso == 0 || boxeador2.Peso == 0)
            {
                Console.WriteLine("Debe Inicializar primero el boxeador 1 y 2");
            }
            else
            {
                Pelear();
            }        
        break;

        case 4:
            salir = true;
        break;
   
    }
  
}

Boxeador CargarDatosBox()
{

    string nombre = Funciones.IngresarTexto("Ingrese el nombre del boxeador: ");
    string pais = Funciones.IngresarTexto("Ingrese el pais: ");
    int peso = Funciones.IngresarEntero("Ingrese el peso: ");
    int pg = Validacion("Ingrese la potencia de los golpes: ", "Ingrese una potencia entre 1 y 100: ");
    int vg = Validacion("Ingrese la velocidad de los golpes: ", "Ingrese una velociadad entre 1 y 100: ");
    Boxeador boxX = new Boxeador(nombre,pais,peso,pg,vg);
    return  boxX;
}

int Validacion(string msj, string msj2)
{
    int num = Funciones.IngresarEntero(msj);
    
    while(num < 1 || num > 100)
    {
        num = Funciones.IngresarEntero(msj2);
    }
    return num;
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
