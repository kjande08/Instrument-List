using System;
using System.Diagnostics;

namespace Software_Dev_Check_2;

class Program
{

    static void Main(string[] args)
    {

        Console.WriteLine("How many records do you want to add?");
        var numberOfRecords = int.Parse(Console.ReadLine());

        var recordList = new List<PercussionInstrument>();
        for (int i = 0; i < numberOfRecords; i++)
        {
            // In this loop, populate the object's properties using Console.ReadLine()
            var percussionInstrument = new PercussionInstrument();

            Console.WriteLine("Enter the value for Material");
            percussionInstrument.Material = Console.ReadLine();

            Console.WriteLine("Enter the value for Pitched");
            percussionInstrument.Pitched = Console.ReadLine();

            Console.WriteLine("Enter the value for Barred");
            percussionInstrument.Barred = Console.ReadLine();

            recordList.Add(percussionInstrument);
        }
    }
}