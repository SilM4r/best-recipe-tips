using Microsoft.Maui.Animations;

namespace best_recipe_tips;

public partial class ListRecipesPage : ContentPage
{

    public Recipes data;
    public ListRecipesPage()
	{
		InitializeComponent();
        


    }

    public void ShowRecipes()
    {
        if(data.hits.Count == 0) 
        {
            Label name = new Label();
            name.Text = "Nenašli se žádné recepty";
            name.HorizontalTextAlignment = TextAlignment.Center;
            MainVerticalStackLayout.Children.Add(name);
            return;
        }
        for (int i = 0; i < data.hits.Count(); i++)
        {
            Recipe recipe = data.hits[i].recipe;

            Border border = new Border();
            border.StrokeThickness = 4;
            border.Stroke = new SolidColorBrush(Colors.Black);
            border.Margin = 10;

            var forgetPassword_tap = new TapGestureRecognizer();
            forgetPassword_tap.Tapped += async (s, e) =>
            {
                await Navigation.PushAsync(new DetailRecipe(recipe));
            };

            VerticalStackLayout vs = new VerticalStackLayout();
            vs.GestureRecognizers.Add(forgetPassword_tap); ;


            Image image = new Image();
            image.HeightRequest = 300;
            image.WidthRequest = 300;
            image.Margin = 10;
            image.Source = recipe.images.REGULAR.url;
            vs.Children.Add(image); 

            Label name = new Label();
            name.Text = recipe.label;
            name.HorizontalTextAlignment = TextAlignment.Center;
            name.WidthRequest = 300;
            vs.Children.Add(name);

            HorizontalStackLayout hl = new HorizontalStackLayout();
            hl.Margin = 10;

            Label calorie = new Label();
            calorie.Text = (recipe.calories / recipe.yield).ToString("0.0") + " kcal";
            calorie.HorizontalTextAlignment = TextAlignment.Start;
            calorie.WidthRequest = 200;
            hl.Children.Add(calorie);

            Label poèetIngradiencích = new Label();
            poèetIngradiencích.Text = recipe.ingredientLines.Count().ToString();
            poèetIngradiencích.HorizontalTextAlignment= TextAlignment.End;
            calorie.WidthRequest = 200;
            hl.Children.Add(poèetIngradiencích);

            vs.Children.Add(hl);

            border.Content = vs;
            RecepisFL.Children.Add(border);
        }
    }


    public void SearchBar(string text, Recipes data)
	{
        vyhledavac.Text = text;
        this.data = data;
        ShowRecipes();
    }

    private void CounterBtn_Clicked(object sender, EventArgs e)
    {

    }
}