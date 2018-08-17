using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Web_Service_WCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class WSPersona : IWSPersona
    {
        public Persona GetPersona(long id)
        {
            switch (id)
            {
                case 1: return new Persona() { Name = "Nahuel", Age = 26 };
                    break;
                case 2: return new Persona() { Name = "Damian", Age = 34 };
                    break;
                default: return new Persona() { Error = "No se ha encontrado a la persona" };
                    break;
            }
        }
    }
}
