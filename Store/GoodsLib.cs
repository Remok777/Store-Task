using System;

namespace Store
{
    public abstract class Goods
    {
        private string _id;
        private string _name;
        private int _price;
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }

        

    }
    public class Laptop : Goods 
    {
        private int _ram;
        private string _proc;
        public int Ram
        {
            get { return _ram; }
            set { _ram = value; }
        }
        public string Processor
        {
            get { return _proc; }
            set { _proc = value; }
        }


    }
    class Smartphone : Goods
    {
        private string _cam;
        private string _screen;
        public string Camera
        {
            get { return _cam; }
            set { _cam = value; }
        }
        public string Screen
        {
            get { return _screen; }
            set { _screen = value; }
        }
        
    }

}
