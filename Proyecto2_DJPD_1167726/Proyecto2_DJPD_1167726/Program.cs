using Proyecto2_DJPD_1167726;

Console.WriteLine("GRANJA DENNIS");
Console.WriteLine("Ingrese la cantidad de dinero inicial");
double dinero = double.Parse(Console.ReadLine());

while (dinero <= 0) //validacion dinero
{
    Console.WriteLine("Ingrese una cantidad mayor a 0");
    dinero = double.Parse(Console.ReadLine());
}
Console.Clear();
Console.WriteLine("Ingrese el numero de empleados");
int numEmpleados = int.Parse(Console.ReadLine());

while (numEmpleados <= 0) //validacion empleados
{
    Console.WriteLine("Ingrese un número válido mayor a 0");
    numEmpleados = int.Parse(Console.ReadLine());
}
Console.Clear();
Console.WriteLine("Ingrese el sueldo mensual para los trabajadores");
double sueldoMensu = double.Parse(Console.ReadLine());

while (sueldoMensu <= 0)//validacion sueldo
{
    Console.WriteLine("Ingrese un sueldo mayor a 0");
    sueldoMensu = double.Parse(Console.ReadLine());
}
Console.Clear();
Console.WriteLine("ingrese los meses a simular");
int meses = int.Parse(Console.ReadLine());

while (meses <= 0) //validacion meses 
{
    Console.WriteLine("Ingrese una cantidad válida");
    meses = int.Parse(Console.ReadLine());
}
Console.Clear();
Console.WriteLine("ingrese las filas para la parcela");
int filas = int.Parse(Console.ReadLine());

while (filas <= 0) //validacion filas
{
    Console.WriteLine("Ingrese una cantidad válida");
    filas = int.Parse(Console.ReadLine());
}
Console.Clear();
Console.WriteLine("ingrese las columnas para la parcela");
int columnas = int.Parse(Console.ReadLine());

while (columnas <= 0) //validacion columnas
{
    Console.WriteLine("Ingrese una cantidad válida");
    filas = int.Parse(Console.ReadLine());
}
;
Console.Clear();
Parcela [,] parcela = new Parcela[filas, columnas]; //Matriz con parcela 

double dineroActual = dinero;
double costosMensuales = numEmpleados * sueldoMensu;
int trigo = 0;
int repollo = 0;
int tomate = 0;
int calabaza = 0;
int esparrago = 0;
// Semillas la infomracion se guarda en la clase
Semillas trigoCult = new Semillas("Trigo", 1, 100, 130);
Semillas repolloCult = new Semillas("Repollo", 2, 180, 280);
Semillas tomateCult = new Semillas("Tomate", 3, 250, 450);
Semillas calabazaCult =  new Semillas("Calabaza", 4, 220, 360);
Semillas esparragoCult =new Semillas("Espárrago", 6, 500, 1000);

int mesActual = 0;
double ingresosTotales = 0;
double materiaPrima = 0;

