using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CallACar.API.Controllers;
using CallACarr.Domain;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace CallACar.Test
{
    public class StatisticsTest
    {
        private StatisticsController _controller;
        
        [SetUp]
        public void Setup()
        {
            _controller = new StatisticsController();
        }

        [Test]
        public async Task APIShouldNotSendPrivateData()
        {
            // get statistics data
            IActionResult data = _controller.GetAggregateData(new DateTime(2021, 03, 18), DateTime.Now);

            Assert.That(data, Is.InstanceOf<OkObjectResult>());

            IList<int> userIds = ((IEnumerable<Reservation>) ((OkObjectResult) data).Value).Select(c => c.UserId)
                .ToList();

            Assert.AreEqual(1, userIds.Distinct().Count()); //Because it are all null values, distincted there should be only one item kept.
            Assert.IsNull(userIds.First());
        }

    }
}