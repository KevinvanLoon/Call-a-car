using NUnit.Framework;

namespace CallACar.Test
{
    public class ReservationTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ReserveCarDoingEverythingOkay()
        {
            Assert.Pass();
        }
        
        [Test]
        public void ReserveCarWithoutAddress()
        {
            Assert.Pass();
        }

        [Test]
        public void ReserveCarUsableForWheelChair()
        {
            Assert.Pass();
        }
        
        [Test]
        public void GetHistoryByUser()
        {
            Assert.Pass();
        }
        
        [Test]
        public void EmployeeShouldRequestForHistoryOfUser()
        {
            Assert.Fail();
        }
    }
}