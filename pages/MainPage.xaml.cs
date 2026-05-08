using Microsoft.Maui.Animations;

namespace best_recipe_tips;

public partial class MainPage : ContentPage
{
	int count = 0;

    ApiService api = new ApiService();

    public MainPage()
	{
		InitializeComponent();
        Refresh();
    }

    public void Refresh()
    {
        MenuBtnname.Text = $"Jídelníček ({GlobalData.ListMenuRecipes.Count()})";
    }

	private async void OnCounterClicked(object sender, EventArgs e)
	{
		Recipes data = api.ZískejRychlýRecept(vyhledavac.Text).Result;

        ListRecipesPage LRP = new ListRecipesPage();
		LRP.SearchBar(vyhledavac.Text, data);
        await Navigation.PushAsync(LRP);
        Refresh();

    }

    private async void AdvancedSearchBtn(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AdvancedSearch());
        Refresh();
    }

    private async void MenuBtn(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MenuPage());
        Refresh();
    }
}

