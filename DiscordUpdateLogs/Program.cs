using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace DiscordUpdateLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            Process Discord = new Process();

            Discord.StartInfo.FileName = @"C:/Users/(your_computer_name)/AppData/Local/Discord/app-0.0.304/Discord.exe";

            Discord.Start();

            Console.Read();
        }
    }
}
