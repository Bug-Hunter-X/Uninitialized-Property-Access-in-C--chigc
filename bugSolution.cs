public class MyClass {
    public int MyProperty { get; set; } = 0; // Initialize the property to a default value

    public void MyMethod() {
        // Accessing a property after it is initialized
        Console.WriteLine(MyProperty);
    }

    public void MyMethod2() {
        MyProperty = 5; // Now initialize the property
        Console.WriteLine(MyProperty); // This will print 5
    }
}