using Concepts.Library.Datastructures.Basic;

namespace Concepts.UnitTests
{
    public class OArray_UnitTests
    {
        private OArray<int> _testArray;

        [SetUp]
        public void Setup()
        {
            _testArray = new OArray<int>(20);
        }

        [Test]
        public void Add_WhenValueAdded_ReturnProperIndex()
        {
            _testArray.Add(2);

            Assert.AreEqual(0, _testArray.Find(2));
        }

        [Test]
        public void Find_WhenValueFound_ReturnProperIndex()
        {
            _testArray.Add(2);
            _testArray.Add(10);

            Assert.AreEqual(1, _testArray.Find(10));
        }

        [Test]
        public void Update_WhenValueUpdated_OldValueGone()
        {
            _testArray.Add(2);
            _testArray.Add(10);

            _testArray.Update(1, 20);

            Assert.AreEqual(-1, _testArray.Find(10));
            Assert.AreEqual(1, _testArray.Find(20));
        }

        [Test]
        public void Delete_WhenValueDeleted_OldValueGone()
        {
            _testArray.Add(2);
            _testArray.Add(10);
            _testArray.Add(30);

            _testArray.Delete(10);

            Assert.AreEqual(-1, _testArray.Find(10));
            Assert.AreEqual(0, _testArray.Find(2));
            Assert.AreEqual(1, _testArray.Find(30));
        }
    }
}