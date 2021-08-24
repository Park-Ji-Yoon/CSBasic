using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic6
{
    class Program
    {
        abstract class AParent
        {
            public abstract void Method();
        }
        class AChild : AParent
        // sealed class AChild : AParent
        {
            sealed public override void Method() { 
            
            }
        }

        class GChild : AChild
        {
            // sealed 때문에 사용 불가
            /*public override void Method()
            {

            }*/
        }

        class Animal
        {
            public void Eat()
            {
                Console.WriteLine("냠냠");
            }
            public virtual void Eat2()
            {
                Console.WriteLine("냠냠");
            }
        }
        class Cat : Animal
        {
            public void Eat()
            {
                Console.WriteLine("냥냥");
            }
            public override void Eat2()
            {
                Console.WriteLine("냥냥");
            }
        }
        
        class Dog : Animal
        {
            public void Eat()
            {
                Console.WriteLine("멍멍");
            }
            public override void Eat2()
            {
                Console.WriteLine("멍멍");
            }
        }

        class Parent
        {
            public int variable = 273;
            public void Method()
            {
                Console.WriteLine("난 부모 메서드");
            }
            public virtual void Method2()
            {
                Console.WriteLine("난 부모 메서드");
            }
        }

        class Child : Parent
        {
            public new string variable = "hiding";
            public new void Method()
            {
                Console.WriteLine("난 자식 메서드");
            }
            public override void Method2()
            {
                Console.WriteLine("난 자식 메서드");
            }
        }

        static void Main(string[] args)
        {
            Child child = new Child();
            Console.WriteLine(child.variable);
            // Console.WriteLine((Parent)child).variable);
            child.Method();
            ((Parent)child).Method();

            child.Method2();
            ((Parent)child).Method2();

            List<Animal> Animals = new List<Animal>()
            {
                new Dog(), new Cat(), new Cat(), new Dog(),
                new Dog(), new Cat(), new Dog(), new Dog()
            };
            foreach(var item in Animals)
            {
                item.Eat();
            }
            foreach (var item in Animals)
            {
                item.Eat2();
            }
        }
    }
}