namespace ToDoApp;

public partial class MainPage : ContentPage
{
	
	/// <summary>
	/// メインウインドウViewmodel
	/// </summary>
	/// <param name="_viewModel">DIコンテナのVMをコンストラクタとして注入</param>
	public MainPage(MainWindowViewModel _viewModel)
	{
		InitializeComponent();
		//BindingContext -> WPFでいうDataContext
		this.BindingContext = _viewModel;

	}
}


