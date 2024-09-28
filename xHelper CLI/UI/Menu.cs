namespace xHelper_CLI.UI;

public class Menu
{
    public void ShowList()
    {
        Console.WriteLine("""
                          1. Aura Mode
                          2. Profile
                          3. MUX mode
                          4. GUI (use Rog Control Center for now)
                          5. Quit
                          """);
    }

    public void UserInteraction(AppInfo appInfo, bool isRunning)
    { 
        if (Console.ReadLine() == "1")
        {
            Console.Clear();
            Console.WriteLine("xHelper CLI Prototype 1 - Aura Mode");
        }

        if (Console.ReadLine() == "2")
        {
            Console.Clear();
            Console.WriteLine("xHelper CLI Prototype 1 - Profile");
        }

        if (Console.ReadLine() == "3")
        {
            Console.Clear();
            Console.WriteLine("xHelper CLI Prototype 1 - MUX mode");
        }

        if (Console.ReadLine() == "4")
        {
            var runner = new Runner();
            Console.Clear();
            runner.RunWithBash("rog-control-center");
        }
        
        if (Console.ReadLine() == "5") isRunning = false;
        
    }
}