using MovieNight.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MovieNight.Tests
{
    public class VotingTests
    {
        [Fact]
        public void Test_VotingId()
        {
            var expected = typeof(Guid);
            var sut = new Voting();
            var actual = sut.Id;

            Assert.True(expected == actual.GetType());
        }

        [Fact]
        public void Test_VotingPerson()
        {
            var expected = 0;
            var sut = new Voting();
            var actual = sut.People;
            
            Assert.True(typeof(List<Person>) == actual.GetType());
            Assert.True(expected <= actual.Count);
        }

        [Fact]
        public void Test_VotingMovie()
        {
            var sut = new Voting();
            
            Assert.NotNull(sut.Movie);
        }
    }
}
