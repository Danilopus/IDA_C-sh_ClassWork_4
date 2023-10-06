using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDA_C_sh_ClassWork
{
    abstract internal class Storage
    {
        public string Name_ { get; set; }
        public string Model_ { get; set; }
        abstract public long Get_Capacity();
        abstract public void Copy_Data();
        abstract public long Get_FreeSpace();
        abstract public string Get_StorageInfo();
        abstract public long Get_Speed();

    }
}
