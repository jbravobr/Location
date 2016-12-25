using Prism.Unity;
using Location.APP.Views;
using Syncfusion.SfBarcode.XForms;
using ZXing.Mobile;

namespace Location.APP
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            

            NavigationService.NavigateAsync("MasterPage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<CadastroPage>();
            Container.RegisterTypeForNavigation<LocalizacaoPage>();
            Container.RegisterTypeForNavigation<MenuPage>();
            Container.RegisterTypeForNavigation<MasterPage>();
        }
    }
}
