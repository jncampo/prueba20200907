using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de ServiceBL
/// </summary>
public class ServiceBL : IDisposable
{
    public ServiceBL()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public IEnumerable<PersonM> ObtenerLista()
    {

        IServiceDAL instancia = new ServiceDAL();
        return instancia.ObtenerLista();
    
    }

    public void Eliminar(PersonM item)
    {
        IServiceDAL instancia = new ServiceDAL();
         instancia.Eliminar(item);
    }

    public PersonM Crear(PersonM item)
    {
        IServiceDAL instancia = new ServiceDAL();
        return instancia.Crear(item);
    }

    public PersonM Modificar(PersonM item)
    {
        IServiceDAL instancia = new ServiceDAL();
        return instancia.Modificar(item);
    }

    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }
}