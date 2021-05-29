namespace ConsoleApp1.Mediator
{
    public class Program
    {
        public static void Main()
        {
            var hardwareInfo = new HardwareInfo();
            var processor = new Processor(hardwareInfo);
            var hardDrive = new HardDrive(hardwareInfo, 2137);

            hardwareInfo.Processor = processor;
            hardwareInfo.HardDrive = hardDrive;

            processor.Compute();
        }
    }
}