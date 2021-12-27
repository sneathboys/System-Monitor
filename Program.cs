using Hardware.Info;
using Spectre.Console;


bool ConLoop = true;

while (ConLoop)
{

    AnsiConsole.Write(new Markup("[bold green]Harry's System Monitoring Program[/]"));
    Console.WriteLine("");
    AnsiConsole.Markup("[underline red]Loading please wait...[/]");

    IHardwareInfo hardwareInfo = new HardwareInfo();

    hardwareInfo.RefreshAll();

    // Creating table and adding 2 colums
    var cputable = new Table();
    cputable.AddColumn("Hardware");
    cputable.AddColumn("value");

    var BiosTable = new Table();

    BiosTable.AddColumn("Hardware");
    BiosTable.AddColumn("Value");

    var storagetable = new Table();

    storagetable.AddColumn("Harware");
    storagetable.AddColumn("Value");

    var RAMTable = new Table();

    RAMTable.AddColumn("Hardware");
    RAMTable.AddColumn("Value");  

    var GPUTable = new Table();

    GPUTable.AddColumn("Hardware");
    GPUTable.AddColumn("value");  


    foreach (var item in hardwareInfo.CpuList)
    {
        string[] words = item.ToString().Split("\r\n");
        for (int i = 0; i < words.Length; i++)
        {
            
            string[] data = words[i].Split(':');
            if (data.Length >= 2)
            {
                cputable.AddRow(data[0], data[1]);
            }
        }
    }
    

    foreach (var item in hardwareInfo.BiosList)
    {
        string[] words = item.ToString().Split("\r\n");
        for (int i = 0; i < words.Length; i++)
        {
            
            string[] data = words[i].Split(':');
            if (data.Length >= 2)
            {
                BiosTable.AddRow(data[0], data[1]);
            }
        }
    }


    foreach (var item in hardwareInfo.DriveList)
    {
        string[] words = item.ToString().Split("\r\n");
        for (int i = 0; i < words.Length; i++)
        {
            
            string[] data = words[i].Split(':');
            if (data.Length >= 2)
            {
                storagetable.AddRow(data[0], data[1]);
            }
        }
    }


    foreach (var item in hardwareInfo.MemoryList)
    {
                string[] words = item.ToString().Split("\r\n");
        for (int i = 0; i < words.Length; i++)
        {
            
            string[] data = words[i].Split(':');
            if (data.Length >= 2)
            {
                RAMTable.AddRow(data[0], data[1]);
            }
        }
    }


    foreach (var item in hardwareInfo.VideoControllerList)
    {
                string[] words = item.ToString().Split("\r\n");
        for (int i = 0; i < words.Length; i++)
        {
            
            string[] data = words[i].Split(':');
            if (data.Length >= 2)
            {
                GPUTable.AddRow(data[0], data[1]);
            }
        }
    }

    Console.WriteLine("");
    Console.WriteLine("");
    AnsiConsole.Write(new Markup("[bold green]CPU Infomation:[/]"));
    Console.WriteLine("");
    Console.WriteLine("");
    AnsiConsole.Write(cputable);

    AnsiConsole.Write(new Markup("[bold green]Bios Infomation:[/]"));
    Console.WriteLine("");
    Console.WriteLine("");
    AnsiConsole.Write(BiosTable);

    AnsiConsole.Write(new Markup("[bold green]Storage Infomation:[/]"));
    Console.WriteLine("");
    Console.WriteLine("");
    AnsiConsole.Write(storagetable);

    AnsiConsole.Write(new Markup("[bold green]RAM Infomation:[/]"));
    Console.WriteLine("");
    Console.WriteLine("");
    AnsiConsole.Write(RAMTable);

    AnsiConsole.Write(new Markup("[bold green]GPU Infomation:[/]"));
    Console.WriteLine("");
    Console.WriteLine("");
    AnsiConsole.Write(GPUTable);


    Console.WriteLine("Thank you for using Harry's System Monitor!");
    Console.WriteLine("Check us out on github https://www.google.com/");

    Console.WriteLine("Press R to restart or any other key to end the program");

    

    

    var keyPress = Console.ReadLine();
    if (keyPress == "r")
    {
        AnsiConsole.Write("[yellow]Resarting The App...[/]");
        Console.ReadLine();
    }

    else
    {
        ConLoop = false;

    }
}