using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface IService
{

    //[OperationContract]
    //string GetData(int value);

    //[OperationContract]
    //PersonM GetDataUsingDataContract(PersonM composite);

    [OperationContract]
    IEnumerable<PersonM> ObtenerLista();

    [OperationContract]
	PersonM Crear(string cedula, string nombre, string telefono);

	[OperationContract]
	PersonM Modificar(string cedula, string nombre, string telefono);

	[OperationContract]
	void Eliminar(string cedula);

	[OperationContract]
	PersonM Detalle(PersonM item);



	// TODO: agregue aquí sus operaciones de servicio
}

// Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.

