using System;

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
    class Smartphone : Goods
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
            