using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stripe.Console
{
    class Program
    {
        static void Main(string[] args)
        {

            StripeConfiguration.SetApiKey("sk_test_xi0dPfNUZaxDKi1pVfodZ9rR");

            // Create Customer Account------------------------------------------>>

            /*
             var myCustomer = new StripeCustomerCreateOptions();
             myCustomer.Email = "pork@email.com";
             myCustomer.Description = "Johnny Tenderloin (pork@email.com)";
            
             //myCustomer.SourceToken = *token*;
             //myCustomer.PlanId = *planId*;                          // only if you have a plan
             //myCustomer.TaxPercent = 20;                            // only if you are passing a plan, this tax percent will be added to the price.
             //myCustomer.CouponId = *couponId*;                        // only if you have a coupon
             //myCustomer.TrialEnd = DateTime.UtcNow.AddMonths(12);    // when the customers trial ends (overrides the plan if applicable)
             //myCustomer.Quantity = 1;                               // optional, defaults to 1
           
             var customerService = new StripeCustomerService();
             StripeCustomer stripeCustomer = customerService.Create(myCustomer);
 
             */

            // Create Customer Account------------------------------------------>>

            // Get All Customer Account------------------------------------------>>

            /*
            var customerService = new StripeCustomerService();
            IEnumerable<StripeCustomer> response = customerService.List(); 
            string acc ="";
            foreach (var c in response)
            {
                acc = c.Id;
            }
            */
            // Get All Customer Account------------------------------------------>>


            string CustomerID = "cus_8okXH7CccdwXhj";

            //  Create payment with TOCKEN based ----------------------------------------->>

            /*var myToken = new StripeTokenCreateOptions
            {
                Card = new StripeCreditCardOptions
                {
                    Number = "4242424242424242",
                    ExpirationYear = "2022",
                    ExpirationMonth = "10",
                    AddressCountry = "US",                // optional
                    AddressLine1 = "24 Beef Flank St",    // optional
                    AddressLine2 = "Apt 24",              // optional
                    AddressCity = "Biggie Smalls",        // optional
                    AddressState = "NC",                  // optional
                    AddressZip = "27617",                 // optional
                    Name = "Joe Meatballs",               // optional
                    Cvc = "122"                          // optional
                }
            };
            var tokenService = new StripeTokenService();
            var stripeToken = tokenService.Create(myToken);
            string id = stripeToken.Id;
            var myCharge = new StripeChargeCreateOptions
            {
                Amount = (50 * 100),
                Currency = "USD",
                Description = "Charge for property sign and postage",
                SourceTokenOrExistingSourceId = id,
                ApplicationFee = 250
            };

            var chargeService = new StripeChargeService();
            var stripeCharge = chargeService.Create(myCharge);
            var ss = stripeCharge.Id;
            */

            //  Create payment with TOCKEN based ----------------------------------------->>

            //  Create payment with out TOCKEN  ----------------------------------------->>

            /*
            // setting up the card
            var myCharge = new StripeChargeCreateOptions();
            // always set these properties
            myCharge.Amount = 51530;
            myCharge.Currency = "USD";
            myCharge.Description = "Charge it like it's hot";
            myCharge.SourceCard = new SourceCard()
            {
                Number = "4242424242424242",
                ExpirationYear = "2022",
                ExpirationMonth = "10",
                AddressCountry = "US",                // optional
                AddressLine1 = "24 Beef Flank St",    // optional
                AddressLine2 = "Apt 24",              // optional
                AddressCity = "Biggie Smalls",        // optional
                AddressState = "NC",                  // optional
                AddressZip = "27617",                 // optional
                Name = "Joe Meatballs",               // optional
                Cvc = "122"                          // optional
            };

            myCharge.Capture = true;
            myCharge.ApplicationFee = 250;
            var chargeService = new StripeChargeService();

            StripeCharge stripeCharge = chargeService.Create(myCharge);
            var ss = stripeCharge.Id;
            */

            //  Create payment with out TOCKEN  ----------------------------------------->>



            // For create connected account ------------------------------------------>>
            /*

            var dd = new StripeAccountCreateOptions
            {
                BusinessName = "My Company 3",
                BusinessUrl = "www.mycompany3.com",
                Country = "US",
                DefaultCurrency = "usd",
                Email = "mohankumar1@gmail.com",
                Managed = true,
                LegalEntity = new StripeAccountLegalEntityOptions
                {
                    AddressCity = "NY",
                    AddressLine1 = "Address 1",
                    AddressLine2 = "Address 2",
                    AddressState = "NY",
                    FirstName = "Mohan",
                    LastName = "Kumar",
                    Type = "individual",
                    BirthDay = "01",
                    BirthMonth = "01",
                    BirthYear = "1980",
                    AddressPostalCode ="10005",
                    SSNLast4 = "1111",
                    PersonalIdNumber = "111111111"                        
                },
                ExternalCardAccount = new StripeAccountCardOptions
                {
                    Number = "4000056655665556",
                    ExpirationYear = "2022",
                    ExpirationMonth = "10",
                    Currency = "usd",
                    AddressCountry = "US",                // optional
                    AddressLine1 = "24 Beef Flank St",    // optional
                    AddressLine2 = "Apt 24",              // optional
                    AddressCity = "Biggie Smalls",        // optional
                    AddressState = "NC",                  // optional
                    AddressZip = "27617",                 // optional
                    Name = "Mohan Kumar",               // optional
                    Cvc = "122"                          // optional
                },
                TosAcceptanceDate = DateTime.Now.Date,
                TosAcceptanceIp = "192.168.1.1"
            };

            var ancc = new StripeAccountService().Create(dd);
            
            */
            

            var AccoutnID = "acct_18XAQcBNjgnmKTbi";
            var AccountKeySK = "sk_test_617JoBWYxIWbMLebPBoCZ0ZZ";
            var AccountKeyPK = "pk_test_odUaefapZKPVBVfc2kOhsKib";


            // For create connected account ------------------------------------------>>



            // Get  connected account details------------------------------------------>>
            /*
                var ancc = new StripeAccountService().Get("acct_18X9q8FIcEp34AGS");
                var AccoutnID = ancc.Id;
             */
            // Get  connected account details------------------------------------------>>



            var myToken = new StripeTokenCreateOptions
            {
                Card = new StripeCreditCardOptions
                {
                    Number = "4242424242424242",
                    ExpirationYear = "2022",
                    ExpirationMonth = "10",
                    AddressCountry = "US",                // optional
                    AddressLine1 = "24 Beef Flank St",    // optional
                    AddressLine2 = "Apt 24",              // optional
                    AddressCity = "Biggie Smalls",        // optional
                    AddressState = "NC",                  // optional
                    AddressZip = "27617",                 // optional
                    Name = "Joe Meatballs",               // optional
                    Cvc = "122"                          // optional
                }
            };
            var tokenService = new StripeTokenService();
            var stripeToken = tokenService.Create(myToken);
            string id = stripeToken.Id;
            var myCharge = new StripeChargeCreateOptions
            {
                Amount = (500 * 100),
                Currency = "USD",
                Description = "Charge for property sign and postage",
                SourceTokenOrExistingSourceId = id,
                ApplicationFee = 250
            };

            var chargeService = new StripeChargeService();
            var stripeCharge = chargeService.Create(myCharge,
                 new StripeRequestOptions
                 {
                     ApiKey = AccountKeySK,
                     StripeConnectAccountId = AccoutnID,
                 });
            var ss = stripeCharge.Id;


            /*

            var aa = new StripeCustomerService().GetAsync(CustomerID);

            var myBankAccount = new BankAccountCreateOptions
            {
                SourceBankAccount = new SourceBankAccount()
                {
                    AccountNumber = "000123456789",
                    Country = "US",
                    Currency = "usd",
                    AccountHolderName = "Frank",
                    AccountHolderType = BankAccountHolderType.Company,
                    RoutingNumber = "091000019"
                }
            };

            var bankAccountService = new BankAccountService();
            CustomerBankAccount bankAccount = bankAccountService.Create(CustomerID, myBankAccount);


            */




        }
    }
}
