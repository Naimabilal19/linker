using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linker
{
    abstract class Component
    {
        public string name { get; set; }
        public int count { get; set; }
        public int price { get; set; }

        public abstract void Add(Component component);
        public abstract void Rem(Component component);
        public abstract void Show();
}
    /*interface Icomponent
    {
        
    }*/
    class Box : Component
    {
        List<Component> list = new List<Component>();


        public override void Add(Component component)
        {
            list.Add(component);
        }
        public override void Rem(Component component)
        {

            list.Remove(component);
        }
        public override void Show()
        {
            Console.WriteLine($"Name: {name}\nCount: {count}\nPrice: {price}\n");
        }
    }
    class Leaf : Component
    {
        public override void Rem(Component component)
        {
            throw new NotImplementedException();
        }
        public override void Show()
        {
            Console.WriteLine($"Name: {name}\nCount: {count}\nPrice: {price}\n");
        }

        public override void Add(Component component)
        {
            throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Component c = new Box();
            c.name = "Iphone 13";c.price = 30000;c.count = 10;
            Component l = new Leaf();
            l.name = "Samsung";l.price = 20000;l.count = 12;
            c.Add(l);
            c.Rem(l);
            c.Show();

        }
    }
}
