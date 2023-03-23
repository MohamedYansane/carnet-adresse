using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using RepertoireService.Model;

namespace RepertoireService
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: ajoutez vos opérations de service ici
        [OperationContract]
        List<contact> getAllContact();

        [OperationContract]
        bool addContact(contact user);

        [OperationContract]
        bool supprimerContact(int id);

        [OperationContract]
        List<contact> searchContact(string nom, string prenom);

        [OperationContract]
        bool editContact(contact user);

        [OperationContract]
        contact getIdMatch(int id);

        [OperationContract]
        bool ajoutNumContact(numtel pers);

        [OperationContract]
        List<numtel> afficherNumTel();

        [OperationContract]
        string getNumberOfContact();
    }


    // Utilisez un contrat de données comme indiqué dans l'exemple ci-après pour ajouter les types composites aux opérations de service.
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
