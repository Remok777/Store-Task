
namespace Store
{
    public abstract class Goods
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public Goods(int _id, string _name, int _price)
        {
            Id = _id;
            Name = _name;
            Price = _price;
        }
    }
}
            