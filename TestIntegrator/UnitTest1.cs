using Xunit;
using Integr;

namespace TestIntegrator
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(2.0,5.0,10, 7.112)]
        [InlineData(3.5, 10.0, 100, 16.184)]
        [InlineData(0.0,0.0,10,0)]

        public void IntegrateByMidpointRule_Test(double a, double b, int n, double expecded)
        {
            var integrator = new Integrator(a, b, n);


            double result = integrator.IntegrateByMidpointRule();

            Assert.Equal(expecded, result, 3);
        }

    }
}