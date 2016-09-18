namespace Human
{
    public class Human
    {
        public GenderType Gender { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public static Human GenerateRandomHuman(int magicAgeNumber)
        {
            var human = new Human();
            human.Age = magicAgeNumber;

            if (human.Age % 2 == 0)
            {
                human.Name = "Ivancho";
                human.Gender = GenderType.ToughGuy;
            }
            else
            {
                human.Name = "Marijka";
                human.Gender = GenderType.SexyChick;
            }

            return human;
        }
    }
}
