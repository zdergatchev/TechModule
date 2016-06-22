using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.URLParser
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = Console.ReadLine();
            int protocolIndex = url.IndexOf("://");
            string protocol = "";
            if (protocolIndex > 0)                  // има протокол
            {
                protocol = url.Substring(0, protocolIndex);
            }
            //Console.WriteLine(protocolIndex);

            int resourceIndex = url.IndexOf("/", protocolIndex + 3);
            string server = "";
            string resource = "";
            if (resourceIndex > 0)                  // има сървър и протокол
            {
                server = url.Substring(protocolIndex + 3, resourceIndex - protocolIndex - 3);
                resource = url.Substring(resourceIndex + 1);
            }
            else if(protocolIndex > 0)              // ако има протокол, а няма ресурс
            {
                server = url.Substring(protocolIndex + 3);
            }
            else                                    // няма протокол и няма ресурс
            {
                server = url.Substring(protocolIndex + 1);
            }
            //Console.WriteLine(protocol);
            //Console.WriteLine(server);
            
            Console.WriteLine("[protocol] = \"{0}\"", protocol);
            Console.WriteLine("[server] = \"{0}\"", server);
            Console.WriteLine("[resource] = \"{0}\"", resource);
        }
    }
}
