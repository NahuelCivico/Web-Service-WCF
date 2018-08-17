using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Web_Service_WCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IWSPersona
    {
        [OperationContract]
        Persona GetPersona(Int64 id);

        // TODO: agregue aquí sus operaciones de servicio
    }


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class Persona : Base
    {
        private String name;
        private Int32 _age;

        [DataMember]
        public String Name { get => name; set => name = value; }
        [DataMember]
        public Int32 Age { get => _age; set => _age = value; }
    }

    [DataContract]
    public class Base
    {
        private String error;

        [DataMember]
        public String Error { get => error; set => error = value; }
    }
}
