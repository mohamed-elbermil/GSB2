using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB2_project.Models
{
    internal class Medicine
    {
        //ceci est une propriété, elle permet d'acceder en lecture et en écriture
        //à notre attribut de classe via les méthodes get et set
        public int Id { get; set; }
        public int IdUser { get; set; }
        public int Dosage { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Molecule { get; set; }

        //ceci est le constructeur par défaut
        //il permet de créer une instance de la classe qui nous permettra d'acceder
        //aux méthodes et propriétés de celle ci 
        public Medicine() { }

        //ceci est une surcharge du constructeur, elle permettra la création d'objet User
        //qui sera instancié avec les variables passées en parametres
        public Medicine(int id, int idUser, int dosage, string name, string description, string molecule)
        {
            this.Id = id;
            this.IdUser = idUser;
            this.Dosage = dosage;
            this.Name = name;
            this.Description = description;
            this.Molecule = molecule;
        }
    }
}
