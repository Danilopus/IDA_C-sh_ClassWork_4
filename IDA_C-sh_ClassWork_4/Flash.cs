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
            return _description + "\nCapacity: " + (Capacity / (1024*1024)) + " [KB/s]\nRead/Write Speed: " + Speed_ + " [Mbit/sec]\n";
        }
    }
}
