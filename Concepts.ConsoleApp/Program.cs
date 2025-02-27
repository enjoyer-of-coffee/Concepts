namespace Concepts.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tiger tiger = new Tiger();
            //tiger.Sound();
            //Dog dog = new Dog();
            //dog.Sound();
            //Monkey monkey = new Monkey();
            //monkey.Sound();
            //IAnimal animal = new Tiger();
            //animal.Sound();
            //animal = new Dog();
            //animal.Sound();
            //animal = new Monkey();
            //animal.Sound();
            //List<IAnimal> animals = new List<IAnimal>
            //{
            //    new Tiger(),
            //    new Dog(),
            //    new Monkey()
            //};
            //foreach (IAnimal animal in animals)
            //{
            //    animal.Sound();
            //}
            //IAnimal animal = AnimalProducer.GetAnimal();
            //animal.Sound();
            //animal = AnimalProducer.GetAnimal();
            //animal.Sound();
            //animal = AnimalProducer.GetAnimal();
            //animal.Sound();
            IAnimal animal = AnimalProducer.GetAnimal();
            AnimalProducer.MakeSound(animal);
            animal = AnimalProducer.GetAnimal();
            AnimalProducer.MakeSound(animal);
            animal = AnimalProducer.GetAnimal();
            AnimalProducer.MakeSound(animal);
            Console.ReadKey();
        }
    }
}
