using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_IP_app
{
    internal class Program
    {

        
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Enter your ip: ");
                string newIp;
                if(string.IsNullOrEmpty(newIp = Console.ReadLine()))
                {
                    throw new Exception("You enter empty ip");
                }
                else
                {
                    IPInfo.GetInfoByIP(newIp);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
