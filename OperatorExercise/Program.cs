namespace OperatorExercise
{
    public class Program
    { 
        static void Main(string[] args)
        {
            var a = 17;
            var b = 4;
            var sum = a + b;
            var diffirence = a - b;
            var product = a * b;
            var quotent = a / b;
            var remainder = a % b;

            Console.WriteLine($" {a}/{b} is {quotent} remainder {remainder}");


            Console.WriteLine("What is the radius of your circle?");
            var userInput = Console.ReadLine();

            var radius = double.Parse(userInput);

            Console.WriteLine($"A circle with a radius of {userInput} will have a area of");

            Console.WriteLine(AreaOfCircle(radius));
        }

        public static double AreaOfCircle(double radius)
        {
            var area = Math.PI * Math.Pow(radius, 2);

            return area;
        }

    }
}
