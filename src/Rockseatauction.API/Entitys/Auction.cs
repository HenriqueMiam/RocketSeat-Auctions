namespace Rockseatauction.API.Entitys;

public class Auction
{
    public int Id { get; set; }
    public string Name { get; set; } = String.Empty;
    public DateTime Starts { get; set; }
    public DateTime Ends { get; set; }

    public List<Item> Items { get; set; } = [];

}
