using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace Tests
{
    public class BasicTest
    {
        [Fact]
        public void Add()
        {
            var test = 1;
            var test2 = 1 + 2;
            test2.Should().Be(3);
        }
    }
}
