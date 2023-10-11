using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDA_C_sh_ClassWork
{
    internal class RangeOfArray
    {
        int[] int_arr;
        //int _size = 0;
        int _capacity = 100;
        public int Min_Index_ { protected set; get; } = 0;
        public int Max_Index_ { protected set; get; } = 0;
        public int Length
        {
            get { return int_arr.Length; }            
        }
        public RangeOfArray() { int_arr = new int[_capacity]; Max_Index_ = _capacity - 1; }
        public RangeOfArray(int min_index, int max_index)
        {
            if (min_index == max_index) throw new Exception("NULL size not allowed");
            if (min_index > max_index) Service.ServiceFunction.swap(ref min_index, ref max_index);  

            Min_Index_ = min_index; 
            Max_Index_ = max_index;
            int_arr = new int[Max_Index_ - Min_Index_+1];
        }
        public RangeOfArray(int max_index)
        {
            int min_index = 0;
            if (min_index == max_index) throw new Exception("NULL size not allowed");
            if (min_index > max_index) Service.ServiceFunction.swap(ref min_index, ref max_index);

            Min_Index_ = min_index;
            Max_Index_ = max_index;
            int_arr = new int[Max_Index_ - Min_Index_];
        }
        public string ShowSettings()
        {
            //return ("Min_Index: {0}\nMax_Index: {1}", Min_Index_, Max_Index_).ToString();
            return ("Min_Index: "+ Min_Index_+"\nMax_Index: "+ Max_Index_).ToString();
        }
        public int this[int index]
            {
            get 
            {
                if (index < Min_Index_ || index > Max_Index_) throw new IndexOutOfRangeException("IndexOutOfRange\n" + ShowSettings());
                return int_arr[index - Min_Index_]; 
            }
            set 
            {
                if (index < Min_Index_ || index > Max_Index_) throw new IndexOutOfRangeException("IndexOutOfRange\n" + ShowSettings());
                int_arr[index - Min_Index_] = value; 
            }
            }
    }
}
