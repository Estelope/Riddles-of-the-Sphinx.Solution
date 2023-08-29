using Microsoft.VisualStudio.TestTools.UnitTesting;
using Riddle.Models;

namespace ROTS.Tests
{
  [TestClass]
  public class SphinxTests
  {

    [TestMethod]
    public void SphinxConstructor_CreatesInstanceOfSphinx_Sphinx()
    {
      Sphinx newRiddle = new Sphinx();
      Assert.AreEqual(typeof(Sphinx), newRiddle.GetType());
    }

  }
}