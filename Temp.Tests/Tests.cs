using FluentAssertions;
using NUnit.Framework;
using Vostok.Logging.Abstractions;
using Vostok.Logging.Console;

namespace Temp.Tests
{
    [TestFixture]
    internal class Tests
    {
        [Test]
        public void Test1()
        {
            new SynchronousConsoleLog().Info("Test1");
        }

        [Test]
        public void Test2()
        {
            var log = new SynchronousConsoleLog();
            for (int i = 0; i < 10; i++)
                log.Info("Test2 {i}", i);

            5.Should().Be(6);
        }
    }
}