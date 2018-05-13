﻿using System.ComponentModel.DataAnnotations;
using Stratis.Bitcoin.Features.SmartContracts.Consensus.Rules;
using Stratis.Bitcoin.Utilities.ValidationAttributes;

namespace Stratis.Bitcoin.Features.SmartContracts.Models
{
    public class BuildCallContractTransactionRequest
    {
        public BuildCallContractTransactionRequest()
        {
            this.AccountName = "account 0";
            this.GasPrice = "1";
            this.GasLimit = "10000";
        }

        [Required(ErrorMessage = "The name of the wallet is missing.")]
        public string WalletName { get; set; }

        public string AccountName { get; set; }

        [Required(ErrorMessage = "A destination address is required.")]
        public string ContractAddress { get; set; }

        [Required(ErrorMessage = "A method name is required.")]
        public string MethodName { get; set; }

        [Required(ErrorMessage = "An amount is required.")]
        public string Amount { get; set; }

        [MoneyFormat(isRequired: true, ErrorMessage = "The fee is not in the correct format.")]
        public string FeeAmount { get; set; }

        [Required(ErrorMessage = "A password is required.")]
        public string Password { get; set; }

        [Range(GasBudgetRule.GasPriceMinimum, GasBudgetRule.GasPriceMaximum)]
        public string GasPrice { get; set; }

        [Range(GasBudgetRule.GasLimitMinimum, GasBudgetRule.GasLimitMaximum)]
        public string GasLimit { get; set; }

        [Required(ErrorMessage = "Sender is required.")]
        public string Sender { get; set; }

        public string[] Parameters { get; set; }
    }
}