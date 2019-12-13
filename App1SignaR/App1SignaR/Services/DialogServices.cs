﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using App1SignaR.Interfaces;
using System.Threading.Tasks;


namespace App1SignaR.Services
{
    public class DialogServices : IDialogService
    {
        public Task DisplayAlert(string title, string message, string cancel)
        {
            var page = Application.Current.MainPage;
            if (page == null)
                return Task.CompletedTask;

            return page.DisplayAlert(title, message, cancel);
        }

        public Task<bool> DisplayAlert(string title, string message, string accept, string cancel)
        {
            var page = Application.Current.MainPage;
            if (page == null)
                return Task.FromResult(false);

            return page.DisplayAlert(title, message, accept, cancel);
        }
    }
}
