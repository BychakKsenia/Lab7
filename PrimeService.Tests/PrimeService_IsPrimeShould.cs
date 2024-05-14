using Prime.Services;

namespace Prime.UnitTests.Services
{
    public class PrimeService_IsPrimeShould
    {
        private readonly PrimeService _primeService;

        public PrimeService_IsPrimeShould()
        {
            _primeService = new PrimeService();
        }

        [Theory]
        [InlineData(0, 0, 1, 2)]
        [InlineData(-2, 3, 0, 0)]
        [InlineData(0, 0, 0, 0)]
        public void IsVectorDot(double x1, double y1, double x2, double y2)
        {
            var result = _primeService.GetVectorsTypes(x1, y1, x2, y2);
            Assert.Equal("One (or both) of vectors is dot", result);
        }

        [Theory]
        [InlineData(1, 2, 1, 2)]
        [InlineData(-1, -2, 1, 2)]
        [InlineData(1, 2, 2, 1)]
        public void IsEqualLength(double x1, double y1, double x2, double y2)
        {
            var result = _primeService.GetVectorsTypes(x1, y1, x2, y2);
            Assert.Contains("equal",result);
        }

        [Theory]
        [InlineData(-1, -2, 1, 2)]
        [InlineData(-1, 4, 2, -8)]
        public void IsOpposite(double x1, double y1, double x2, double y2)
        {
            var result = _primeService.GetVectorsTypes(x1, y1, x2, y2);
            Assert.Contains("unlike", result);
        }

        [Theory]
        [InlineData(0, 4, 2, -8)]
        [InlineData(6, 3, 4, 6)]
        [InlineData(1, 5, 2, 6)]
        public void IsNotColinear(double x1, double y1, double x2, double y2)
        {
            var result = _primeService.GetVectorsTypes(x1, y1, x2, y2);
            Assert.Contains("non-collinear", result);
        }
    }
}