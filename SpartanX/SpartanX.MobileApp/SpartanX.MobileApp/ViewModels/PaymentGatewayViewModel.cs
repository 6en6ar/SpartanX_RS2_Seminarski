using Acr.UserDialogs;
using SpartanX.MobileApp.ViewModels;
using SpartanX.MobileApp.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SpartanX.MobileApp.ViewModels
{
    public class PaymentGatewayPageViewModel : BindableBase
    {
        #region Variable

        private ModelSpartanX.CreditCardModel _creditCardModel;
        private TokenService Tokenservice;
        private Token stripeToken;
        private bool _isCarcValid;
        private bool _isTransectionSuccess;
        private string _expMonth;
        private string _expYear;
        private string _title;

        #endregion Variable

        #region Public Property
        private string StripeTestApiKey = "pk_test_51Jpd6SLeLPvznSdYgqnpTOUZ4bJbt2c7M6ooGYWrrsvLd6VSj7uym5Ck7WwLEInYwbIB0tn7kyDOTJHSyn3HVZCz005kDO0Bmt";
        private string StripeSecretApiKey = "sk_test_51Jpd6SLeLPvznSdYpmnKoZbws9XU1d4AGQyz9s9s9NYGLmAIG1xhh9Rr9wd7n0rneHHLF6pFZzy65PnPxdQKaw3D00d7WNohn8";
        public string ExpMonth
        {
            get { return _expMonth; }
            set { SetProperty(ref _expMonth, value); }
        }

        public bool IsCarcValid
        {
            get { return _isCarcValid; }
            set { SetProperty(ref _isCarcValid, value); }
        }

        public bool IsTransectionSuccess
        {
            get { return _isTransectionSuccess; }
            set { SetProperty(ref _isTransectionSuccess, value); }
        }

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public string ExpYear
        {
            get { return _expYear; }
            set { SetProperty(ref _expYear, value); }
        }
        decimal _iznos = 0;
        public decimal Iznos
        {
            get { return _iznos; }
            set { SetProperty(ref _iznos, value); }
        }

        public ModelSpartanX.CreditCardModel CreditCardModel
        {
            get { return _creditCardModel; }
            set { SetProperty(ref _creditCardModel, value); }
        }

        #endregion Public Property

        #region Constructor

        public PaymentGatewayPageViewModel()
        {
            CreditCardModel = new ModelSpartanX.CreditCardModel();
            Title = "Card Details";
        }

        #endregion Constructor

        #region Command

        public DelegateCommand SubmitCommand => new DelegateCommand(async () =>
        {
            CreditCardModel.ExpMonth = Convert.ToInt64(ExpMonth);
            CreditCardModel.ExpYear = Convert.ToInt64(ExpYear);
            CancellationTokenSource tokenSource = new CancellationTokenSource();
            CancellationToken token = tokenSource.Token;
            try
            {
                UserDialogs.Instance.ShowLoading("Payment processing..");
                await Task.Run(async ()  =>
                {

                    var Token = CreateToken();
                    Console.Write("Payment Gateway" + "Token :" + Token);
                    if (Token != null)
                    {
                        IsTransectionSuccess = MakePayment(Token);
                    }
                    else
                    {
                        UserDialogs.Instance.Alert("Bad card credentials", null, "OK");
                    }
                });
            }
            catch (Exception ex)
            {
                UserDialogs.Instance.HideLoading();
                UserDialogs.Instance.Alert(ex.Message, null, "OK");
                Console.Write("Payment Gatway" + ex.Message);

            }

            if (IsTransectionSuccess)
            {
                Console.Write("Payment Gateway" + "Payment Successful ");
                UserDialogs.Instance.Alert("Your payment was successfull", "Payment success", "OK");
                UserDialogs.Instance.HideLoading();

            }
            else
            {

                UserDialogs.Instance.HideLoading();
                UserDialogs.Instance.Alert("Oops, something went wrong", "Payment failed", "OK");
                Console.Write("Payment Gateway" + "Payment Failure ");
            }


        });

        #endregion Command

        #region Method

        private string CreateToken()
        {
            try
            {
                StripeConfiguration.SetApiKey(StripeTestApiKey);
                var service = new ChargeService();
                var Tokenoptions = new TokenCreateOptions
                {
                    
                    Card = new TokenCardOptions
                    {
                        Number = CreditCardModel.Number,
                        ExpYear = CreditCardModel.ExpYear,
                        ExpMonth = CreditCardModel.ExpMonth,
                        Cvc = CreditCardModel.Cvc,
                        Name = GlobalKorisnik.GlobalKorisnik.Prijavljeni.KorisnickoIme,
                        AddressLine1 = "Adresa 1",
                        AddressLine2 = "Adresa 2",
                        AddressCity = "Sarajevo",
                        AddressZip = "71000",
                        AddressState = "SA",
                        AddressCountry = "Bosnia and Herzegovina",
                        Currency = "bam",
                    }
                };

                Tokenservice = new TokenService();
                stripeToken = Tokenservice.Create(Tokenoptions);
                return stripeToken.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool MakePayment(string token)
        {
            try
            {
                StripeConfiguration.SetApiKey(StripeSecretApiKey);
                var options = new ChargeCreateOptions
                {
                    Amount = ((long)Iznos) * 100,
                    Currency = "bam",
                    Description = "Charge for " + GlobalKorisnik.GlobalKorisnik.Prijavljeni.Email,
                    Source = stripeToken.Id,
                    StatementDescriptor = "Custom descriptor",
                    Capture = true,
                    ReceiptEmail = "1337@gmail.com",
                };
                //Make Payment
                var service = new ChargeService();
                Charge charge = service.Create(options);
                return true;
            }
            catch (Exception ex)
            {
                Console.Write("Payment Gateway (CreateCharge)" + ex.Message);
                throw ex;
            }
        }

        private bool ValidateCard()
        {
            if (CreditCardModel.Number.Length == 16 && ExpMonth.Length == 2 && ExpYear.Length == 2 && CreditCardModel.Cvc.Length == 3)
            {
                return true;
            }
            return false;
        }

        #endregion Method
    }
}