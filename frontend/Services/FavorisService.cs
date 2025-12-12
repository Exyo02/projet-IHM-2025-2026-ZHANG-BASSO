namespace frontend.Services
{
    public class FavorisService
    {
        List<Offre> offres = new List<Offre>();
        public FavorisService()
        {
            offres.Add(new Offre(0,"Titre",6,"Informatique", "3 rue de la place d'en face","Lago","Dupond",
            """
            Lorem ipsum dolor sit amet. Rem reprehenderit ipsa ex quia ipsum nam autem vitae est quod error et saepe vero. Eum nihil quia est expedita incidunt a fugiat fugiat.

            Sit repellendus nostrum et inventore cumque At beatae voluptas in illo saepe et ipsa molestiae in voluptatibus laborum. In voluptate deleniti eum laboriosam minima aut quasi commodi aut dignissimos ullam. Aut recusandae eius vel blanditiis molestias qui laborum enim non veniam consequatur?
            """));
            offres.Add(new Offre(1,"Titre",6,"Informatique", "3 rue de la place d'en face","Lago","Dupond",
            """
            Lorem ipsum dolor sit amet. Rem reprehenderit ipsa ex quia ipsum nam autem vitae est quod error et saepe vero. Eum nihil quia est expedita incidunt a fugiat fugiat.
            
            Sit repellendus nostrum et inventore cumque At beatae voluptas in illo saepe et ipsa molestiae in voluptatibus laborum. In voluptate deleniti eum laboriosam minima aut quasi commodi aut dignissimos ullam. Aut recusandae eius vel blanditiis molestias qui laborum enim non veniam consequatur?
            """));
        }
        public List<Offre> GetOffres()
        {
            return offres;
        }
        public Offre GetOffre(int id)
        {
            return offres[id];
        }
    }
}