using System;
// using System.Text.Json;
// using System.Text.Json.Serialization; //.JsonConverter;
using LibreHardwareMonitor.Hardware;

public class Program
{
    public class UpdateVisitor : IVisitor
    {
        public void VisitComputer(IComputer computer)
        {
            computer.Traverse(this);
        }
        public void VisitHardware(IHardware hardware)
        {
            hardware.Update();
            foreach (IHardware subHardware in hardware.SubHardware) subHardware.Accept(this);
        }
        public void VisitSensor(ISensor sensor) { }
        public void VisitParameter(IParameter parameter) { }
    }

    static public void Main()
    {
        Computer computer = new Computer
        {
            IsCpuEnabled = false,
            IsGpuEnabled = false,
            IsMemoryEnabled = false,
            IsMotherboardEnabled = false,
            IsControllerEnabled = false,
            IsNetworkEnabled = false,
            IsStorageEnabled = true
        };

        computer.Open();
        computer.Accept(new UpdateVisitor());
/*
        var options = new JsonSerializerOptions
        {
            WriteIndented = true,
        };
        Console.WriteLine(JsonSerializer.Serialize(computer.Hardware as IHardware, typeof(IHardware), options));
*/
        Console.WriteLine(computer.GetReport());
    }
}
