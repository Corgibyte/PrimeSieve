using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeSieve.Models;
using System.Collections.Generic;

namespace PrimeSieve.Tests
{
  [TestClass]
  public class SieveTests
  {
    [TestMethod]
    public void FindPrimes_EmptyListWhenZero_EmptyList()
    {
      List<int> emptyList = new List<int> { };
      CollectionAssert.AreEqual(emptyList, Sieve.FindPrimes(0));
    }
  }
}

// NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()