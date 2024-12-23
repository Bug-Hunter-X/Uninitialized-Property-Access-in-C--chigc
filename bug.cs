public class MyClass {
    public int MyProperty { get; set; }

    public void MyMethod() {
        // Accessing a property before it is initialized
        Console.WriteLine(MyProperty); // This will print 0, not throw an exception
    }
}