using Gateway_Domain.Entities;
using GatewayDomain.Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatewayTDD
{
    public class Domain_Interfaces_UnitTest
    {
        private readonly Mock<ICompanyRepository> _mock;
        public Domain_Interfaces_UnitTest()
        {
                _mock = new Mock<ICompanyRepository>();
        }

        

        [Fact]
        public async Task Domain_Interface_Comapny_AddAsync_Test_Method()
        {


            //Arrange
            var comp = new Company
            {
               CompanyId = 1,
               CompanyArabicName = "A",
               CompanyEnglishName = "B",
               CompanyAddress ="any"
            };
            _mock.Setup(repo => repo.AddAsync(It.IsAny<Company>())).ReturnsAsync(comp);

            //Acting
            ICompanyRepository repository = _mock.Object;
            var actualed_value = repository.AddAsync(comp);

            //Asserting
            Assert.NotNull(actualed_value);
        }
    }
}
