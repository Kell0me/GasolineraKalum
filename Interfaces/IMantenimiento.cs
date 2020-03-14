using System;

namespace GasolineraKalum.Interfaces
{
    public interface IMantenimiento
    {
         void agregar(object elemento);
        //como estamos programando en c# tiene que ser en minuscula
         void modificar(object elemento);
         void eliminar(object elemento);

         object buscar(string id);

         void listar();
    }
}