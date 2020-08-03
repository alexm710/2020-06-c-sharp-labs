using NUnit.Framework;
using lab_23_safari_park;

namespace lab_24_safari_park_test
{
    public class Tests
    {
        [SetUp]

        [Test]
        public void WhenADefaultVehicleMovesTwiceItsPositionIs20()
        {
            Vehicle v = new Vehicle();
            var result = v.Move(2);
            Assert.AreEqual(20, v.Position);
            Assert.AreEqual("Moving along 2 times", result);
        }

        [Test]
        public void WhenAVehicleWithSpeed40IsMovedOnceItsPositionIs40()
        {
            Vehicle v = new Vehicle(5, 40);
            var result = v.Move();
            Assert.AreEqual(40, v.Position);
            Assert.AreEqual("Moving along", result);
        }

        [Test]
        public void AirplaneTest()
        {
            Airplane a = new Airplane(200, 100, "JetsRUS") { NumPassengers = 150 };
            a.Ascend(500);
            var result = _altitude;
            Assert.AreEqual(40, v.Position);
            Assert.AreEqual($"Thank you for flying with {Airplane}, result);
        }
    }
}