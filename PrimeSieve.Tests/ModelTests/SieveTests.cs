using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeSieve.Models;
using System.Collections.Generic;

namespace PrimeSieve.Tests
{
  [TestClass]
  public class SieveTests
  {
    [TestMethod]
    public void FindPrimes_EmptyListWhenInputZero_EmptyList()
    {
      List<int> emptyList = new List<int> { };
      CollectionAssert.AreEqual(emptyList, Sieve.FindPrimes(0));
    }

    [TestMethod]
    public void FindPrimes_OnePrimeWhenInputTwo_EmptyList()
    {
      List<int> primeList = new List<int> { 2 };
      CollectionAssert.AreEqual(primeList, Sieve.FindPrimes(2));
    }
  }
}

// NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()