public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a disposed object
        using (var context = new MyDbContext())
        {
            var data = context.MyTable.ToList();
        }

        // ... later in the method ...
        var item = context.MyTable.FirstOrDefault(); // context is already disposed!
    }
}