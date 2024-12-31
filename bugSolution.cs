public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Correct way: Accessing the data within the using block
        List<MyTable> data = null;
        using (var context = new MyDbContext())
        {
            data = context.MyTable.ToList();
        }

        // ... later in the method ...
        if (data != null)
        {
            var item = data.FirstOrDefault();
        }
    }
} 

//If you need to access context outside of the using block, create a copy of the relevant data before disposing of the context. 
//For example:
public void MyMethod2()
{
    List<MyTable> data = null;
    using (var context = new MyDbContext())
    {
        data = context.MyTable.ToList();
    }
    var item = data.FirstOrDefault();
}
