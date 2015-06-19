using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CampaignMonitorWebApp.Helpers
{
    public static class IntHelper
    {

        //There seemed to be a number of ways to do this, many of which over complicated.
        //The easiest and perhaps most efficient was through stackoverflow
        //http://stackoverflow.com/questions/5793009/efficiently-finding-all-divisors-of-a-number

        public static List<int> GetDivisors(int divisor)
        {
            try
            {
                return GetDivisorsList(divisor).ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }



        private static IEnumerable<int> GetDivisorsList(int n)
        {
            try
            {
                return from a in Enumerable.Range(1, n / 1)
                       where n % a == 0
                       select a;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        //I was looking for a linq solution for this as find linq easier to maintain and understand than looping / nested loops.
        //There were various ways to achieve this, but this seemed the most efficient in any case.
        public static int[] getMostPopularElement(int[] a)
        {
            try
            {
                return a.GroupBy(i => i)
                    .GroupBy(numGroup => numGroup.Count(), numGroup => numGroup.Key)
                    .OrderByDescending(supergroup => supergroup.Key)
                    .First().ToArray();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}