namespace Singleton;
public class SingletonSample
{
    private static SingletonSample? instance;

    private SingletonSample() { }

    public static SingletonSample Instance
    {
        get
        {
            instance ??= new SingletonSample();
            return instance;
        }
    }

    public static void SomeMethod()
    =>Console.WriteLine("SomeMethod of the Singleton instance");
    
}