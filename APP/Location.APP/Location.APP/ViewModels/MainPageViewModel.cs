
using Prism.Mvvm;
using Prism.Navigation;
using PropertyChanged;
using Xamarin.Forms;

namespace Location.APP.ViewModels
{
    [ImplementPropertyChanged]
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        public string Valor { get; set; }

        public MainPageViewModel()
        {

        }

        //public Command Scanear
        //{
        //    get
        //    {
        //        return new Command(async () =>
        //        {
        //            try
        //            {                        

        //                var scanner = new ZXing.Mobile.MobileBarcodeScanner();

        //                var result = await scanner.Scan();
        //                if (result!=null)             
        //                    Valor = result.Text;
             
        //            }
        //            catch (System.Exception ex)
        //            {
        //                throw ex;
        //            }
        //        });
        //    }
        //}

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("title"))
                Title = (string)parameters["title"] + " and Prism";
        }
    }
}
