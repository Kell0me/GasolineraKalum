
using System;
using System.Collections.Generic;
using GasolineraKalum.Entities;
using GasolineraKalum.Interfaces; //primero pone esta libreria
using static GasolineraKalum.Util.Printer; //para llamar la clase y utlizarla y siempre se coloca como static
using static System.Console;

namespace GasolineraKalum.Controllers    //como se asignar una interface a  una clase
{
    public class GasolineraController : IMantenimiento //dos veces dar ctrl + . para implementar los metodos de la interfaz
    {
        //clase padre es bomba
        private List<Bomba> listaDeBombas = new List<Bomba>(); //  private List<Bomba> listaDeBombas;aca el objeto listaDeBombas solo esta declarado y no esta instanciada

        //con el otro ctrl  + .  agregar todos los metodos
        public void agregar(object elemento)
        {
            
            this.listaDeBombas.Add((Bomba)elemento); //se convirtio en tipo bomba  ya que era object 
        }

//public void buscar(string id)
        public object buscar(string id) // por este cambio hay que cambiar en la interfaz
        {
            Bomba resultado = null;
            foreach (var item in listaDeBombas)  //para realizar la busqueda por id
            {
                if(item.Id.Equals(id, StringComparison.Ordinal))
                {
                resultado = item;
                break; //como ya encontro el elmento buscado
                }
                
            }
            return resultado;
        }

        public void eliminar(object elemento)
        {
            this.listaDeBombas.Remove((Bomba)elemento);            
        }

        public void listar()
        {
            WriteTitle("Lista de bombas de gasolina");
            foreach (var item in this.listaDeBombas)
            {
                WriteLine(item);

            }
        }

        public void modificar(object elemento)
        {
            
        }
    }
}