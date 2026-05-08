using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace best_recipe_tips
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class CA: INutrient
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class CHOCDF: INutrient
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class CHOCDFNet : INutrient
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class CHOLE: INutrient
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class Digest
    {
        public string label { get; set; }
        public string tag { get; set; }
        public string schemaOrgTag { get; set; }
        public double total { get; set; }
        public bool hasRDI { get; set; }
        public double daily { get; set; }
        public string unit { get; set; }
        public List<Sub> sub { get; set; }
    }

    public class ENERCKCAL : INutrient
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class FAMS : INutrient
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class FAPU : INutrient
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class FASAT : INutrient
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class FAT : INutrient
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class FATRN : INutrient
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class FE : INutrient
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class FIBTG : INutrient
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class FOLAC : INutrient
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class FOLDFE : INutrient
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class FOLFD : INutrient
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class Hit
    {
        public Recipe recipe { get; set; }
        public Links _links { get; set; }
    }

    public class Images
    {
        public THUMBNAIL THUMBNAIL { get; set; }
        public SMALL SMALL { get; set; }
        public REGULAR REGULAR { get; set; }
        public LARGE LARGE { get; set; }
    }

    public class Ingredient
    {
        public string text { get; set; }
        public double quantity { get; set; }
        public string measure { get; set; }
        public string food { get; set; }
        public double weight { get; set; }
        public string foodCategory { get; set; }
        public string foodId { get; set; }
        public string image { get; set; }
    }

    public class K : INutrient
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class LARGE
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Links
    {
        public Next next { get; set; }
        public Self self { get; set; }
    }

    public class MG : INutrient
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class NA : INutrient
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class Next
    {
        public string href { get; set; }
        public string title { get; set; }
    }

    public class NIA : INutrient
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class P : INutrient
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class PROCNT : INutrient
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class Recipe
    {
        public string uri { get; set; }
        public string label { get; set; }
        public string image { get; set; }
        public Images images { get; set; }
        public string source { get; set; }
        public string url { get; set; }
        public string shareAs { get; set; }
        public float yield { get; set; }
        public List<string> dietLabels { get; set; }
        public List<string> healthLabels { get; set; }
        public List<string> cautions { get; set; }
        public List<string> ingredientLines { get; set; }
        public List<Ingredient> ingredients { get; set; }
        public double calories { get; set; }
        public double totalCO2Emissions { get; set; }
        public string co2EmissionsClass { get; set; }
        public double totalWeight { get; set; }
        public float totalTime { get; set; }
        public List<string> cuisineType { get; set; }
        public List<string> mealType { get; set; }
        public List<string> dishType { get; set; }
        public TotalNutrients totalNutrients { get; set; }
        public TotalDaily totalDaily { get; set; }
        public List<Digest> digest { get; set; }
        public List<string> tags { get; set; }
    }

    public class REGULAR
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class RIBF : INutrient
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class Recipes
    {
        public int from { get; set; }
        public int to { get; set; }
        public int count { get; set; }
        public Links _links { get; set; }
        public List<Hit> hits { get; set; }
    }

    public class Self
    {
        public string href { get; set; }
        public string title { get; set; }
    }

    public class SMALL
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Sub
    {
        public string label { get; set; }
        public string tag { get; set; }
        public string schemaOrgTag { get; set; }
        public double total { get; set; }
        public bool hasRDI { get; set; }
        public double daily { get; set; }
        public string unit { get; set; }
    }

    public class SUGAR : INutrient
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class SUGARAdded : INutrient
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class THIA : INutrient
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class THUMBNAIL
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class TOCPHA : INutrient
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class TotalDaily
    {
        public List<INutrient> classes = new List<INutrient>();

        public ENERCKCAL ENERC_KCAL { get; set; }
        public FAT FAT
        {
            get { return null; }
            set
            {

                classes.Add(value);
            }
        }
        public FASAT FASAT
        {
            get { return null; }
            set
            {

                classes.Add(value);
            }
        }
        public CHOCDF CHOCDF
        {
            get { return null; }
            set
            {

                classes.Add(value);
            }
        }
        public FIBTG FIBTG
        {
            get { return null; }
            set
            {

                classes.Add(value);
            }
        }
        public PROCNT PROCNT
        {
            get { return null; }
            set
            {

                classes.Add(value);
            }
        }
        public CHOLE CHOLE
        {
            get { return null; }
            set
            {

                classes.Add(value);
            }
        }
        public NA NA
        {
            get { return null; }
            set
            {

                classes.Add(value);
            }
        }
        public CA CA
        {
            get { return null; }
            set
            {

                classes.Add(value);
            }
        }
        public MG MG
        {
            get { return null; }
            set
            {

                classes.Add(value);
            }
        }
        public K K
        {
            get { return null; }
            set
            {

                classes.Add(value);
            }
        }
        public FE FE
        {
            get { return null; }
            set
            {

                classes.Add(value);
            }
        }
        public ZN ZN
        {
            get { return null; }
            set
            {

                classes.Add(value);
            }
        }
        public P P
        {
            get { return null; }
            set
            {

                classes.Add(value);
            }
        }
        public VITARAE VITA_RAE
        {
            get { return null; }
            set
            {

                classes.Add(value);
            }
        }
        public VITC VITC
        {
            get { return null; }
            set
            {

                classes.Add(value);
            }
        }
        public THIA THIA
        {
            get { return null; }
            set
            {

                classes.Add(value);
            }
        }
        public RIBF RIBF
        {
            get { return null; }
            set
            {

                classes.Add(value);
            }
        }
        public NIA NIA
        {
            get { return null; }
            set
            {

                classes.Add(value);
            }
        }
        public VITB6A VITB6A
        {
            get { return null; }
            set
            {

                classes.Add(value);
            }
        }
        public FOLDFE FOLDFE
        {
            get { return null; }
            set
            {

                classes.Add(value);
            }
        }
        public VITB12 VITB12
        {
            get { return null; }
            set
            {

                classes.Add(value);
            }
        }
        public VITD VITD
        {
            get { return null; }
            set
            {

                classes.Add(value);
            }
        }
        public TOCPHA TOCPHA
        {
            get { return null; }
            set
            {

                classes.Add(value);
            }
        }
        public VITK1 VITK1
        {
            get { return null; }
            set
            {

                classes.Add(value);
            }
        }

    }

    public class TotalNutrients
    {
        public List<INutrient> classes = new List<INutrient>();

        public ENERCKCAL ENERC_KCAL
        {
            get; set;
        }
        public FAT FAT
        {
            get { return null; }
            set
            {

                classes.Add(value);
            }
        }
        public FASAT FASAT
        {
            get { return null; }
            set
            {

                classes.Add(value);
            }
        }
        public FATRN FATRN          
        {
            get { return null; }
            set
            {

                classes.Add(value);
            }
        }
        public FAMS FAMS            
        {
            get { return null; }
            set
            {

                classes.Add(value);
            }
        }
        public FAPU FAPU            
        {
            get { return null; }
            set
            {

                classes.Add(value);
            }
        }
        public CHOCDF CHOCDF        
        {
            get { return null; }
            set
            {

                classes.Add(value);
            }
        }
        public CHOCDFNet CHOCDFnet  
        {
            get { return null; }
            set
            {

                classes.Add(value);
            }
        }
        public FIBTG FIBTG          
        {
            get { return null; }
            set
            {

                classes.Add(value);
            }
        }
        public SUGAR SUGAR          
        {
            get { return null; }
            set
            {

                classes.Add(value);
            }
        }
        public PROCNT PROCNT        
        {
            get { return null; }
            set
            {

                classes.Add(value);
            }
        }
        public CHOLE CHOLE          
        {
            get { return null; }
            set
            {

                classes.Add(value);
            }
        }
        public NA NA                
        {
            get { return null; }
            set
            {

                classes.Add(value);
            }
        }
        public CA CA                
        {
            get { return null; }
            set
            {

                classes.Add(value);
            }
        }
        public MG MG                
        {
            get { return null; }
            set
            {

                classes.Add(value);
            }
        }
        public K K                  
        {
            get { return null; }
            set
            {

                classes.Add(value);
            }
        }
        public FE FE                
        {
            get { return null; }
            set
            {

                classes.Add(value);
            }
        }
        public ZN ZN                
        {
            get { return null; }
            set
            {

                classes.Add(value);
            }
        }
        public P P                  
        {
            get { return null; }
            set
            {

                classes.Add(value);
            }
        }
        public VITARAE VITA_RAE     
        {
            get { return null; }
            set
            {

                classes.Add(value);
            }
        }
        public VITC VITC            
        {
            get { return null; }
            set
            {

                classes.Add(value);
            }
        }
        public THIA THIA            
        {
            get { return null; }
            set
            {

                classes.Add(value);
            }
        }
        public RIBF RIBF            
        {
            get { return null; }
            set
            {

                classes.Add(value);
            }
        }
        public NIA NIA              
        {
            get { return null; }
            set
            {

                classes.Add(value);
            }
        }
        public VITB6A VITB6A        
        {
            get { return null; }
            set
            {

                classes.Add(value);
            }
        }
        public FOLDFE FOLDFE        
        {
            get { return null; }
            set
            {

                classes.Add(value);
            }
        }
        public FOLFD FOLFD          
        {
            get { return null; }
            set
            {

                classes.Add(value);
            }
        }
        public FOLAC FOLAC          
        {
            get { return null; }
            set
            {

                classes.Add(value);
            }
        }
        public VITB12 VITB12        
        {
            get { return null; }
            set
            {

                classes.Add(value);
            }
        }
        public VITD VITD            
        {
            get { return null; }
            set
            {

                classes.Add(value);
            }
        }
        public TOCPHA TOCPHA        
        {
            get { return null; }
            set
            {

                classes.Add(value);
            }
        }
        public VITK1 VITK1          
        {
            get { return null; }
            set
            {

                classes.Add(value);
            }
        }
        public WATER WATER
        {
            get { return null; }
            set
            {

                classes.Add(value);
            }
        }
        public SUGARAdded SUGARadded
        {
            get { return null; }
            set
            {

                classes.Add(value);
            }
        }
    }

    public class VITARAE : INutrient
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class VITB12 : INutrient
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class VITB6A : INutrient
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class VITC : INutrient
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class VITD : INutrient
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class VITK1 : INutrient
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class WATER : INutrient
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public class ZN : INutrient
    {
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }

    public interface INutrient
    {
        // Property signatures:
        public string label { get; set; }
        public double quantity { get; set; }
        public string unit { get; set; }
    }



}
