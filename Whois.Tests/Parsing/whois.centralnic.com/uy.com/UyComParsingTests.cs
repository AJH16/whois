using Whois.Visitors;
using NUnit.Framework;

namespace Whois.Parsing.Whois.Centralnic.Com.UyCom
{
    [TestFixture]
    public class UyComParsingTests : ParsingTests
    {
        private PatternExtractorVisitor visitor;

        [SetUp]
        public void SetUp()
        {
            visitor = new PatternExtractorVisitor();
        }

        [Test]
        public void Test_found()
        {
            var sample = SampleReader.Read("whois.centralnic.com", "uy.com", "found.txt");
            var match = visitor.Parse(sample);

            Assert.IsTrue(match.Success);
            Assert.IsTrue(sample.Length > 0);
        }

        [Test]
        public void Test_not_found()
        {
            var sample = SampleReader.Read("whois.centralnic.com", "uy.com", "not_found.txt");
            var match = visitor.Parse(sample);

            Assert.IsTrue(match.Success);
            Assert.IsTrue(sample.Length > 0);
        }

        [Test]
        public void Test_found_status_registered()
        {
            var sample = SampleReader.Read("whois.centralnic.com", "uy.com", "found_status_registered.txt");
            var match = visitor.Parse(sample);

            Assert.IsTrue(match.Success);
            Assert.IsTrue(sample.Length > 0);
        }
    }
}
