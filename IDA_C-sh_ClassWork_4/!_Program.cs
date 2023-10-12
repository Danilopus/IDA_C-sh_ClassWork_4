// ClassWork template 1.2 // date: 29.09.2023

using IDA_C_sh_ClassWork;
using IDA_C_sh_ClassWork_4;
using Service;
using System;
using System.ComponentModel;
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
            Console.WriteLine("\n* Current settings\n" + variadic_range_array.ShowSettings());
            variadic_range_array[-3] = 777;
            variadic_range_array[15] = 555;
            //variadic_range_array[20] = 333;
            for (int i = variadic_range_array.Min_Index_; i <= variadic_range_array.Max_Index_; i++)
                //Console.WriteLine("[{0}] {1}", i, variadic_range_array[i]);
                Console.WriteLine("[" + i + "] " + variadic_range_array[i]);


            RangeOfArray variadic_range_array_2 = new RangeOfArray(5, 15);
            try { variadic_range_array_2[-3] = 777; }
            catch (Exception e) { Console.WriteLine(e.Message); }
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
                (app.CompleteDataSize / (1024 * 1024)),
                (app.CompleteDataSize / (1024 * 1024 * 1024)),
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


            Console.Write("\n\nWhat storages do you have?\n" + "Flash: ");
            int N_Flash = ServiceFunction.Get_Int(0, 1000, " its too much"); // количество флэшек
            Console.Write("DVD: ");
            int N_DVD = ServiceFunction.Get_Int(0, 100, " its too much\nDVD: "); // количество DVD дисков
            Console.Write("HDD: ");
            int N_HDD = ServiceFunction.Get_Int(0, 10, " its too much"); // количество HDD дисков
            app.Initialise(N_Flash, N_DVD, N_HDD);

            //Get_All_Devices_Common_Capacity
            Console.WriteLine("\n\nAll_Devices_Common_Capacity: " +
            (app.Get_All_Devices_Common_Capacity() / (1024 * 1024 * 1024)) + " [Gb]");

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
            //Console.ReadKey();

        }
        //Figure
        public static void Task_3()
        {
            Figure generalised_figure = new Figure();

            do
            // Figure and Color choosing block
            {
                Console.Clear();
                Console.WriteLine("\n*** Figure_draw app ***\n\n");
     
                    // Figure
                    Figure_Type figure_type = Get_Figure_Choise();
                    // Color
                    ConsoleColor color = Get_Figure_Color_Choise();
                

                switch (figure_type)
                {
                    case Figure_Type.Circle: new Circle(color); break;
                    case Figure_Type.Rectangle: new Rectangle(color); break;
                    case Figure_Type.Triangle: new Triangle(color); break;
                    case Figure_Type.MultiAngleFigure: new MultiAngleFigure(color); break;
                    case Figure_Type.Diamond: new Diamond(color); break;
                }

                Console.WriteLine("\nFigure list:\n");
                foreach (var item in Figure.figure_list)
                    Console.Write(item + " | ");

                Console.WriteLine("\n\nAdd figure?\nEnter - yes, any else key - no");                
            } while (Console.ReadKey().Key == ConsoleKey.Enter);

            generalised_figure.DrawAll();
            Figure.figure_list.Clear();
        }
        public enum Figure_Type { Circle, Rectangle, Triangle, Diamond, MultiAngleFigure };
        static Figure_Type Get_Figure_Choise()
        {
            Console.WriteLine("Choose a figure to draw:\n" +
             "1 - Circle\n" +
             "2 - Rectangle\n" +
             "3 - Triangle\n" +
             "4 - Diamond\n" +
             "5 - MultiAngleFigure");
            return (Figure_Type)(ServiceFunction.Get_Int(1, 5, "out of range")-1);
        }
        static ConsoleColor Get_Figure_Color_Choise()
        {
            Console.WriteLine("Choose a color of figure:\n" +            
                "Black       - 0\n" + 
                "Blue        - 9\n" +
                "Cyan        - 11\n" +
                "DarkBlue    - 1\n" +
                "DarkCyan    - 3\n" +
                "DarkGray    - 8\n" +
                "DarkGreen   - 2\n" +
                "DarkMagenta - 5\n" +
                "DarkRed     - 4\n" +
                "DarkYellow  - 6\n" +
                "Gray        - 7\n" +
                "Green       - 10\n" +
                "Magenta     - 13\n" +
                "Red         - 12\n" +
                "White       - 15\n" +
                "Yellow      - 14\n");
            int color_number = ServiceFunction.Get_Int(0, 15, "out of range");
         /*       ConsoleColor color = ConsoleColor.White;
                switch (color_number)
                {
                    case 1: color = ConsoleColor.Black; break;
                    case 2: color = ConsoleColor.White; break;
                    case 3: color = ConsoleColor.Yellow; break;
                    case 4: color = ConsoleColor.Red; break;
                    case 5: color = ConsoleColor.Green; break;
                }*/
            //return color;

            return (ConsoleColor)(color_number);
        }

    
} // class Programm
}// namespace

