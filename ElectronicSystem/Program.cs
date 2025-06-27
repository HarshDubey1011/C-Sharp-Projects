namespace ElectronicSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IElectronicDevice TV = TVRemote.GetDevice();
            PowerButton powBut = new PowerButton(TV);
            VolumeButton volumeBut = new VolumeButton(TV);
            powBut.Execute();
            powBut.Undo();
            powBut.Execute();
            powBut.Undo();
            for(int i = 0;i<80;i++)
            {
                volumeBut.VolumeUp();
            }
            for(int i = 0;i<50;i++)
            {
                volumeBut.VolumeDown();
            }
        }
    }
}
