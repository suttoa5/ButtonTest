namespace ButtonTest;

public partial class AddPage : ContentPage
{
	public AddPage(AddPageViewModel vm)
	{
		InitializeComponent();
		BindingContext= vm;
	}
}