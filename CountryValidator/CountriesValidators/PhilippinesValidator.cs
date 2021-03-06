﻿using System.Text.RegularExpressions;

namespace CountryValidation.Countries
{
    public class PhilippinesValidator : IdValidationAbstract
    {

        public PhilippinesValidator()
        {
            CountryCode = nameof(Country.PH);
        }

        public override ValidationResult ValidateEntity(string id)
        {
            id = id.RemoveSpecialCharacthers().ToUpper();
            if (!Regex.IsMatch(id, @"^\d{12}[VN]?$"))
            {
                return ValidationResult.InvalidFormat("123456789012");
            }
            return ValidationResult.Success();
        }

        public override ValidationResult ValidateIndividualTaxCode(string id)
        {
            id = id.RemoveSpecialCharacthers().ToUpper();
            if (!Regex.IsMatch(id, @"^\d{12}[VN]?$"))
            {
                return ValidationResult.InvalidFormat("1234-5678901-2");
            }
            return ValidationResult.Success();
        }

        public override ValidationResult ValidatePostalCode(string postalCode)
        {
            postalCode = postalCode.RemoveSpecialCharacthers();
            if (!Regex.IsMatch(postalCode, "^\\d{4}$"))
            {
                return ValidationResult.InvalidFormat("NNNN");
            }
            return ValidationResult.Success();
        }

        public override ValidationResult ValidateVAT(string vatId)
        {
            vatId = vatId.RemoveSpecialCharacthers().ToUpper();
            if (!Regex.IsMatch(vatId, @"^\d{12}V$"))
            {
                return ValidationResult.InvalidFormat("123456789012V");
            }

            return ValidationResult.Success();
        }
    }
}
