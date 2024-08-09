using System;

class Singleton
{
    // Private constructor ensures that the class cannot be instantiated from outside
    private Singleton()
    {
        // implementation
    }

    // Using Lazy<T> to ensure thread-safe, lazy initialization
    private static readonly Lazy<Singleton> _singleton = new Lazy<Singleton>(() => new Singleton());

    // Public static property to access the singleton instance
    public static Singleton Instance
    {
        get
        {
            return _singleton.Value;
        }
    }
}
