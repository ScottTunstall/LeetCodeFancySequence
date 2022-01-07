using LeetcodeFancySequence;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        private Fancy _fancy;

        [SetUp]
        public void Setup()
        {
            _fancy = new Fancy();
        }

        [Test]
        public void Test_Mult()
        {
            _fancy.Append(1);
            _fancy.MultAll(5);
            _fancy.MultAll(2);
            _fancy.Append(2);
            _fancy.MultAll(6);
            
            Assert.AreEqual(60, _fancy.GetIndex(0));
            Assert.AreEqual(12, _fancy.GetIndex(1));
        }


        [Test]
        public void Test1()
        {
            // The example given for the problem
            _fancy.Append(2); // fancy sequence: [2]
            _fancy.AddAll(3); // fancy sequence: [2+3] -> [5]
            _fancy.Append(7); // fancy sequence: [5, 7]
            _fancy.MultAll(2); // fancy sequence: [5*2, 7*2] -> [10, 14]
            Assert.AreEqual(10,_fancy.GetIndex(0)); // return 10
            
            _fancy.AddAll(3); // fancy sequence: [10+3, 14+3] -> [13, 17]
            _fancy.Append(10); // fancy sequence: [13, 17, 10]
            _fancy.MultAll(2); // fancy sequence: [13*2, 17*2, 10*2] -> [26, 34, 20]

            Assert.AreEqual(26, _fancy.GetIndex(0)); // return 26
            Assert.AreEqual(34, _fancy.GetIndex(1)); // return 34
            Assert.AreEqual(20, _fancy.GetIndex(2)); // return 20        }
        }


        [Test]
        public void Test2()
        {
            _fancy.Append(12);
            _fancy.Append(8);
            _fancy.GetIndex(1);
            _fancy.Append(12);
            _fancy.GetIndex(0);
            _fancy.AddAll(12);
            _fancy.Append(8);
            _fancy.GetIndex(2);
            _fancy.GetIndex(2);
            _fancy.Append(4);
            _fancy.Append(13);
            _fancy.GetIndex(4);
            _fancy.Append(12);
            _fancy.GetIndex(6);
            _fancy.Append(11);
            _fancy.GetIndex(1);
            _fancy.Append(10);
            _fancy.GetIndex(2);
            _fancy.MultAll(3);
            _fancy.AddAll(1);
            _fancy.GetIndex(6);
            _fancy.Append(14);
            _fancy.AddAll(5);
            _fancy.GetIndex(6);
            _fancy.MultAll(12);
            _fancy.GetIndex(3);
            _fancy.MultAll(12);
            _fancy.AddAll(15);
            _fancy.AddAll(6);
            _fancy.Append(7);
            _fancy.MultAll(8);
            _fancy.Append(13);
            _fancy.Append(15);
            _fancy.Append(15);
            _fancy.MultAll(10);
            _fancy.GetIndex(9);
            _fancy.MultAll(12);
            _fancy.MultAll(12);
            _fancy.MultAll(9);
            _fancy.GetIndex(9);

            _fancy.AddAll(9);
            _fancy.Append(9);
            _fancy.MultAll(4);
            _fancy.AddAll(8);
            _fancy.AddAll(11);
            _fancy.MultAll(15);
            _fancy.AddAll(9);
            _fancy.AddAll(1);
            _fancy.Append(4);
            _fancy.Append(10);
            
            Assert.AreEqual(150746316, _fancy.GetIndex(9));
        }


        [Test]
        public void Test3()
        {
            _fancy.Append(5);
            _fancy.GetIndex(0);
            _fancy.MultAll(14);
            _fancy.MultAll(10);
            _fancy.GetIndex(0);
            _fancy.AddAll(12);
            _fancy.Append(10);
            _fancy.Append(4);
            _fancy.GetIndex(2);
            _fancy.Append(4);
            _fancy.Append(2);
            _fancy.AddAll(1);
            _fancy.GetIndex(1);
            _fancy.MultAll(8);
            _fancy.AddAll(11);
            _fancy.Append(15);
            _fancy.AddAll(12);
            _fancy.GetIndex(0);
            _fancy.GetIndex(3);
            _fancy.MultAll(4);
            _fancy.MultAll(11);
            _fancy.MultAll(11);
            _fancy.Append(10);
            _fancy.AddAll(8);
            _fancy.GetIndex(2);
            _fancy.GetIndex(3);
            _fancy.GetIndex(0);
            _fancy.Append(7);
            _fancy.GetIndex(3);
            _fancy.AddAll(2);
            _fancy.MultAll(6);
            _fancy.Append(10);
            _fancy.MultAll(6);
            _fancy.AddAll(8);
            _fancy.GetIndex(7);
            _fancy.Append(9);
            _fancy.Append(9);
            _fancy.AddAll(12);
            _fancy.GetIndex(0);
            _fancy.MultAll(13);
            _fancy.GetIndex(7);
            _fancy.AddAll(3);
            _fancy.GetIndex(4);
            _fancy.MultAll(8);
            _fancy.AddAll(14);
            _fancy.GetIndex(2);
            _fancy.AddAll(9);
            _fancy.Append(9);
            _fancy.Append(9);
            _fancy.Append(7);
            _fancy.MultAll(5);
            _fancy.MultAll(12);
            _fancy.Append(9);
            _fancy.MultAll(3);
            _fancy.AddAll(8);
            _fancy.GetIndex(10);
            _fancy.AddAll(14);
            _fancy.MultAll(14);
            _fancy.MultAll(14);
            _fancy.MultAll(6);
            _fancy.Append(1);
            _fancy.MultAll(3);
            _fancy.Append(11);
            _fancy.MultAll(12);
            _fancy.AddAll(6);
            _fancy.Append(7);
            _fancy.Append(13);
            _fancy.GetIndex(12);
            _fancy.GetIndex(5);
            _fancy.GetIndex(6);
            _fancy.AddAll(1);
            _fancy.MultAll(11);
            _fancy.MultAll(11);
            _fancy.Append(4);
            _fancy.Append(9);
            _fancy.GetIndex(7);
            _fancy.Append(11);
            _fancy.Append(1);
            _fancy.Append(3);
            _fancy.GetIndex(1);
            _fancy.GetIndex(0);

            Assert.AreEqual(601045500, _fancy.GetIndex(0));

        }

    }

}