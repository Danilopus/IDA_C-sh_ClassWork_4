using IDA_C_sh_ClassWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDA_C_sh_ClassWork
{
    internal class Flash : Storage
    {
        public void StorageClassInfo()
        {
            Console.WriteLine("Device name: {0}\nCapacity: {1} [Mb], {2} [Gb]",          
                Name_,
                Get_Capacity()/(1024*1024),
                (double)Get_Capacity() / (1024 * 1024*1024)
                );
        }
       public Flash()
        {
            Name_ = "USB_Flash";
            Model_ = "1Gb";
        }
        override public long Get_Speed()
        {
            return Speed_;
        }
        public long Speed_ { get; set; } = 480 * Convert.ToInt64(Math.Pow(2,20)); // bytes/sec
        public long Capacity { get; set; } = Convert.ToInt64(Math.Pow(2, 30)); // in bytes
        string _description = "Flash storage USB 3.0";
        override public long Get_Capacity() { return Capacity; }
        override public void Copy_Data()
        {
            Console.WriteLine("\n\nCopy in progress... Done");
        }
        override public long Get_FreeSpace()
        {
            return Capacity;
        }
        override public string Get_StorageInfo()
        {
            return "\nDevice name: " + Name_ +
                "\nModel: " + Model_ +
                "\ndescription: " + _description +
                "\nCapacity: " + (Capacity / (1024*1024)) + " [Mb]" +
                "\nRead/Write Speed: " + (Speed_ / (1024 * 1024)) + " [Mb/sec]\n";
        }
    }
}
