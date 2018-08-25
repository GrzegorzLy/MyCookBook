﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyCookBook.Services
{
    public sealed class NavigationService
    {
        public static async Task Push(Page page)
        {
            await Application.Current.MainPage.FadeTo(0.0, 200);
            await Application.Current.MainPage.Navigation.PushAsync(page);
            await Application.Current.MainPage.FadeTo(1.0, 500);
        }

        public static async Task Pop()
        {
            await Application.Current.MainPage.FadeTo(0.0, 200);
            await Application.Current.MainPage.Navigation.PopAsync();
            await Application.Current.MainPage.FadeTo(1.0, 500);
        }
    }
}
