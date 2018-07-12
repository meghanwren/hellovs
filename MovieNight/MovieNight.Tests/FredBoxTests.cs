using MovieNight.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace MovieNight.Tests
{
    public class FredBoxTests
    {
        private FredBox sut;
        public FredBoxTests()
        {
            sut = new FredBox();

        }

        [Fact]
        public void Test_FredBoxMakeMovie()
        {
            var expected = "My First Movie";
            var actual = sut.MakeMovie(expected);

            Assert.True(expected == actual.Title);
        }

        [Fact]
        public void Test_FredBoxMakeMovie_Negative()
        {
            string title = null;
            var actual = sut.MakeMovie(title);

            Assert.NotNull(actual.Title);
        }

        [Fact]
        public void Test_FredBoxGetMovies()
        {
            var expected = 0;
            var actual = sut.GetMovies();

            Assert.True(expected <= actual.Count());
        }

        [Fact]
        public void Test_FredBoxDistributeMovie()
        {
            var expected = sut.GetMovies().Count();
            var title = "My Second Movie";

            sut.DistributeMovie(sut.MakeMovie(title));

            Assert.True(expected < sut.GetMovies().Count());
        }
    }
}