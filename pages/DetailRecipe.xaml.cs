using Microsoft.Maui.Controls;
using System;
using System.Windows.Input;

namespace best_recipe_tips;

public partial class DetailRecipe : ContentPage
{
    public string url;
    private int pocetPorci;
    private Recipe recipe;
    private bool isInMenuList = false;
    public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(this.url));
    public DetailRecipe(Recipe recipe)
	{

        InitializeComponent();
        BindingContext = this;
        pocetPorci = (int)recipe.yield;
        this.recipe = recipe;
        RecepisDetail();

        foreach (Recipe recipe2 in GlobalData.ListMenuRecipes)
        {
            if (this.recipe.uri == recipe2.uri)
            {
                isInMenuList = true;
                jidelnikBTN.Text = "Odebrat jídlo z jídelníèku";
            }
        }


    }

	private void RecepisDetail()
	{
		nadpisText.Text = recipe.label;
        string tags = string.Empty;

        iconImage.Source = recipe.images.REGULAR.url;

        foreach (string tag in recipe.healthLabels)
        {
            if (tags == string.Empty)
            {
                tags += tag;
            }

            else 
            {
                tags += ", " + tag;
            }
        }
        tagText.Text = tags;
        if (pocetPorci != 0)
        {
            calorieText.Text = ((int)recipe.calories / pocetPorci).ToString() + " kcal";
        }
        else
        {
            calorieText.Text = ((int)recipe.calories).ToString() + " kcal";
        }
        


        string ingredience = string.Empty;

        foreach (string item in recipe.ingredientLines)
        {
            ingredience += "- "+item + Environment.NewLine;
        }

        ingredienceText.Text = ingredience;
        porceText.Text = pocetPorci.ToString();

        url = recipe.url;

        string nutricnihodnoty = "";

        foreach (INutrient item in recipe.totalNutrients.classes)
        {
            nutricnihodnoty += item.label;

            int mezera = 27 - item.label.Length;

            for (int i = 0;i < mezera+1; i++)
            {
                nutricnihodnoty += " ";
            }

            mezera = 10 - ((item.quantity / pocetPorci).ToString("0.0") + item.unit).Length;

            nutricnihodnoty += (item.quantity / pocetPorci).ToString("0.0") + item.unit;

            for (int i = 0; i < mezera + 1; i++)
            {
                nutricnihodnoty += " ";
            }


            // int index = recipe.totalNutrients.classes.FindIndex(a => a.label == item.label);


            foreach (INutrient item2 in recipe.totalDaily.classes)
            {
                if(item2.label == item.label)
                {
                    nutricnihodnoty += (item2.quantity / pocetPorci).ToString("0.0") + item2.unit;
                }
            }

            nutricnihodnoty += Environment.NewLine;
        }

        nutriHodnoty.Text = nutricnihodnoty;
        timeText.Text = "Celkový èas vaøení: " + recipe.totalTime.ToString("0.0") + " minut";
        WeightText.Text = "Celkové množství: " + recipe.totalWeight.ToString("0.0") + "g" + Environment.NewLine;
        WeightText.Text += "Množství na jednu porci: " + (recipe.totalWeight / pocetPorci).ToString("0.0") + "g";
        C2ClassText.Text = "Celkem C02 emisí: " + recipe.totalCO2Emissions.ToString("0.0") + " Tøída: " + recipe.co2EmissionsClass;


    }

    private void Button_PorcePlus(object sender, EventArgs e)
    {
        pocetPorci++;
        RecepisDetail();
    }

    private void Button_PorceMinus(object sender, EventArgs e)
    {
        if(pocetPorci > 1) 
        {
            pocetPorci--;
            RecepisDetail();
        }
    }

    private void Button_Jidelak(object sender, EventArgs e)
    {
        if (isInMenuList)
        {
            recipe.yield = pocetPorci;
            GlobalData.ListMenuRecipes.Remove(recipe);
            jidelnikBTN.Text = "Pøidat jídlo do jídelníèku";
            isInMenuList = false;
        }
        else 
        {
            GlobalData.ListMenuRecipes.Add(recipe);
            jidelnikBTN.Text = "Odebrat jídlo z jídelníèku";
            isInMenuList = true;
        }
    }
}