namespace ConsoleApp1
{
    public interface Communicable
    {
        public bool SendData(byte[] data);
        public byte[] ReceiveData();
    }
}