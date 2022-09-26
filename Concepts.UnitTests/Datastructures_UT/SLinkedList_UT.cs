using Concepts.Library.Datastructures.Basic;

namespace Concepts.UnitTests.Datastructures_UT
{
    public class SLinkedList_UT
    {
        private SLinkedList<int> _testLinkedList;

        [SetUp]
        public void Setup()
        {
            _testLinkedList = new SLinkedList<int>();
        }

        [Test]
        public void AddFirst_WhenListEmpty_ValueAdded()
        {
            _testLinkedList.AddFirst(1);

            Assert.That(_testLinkedList.Length, Is.EqualTo(1));
        }

        [Test]
        public void AddLast_WhenListEmpty_ValueAdded()
        {
            _testLinkedList.AddLast(1);

            Assert.That(_testLinkedList.Length, Is.EqualTo(1));
        }

        [Test]
        public void Find_WhenHasValue_FoundValue()
        {
            _testLinkedList.AddLast(1);

            Assert.That(_testLinkedList.Find(1), Is.EqualTo(0));
        }

        [Test]
        public void Update_WhenHasValue_UpdateValue()
        {
            _testLinkedList.AddLast(1);
            _testLinkedList.AddLast(10);

            var result = _testLinkedList.Update(10, 12);

            Assert.That(result, Is.EqualTo(12));
        }

        [Test]
        public void Delete_WhenHasValues_DeleteValue()
        {
            _testLinkedList.AddLast(1);
            _testLinkedList.AddLast(10);
            _testLinkedList.AddLast(12);

            _testLinkedList.Delete(10);

            Assert.That(-1, Is.EqualTo(_testLinkedList.Find(10)));
        }
    }
}