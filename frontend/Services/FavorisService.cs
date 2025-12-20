namespace frontend.Services
{
    public class FavorisService
    {
        private List<Offre> offres = new List<Offre>();
        
        public void AddFavoris(Offre offre)
        {
            offre.Favoris = true;
            offres.Add(offre);
        }
        public void DeleteFavoris(Offre offre)
        {
            offre.Favoris = false;
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