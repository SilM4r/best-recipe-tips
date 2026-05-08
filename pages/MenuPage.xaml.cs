using System.Diagnostics.Metrics;

namespace best_recipe_tips;

public partial class MenuPage : ContentPage
{
    public Recipe recipe;

	public MenuPage()
	{
		InitializeComponent();
		MenuRecipeList();
        ListNutrieValume();

    }


    private void ListNutrieValume()
    {
        List<string> listName = new List<string>();
        List<double> listValue = new List<double>();
        List<string> listValueName = new List<string>();




        if (GlobalData.ListMenuRecipes.Count() == 0) 
        {
            return;  
        }

        bool isFull = false;
        string ingredience = string.Empty;

        foreach (Recipe recipe in GlobalData.ListMenuRecipes)
        {
            for (int i = 0; i < recipe.totalNutrients.classes.Count(); i++)
            {
                INutrient item = recipe.totalNutrients.classes[i];

                if (!isFull)
                {
                    listValue.Add(item.quantity / recipe.yield);
                    listName.Add(item.label);
                    listValueName.Add(item.unit);
                }

                else 
                {
                    listValue[i] += (item.quantity / recipe.yield);
                }
            }

            isFull = true;

            foreach (string item in recipe.ingredientLines)
            {
                ingredience += "- " + item + Environment.NewLine;
            }

            
        }
        ingredienceText.Text = ingredience;
        string nutricnihodnoty = "";


        for (int i = 0; i < listValue.Count(); i++)
        {
            nutricnihodnoty += listName[i];

            int mezera = 27 - listName[i].Length;

            for (int i2 = 0; i2 < mezera + 1; i2++)
            {
                nutricnihodnoty += " ";
            }

            mezera = 10 - (listValue[i].ToString("0.0") + listValueName[i]).Length;

            nutricnihodnoty += listValue[i].ToString("0.0") + listValueName[i];

            for (int i3 = 0; i3 < mezera + 1; i3++)
            {
                nutricnihodnoty += " ";
            }

            nutricnihodnoty += Environment.NewLine;
        }

        nutriHodnoty.Text = nutricnihodnoty;
    }

	private void MenuRecipeList()
	{
        if (GlobalData.ListMenuRecipes.Count() == 0)
        {
            recipe = null;
            ListRecipeLayout.Children.Clear();
            return;
        }

        ListRecipeLayout.Children.Clear();

        for (int i = 0; i < GlobalData.ListMenuRecipes.Count(); i++) 
		{
            recipe = GlobalData.ListMenuRecipes[i];

            HorizontalStackLayout hsl = new HorizontalStackLayout();
            hsl.Margin = 10;

            Image image = new Image();
            image.HeightRequest = 200;
            image.WidthRequest = 200;
            image.Margin = 10;
            image.Source = recipe.images.SMALL.url;
            hsl.Children.Add(image);

            VerticalStackLayout vsl = new VerticalStackLayout();


            Label name = new Label();
            name.Text = recipe.label;
            name.FontSize = 20;
            name.HorizontalTextAlignment = TextAlignment.Center;
            name.WidthRequest = 300;
            vsl.Children.Add(name);


            Button button = new Button();
            button.Text = "odebrat";
            button.StyleId = recipe.label + "delete";
            button.Clicked += DeleteBtn;
            vsl.Children.Add(button);

            Button button2 = new Button();
            button2.Text = "detail";
            button2.StyleId = recipe.label + "detail";
            button2.Clicked += DetailBtn;
            vsl.Children.Add(button2);

            hsl.Children.Add(vsl);


            ListRecipeLayout.Children.Add(hsl);
        }
	}
    


    private Recipe isInGlobalDataListMenuRecipes(string recipeName, string suffix)
    {
        foreach (Recipe item in GlobalData.ListMenuRecipes)
        {
            if (item.label + suffix == recipeName)
            {
                return item;
            }
        }
        return null;
    }

    private async void DetailBtn(object sender, EventArgs e)
    {
        string recipeName = (sender as Button).StyleId;

        Recipe recipe = isInGlobalDataListMenuRecipes(recipeName, "detail");

        if (recipe != null)
        {
            await Navigation.PushAsync(new DetailRecipe(recipe));
        }
        MenuRecipeList();
        ListNutrieValume();
    }

    private void DeleteBtn(object sender, EventArgs e)
    {
        string recipeName = (sender as Button).StyleId;

        Recipe recipe = isInGlobalDataListMenuRecipes(recipeName, "delete");

        if (recipe != null)
        {
            GlobalData.ListMenuRecipes.Remove(recipe);
        }
        MenuRecipeList();
        ListNutrieValume();
    }
}