using MyCookBook.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MyCookBook.ViewModels
{
    public class RecipeViewModel : BaseViewModel
    {
        private Recipe _recipe;
        private string _message;

        public Recipe Recipe
        {
            get { return _recipe; }
            set
            {
                _recipe = value;
                OnPropertyChanged();
            }
        }
        public string Message
        {
            get => _message;
            set
            {
                _message = value;
                OnPropertyChanged();
            }
        }

        public Command SaveRecipe
        {
            get
            {
                return new Command(() =>
                {
                    Message = $"taddamm {Recipe.Name} ===== {Recipe.Description}";
                });
            }
        }
        public RecipeViewModel()
        {

            Recipe = new Recipe() { Name = "Pierogi miesiem", Description = "Domowe pierogi z mięsem " };
            // new Recipe(){Name = "Pierogi ruskie", Description="Domowe pierogi z serem i ziemniakami "}

        }
    }
}
