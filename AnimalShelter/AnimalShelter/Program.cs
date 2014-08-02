using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    class Program
    {
        static void Main(string[] args)
        {

            Dog p = new Dog("Pete");
            Dog m = new Dog("Molly");
            Dog z = new Dog("Zoe");
            Cat po = new Cat("Pototo");
            Cat n = new Cat("Nena");
            Dog o = new Dog("Oso");
            AnimalQueue shelter = new AnimalQueue();

            shelter.enqueue(p);
            shelter.enqueue(m);
            shelter.enqueue(z);
            shelter.enqueue(po);
            shelter.enqueue(n);
            shelter.enqueue(o);

            Animal []animals = new Animal[10];

            animals[0] = shelter.dequeueCat();
            animals[1] = shelter.dequeueAny();
            animals[2] = shelter.dequeueAny();
            animals[3] = shelter.dequeueAny();
            animals[4] = shelter.dequeueAny();
            animals[5] = shelter.dequeueAny();

            foreach(var animal in animals)
            {
                Console.WriteLine(animal);
            }

            Console.ReadKey();

        }
    }
    class AnimalQueue {

        Queue<Cat> cats = new Queue<Cat>();
        Queue<Dog> dogs = new Queue<Dog>();
        int order = 0;
        public void enqueue(Animal a)
        {
           
            a.setOrder(order++);
            if (a is Dog)
            {
                
                dogs.Enqueue((Dog)a);
            }
            else if (a is Cat)
            {
                cats.Enqueue((Cat)a);
            }
            Console.WriteLine();

        }
        public Animal dequeueAny()
        {
            if (dogs.Count == 0)
            return cats.Dequeue();

            if (cats.Count ==0)
            return dogs.Dequeue();

            Dog dog = dogs.Peek();
            Cat cat = cats.Peek();


            if (dog.isThisOlder(cat)) return dogs.Dequeue();
            else return cats.Dequeue();
        }
        
        public Animal dequeueDog()
        {
            return dogs.Dequeue();
        }
        public Animal dequeueCat()
        {
            return cats.Dequeue();
        }
    }

    abstract class Animal {

        string name = "";
        int order;

        public Animal(string name)
        {
            this.name = name;
        }

        public void setOrder(int order)
        {
            this.order = order;
        }
        public bool isThisOlder(Animal a)
        {
            if (this.order < a.order)
                return true;
            return false;

        }

        public override string ToString()
        {
            return this.name;
        }
    
    }

    class Dog : Animal {

        public Dog(string name):base(name)
        {
            
        }
    }
    class Cat : Animal
    {
        public Cat(string name) : base(name) { }

    }
}
