using MovieNight.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MovieNight.Tests
{
    public class MovieTests
    {
        [Fact]
        public void Test_MovieId()
        {
            var expected = typeof(Guid);
            var sut = new Movie();
            var actual = sut.Id;

            Assert.True(expected == actual.GetType());
        }
    }
}
