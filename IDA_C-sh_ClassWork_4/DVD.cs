using IDA_C_sh_ClassWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDA_C_sh_ClassWork
{
    internal class DVD : Storage
    {
        override public long Get_Speed()
        {
            return Speed_;
        }

        public long Speed_ { get; set; } = 1385000 * 16; // скорость записи DVD принята как 16х, данные в [байт/с]
        public long Capacity_1 { get; set; } = 47*Convert.ToInt64(1E8); // 4,7 Gb in bytes
        public long Capacity_2 { get; set; } = 9 * Convert.ToInt64(1E9); // 9 Gb in bytes
        public enum DVD_type { onesided, bisided };
        public DVD_type _type { get; set; } = DVD_type.bisided;

        string _description = "DVD storage";
        override public long Get_Capacity() 
        { 
            if (_type == DVD_type.onesided) return Capacity_1;
            else return Capacity_2;
        }
        override public void Copy_Data()
        {
            Console.WriteLine("\n\nCopy in progress... Done");
        }
        override public long Get_FreeSpace()
        {
            return Get_Capacity();
        }
        override public string Get_StorageInfo()
        {
            return _description + "\nCapacity: " + (Get_Capacity() / (1024 * 1024)) + " [Mbytes]\nRead/Write Speed: " + (Speed_/(1024*1024)) + " [Mbytes/sec]\n";
        }
    }
}
