using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WCFCineStar.bean;

namespace WCFCineStar
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ICineStar
    {
        [OperationContract]
        DataSet getCineTarifas(int id);

        [OperationContract]
        DataSet getCines();

        [OperationContract]
        DataSet getPeliculas(int id);

        [OperationContract]
        DataSet getPelicula(int id);

        [OperationContract]
        List<Pelicula> getPeliculasList(int id);

        [OperationContract]
        Pelicula getPeliculaEntidad(int id);
    }


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
