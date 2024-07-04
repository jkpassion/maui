namespace MauiTemplateApp1.ViewModels
{
    public partial class MainViewModel(ISemanticScreenReader screenReader) : BaseViewModel("Home")
    {
        private int _count = 0;

        [ObservableProperty]
        private string _countText = "Current count: 0";

        [RelayCommand]
        private void Increment()
        {
            _count++;
            CountText = $"Current count: {_count}";
            screenReader.Announce(CountText);
        }
    }
}
