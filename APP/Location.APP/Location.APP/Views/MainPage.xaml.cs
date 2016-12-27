using Xamarin.Forms;
using Plugin.Geolocator;
using Xamarin.Forms.GoogleMaps;
using System.Threading.Tasks;

namespace Location.APP.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
			Informacoes().ConfigureAwait(false);
            InitializeComponent();
        }

		protected async Task Informacoes()
		{
			try
			{

				var locator = CrossGeolocator.Current;
				var position = await locator.GetPositionAsync(5000);

				var actualPosition = new Position(position.Latitude, position.Longitude);

				map.MoveToRegion(MapSpan.FromCenterAndRadius(
					actualPosition , Distance.FromMiles(1)));
				var pin = new Pin() 
				{
					Position = actualPosition,
					Label = "",
					Type = PinType.Generic,

				};

				map.Pins.Add(pin);
			}
			catch (System.Exception ex)
			{
				throw ex;
			}
		}
    }
}
