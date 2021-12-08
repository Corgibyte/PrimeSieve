using System.Collections.Generic;

namespace PrimeSieve.Models
{
  public class Sieve
  {

    public static List<int> FindPrimes(int number)
    {

      List<int> primes = new List<int> { };
      for (int i = 2; i <= number; i++)
      {
        primes.Add(i);
      }

      //Another for loop to prune the list
      for (int i = 2; i <= number; i++)
      {
        for (int j = i + 1; j <= number; j++)
        {
          if (j % i == 0)
          {
            primes.Remove(j);
          }
        }
      }
      return primes;
    }
  }
}

/* for (int i = 2; i <= number; i++)
{
  if (i % 2 != 0 && i > 2)
  {
    primes.Add(i);
  }
} */

