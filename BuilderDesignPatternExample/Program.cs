using Newtonsoft.Json;

public class Program
{
    public static void Main(string[] args)
    {
        var computer = new ComputerBuilder()
            .AddCpu("Intel i7")
            .AddRam("8")
            .AddHardDisk("1 TB")
            .Build();

        Console.WriteLine(JsonConvert.SerializeObject(computer));
    }
}

public class Computer
{
    public string CPU { get; set; } = null!;
    public string RAM { get; set; } = null!;
    public string HardDisk { get; set; } = null!;
}

public class ComputerBuilder
{
    private Computer _computer = new();

    public ComputerBuilder AddRam(string ram)
    {
        _computer.RAM = ram;
        return this;
    }

    public ComputerBuilder AddCpu(string cpu)
    {
        _computer.CPU = cpu;
        return this;
    }

    public ComputerBuilder AddHardDisk(string hardDisk)
    {
        _computer.HardDisk = hardDisk;
        return this;
    }

    public Computer Build()
    {
        return _computer;
    }
}