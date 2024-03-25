using static ZOO.Zoo;

Animal[] animals = new Animal[5];

Penguin penguin = new Penguin("Пингвинчик", 5);
Monkey monkey = new Monkey("Обезьянка", 3);
Kangaroo kangaroo = new Kangaroo("Сумчатик", 2);
Shark shark = new Shark("Акула Брусничка", 10);
Classmate classmate = new Classmate("Друг", 12);

animals[0] = penguin;
animals[1] = monkey;
animals[2] = kangaroo;
animals[3] = shark;
animals[4] = classmate;

foreach (Animal animal in animals)
{
    Console.WriteLine(animal.MakeSound());
}