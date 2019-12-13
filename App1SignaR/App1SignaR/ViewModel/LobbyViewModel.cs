using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms
using Xamarin.Essentials;
using App1SignaR.View;

namespace App1SignaR.ViewModel
{
    public class LobbyViewModel 
    {
        public List<string> Rooms { get; }
        public LobbyViewModel()
        {
            Rooms = ChatService.GetRooms();
        }

        public string UserName
        {
            get => Settings.UserName;
            set
            {
                if (value == UserName)
                    return;
                Settings.UserName = value;
                OnPropertyChanged();
            }
        }

        public async Task GoToGroupChat(INavigation navigation, string group)
        {
            if (string.IsNullOrWhiteSpace(group))
                return;

            if (string.IsNullOrWhiteSpace(UserName))
                return;

            Settings.Group = group;
            await navigation.PushModalAsync(new XamChatNavigationPage(new GroupChatPage()));
        }

    }
}
