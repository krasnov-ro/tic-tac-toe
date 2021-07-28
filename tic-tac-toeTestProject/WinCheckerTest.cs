using Microsoft.VisualStudio.TestTools.UnitTesting;
using tic_tac_toe;

namespace tic_tac_toeTestProject
{
    [TestClass]
    public class WinCheckerTest
    {
        [TestMethod]
        public void WinCheckerTestMethod()
        {
            GameForm gameForm = new GameForm();
            var result = gameForm.CheckWinner();

            Assert.AreEqual(true, result, "CheckWinner method - fatal error");
        }
    }
}
