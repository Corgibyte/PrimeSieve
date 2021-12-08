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
    public void FindPrimes_OnePrimeWhenInputTwo_PrimeList()
    {
      List<int> primeList = new List<int> { 2 };
      CollectionAssert.AreEqual(primeList, Sieve.FindPrimes(2));
    }

    [TestMethod]
    public void FindPrimes_TwoPrimesWhenInputFour_PrimeList()
    {
      List<int> primeList = new List<int> { 2, 3 };
      CollectionAssert.AreEqual(primeList, Sieve.FindPrimes(4));
    }

    [TestMethod]
    public void FindPrimes_PrimesTo15_PrimeList()
    {
      List<int> primeList = new List<int> { 2, 3, 5, 7, 11, 13 };
      CollectionAssert.AreEqual(primeList, Sieve.FindPrimes(15));
    }
  }
}

// NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()