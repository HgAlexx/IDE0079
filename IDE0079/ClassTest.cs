
#pragma warning disable CA1000

namespace IDE0079;

public class ClassTest<T>
{
    public T? SomeMethod { get; init; }

    public static void StaticTest()
    {
        throw new NotImplementedException();
    }
}
