using Microsoft.VisualStudio.TestTools.UnitTesting;

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

    [TestMethod]
    public void GetRandomRiddle_ReturnsValidRiddle()
    {
    Sphinx sphinx = new Sphinx();
    Riddle riddle = sphinx.GetRandomRiddle();
        Assert.IsFalse(string.IsNullOrEmpty(riddle.Question));
        Assert.IsFalse(string.IsNullOrEmpty(riddle.Answer));
    }

  }
}