using RemoteApp.DifferentDevices;

namespace RemoteApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tv = new Tv();
            var remoteTV = new Remote(tv);

            remoteTV.togglePower();

            var radio = new Radio();
            var remoteRadio = new Remote(radio);
        }
    }
}