﻿using CountryValidation.Countries;
using Xunit;

namespace CountryValidation.Tests
{
    public class CroatiaValidatorTests
    {
        private readonly CroatiaValidator _croatiaValidator;

        public CroatiaValidatorTests()
        {
            _croatiaValidator = new CroatiaValidator();
        }

        [Theory]
        [InlineData("33392005961", true)]
        [InlineData("33392005962", false)]
        public void TestNationalId(string code, bool isValid)
        {
            Assert.Equal(isValid, _croatiaValidator.ValidateNationalIdentity(code).IsValid);
        }

        [Theory]
        [InlineData("33392005961", true)]
        [InlineData("33392005962", false)]
        public void TestIndividualCode(string code, bool isValid)
        {
            Assert.Equal(isValid, _croatiaValidator.ValidateIndividualTaxCode(code).IsValid);
        }

        [Theory]
        [InlineData("33392005961", true)]
        [InlineData("33392005962", false)]
        public void TestCorrectEntityCode(string code, bool isValid)
        {
            Assert.Equal(isValid, _croatiaValidator.ValidateEntity(code).IsValid);
        }

        [Theory]
        [InlineData("33392005961", true)]
        [InlineData("33392005962", false)]
        public void TestCorrectVatCode(string code, bool isValid)
        {
            Assert.Equal(isValid, _croatiaValidator.ValidateVAT(code).IsValid);
        }

        [Theory]
        [InlineData("21001 ", true)]
        [InlineData("10002", true)]
        [InlineData("23", false)]
        public void TestPostalCode(string code, bool isValid)
        {
            Assert.Equal(isValid, _croatiaValidator.ValidatePostalCode(code).IsValid);
        }
    }
}
