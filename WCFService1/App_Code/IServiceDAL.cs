using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de IServicioDAL
/// </summary>
public interface IServiceDAL
{

    IEnumerable<PersonM> ObtenerLista();
    void Eliminar(PersonM item);
    PersonM Crear(PersonM item);
    PersonM Modificar(PersonM item);
}