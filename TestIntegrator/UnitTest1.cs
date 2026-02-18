using Xunit;
using Integr;

namespace TestIntegrator
{
    public class UnitTest1
    {
        [Fact]
        public void IntegrateByMidpointRule_Test()
        {

            var integrator = new Integrator(a: 2, b: 5, n: 10);


            double result = integrator.IntegrateByMidpointRule();

            double expected = 7.1122;
            Assert.Equal(expected, result, 4);
        }
    }
}