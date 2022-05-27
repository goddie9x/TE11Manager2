using System.Diagnostics;
using System.IO;

namespace TE11Manager.Util
{
    internal static class TestData
    {
        public static void test(string data)
        {
            File.WriteAllText("index.html",data);
            Process.Start(@"cmd.exe ", @"/c " + "index.html");
        }
    }
}
