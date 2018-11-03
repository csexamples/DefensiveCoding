using System;
using Common;
using Xunit;

namespace CommonTest
{
    public class StringHandlerTest
    {
        [Fact]
        public void InsertSpacesTestValid()
        { 
            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";

            var actual = source.InsertSpaces();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InsertSpacesWithExistingSpace()
        {
            var source = "Sonic Screwdriver";
            var expected = "Sonic Screwdriver";

            var actual = source.InsertSpaces();

            Assert.Equal(expected, actual);
        }
    }
}
