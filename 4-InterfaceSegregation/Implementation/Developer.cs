namespace InterfaceSegregation
{
    public class Developer : IActivitiesDevelop
    {
        public Developer()
        {
        }
        public void Develop() 
        {
            Console.WriteLine("I'm developing the functionalities required");
        }
    }
}