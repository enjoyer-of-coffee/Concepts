namespace Concepts.ConsoleApp
{
    class AnimalProducer
    {
        internal static IAnimal GetAnimal()
        {
            IAnimal animal;
            Random random = new Random();
            int temp = random.Next(0, 3);
            if (temp == 0)
            {
                animal = new Tiger();
            }
            else if (temp == 1)
            {
                animal = new Dog();
            }
            else
            {
                animal = new Monkey();
            }
            return animal;
        }
        internal static void MakeSound(IAnimal animal)
        {
            animal.Sound();
        }
    }
}
