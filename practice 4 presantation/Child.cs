namespace practice_4_presantation
{
    public class Child
    {
        private string name;
        private int age;
        private bool isMale;

        public Child(string name, bool isMale)
        {
            this.name = name;
            this.isMale = isMale;
        }

        private int PalculateAge(int year)
        {
            int currentYear = 2025;

            this.age = 2025 - year;

            return this.age;
        }

        protected void PrintInfo()
        {
            Console.WriteLine($"this child name is {name} he is {age} years old and the fact that its a male is {isMale}");
        }
    }
}
