using NUnit.Framework;
using Moq;
using AdventureWorkWebApp.Services;
using System.Threading.Tasks;
using AdventureWorkWebApp.Models;

namespace AdventureWorkWebApp.Tests
{
    [TestFixture]
    public class DimServiceTests
    {
        private Mock<IDimAccountService> _moqService;

        [SetUp]
        public void Setup()
        {
            _moqService = new Mock<IDimAccountService>();
        }

        [Test]
        public async Task GetDimCustomerByIdAsync_SomeIntNumber_DimAccountWithSomeIntKey()
        {
            _moqService.Setup(a => a.GetDimCustomerByIdAsync(It.IsAny<int>()))
                .ReturnsAsync((int x) => { return new DimAccount() { AccountKey = x }; });

            int someInt = 10;

            IDimAccountService _dimAccountService = _moqService.Object;

            DimAccount actualDimAccount = await _dimAccountService.GetDimCustomerByIdAsync(someInt);

            Assert.AreEqual(someInt, actualDimAccount.AccountKey);
        }
    }
}