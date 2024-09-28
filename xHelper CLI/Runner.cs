using System.Diagnostics;
namespace xHelper_CLI;

public class Runner
{
    public void RunWithBash(string command)
    {
        var processStartInfo = new ProcessStartInfo
        {
            FileName = "/bin/bash",
            Arguments = $"\"{command}\"",
        };

        using var process = Process.Start(processStartInfo);
        process?.WaitForExit();
    }
}