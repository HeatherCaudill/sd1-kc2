using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace sd1_kc2
{
    internal class Program
    {

    }
    public class Transportation

    {
        public string Transmission;
        { 
            Automatic;
            Manual;
        }
        public string Records;
        {
            Repairs;
            Books;
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("How many records do you want to add? ");
        var numberOfRecords = int.Parse(Console.ReadLine());

        var recordList = new List<Transportation>();
        for (int i = 0; i < numberOfRecords; i++)
        {
            // In this loop, populate the object's properties using Console.ReadLine()
            var Transportation = new Transportation();

            Console.WriteLine("Enter the value for ");
            Transportation.= Console.ReadLine();
            recordList.Add(Transportation);
        }

        // Print out the list of records using Console.WriteLine()
    }
}
