
namespace Store.Entities
{
    public class Smartphone : Goods
    {
        public string Camera { get; set; }
        public string Screen { get; set; }

        public Smartphone(int _id, string _name, int _price, string _cam, string _screen)
            : base(_id, _name, _price)
        {
            Camera = _cam;
            Screen = _screen;
        }
        public override string ToString()
        {
            return $"{Id} | {Name} | {Price} | {Camera} | {Screen} |";
        }
    }
}
