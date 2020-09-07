using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de PersonM
/// </summary>
[DataContract]
public class PersonM
{
	//bool boolValue = true;
	//string stringValue = "Hello ";

	[DataMember]
	public string Cedula { get; set; }

	[DataMember]
	public string Nombre { get; set; }

	[DataMember]
	public string Telefono { get; set; }


}