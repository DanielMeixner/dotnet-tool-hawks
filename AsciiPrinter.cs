using System;

namespace hawks{
    public class AsciiPrinter
        {
            public void PrintRandomFile()
            {
                var curAss = this.GetType().Assembly.Location;
                var curDir = System.IO.Directory.GetParent(curAss);
                Console.WriteLine(curDir);

                var asciiDir = curDir + "/asciifiles";
                var files = System.IO.Directory.GetFiles(asciiDir);
                if (files.Length > 0)
                {
                    Random r = new Random();
                    var n = r.Next(0, files.Length);

                    var linearr = System.IO.File.ReadLines(files[n]);
                    foreach (var line in linearr)
                    {
                        Console.WriteLine(line);
                    }
                }
            }

        }
}