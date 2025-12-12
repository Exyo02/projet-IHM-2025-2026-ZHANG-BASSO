public class Offre{
    public int Id {get;set;}
    public string Titre {get;set;} 
    public int Duree {get;set;}
    public string Domaine {get;set;}
    public string Adress {get;set;}
    public string Laboratoire {get;set;}
    public DateTime DateDebut {get;set;}
    public int NbAnnees {get;set;}
    public string NomResponsable {get;set;}
    public string Description {get;set;}


    public Offre(int id,string titre, int duree,string domaine,
                 string adress,string labo,string responsable,
                 string description){
        Id = id;
        Titre = titre;
        Duree = duree;
        Domaine = domaine;
        Adress = adress;
        Laboratoire = labo;
        NomResponsable = responsable;
        Description = description;
    }
}