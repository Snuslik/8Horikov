namespace ZOO
{
    public class Zoo
    {
        public interface ISwimmer
        {
            string Swim();
        }

        public interface IWalker
        {
            string Walk();
        }

        public interface IFlyer
        {
            string Fly();
        }

        public interface ISocialInteraction
        {
            string Socialize();
        }

        public class Animal
        {
            public string Name;
            public int Age;
            public string Species;
            public string Sound;
            public bool IsAlive;
            public string Habitat;

            public Animal(string name, int age, string species, string sound)
            {
                Name = name;
                Age = age;
                Species = species;
                Sound = sound;
                IsAlive = true;
                Habitat = "Неизвестно";
            }

            public virtual string MakeSound()
            {
                return $"{Name} {Species} издает звук: {Sound}";
            }

            public virtual string Eat()
            {
                return $"{Name} {Species} питается в зоопарке.";
            }

            public virtual string Sleep()
            {
                return $"{Name} {Species} спит в своем уютном вольере.";
            }

            public virtual string Reproduce()
            {
                return $"{Name} {Species} размножается в специальных условиях зоопарка.";
            }
        }

        public class Penguin : Animal, ISwimmer
        {
            public Penguin(string name, int age) : base(name, age, "Пингвин", "кря")
            {
                Habitat = "Вольер для пингвинов";
            }

            public string Swim()
            {
                return $"{Name} пингвин плавает в бассейне внутри вольера.";
            }
        }

        public class Monkey : Animal, IWalker
        {
            public Monkey(string name, int age) : base(name, age, "Обезьяна", "у-у-у")
            {
                Habitat = "Вольер для обезьян";
            }

            public string Walk()
            {
                return $"{Name} обезьяна карабкается и играет в вольере.";
            }
        }

        public class Shark : Animal, ISwimmer
        {
            public Shark(string name, int age) : base(name, age, "Акула", "жуткий звук")
            {
                Habitat = "Аквариум";
            }

            public string Swim()
            {
                return $"{Name} акула плавает в аквариуме зоопарка.";
            }
        }

        public class Classmate : Animal, ISocialInteraction
        {
            public Classmate(string name, int age) : base(name, age, "Одноклассник", "Привет!")
            {
                Habitat = "Классная комната";
            }

            public string Socialize()
            {
                return $"{Name} одноклассник общается с другими детьми в классной комнате.";
            }
            public override string MakeSound()
            {
                return $"{Name} одноклассник издает звук: {Sound}";
            }
        }
        public class Kangaroo : Animal, IWalker
        {
            public Kangaroo(string name, int age) : base(name, age, "Кенгуру", "скак-скак")
            {
                Habitat = "Вольер для кенгуру";
            }

            public string Walk()
            {
                return $"{Name} кенгуру ходит и прыгает в вольере.";
            }

        }
    }
}