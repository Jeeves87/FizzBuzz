using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class GetArray
    {
        int UserStart;
        int UserSize;
        private int[] _userArray;
        public int[] userArray
        {
            get
            {
                return _userArray;
            }
            set
            {
                if (value != null)
                {
                    _userArray = value;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
        }
        

        public int[] MakeArray()
        {
           int[] UserArray = Enumerable.Range(UserStart, UserSize).ToArray();
            return UserArray;
        }

        public GetArray(string userStart, string userSize)
        {
            bool success = int.TryParse(userStart, out UserStart);
            if (success)
            { Console.WriteLine("Your entry was a number!"); }
            else
            {
                Console.WriteLine("Conversion failed");
            }
            bool success2 = int.TryParse(userSize, out UserSize);
            if (success)
            { Console.WriteLine("Your entry was a number!"); }
            else
            {
                Console.WriteLine("Conversion failed");
            }     
        }

    
        

    
        
        


        


    }
}
