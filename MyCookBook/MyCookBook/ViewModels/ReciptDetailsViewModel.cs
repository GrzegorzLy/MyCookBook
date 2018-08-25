using MyCookBook.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MyCookBook.ViewModels
{
    public class RecipeDetailsViewModel :BaseViewModel
    {
        private Recipe recipe;
        public Recipe Recipe
        {
            get => recipe;
            set
            {
                recipe = value;
                OnPropertyChanged();
            }
        }
        private List<Igredient> igredients;
        public List<Igredient> Igredients
        {
            get { return igredients; }
            set
            {
                if (igredients != value)
                {
                    igredients = value;
                    OnPropertyChanged();
                };
            }
        }
        public RecipeDetailsViewModel(Recipe recipe)
        {
            this.recipe = recipe;
            Igredients = new List<Igredient>
            {
                new Igredient(){ Name = "Maka", Quantity= 200, Unit = "dg"},
                new Igredient(){ Name = "Jajko", Quantity= 2, Unit = "szt"},
                new Igredient(){ Name = "Mieso mielone", Quantity= 500, Unit = "dg"},
                };

            //dodac lisatview
        }
    }
}
