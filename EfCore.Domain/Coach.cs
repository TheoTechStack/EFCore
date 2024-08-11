namespace EfCore.Domain;

public class Coach : BaseDomainModel
{
    //EfCore picks this a Primary key.
    public int Id { get; set; }
    public string Name { get; set; }
}