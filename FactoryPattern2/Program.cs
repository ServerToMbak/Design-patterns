using FactoryPattern2;

public class Program
{
    static void Main(string[] args)
    {
        IDreamFactory dreamFactory = new DreamFactory();

        var familyDream = dreamFactory.makeTheDreamYouWısh("Familya");
        Console.WriteLine(familyDream.makeADream);

        var individualDream = dreamFactory.makeTheDreamYouWısh("Individual");
        Console.WriteLine(individualDream.makeADream);

    }
}