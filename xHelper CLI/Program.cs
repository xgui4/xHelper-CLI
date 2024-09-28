using xHelper_CLI.UI;

namespace xHelper_CLI;

class Program
{
    static void Main(string[] args)
    {
        var appInfo = new AppInfo();
        var menu = new Menu(); 
        bool isRunning = true;
        while (isRunning)
        {
            Console.WriteLine(appInfo.AppName + " " + appInfo.AppVersion + " - Home");

            menu.ShowList();
            
            menu.UserInteraction(appInfo, isRunning);
        }
    }
}