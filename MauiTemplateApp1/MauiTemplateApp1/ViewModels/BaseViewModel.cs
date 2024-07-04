namespace MauiTemplateApp1.ViewModels
{
    public partial class BaseViewModel(string title = "") : ObservableObject
    {
        [ObservableProperty]
        private string _title = title;
    }
}
