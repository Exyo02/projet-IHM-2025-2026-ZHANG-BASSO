namespace frontend.Services;

public class ActuService
{

  public class Actu
  {
    public int Id { get; set; }
    public string Titre { get; set; } = "";
    public string Description { get; set; } = "";
  }
  public List<Actu> GetActus()
  {
    return new()
        {
            new Actu { Titre = "Actus 1", Description = "Description" },
            new Actu { Titre = "Actus 2", Description = "Description" },
            new Actu { Titre = "Actus 3", Description = "Description" }
        };
  }
}
