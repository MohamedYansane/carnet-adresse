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
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class Service1 : IService1
    {
        carnetadresseEntities db = new carnetadresseEntities();
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
        public List<contact>getAllContact()
        {
            return db.contact.ToList();
        }
        public bool addContact(contact user)
        {
            bool rep = false;
            try
            {
                db.contact.Add(user);
                db.SaveChanges();
                rep = true;
            }catch(Exception e )
            {
                Console.WriteLine("Ajout non reussi à cause de: " +e.Message);
            }
            return rep;
        }

        public bool supprimerContact(int id)
        {
            bool rep = false;
            try
            {
                var user = db.contact.Find(id);
                db.contact.Remove(user);
                db.SaveChanges();

                rep = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Suppression non effectué  à cause de: " + e.Message);
            }
            return rep;
        }
        public List<contact>searchContact(string nom, string prenom)
        {
            var result = db.contact.ToList();
            if (!string.IsNullOrEmpty(nom))
            {
                result = result.Where(c =>c.nom.ToUpper().Contains(nom.ToUpper())).ToList();
            }
            if (!string.IsNullOrEmpty(prenom))
            {
                result = result.Where(c => c.prenom.ToUpper().Contains(prenom.ToUpper())).ToList();
            }

            return result;
        }

        public bool editContact(contact user)
        {
            bool rep = false;
            try
            {
                contact c = db.contact.Find(user.idContact);
                c.nom = user.nom;
                c.prenom = user.prenom;
                c.sexe = user.sexe;
                c.csp = user.csp;
                db.SaveChanges();
                rep = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("edition non reussi à cause de: " + e.Message);
            }
            return rep;
        }
        public contact getIdMatch(int id)
        {
            return db.contact.Find(id);
        }
        public bool ajoutNumContact(numtel pers)
        {
            bool rep = false;
            try
            {
                db.numtel.Add(pers);
                db.SaveChanges();
                rep = true;
            }catch(Exception e)
            {
                Console.WriteLine("Erreur d'insertion à cause de: "+e.Message);
            }
            return rep;
        }

        public List<numtel> afficherNumTel()
        {
            return db.numtel.ToList();
        }

        public string getNumberOfContact()
        {
            var nbr = (from c in db.contact select new { c.idContact }).Count().ToString();
            return nbr;
        }

        public void search(string text)
        {
           
        }

        public List<NumAndContact>imprimerContact()
        {
            var result = (from userContact in db.contact
                          join num in db.numtel
                          on userContact.idContact equals num.idContact
                          select new NumAndContact
                          {
                              numeroContact = userContact.idContact,
                              nom = userContact.nom,
                              prenom = userContact.prenom,
                              csp = userContact.csp,
                              sexe = userContact.sexe,
                              ville = userContact.ville,
                              numeroTel = num.NumeroTel


                          }).ToList();
            return result;
        }


    }
}
