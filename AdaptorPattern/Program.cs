using AdaptorPattern;
public class Program
{
    static void Main(string[] args)
    {
        Duck duck = new MallardDuck();

        wildTurkey turkey = new wildTurkey();
        Duck turkeyAdaptor = new TurkeyAdaptor(turkey);

        Console.WriteLine("The turkey says..");
        turkeyAdaptor.quack();
        turkeyAdaptor.fly();



    }
}