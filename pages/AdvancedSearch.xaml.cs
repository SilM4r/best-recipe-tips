namespace best_recipe_tips;

public partial class AdvancedSearch : ContentPage
{
    ApiService api = new ApiService();
    public AdvancedSearch()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        //&ingr=10&diet=high-protein&health=alcohol-free&cuisineType=British&mealType=Dinner&dishType=Side%20dish&calories=1-800&time=360&co2EmissionsClass=B

        string parametry = "";

        if (!String.IsNullOrEmpty(ingrText.Text))
        {
            parametry += "&ingr=" + ingrText.Text;
        }

        if (pickerDiet.SelectedIndex != 0)
        {
            parametry += "&diet=" + pickerDiet.SelectedItem;
        }
        
        if (!String.IsNullOrEmpty(healtText.Text))
        {
            string[] listText = healtText.Text.Split(",");

            for (int i = 0; i < listText.Length; i++) 
            {
                parametry += "&health=" + listText[i];
            }
        }

        if (pickerNation.SelectedIndex != 0)
        {
            parametry += "&cuisineType=" + pickerNation.SelectedItem;
        }

        if (pickerMealType.SelectedIndex != 0)
        {
            parametry += "&mealType=" + pickerMealType.SelectedItem;
        }

        if (pickerdish.SelectedIndex != 0)
        {
            parametry += "&dishType=" + pickerdish.SelectedItem;
        }

        if (!String.IsNullOrEmpty(CalorieText.Text))
        {
            parametry += "&calories=" + CalorieText.Text;
        }

        if (!String.IsNullOrEmpty(TimeText.Text))
        {
            parametry += "&time=" + TimeText.Text;
        }

        if (pickerCO2.SelectedIndex != 0)
        {

            parametry += "&co2EmissionsClass=" + pickerCO2.SelectedItem;
        }

        parametry = parametry.Replace("+", "%2B");

        Recipes data = api.AdvancedSearch(parametry).Result;

        if (data == null) 
        {
            await DisplayAlert("Upozornìní", "Zadali jste neplatné hodnoty! Api vrátilo statusCode 400", "OK");
            return;
        }

        ListRecipesPage LRP = new ListRecipesPage();
        LRP.SearchBar(parametry, data);
        await Navigation.PushAsync(LRP);
    }
}