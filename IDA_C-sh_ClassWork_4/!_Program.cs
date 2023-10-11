// ClassWork template 1.2 // date: 29.09.2023

using IDA_C_sh_ClassWork;
using Service;
using System;
using System.Linq.Expressions;
using System.Text;



// ClassWork 04 : [C sharp Lab-Practice] 06.10.2023 --------------------------------




namespace IDA_C_sh_ClassWork
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ConsoleKey key = new ConsoleKey();
            do
            {
               Console.Clear();
                Console.WriteLine("\n*** HomeWork 4: Indexes, Inheritance, Structures\n\n" +
                    "1. Task 1: RangeOfArray\n" +
                    "2. Task 2: BackUpCopy app\n" +
                    "3. Task 3: Figures draw\n" +
                    "\nPress number to choose Task" +
                    "\nEsc - exit\n"
                    );
                key = Console.ReadKey().Key;
               switch (key)
                {
                    case ConsoleKey.D1: case ConsoleKey.NumPad1: Task_1(); break;
                    case ConsoleKey.D2: case ConsoleKey.NumPad2: Task_2(); break;    
                    case ConsoleKey.D3: case ConsoleKey.NumPad3: Task_3(); break;
                }
                Console.ReadKey();
            } while (key != ConsoleKey.Escape);

        } // RangeOfArray
        public static void Task_1() 
        {
            Console.WriteLine
        (" *** RangeOfArray class demo ***\n\n" +
        "Default settings:\n{0}\n", new RangeOfArray().ShowSettings());

         RangeOfArray variadic_range_array = new RangeOfArray(-5, 15);
         Console.WriteLine ("\n* Current settings\n" + variadic_range_array.ShowSettings());
            variadic_range_array[-3] = 777;
            variadic_range_array[15] = 555;
           //variadic_range_array[20] = 333;


            for (int i = variadic_range_array.Min_Index_; i <= variadic_range_array.Max_Index_; i++)
                //Console.WriteLine("[{0}] {1}", i, variadic_range_array[i]);
                Console.WriteLine("[" + i + "] "+ variadic_range_array[i]);




            RangeOfArray variadic_range_array_2 = new RangeOfArray(5, 15);
            try { variadic_range_array_2[-3] = 777; }
            catch(Exception e) { Console.WriteLine(e.Message); }
            variadic_range_array_2[15] = 555;
            variadic_range_array_2[10] = 333;
            Console.WriteLine("\n* Current settings\n" + variadic_range_array_2.ShowSettings());
            for (int i = variadic_range_array_2.Min_Index_; i <= variadic_range_array_2.Max_Index_; i++)
                Console.WriteLine("[{0}] {1}", i, variadic_range_array_2[i]);

        }
        // Резервная копия       
        public static void Task_2() 
        {
            App_BackUpCopy app = new App_BackUpCopy();


            Console.WriteLine
                (" *** File transfer app ***\n\n" + 
                "Data summary: {0} [bytes], {1} [MB], {2} [Gb]\n" +
                "Each file: {3} [bytes], {4} [MB], {5} [Gb]\n",
                app.CompleteDataSize,
                (app.CompleteDataSize/(1024*1024)),
                (app.CompleteDataSize / (1024 * 1024*1024)),
                app.DataFileSize,
                (app.DataFileSize / (1024 * 1024)),
                ((double)app.DataFileSize / (1024 * 1024 * 1024))
                );

            Console.WriteLine("Would you like to see storage types info?\nEnter - yes, any else key - no");
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.WriteLine("\nTypes of storages:\n");
                Console.WriteLine(new Flash().Get_StorageInfo());
                Console.WriteLine(new DVD().Get_StorageInfo());
                Console.WriteLine(new HDD().Get_StorageInfo());
            }

            //Get_Required_Storages_Ammount
            Console.Write("\nRequired Flash Ammount: " +
            app.Get_Required_Storages_Ammount(new Flash()));
            Console.Write("\nRequired DVD Ammount: " +
            app.Get_Required_Storages_Ammount(new DVD()));
            Console.Write("\nRequired HDD Ammount: " +
            app.Get_Required_Storages_Ammount(new HDD()));


            Console.Write("\n\nWhat storages do you have?\n" + "Flash: " );
            int N_Flash = ServiceFunction.Get_Int(0, 1000, " its too much"); // количество флэшек
            Console.Write("DVD: ");
            int N_DVD = ServiceFunction.Get_Int(0, 100, " its too much\nDVD: "); // количество DVD дисков
            Console.Write("HDD: ");
            int N_HDD = ServiceFunction.Get_Int(0, 10, " its too much"); // количество HDD дисков
            app.Initialise(N_Flash, N_DVD, N_HDD);

            //Get_All_Devices_Common_Capacity
            Console.WriteLine("\n\nAll_Devices_Common_Capacity: "+
            (app.Get_All_Devices_Common_Capacity()/(1024*1024*1024)) + " [Gb]");

            try
            {
                //Get_Copy_Time
                Console.Write("\nEstimated copy time: " +
                app.Get_Copy_Time() + " seconds");

                //Copy_All_Data
                Console.WriteLine("\n\nTrying to copy all data");
                app.Copy_All_Data();
            }
            catch (Exception e)
            { Console.WriteLine(e.Message); }

            Console.WriteLine("\n\nWould you like to see device info of each device?\nEnter - yes, any else key - no");
            if (Console.ReadKey().Key != ConsoleKey.Enter) return;
            //Other functions: all devices info
            foreach (Storage storage_obj in app.storage_list)
                Console.WriteLine(storage_obj.Get_StorageInfo());
            Console.ReadKey();

        }
        public static void Task_3() { }

    } // class Programm
}// namespace

