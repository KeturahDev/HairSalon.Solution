namespace HairSalon.Model
{
  public class Client 
  {
    public int Id {get;set;}
    public string Name {get;set;}
    public int SpecialistId {get;set;}
    public int PhoneNumber {get;set;}
    
    // public virtual Stylist Stylist { get; set; }
  }
}