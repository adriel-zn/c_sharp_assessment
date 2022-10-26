using Acccount_Ledger.Data.Models;
using Account_Ledger.Api.Controllers;
using Account_Ledger.Infrastruture.Repository;

namespace Account_Ledger.Test
{
    public class AccountRepositoryTest
    {
        private readonly AccountsRepository _repo;

        [Fact]
        public void Test_GetAccountStatements()
        {
            // Act
            var result = _repo.GetAccountStatements(3);
            //Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void Test_AddAccount()
        {
            // Act
            var account = new Account()
            {
                Id = 1,
                AccountName = "Stock",
                AccountNumber = "1233333",
                AccountTypeId = 1
            };

            //Arrange
            var result = _repo.AddAccount(account);

            //Assert
            Assert.NotNull(result);
        }


        [Fact]
        public void Test_DebitAccount()
        {
            // Act
            var account = new Account()
            {
                Id = 1,
                AccountName = "Stock",
                AccountNumber = "1233333",
                AccountTypeId = 1
            };
            //Arrange
            var result = _repo.DebitAccount(account);
            //Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void Test_CreditAccount()
        {
            // Act
            var account = new Account()
            {
                Id = 1,
                AccountName = "Stock",
                AccountNumber = "1233333",
                AccountTypeId = 2
            };
            //Arrange
            var result = _repo.CreditAccount(account);
            //Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void Test_RemoveAccount()
        {
            // Act
            var account = new Account()
            {
                Id = 1,
                AccountName = "Stock",
                AccountNumber = "1233333",
                AccountTypeId = 2
            };
            //Arrange
            var result = _repo.RemoveAccount(account);
            //Assert
            Assert.NotNull(result);
        }
    }
}