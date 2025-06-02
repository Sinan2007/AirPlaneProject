namespace AirplaneTests
{
    using AirPlaneProject;
    using Moq;
    public class Tests
    {

        [Test]
        public void Airplane_Conctructor_Works()
        {
            var mockEngine=new Mock<IEngine>();
            mockEngine.Setup(e => e.Horsepower).Returns(1000);
            mockEngine.Setup(e => e.FuelConsumption).Returns(500);
            mockEngine.Setup(e => e.Type).Returns("diesel");

            Airplane airplane = new Airplane("model", 500,mockEngine.Object);

            Assert.AreEqual("model",airplane.Model);
            Assert.AreEqual(500, airplane.Capacity);
        }

        [Test]
        public void Airplane_AddEngine_AlreadyAdded()
        {
            var mockEngine = new Mock<IEngine>();
            mockEngine.Setup(e => e.Horsepower).Returns(1000);
            mockEngine.Setup(e => e.FuelConsumption).Returns(500);
            mockEngine.Setup(e => e.Type).Returns("diesel");

            Airplane airplane = new Airplane("model", 500, mockEngine.Object);
            var result=airplane.AddEngine(mockEngine.Object);
            var expected = "The engine is already added";
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Airplane_AddEngine_Works()
        {
            var mockEngine = new Mock<IEngine>();
            mockEngine.Setup(e => e.Horsepower).Returns(1000);
            mockEngine.Setup(e => e.FuelConsumption).Returns(500);
            mockEngine.Setup(e => e.Type).Returns("diesel");

            Airplane airplane = new Airplane("model", 500,null);
            var result = airplane.AddEngine(mockEngine.Object);
            var expected = "Successfuly added";
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Airplane_RemoveEngine_Works()
        {
            var mockEngine = new Mock<IEngine>();
            mockEngine.Setup(e => e.Horsepower).Returns(1000);
            mockEngine.Setup(e => e.FuelConsumption).Returns(500);
            mockEngine.Setup(e => e.Type).Returns("diesel");

            Airplane airplane = new Airplane("model", 500, mockEngine.Object);

            var result = airplane.RemoveEngine();
            var expected = "Successfuly removed";
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Airplane_RemoveEngine_EngineIsNull()
        {
            var mockEngine = new Mock<IEngine>();
            mockEngine.Setup(e => e.Horsepower).Returns(1000);
            mockEngine.Setup(e => e.FuelConsumption).Returns(500);
            mockEngine.Setup(e => e.Type).Returns("diesel");

            Airplane airplane = new Airplane("model", 500, null);

            var result = airplane.RemoveEngine();
            var expected = "No engine for removing";
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Airplane_GetRange_Works()
        {
            var mockEngine = new Mock<IEngine>();
            mockEngine.Setup(e => e.Horsepower).Returns(1000);
            mockEngine.Setup(e => e.FuelConsumption).Returns(500);
            mockEngine.Setup(e => e.Type).Returns("diesel");

            Airplane airplane = new Airplane("model", 500, mockEngine.Object);

            var result = airplane.GetRange(1000);
            var expected = 1600;
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Airplane_DescribeAirplane_Works()
        {
            var mockEngine = new Mock<IEngine>();
            mockEngine.Setup(e => e.Horsepower).Returns(1000);
            mockEngine.Setup(e => e.FuelConsumption).Returns(500);
            mockEngine.Setup(e => e.Type).Returns("diesel");

            Airplane airplane = new Airplane("model", 500, mockEngine.Object);

            var result = airplane.DescribeAirplane();
            var expected = $"Model: model, Capacity: 500, Engine Type: diesel, Fuel Efficiency: {mockEngine.Object.CalculateFuelEfficiency()}";
            Assert.AreEqual(expected, result);
        }
    }
}
