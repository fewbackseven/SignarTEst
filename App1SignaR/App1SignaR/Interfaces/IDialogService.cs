﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App1SignaR.Interfaces
{
    public interface IDialogService
    {
        Task<bool> DisplayAlert(string title, string message, string accept, string cancel);
        Task DisplayAlert(string title, string message, string cancel);
    }
}
