namespace HairSalon.Models
{
  public class Client 
  {
    public int Id {get;set;}
    public string Name {get;set;}
    public int StylistId {get;set;}
    public int PhoneNumber {get;set;}

    // public virtual Stylist Stylist { get; set; }
  }
}