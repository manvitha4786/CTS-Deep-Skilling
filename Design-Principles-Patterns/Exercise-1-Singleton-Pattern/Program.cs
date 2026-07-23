using System;

class Logger
{
    // Create a private static instance
    private static Logger instance;

    // Private constructor
    private Logger()
    {
    }

    // Public method to access the single instance
    public static Logger GetInstance()
    {
        if (instance == null)
        {
            instance = new Logger();
        }

        return instance;
    }

    // Method for logging
    public void Log(string message)
    {
        Console.WriteLine("Log: " + message);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Logger logger1 = Logger.GetInstance();
        Logger logger2 = Logger.GetInstance();

        logger1.Log("Application Started");
        logger2.Log("Application Running");

        // Check whether both references point to the same object
        if (logger1 == logger2)
        {
            Console.WriteLine("Only one Logger instance exists.");
        }
        else
        {
            Console.WriteLine("Multiple Logger instances exist.");
        }
    }
}