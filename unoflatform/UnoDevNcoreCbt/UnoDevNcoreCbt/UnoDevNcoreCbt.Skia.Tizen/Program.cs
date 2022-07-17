using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace UnoDevNcoreCbt.Skia.Tizen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new UnoDevNcoreCbt.App());
            host.Run();
        }
    }
}
