using MauiGameLibrary.ViewModels;

namespace MauiGameLibrary.Views;

public partial class ListOfGamesView : ContentPage
{
	public ListOfGamesView(ListOfGamesViewModel vm)
	{
		InitializeComponent();

		BindingContext = vm;

		
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

        ListOfGamesViewModel? vm = BindingContext as ListOfGamesViewModel;

		if (vm != null)
		{

			vm.RefreshGames();
		}
    }

}