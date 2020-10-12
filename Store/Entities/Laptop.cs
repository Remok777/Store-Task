
namespace Store.Entities
{
    public class Laptop : Goods
    {
        public int Ram { get; set; }
        public string Proccesor { get; set; }

        public Laptop(int _id, string _name, int _price, int _ram, string _proc)
            : base(_id, _name, _price)
        {
            Ram = _ram;
            Proccesor = _proc;
        }
        public override string ToString()
        {
            return $"{Id} | {Name} | {Price} | {Ram} | {Proccesor} |";
        }
    }
}
