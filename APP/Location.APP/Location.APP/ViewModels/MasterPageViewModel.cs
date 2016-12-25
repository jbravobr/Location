using Prism.Mvvm;
using Prism.Navigation;
using PropertyChanged;
using System;

namespace Location.APP.ViewModels
{
    [ImplementPropertyChanged]
    public class MasterPageViewModel : BindableBase, INavigationAware
    {
        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            throw new NotImplementedException();
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            throw new NotImplementedException();
        }
    }
}
