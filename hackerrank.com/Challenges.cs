using System;
using System.Collections.Generic;

namespace hackerrank
{
    public class Challenges
    {
        public int sockMerchant(int n, int[] ar)
        {
            int pairofSocks = 0;
            if ( n == ar.Length && n > 0)
            {
                HashSet<int> even = new HashSet<int>();
                for(int i=0; i< ar.Length;++i)
                {
                    if (!even.Contains(ar[i]))
                    {
                        even.Add(ar[i]);
                    }
                    else
                    {
                        ++pairofSocks;
                        even.Remove(ar[i]);
                    }
                }
            }
            return pairofSocks;
        }
    }
}
