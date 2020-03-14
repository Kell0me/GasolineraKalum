using static GasolineraKalum.Util.Printer;
using static System.Console;
using System;
using GasolineraKalum.Controllers;
using GasolineraKalum.Entities;

namespace GasolineraKalum.Menu
{
    public class MenuPrincipal
    {
        private GasolineraController controller = new GasolineraController();

        public void MostrarMenu()
        {
            try
            {
                int opcion = 0;
                do
                {
                    Clear();
                    WriteTitle("Administracion de Bombas");
                    WriteTitle("1. Agregar");
                    WriteTitle("2. Eliminar");
                    WriteTitle("3. Buscar");
                    WriteTitle("4. Listar");
                    WriteTitle("5. Modificar");
                    WriteTitle("0. Salir");
                    WriteLine("Ingrese una opcion===> ");
                    string respuesta = ReadLine();
                    opcion = Convert.ToByte(respuesta);
                    
                    switch (opcion)
                    {
                        case 1:
                            AgregarTipoBomba();
                            break;
                        case 2:
                            eliminar();
                            break;
                        case 3:
                            buscar();
                            break;
                        case 4:
                            listarBombas();
                            break;
                        case 5:
                            modificar();
                            break;
                        case 0:
                            break;
                        default:
                            WriteLine("No Existe la opicion");
                            break;
                    }

                } while (opcion != 0);
            }
        catch (Exception e)
        {
            WriteLine(e.Message);
        }

              


    }
    private void AgregarTipoBomba()
    {
        WriteTitle("Tipo de Bomba");
        WriteLine("1. Super");
        WriteLine("2. Regular");
        WriteLine("3. Diesel");
        WriteLine("0. Salir");
        WriteLine("Seleccione una opcion==>");
        string respuesta = ReadLine();
        if(respuesta.Equals("1")){
            Bomba super = new Super();
            AgregarElemento(super);
        }else if(respuesta.Equals("2"))
        {
            Bomba regular = new Regular();
            AgregarElemento(regular);
        }
        else if(respuesta.Equals("3"))
        {
            Bomba diesel = new Diesel();
            AgregarElemento(diesel);
        }


        }

    
    private void AgregarElemento(Bomba elemento)
    {
            WriteLine("Ingrese un precio");
            elemento.Precio = Convert.ToDouble(ReadLine());
            WriteLine("Ingrese una medida");
            elemento.Medida = ReadLine();
            WriteLine("Ingrese una Capacidad");
            elemento.Capacidad = Convert.ToInt16(ReadLine());
            if(elemento.GetType() == typeof(Super))
            {
                WriteLine("Ingrese numero de aditivo");
                ((Super)elemento).Aditivo =  Convert.ToInt16(ReadLine());
                
            }else if(elemento.GetType() == typeof(Diesel)){
                WriteLine("Ingrese Formula");
                ((Diesel)elemento).Formula = ReadLine();
            }
            controller.agregar(elemento);
        }

        private void listarBombas()
        {
            controller.listar();
            PresionarEnter();
        }

        private void eliminar(){
            controller.listar();
            WriteLine("Ingrese el id a eliminar");
            string id = Console.ReadLine();
            Object elemento = buscar(id);
            if (elemento != null)
            {
                WriteLine("Esta seguro de eliminar (S/N)");
                string respuesta = Console.ReadLine();
                if (respuesta.Equals("s"))
                {
                    controller.eliminar(elemento);
                    WriteLine("Registro Eliminado!!!");
                    ReadKey();
                }
            }
        }

        private Object buscar(string id)
        {
            return controller.buscar(id);
        }

        public void buscar(){
            WriteLine("Ingrese el id");
            string id = ReadLine();
            Object elemento = controller.buscar(id);
            if (elemento != null)
            {
                WriteLine(elemento);
            }
            else
            {
                WriteLine("no existen registros");

            }
            ReadKey();
        }

        private void modificar()
        {
            controller.listar();            
            WriteLine("Ingrese el Id");
            string id = ReadLine();
            Object elemento = buscar(id);
            if(elemento != null)
            {
                ((Bomba)elemento).Capacidad = 2020;
                WriteLine("Registro Modificado");
            }else
            {
                WriteLine("No existen registros");                
            }
            ReadKey();
            

        }
   }
    
}
