using Gateway_Domain.Entities;
using GatewayDomain.Common;
using Moq;

namespace GatewayTDD
{
    public class Domain_Entities_Validation_UnitTest
    {
        private readonly Mock<IBaseValidation> _mock;
        public Domain_Entities_Validation_UnitTest()
        {
                _mock = new Mock<IBaseValidation>();
        }

        [Fact]
        public async Task Domain_Validation_Is_Valid_Test_Method()
        {
            //Arange
            Company companies = new Company();
            _mock.Setup(demo => demo.isValid()).ReturnsAsync(await companies.isValid());

            //Acting
            IBaseValidation baseValidation = _mock.Object;
            var actualed_value = baseValidation.isValid();

            //Asserting
            Assert.NotNull(actualed_value);
        }
    }
}