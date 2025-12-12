namespace frontend.Services
{
    public class FavorisService
    {
        private List<Offre> offres = new List<Offre>();
        
        public void AddFavoris(Offre offre)
        {
            offres.Add(offre);
        }
        public void DeleteFavoris(Offre offre)
        {
            offres.Remove(offre);
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