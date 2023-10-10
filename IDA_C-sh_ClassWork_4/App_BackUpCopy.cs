using IDA_C_sh_ClassWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDA_C_sh_ClassWork
{
    internal class App_BackUpCopy
    {
        public Storage[] storage_list;
        public long CompleteDataSize { set; get; } = 565 * Convert.ToInt64(Math.Pow(2, 30)); // 565 Gb
        public long DataFileSize { set; get; } = 780 * Convert.ToInt64(Math.Pow(2, 20)); // 780 Mb
        public long Get_All_Devices_Common_Capacity()
        {
            long common_capacity = 0;
            foreach (Storage s in storage_list) 
            {
                common_capacity += s.Get_Capacity();
            }
            return common_capacity;
        }
        public void Copy_All_Data()
        {
            if (Get_All_Devices_Common_Capacity() < CompleteDataSize) 
            { throw new Exception("Not enough space to copy"); }
            Console.WriteLine("Copy in progress... Done");
        }
        public long Get_Copy_Time()
        {
            if (Get_All_Devices_Common_Capacity() < CompleteDataSize)
            { throw new Exception("Not enough space to copy"); }

            long copy_time = 0; // [sec]
            long estimated_data_to_copy = CompleteDataSize;
            foreach (Storage s in storage_list) 
            {                
                copy_time += s.Get_Capacity() / s.Get_Speed();
                estimated_data_to_copy -= s.Get_Capacity();
                if (estimated_data_to_copy < 0) break;
            }
            return copy_time;
        }
        public long Get_Required_Storages_Ammount(Storage storage_obj)
        {
            // добавить обработку дробных значений
            long files_ammount = CompleteDataSize / DataFileSize;
            if (CompleteDataSize % DataFileSize != 0) files_ammount++;
            
            long files_on_one_storage = storage_obj.Get_Capacity() / DataFileSize;

            long required_storage_ammount = files_ammount / files_on_one_storage;
            if (files_ammount % files_on_one_storage != 0) files_ammount++;

            return ++required_storage_ammount;
        }
        public void Initialise(int N_Flash, int N_DVD, int N_HDD)
        {
            storage_list = new Storage[(N_Flash + N_DVD + N_HDD)];
           // Storage[] storage_list = new Storage[100];
           // storage_list = new Storage[100];
            int storage_index = 0;
            for (int i = 0; i < N_Flash; i++) 
            { 
                storage_list[storage_index++] = new Flash();
            }
            for (int i = 0; i < N_HDD; i++)
            {
                storage_list[storage_index++] = new HDD();
            }
            for (int i = 0; i < N_DVD; i++)
            { 
                storage_list[storage_index++] = new DVD(); 
            }   
        }

    }
}


/*
     internal class App_BackUpCopy
    {
        static public Storage[] storage_list;
        static long CompleteDataSize = 565 * Convert.ToInt64(2e30); // 565 Gb
        static long DataFileSize = 780 * Convert.ToInt64(2e20); // 780 Mb
        static public long Get_All_Devices_Common_Capacity()
        {
            long common_capacity = 0;
            foreach (Storage s in storage_list) 
            {
                common_capacity += s.Get_Capacity();
            }
            return common_capacity;
        }
        static public void Copy_All_Data()
        {
            if (Get_All_Devices_Common_Capacity() < CompleteDataSize) 
            { throw new Exception("Not enough space to copy"); }
            Console.WriteLine("Copy in progress... Done");
        }
        static public long Get_Copy_Time()
        {
            if (Get_All_Devices_Common_Capacity() < CompleteDataSize)
            { throw new Exception("Not enough space to copy"); }

            long copy_time = 0; // [sec]
            foreach (Storage s in storage_list) 
            {
                copy_time += s.Get_Capacity() / s.Get_Speed();
            }
            return copy_time;
        }
        static public long Get_Required_Storages_Ammount(Storage storage_obj)
        {
            // добавить обработку дробных значений
            long files_ammount = CompleteDataSize / DataFileSize;
            if (CompleteDataSize % DataFileSize != 0) files_ammount++;
            
            long files_on_one_storage = storage_obj.Get_Capacity() / DataFileSize;

            long required_storage_ammount = files_ammount / files_on_one_storage;
            if (files_ammount % files_on_one_storage != 0) files_ammount++;

            return required_storage_ammount;
        }
        static public void Initialise(int N_Flash, int N_DVD, int N_HDD)
        {
            //storage_list = new Storage[(N_Flash + N_DVD + N_HDD)];
            Storage[] storage_list = new Storage[100];
           // storage_list = new Storage[100];
            int storage_index = 0;
            for (int i = 0; i < N_Flash; i++) 
            { 
                storage_list[storage_index++] = new Flash();
            }
            for (int i = 0; i < N_DVD; i++)
            { 
                storage_list[storage_index++] = new DVD(); 
            }
            for (int i = 0; i < N_HDD; i++)
            {
                storage_list[storage_index++] = new HDD();
            }

        }

    }
*/