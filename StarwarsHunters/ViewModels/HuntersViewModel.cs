using StarwarsHunters.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarwarsHunters.ViewModels
{
    public partial class HuntersViewModel : BaseViewModel
    {
        public ObservableCollection<Hunter> Hunters { get; } = new();
        HunterService hunterService;

        public HuntersViewModel(HunterService hunterService)
        {
            this.hunterService = hunterService;
        }

        [RelayCommand]
        async Task GetHuntersAsync()
        {
            if(IsBusy) 
                return;

            try
            {
                IsBusy = true;
                var hunters = await hunterService.GetHunters();

                if (Hunters.Count != 0)
                    Hunters.Clear();

                foreach (var hunter in hunters)
                    Hunters.Add(hunter);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Unable to get hunters: {ex.Message}");
                await Shell.Current.DisplayAlert("Error!", ex.Message, "OK");
            }
            finally { IsBusy = false; }
        }
    }
}
