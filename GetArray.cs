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

        public bool Validate(string userStart, string userSize)
        {

            if (userStart != null || userSize != null)
            {
                int.TryParse(userStart, out UserStart);
                int.TryParse(userSize, out UserSize);
                return true;
            }
            else
            {
                throw new ArgumentNullException();
            }


        }




        public int[] MakeArray()
        {
            int[] UserArray = Enumerable.Range(UserStart, UserSize).ToArray();
            return UserArray;
        }

        public GetArray(string userStart, string userSize)
        {
            Validate(userStart, userSize);
        }

        public void Churn(int[] UserArray)
        {
            foreach (int i in UserArray)
            {
                if ((i % 15) == 0)
                {
                    Console.WriteLine($"{i}- Fizz Buzz!");
                    continue;
                }


                if ((i % 5) == 0)
                {
                    Console.WriteLine($"{i}- Buzz!");
                    continue;
                }
                if ((i % 3) == 0)
                {
                    Console.WriteLine($"{i}- Fizz!");
                    continue;
                }
            }

        }
    }
}
