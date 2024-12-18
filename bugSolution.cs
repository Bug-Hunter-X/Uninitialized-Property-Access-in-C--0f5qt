public class ExampleClass
{
    // Initialize the property directly
    public int MyProperty { get; set; } = 0; 

    // Or, initialize in the constructor
    public ExampleClass()
    {
        MyProperty = 0; // Initialize here
    }

    public void MyMethod()
    {
        Console.WriteLine(MyProperty); // Now it will print a defined value
    }
}