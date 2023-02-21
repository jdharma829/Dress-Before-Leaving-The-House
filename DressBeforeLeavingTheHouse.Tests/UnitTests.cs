namespace DressBeforeLeavingTheHouse.Tests
{
    public class Tests
    {
        private DressingManager? _manager;

        [SetUp]
        public void Setup()
        {
            _manager = new DressingManager();
        }

        [TestCase("HOT 8, 6, 4, 2, 1, 7", "Removing PJs, shorts, shirt, sunglasses, sandals, leaving house")]
        [TestCase("COLD 8, 6, 3, 4, 2, 5, 1, 7", "Removing PJs, pants, socks, shirt, hat, jacket, boots, leaving house")]
        [TestCase("HOT 7", "fail")]
        [TestCase("HOT 8, 6, 6", "Removing PJs, shorts, fail")]
        [TestCase("HOT 8, 6, 3", "Removing PJs, shorts, fail")]
        [TestCase("COLD 8, 6, 3, 4, 2, 5, 7", "Removing PJs, pants, socks, shirt, hat, jacket, fail")]
        [TestCase("COLD 8, 6, 3, 4, 2, 5, 1", "Removing PJs, pants, socks, shirt, hat, jacket, boots, fail")]
        [TestCase("COLD 6", "fail")]

        [TestCase("HOT 8, 6, 4, 2, 1", "Removing PJs, shorts, shirt, sunglasses, sandals, fail")]
        public void TestDressingStyle(string input, string output)
        {
            Assert.AreEqual(_manager?.Process(input), output);
        }
    }
}