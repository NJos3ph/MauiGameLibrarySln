using MauiGameLibrary.ViewModels;

namespace MauiGameLibrary.Views;

public partial class UpdateGameView : BasePage
{
	public UpdateGameView(UpdateGameViewModel vm)
	{
		InitializeComponent();

		BindingContext =vm;
	}

  //  protected override void OnAppearing()
  //  {
  //      base.OnAppearing();




		//BaseViewModel vm = BindingContext as BaseViewModel;

		//if (vm != null)
		//{

		//	vm.OnAppearing();

		//}	
  //  }
}