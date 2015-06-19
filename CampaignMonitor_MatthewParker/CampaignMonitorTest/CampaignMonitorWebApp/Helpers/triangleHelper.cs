using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CampaignMonitorWebApp.Exceptions;

namespace CampaignMonitorWebApp.Helpers
{
    public static class TriangleHelper
    {

        public enum TriangleType
        {
            Scalene = 1, // no two sides are the same length
            Isosceles = 2, // two sides are the same length and one differs
            Equilateral = 3, // all sides are the same length
            Error = 4 // inputs can't produce a triangle
        }


        ///I found this excellent article returning triangle types from 3 input ints. So my work here, and the tests, are based on this
        ///http://codereview.stackexchange.com/questions/18257/function-for-determining-triangle-type
        public static string GetTriangleType(int a, int b, int c)
        {

            try
            {
                //Placing items in an array for processing 
                int[] values = new int[3] { a, b, c };

                if (a <= 0 || b <= 0 || c <= 0)
                {
                    throw new InvalidTriangleException("Negative numbers invalid triangle exception");
                }
                else if (values.Distinct().Count() == 1) //There is only one distinct value in the set, therefore all sides are of equal length
                {
                    return string.Format("{0} with output {1}", TriangleType.Equilateral, area(a, b, c));
                }
                else if (values.Distinct().Count() == 2) //There are only two distinct values in the set, therefore two sides are equal and one is not
                {
                    return string.Format("{0} with output {1}", TriangleType.Isosceles, area(a, b, c));
                }
                else if (values.Distinct().Count() == 3) // There are three distinct values in the set, therefore no sides are equal
                {
                    return string.Format("{0} with output {1}", TriangleType.Scalene, area(a, b, c));
                }
                else
                {
                    throw new InvalidTriangleException("Invalid triangle exception");
                }
            }
            catch ( Exception e )
            {
                throw new Exception(e.Message);
            }
        }
        
        private static double area(double numA, double numB, double numC)
        {
            try
            {
                return (numA + numB + numC) / 2;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}