using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDA_C_sh_ClassWork
{
    internal class HDD : Storage
    {
        override public long Get_Speed()
        {
            return Speed_;
        }

        public long Speed_ { get; set; } = 60 * Convert.ToInt64(Math.Pow(2, 20)); // скорость записи HDD принята как USB 2.0 = 60 Мбайт/сек, данные в [байт/с]
        int disk_partition_quantity { get; set; } = 5;
        public long partition_Capacity { get; set; } = 20 * Convert.ToInt64(Math.Pow(2, 30)); // 20 Gb in bytes
        public HDD()
        {
            Name_ = "HardDiskDrive storage";
            Model_ = "5*20=120Gb";
        }
        string _description = "HDD storage based on magnetics disks";
        override public long Get_Capacity()
        {
            return partition_Capacity * disk_partition_quantity;
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
            return "\nDevice name: " + Name_ + 
                "\nModel: " + Model_+
                "\ndescription: "+ _description + 
                "\nFullCapacity: " + (Get_Capacity() / (1024 * 1024)) + " [Mbytes]" +
                "\ndisk_partition_quantity: " + disk_partition_quantity +
                "\nEach partition capacity: " + (partition_Capacity / (1024 * 1024)) + " [Mbytes]" +
                "\nRead/Write Speed: " + (Speed_ / (1024 * 1024)) + " [Mbytes/sec]\n";
        }
    }
}
