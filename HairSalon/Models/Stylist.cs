namespace HairSalon.Models
{
  public class Stylist
  {
    public Stylist()
    {
      this.Restaurants = new HashSet<Client>();
    }
    public int Id {get;set;}
    public string Name {get;set;}
    public string Specialty {get;set;}
    public virtual ICollection<Client> Clients {get;set;}

  }
}