int menu;
do
{
   //menu de opciones
    Console.WriteLine("1.COMPRAR SEMILLAS");
    Console.WriteLine("2.SEMBRAR");
    Console.WriteLine("3.CONSULTAR PARCELAS");
    Console.WriteLine("4.AVANZAR MES");
    Console.WriteLine("5.SALIR");
    menu = int.Parse(Console.ReadLine());

    
    while (menu < 1 || menu > 5) //validacion para que solo pueda ingresar de 1 a 5
    {

        Console.WriteLine("La opción ingresada no es válida. Ingrese un número del 1 al 5: ");
        
        menu = int.Parse(Console.ReadLine());
        
    }

    Console.Clear();

  

    switch (menu)
    {
        case 1:

            double utilidad = dineroActual - costosMensuales;

            Console.WriteLine("Dinero Disponible:" + dineroActual);
            Console.WriteLine("Costos Mensuales Proyectados:" + costosMensuales);
            Console.WriteLine("La utilidad es:" + utilidad );
            if (utilidad >= 0 ) //validacion si utilidades es mayor a 0
            {
                Console.WriteLine("1. " + trigoCult.nombre + " | Tiempo: " + trigoCult.tiempo + " | Costo: " + trigoCult.costo + " | Ganancia: " + trigoCult.ganacia);

                Console.WriteLine("2. " + repolloCult.nombre + " | Tiempo: " + repolloCult.tiempo + " | Costo: " + repolloCult.costo + " | Ganancia: " + repolloCult.ganacia);

                Console.WriteLine("3. " + tomateCult.nombre + " | Tiempo: " + tomateCult.tiempo + " | Costo: " + tomateCult.costo + " | Ganancia: " + tomateCult.ganacia);

                Console.WriteLine("4. " + calabazaCult.nombre + " | Tiempo: " + calabazaCult.tiempo + " | Costo: " + calabazaCult.costo + " | Ganancia: " + calabazaCult.ganacia);

                Console.WriteLine("5. " + esparragoCult.nombre + " | Tiempo: " + esparragoCult.tiempo + " | Costo: " + esparragoCult.costo + " | Ganancia: " + esparragoCult.ganacia);
                int semillas = int.Parse(Console.ReadLine());

                while (semillas < 1 || semillas > 5) //validacion que permite ingresar solo de 1 al 5 
                {
                    Console.WriteLine("Ingrese una opción válida");
                    semillas = int.Parse(Console.ReadLine());
                }

                if (semillas == 1) 
                {
                    Console.WriteLine("¿Cuántas semillas de trigo desea?");
                    Console.WriteLine("¿Cuántas semillas de trigo desea?");
                    int cantidad = int.Parse(Console.ReadLine());

                    while (cantidad <= 0)
                    {
                        Console.WriteLine("Ingrese una cantidad mayor a 0");
                        cantidad = int.Parse(Console.ReadLine());
                    }
                    double total = cantidad * trigoCult.costo;

                    if (dineroActual >= total)
                    {
                        trigo += cantidad;
                        dineroActual -= total;
                        materiaPrima += total;

                        Console.WriteLine("Compra realizada");
                    }
                    else
                    {
                        Console.WriteLine("Dinero Insuficiente");
                    }
                }

                else if (semillas == 2)
                {
                    Console.WriteLine("¿Cuántas semillas de repollo desea?");
                    int cantidad = int.Parse(Console.ReadLine());

                    while (cantidad <= 0)
                    {
                        Console.WriteLine("Ingrese una cantidad mayor a 0");
                        cantidad = int.Parse(Console.ReadLine());
                    }
                    double total = cantidad * repolloCult.costo;

                    if (dineroActual >= total)
                    {
                        repollo += cantidad;
                        dineroActual -= total;
                        materiaPrima += total;

                        Console.WriteLine("Compra realizada");
                    }
                    else
                    {
                        Console.WriteLine("Dinero Insuficiente");
                    }
                }
                else if (semillas == 3)
                {
                    Console.WriteLine("¿Cuántas semillas de tomate desea?");
                    int cantidad = int.Parse(Console.ReadLine());

                    while (cantidad <= 0)
                    {
                        Console.WriteLine("Ingrese una cantidad mayor a 0");
                        cantidad = int.Parse(Console.ReadLine());
                    }
                    double total = cantidad * tomateCult.costo;

                    if (dineroActual >= total)
                    {
                        tomate += cantidad;
                        dineroActual -= total;
                        materiaPrima += total;

                        Console.WriteLine("Compra realizada");
                    }
                    else
                    {
                        Console.WriteLine("Dinero Insuficiente");
                    }
                }
                else if (semillas == 4)
                {
                    Console.WriteLine("¿Cuántas semillas de calabaza desea?");
                    int cantidad = int.Parse(Console.ReadLine());

                    while (cantidad <= 0)
                    {
                        Console.WriteLine("Ingrese una cantidad mayor a 0");
                        cantidad = int.Parse(Console.ReadLine());
                    }
                    ;
                    double total = cantidad * calabazaCult.costo;

                    if (dineroActual >= total)
                    {
                        calabaza += cantidad;
                        dineroActual -= total;
                        materiaPrima += total;

                        Console.WriteLine("Compra realizada");
                    }
                    else
                    {
                        Console.WriteLine("Dinero Insuficiente");
                    }
                }
                else if (semillas == 5)
                {
                    Console.WriteLine("¿Cuántas semillas de esparrago desea?");
                    int cantidad = int.Parse(Console.ReadLine());

                    while (cantidad <= 0)
                    {
                        Console.WriteLine("Ingrese una cantidad mayor a 0");
                        cantidad = int.Parse(Console.ReadLine());
                    }
                    double total = cantidad * esparragoCult.costo;

                    if (dineroActual >= total)
                    {
                        esparrago += cantidad;
                        dineroActual -= total;
                        materiaPrima += total;

                        Console.WriteLine("Compra realizada");
                    }
                    else
                    {
                        Console.WriteLine("Dinero Insuficiente");
                    }
                }
                else
                {
                    Console.WriteLine("Opción inválida");
                }

            }
            else
            {
            Console.WriteLine("Cantidad de dinero Insuficiente");
            }
            Console.ReadKey();
            Console.Clear();
            break;
        case 2:
            int continuarSiembra;
            do // ciclo para sembrar 
            {
            
            Console.WriteLine("Ingrese la fila donde desea plantar");
            int filaPlantar = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la columna donde desea plantar");
            int columnaPlantar = int.Parse(Console.ReadLine());
            Console.Clear();

            if (filaPlantar >= 0 && filaPlantar < filas) //validacion para las filas
            {
                if (columnaPlantar >= 0 && columnaPlantar < columnas) //validacion para las columnas
                {

                    
                    if (parcela[filaPlantar, columnaPlantar] == null)
                    {

                        Console.WriteLine("La cantidad de semillas de trigo que tienes es: " + trigo);

                        Console.WriteLine("La cantidad de semillas de repollo que tienes es: " + repollo);

                        Console.WriteLine("La cantidad de semillas de tomate que tienes es: " + tomate);

                        Console.WriteLine("La cantidad de semillas de calabaza que tienes es: " + calabaza);

                        Console.WriteLine("La cantidad de semillas de espárrago que tienes es: " + esparrago);

                        Console.WriteLine("¿Qué desea plantar?");
                        //menu para que escoja que tipo de semilla quiere plantar 
                        Console.WriteLine("1. Trigo");
                        Console.WriteLine("2. Repollo");
                        Console.WriteLine("3. Tomate");
                        Console.WriteLine("4. Calabaza");
                        Console.WriteLine("5. Espárrago");

                        int plantar = int.Parse(Console.ReadLine());

                            while (plantar < 1 || plantar > 5)
                            {
                                Console.WriteLine("Ingrese una opción válida");
                                plantar = int.Parse(Console.ReadLine());
                            }

                            if (plantar == 1)
                        {
                            if (trigo > 0)
                            {
                                parcela[filaPlantar, columnaPlantar] = new Parcela("Trigo", 1, true, 130);

                                trigo--;

                                Console.WriteLine("Trigo sembrado correctamente");
                            }
                            else
                            {
                                Console.WriteLine("No tiene semillas de trigo");
                            }
                        }
                        else if (plantar == 2)
                        {
                            if (repollo > 0)
                            {
                                parcela[filaPlantar, columnaPlantar] = new Parcela("Repollo", 2, true, 280);

                                repollo--;

                                Console.WriteLine("Repollo sembrado correctamente");
                            }
                            else
                            {
                                Console.WriteLine("No tiene semillas de repollo");
                            }
                        }

                        else if (plantar == 3)
                        {
                            if (tomate > 0)
                            {
                                parcela[filaPlantar, columnaPlantar] = new Parcela("Tomate", 3, true, 450);

                                tomate--;

                                Console.WriteLine("Tomate sembrado correctamente");
                            }
                            else
                            {
                                Console.WriteLine("No tiene semillas de tomate");
                            }
                        }

                        else if (plantar == 4)
                        {
                            if (calabaza > 0)
                            {
                                parcela[filaPlantar, columnaPlantar] = new Parcela("Calabaza", 4, true, 360);

                                calabaza--;

                                Console.WriteLine("Calabaza sembrada correctamente");
                            }
                            else
                            {
                                Console.WriteLine("No tiene semillas de calabaza");
                            }
                        }

                        else if (plantar == 5)
                        {
                            if (esparrago > 0)
                            {
                                parcela[filaPlantar, columnaPlantar] = new Parcela("Espárrago", 6, true, 1000);

                                esparrago--;

                                Console.WriteLine("Espárrago sembrado correctamente");
                            }
                            else
                            {
                                Console.WriteLine("No tiene semillas de espárrago");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Opción inválida");
                        }

                    }
                    else
                    {
                        Console.WriteLine("La parcela ya está ocupada");
                    }

                }
                else
                {
                    Console.WriteLine("Columna inválida");
                }
            }
            else
            {
                Console.WriteLine("Fila inválida");
            }
                
                Console.Clear();

                Console.WriteLine("¿Desea seguir sembrando?");
                Console.WriteLine("1. Sí");
                Console.WriteLine("2. No");

                continuarSiembra = int.Parse(Console.ReadLine());

                while (continuarSiembra != 1 && continuarSiembra != 2)
                {
                    Console.WriteLine("Ingrese 1 para Sí o 2 para No");
                    continuarSiembra = int.Parse(Console.ReadLine());
                }

                Console.Clear();
            }
            while (continuarSiembra == 1);

            Console.Clear();


            break;
            case 3:
            Console.WriteLine("MAPA DE PARCELA");

            for (int i = 0; i < filas; i++) //recorre la matriz para poder mostrar que espacios estan opucados y cuales no 
            {
                for (int j = 0; j < columnas; j++)
                {

                    if (parcela[i, j] == null) 
                    {
                        Console.Write("[ Libre ]");
                    }
                    else
                    {
                        Console.Write("[ Ocupada ]");
                    }

                }

                Console.WriteLine();
            }

            Console.WriteLine("Ingrese la fila que desea consultar");
            int filaConsult = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la columna que desea consultar");
            int columnaConsult = int.Parse(Console.ReadLine());

            if (filaConsult >= 0 && filaConsult < filas &&
                columnaConsult >= 0 && columnaConsult < columnas)
            {
                if (parcela[filaConsult, columnaConsult] != null)//validacion de la parcela 
                {
                    Console.WriteLine("Cultivo: " + parcela[filaConsult, columnaConsult].tipoCultivo); //imprime los datos de cada cultivo que se desea consultar 

                    Console.WriteLine("Tiempo restante: " + parcela[filaConsult, columnaConsult].tiempoRestante);

                    Console.WriteLine("Ganancia esperada: " + parcela[filaConsult, columnaConsult].gananciaEsperada);
                }
                else
                {
                    Console.WriteLine("Parcela vacía");
                    Console.WriteLine("Los ingresos esperados son de Q.0.00");
                }
            }
            else
            {
                Console.WriteLine("Posición inválida");
            }

            Console.ReadKey();
            Console.Clear();
            break;
            
        case 4:
            
            mesActual++;

            Console.WriteLine("Mes actual: " + mesActual);
          
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
  
                    if (parcela[i, j] != null)
                    {

                        parcela[i, j].Crecer(); //funcion de clase para hacer crecer al cultivo 

                        Console.WriteLine("La parcela [" + i + "," + j + "] avanzó un mes");

                        
                        if (parcela[i, j].tiempoRestante == 0) // Cuando el cultivo se sembro correctamente
                        {

                            Console.WriteLine("Cultivo cosechado: " +
                                parcela[i, j].tipoCultivo);
    
                            double ganancia =
                                parcela[i, j].Cosechar();// Desocupa la parcela 

                           
                            dineroActual += ganancia;
                            ingresosTotales += ganancia;

                            Console.WriteLine("Ganancia obtenida: Q." + ganancia);

                            parcela[i, j] = null;
                        }
                    }
                }
            }

            
            dineroActual -= costosMensuales;

            Console.WriteLine("Pago de empleados realizado: Q." + costosMensuales);

            Console.WriteLine("Dinero actual: Q." + dineroActual);

          
            if (mesActual >= meses)
            {
                Console.WriteLine("La simulación ha finalizado");

                menu = 5;
            }

            if (dineroActual <= 0)
            {
                Console.WriteLine("Se quedó sin dinero"); 

                menu = 5;
            }
            Console.ReadKey();
            Console.Clear();
            break;
            

            case 5:
            break;
    }
    if (dineroActual <= 0)
    {
        Console.WriteLine("La simulación terminó por falta de dinero");

        menu = 5;
    }

} while (menu != 5) ;
double manoDeObra =
    numEmpleados * sueldoMensu * mesActual;

double inventarioProceso = 0;


for (int i = 0; i < filas; i++)
{
    for (int j = 0; j < columnas; j++)
    {

        if (parcela[i, j] != null)
        {
            inventarioProceso +=
                parcela[i, j].gananciaEsperada;
        }
    }
}

double utilidades = dinero + ingresosTotales + inventarioProceso - manoDeObra - materiaPrima;

Console.Clear();

Console.WriteLine("REPORTE FINAL");//reporte final

Console.WriteLine("Capital inicial: Q." + dinero);

Console.WriteLine("Ingresos: Q." + ingresosTotales);

Console.WriteLine("Inventario en proceso: Q." + inventarioProceso);

Console.WriteLine("Mano de obra: Q." + manoDeObra);

Console.WriteLine("Materia prima: Q." + materiaPrima);

Console.WriteLine("Utilidades finales: Q." + utilidades);