// ClassWork template 1.2 // date: 29.09.2023

using IDA_C_sh_ClassWork;
using Service;
using System;
using System.Linq.Expressions;
using System.Text;



// ClassWork 04 : [C sharp Practice] 06.10.2023 --------------------------------




namespace IDA_C_sh_ClassWork
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Task_1();
            // Task_2();
            // Task_3();


            Console.ReadKey();

        }
        // Резервная копия
        public static void Task_1() 
        {
            App_BackUpCopy app = new App_BackUpCopy();
            int N_Flash = 5; // количество флэшек
            int N_DVD = 10; // количество DVD дисков
            int N_HDD = 15; // количество HDD дисков
            app.Initialise(N_Flash, N_DVD, N_HDD);

            //Get_All_Devices_Common_Capacity
            Console.WriteLine("\nAll_Devices_Common_Capacity: "+
            (app.Get_All_Devices_Common_Capacity()/(1024*1024*1024)) + " [Gb]");

            //Copy_All_Data
            Console.WriteLine("\nTrying to copy all data");
            app.Copy_All_Data();

            //Get_Copy_Time
            Console.Write("\nEstimated copy time: " +
            app.Get_Copy_Time() + " seconds");

            //Get_Required_Storages_Ammount
            Console.Write("\n\nRequired Flash Ammount: " +
            app.Get_Required_Storages_Ammount(new Flash()));
            Console.Write("\nRequired DVD Ammount: " + 
            app.Get_Required_Storages_Ammount(new DVD()));
            Console.Write("\nRequired HDD Ammount: " +
            app.Get_Required_Storages_Ammount(new HDD()));

            //Other functions: all devices info
            /*foreach (Storage storage_obj in app.storage_list)
                Console.WriteLine(storage_obj.Get_StorageInfo());*/




        }
        public static void Task_2() { }
        public static void Task_3() { }

    } // class Programm
}// namespace

