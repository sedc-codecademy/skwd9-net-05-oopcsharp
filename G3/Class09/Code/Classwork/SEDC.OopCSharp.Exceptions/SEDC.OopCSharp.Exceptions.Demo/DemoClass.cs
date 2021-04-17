using System;
using System.Collections.Generic;

namespace SEDC.OopCSharp.Exceptions.Demo
{
    public class DemoClass
    {
        public int GetNumberAtCertainPositionParent(int position, List<int> listOfIntegers)
        {
            Console.WriteLine("Open connection to database");
            int resultNumber = 0;
            try
            {
                 resultNumber = GetNumberAtCertainPosition(position, listOfIntegers);
            }
            catch(Exception ex)
            {
                throw;
            }
            finally
            {
                Console.WriteLine("Close connection to database");
            }
            return resultNumber;
        }

        public int GetNumberAtCertainPosition(int position, List<int> listOfIntegers)
        {
            //int result = 0;
            //try
            //{
                return listOfIntegers[position];
            //}
            //catch(Exception ex)
            //{
            //    throw;
            //}
            //return result;
        }
    }
}
