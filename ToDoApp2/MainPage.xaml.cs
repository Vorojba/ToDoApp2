using ToDoApp2.ViewModel;
namespace ToDoApp2;

public partial class MainPage : ContentPage
{


	public MainPage()
	{
		InitializeComponent();
        BindingContext = new CountryViewModel();
    }
}

