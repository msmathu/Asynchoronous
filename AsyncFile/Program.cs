
class Program
{
    static async Task Main(string[] args)
    {
        var result1 = await LongProcess1();
        //int val = await result1;
        //DisplayResult(val);
        var result2 = LongProcess2();
        Console.WriteLine("After two long processes.");
        //val = await result2;
        //DisplayResult(val);

        Task Emp1 = Employee1();
        await Emp1;
        
        Task Emp2 = Employee2();
        await Emp2;
    }
    static async Task<int> LongProcess1()
    {
        Console.WriteLine("LongProcess 1 Started");
        await Task.Delay(4000);
        Console.WriteLine("LongProcess 1 Completed");
        return 67;
    }

    static async Task<int> LongProcess2()
    {
        Console.WriteLine("LongProcess 2 Started");
        await Task.Delay(4000); // hold  4 seconds
        Console.WriteLine("LongProcess 2 Completed");
        return 20;
    }

    static void DisplayResult(int val)
    {
        Console.WriteLine(val);
    }
    static async Task Employee1(){
        await Task.Delay(6000);
        Console.WriteLine("Hi Employee1");
    }
    static async Task  Employee2()
    {
        var a = 100;
        await Task.Delay(2000);
        Console.WriteLine(a);
    }
}
