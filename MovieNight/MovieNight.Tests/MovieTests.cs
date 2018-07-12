using MovieNight.Library.Enums;
using MovieNight.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MovieNight.Tests
{
    public class MovieTests
    {
        private Movie sut;

        public MovieTests()
        {
            sut = new Movie();
        }

        [Fact]
        public void Test_MovieId()
        {
            var expected = typeof(Guid);
            var actual = sut.Id;

            Assert.True(expected == actual.GetType());
        }

        [Fact]
        public void Test_MovieActors()
        {
            var expected = 1;
            var actual = sut.Actors;

            Assert.True(typeof(List<Actor>) == actual.GetType());
            Assert.True(expected <= actual.Count);
        }

        [Fact]
        public void Test_MovieTitle()
        {
            var expected = typeof(string);

            Assert.True(expected == sut.Title.GetType());
            Assert.NotEmpty(sut.Title);
        }

        [Fact]
        public void Test_MovieGenre()
        {
            var expected = typeof(EGenre);

            Assert.True(expected == sut.Genre.GetType());
            Assert.NotEqual(EGenre.None, sut.Genre);
        }


    }
}
