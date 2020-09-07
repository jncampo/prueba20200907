using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.UI;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
public class Service : IService
{
    

   
    public IEnumerable<PersonM> ObtenerLista()
    {
        try
        {
			using (var instancia = new ServiceBL())
			{
				return instancia.ObtenerLista();
			}
		}
        catch (Exception ex)
        {
            throw new Exception("Error");
        }
    }

	public PersonM Crear(string cedula,string nombre, string telefono)
	{
		try
		{
			using (var instancia = new ServiceBL())
			{
				PersonM item = new PersonM();
				item.Cedula = cedula;
				item.Nombre = nombre;
				item.Telefono = telefono;
				return instancia.Crear(item);
			}
		}
		catch (Exception ex)
		{
			throw new Exception("Error");
		}
	}
	public PersonM Modificar(string cedula, string nombre, string telefono)
	{
		try
		{
			using (var instancia = new ServiceBL())
			{
				PersonM item = new PersonM();
				item.Cedula = cedula;
				item.Nombre = nombre;
				item.Telefono = telefono;
				return instancia.Modificar(item);
			}
		}
		catch (Exception ex)
		{
			throw new Exception("Error");
		}
	}
	public void Eliminar(string cedula)
	{

		try
		{
			using (var instancia = new ServiceBL())
			{
				PersonM item = new PersonM();
				item.Cedula = cedula;
				 instancia.Eliminar(item);
			}
		}
		catch (Exception ex)
		{
			throw new Exception("Error");
		}
	}

	public PersonM Detalle(PersonM item)
	{
		return null;
	}
}
