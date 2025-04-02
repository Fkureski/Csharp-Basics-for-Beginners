namespace CSharpFundamentals
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public void Introduce()
        {
            Console.WriteLine("Hello, my name is " + FirstName + " " + LastName);
        }
    }
}
