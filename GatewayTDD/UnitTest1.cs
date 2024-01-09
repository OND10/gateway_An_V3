using Gateway_Domain.Entities;
using GatewayDomain.Common;
using Moq;

namespace GatewayTDD
{
    public class UnitTest1
    {
        private readonly Mock<IBaseValidation> _mock;
        public UnitTest1()
        {
                _mock = new Mock<IBaseValidation>();
        }

        [Fact]
        public async Task Domain_Validation_Test_Method()
        {


            //Arange
            Companies companies = new Companies();
            _mock.Setup(demo => demo.isValid()).ReturnsAsync(await companies.isValid());

            //Acting
            IBaseValidation baseValidation = _mock.Object;
            var actualed_value = baseValidation.isValid();

            //Asserting
            Assert.NotNull(actualed_value);
        }
    }
}