using MyCookBook.Models;
using MyCookBook.Services;
using MyCookBook.Views;
using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyCookBook.ViewModels
{
    public class RecipeViewModel : BaseViewModel
    {

        private List<Recipe> recipes;
        public List<Recipe> Recipes
        {
            get
            {
                return recipes;
            }
            set
            {
                if (recipes != value)
                {
                    recipes = value;
                    OnPropertyChanged();
                };
            }
        }


        public DelegateCommand<Recipe> RecipeSelectedCommand { get; }
       
        public RecipeViewModel()
        {
            LoadRecipt();         
            RecipeSelectedCommand = new DelegateCommand<Recipe>(RecipeSelected);
        }

        private async void RecipeSelected(Recipe recipe)
        {
            var parameters = new NavigationParameters
            {
                { "recipe", recipe }
            };

            await NavigationService.Push(new ReciptPage(recipe));
        }

        private async void LoadRecipt()
        {
           Recipes = await App.LocalDB.GetItems<Recipe>();           
        }

    }
    
}
