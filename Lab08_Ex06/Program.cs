var mc = new MyClass();
mc.DisplayParam("Hello", "World");
class MyClass
{

    public void DisplayParam(int a, int b)
    {
         System.Console.WriteLine($"a = {a}, b = {b}");
    }
}