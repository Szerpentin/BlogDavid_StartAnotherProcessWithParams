using System.Diagnostics;


var proc = Process.Start(new ProcessStartInfo
{
    // Arguments to pass to another process, separated by a space
    Arguments = "10 20",
    // Name of the exe file. Note: it will be copied by the builder (Visual Studio) to the projects bin folder, as it is dependent on the project "BlodDavid_CounterProject"
    FileName = "BlodDavid_CounterProject.exe",
    // To redirect the output stream, we need to set it to false
    UseShellExecute = false,
    // We want to capture the data written to the output of the other process
    RedirectStandardOutput = true,
    // We don't want to show the users another windows, just the output in our main app
    CreateNoWindow = true
});

// Starting the another process
proc.Start();

// Listening to the output stream
while (!proc.StandardOutput.EndOfStream)
{
    Console.WriteLine($"Message from the other process: {proc.StandardOutput.ReadLine()}");
}
// Don't let our program to exit until the other process finishes
proc.WaitForExit();

// Notifying our user that the other project ended
Console.WriteLine("To exit press enter!");
Console.ReadLine();