namespace API;
//each class I create is going to have a namespace where it logically resides,
//whick prevent from having conflicts with classes that got same name. 

public class Products
{
    public int Id { get; set; }
    public required string Name { get; set; } 
    // = "" || ? || required modifier 
    public required string Description { get; set; }
    public long Price { get; set; }
    public required string PictureUrl { get; set; }
    public required string Type { get; set; }
    public required string Brand { get; set; }
    public int QuantityInStock { get; set; }
}
