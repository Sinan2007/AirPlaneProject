namespace EngineTests
{
    using AirPlaneProject;
    public class Tests
    {

        [Test]
        public void Engine_Constructor_Works()
        {
            Engine engine = new Engine(1000, 819, "diesel");

            Assert.AreEqual(1000, engine.Horsepower);
            Assert.AreEqual(819, engine.FuelConsumption);
            Assert.AreEqual("diesel", engine.Type);
        }

        [Test]
        public void Engine_CalculateFuelEfficiency_Works()
        {
            Engine engine = new Engine(1000, 500, "diesel");

            var result=engine.CalculateFuelEfficiency();

            var expected = 2;
            Assert.AreEqual(expected, result);
        }
    }
}