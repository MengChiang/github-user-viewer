using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using UserViewer;

namespace ListBox.Example
{
    public class MainWindowViewModel
    {
        public ObservableCollection<ItemViewModel> Items { get; } = new ObservableCollection<ItemViewModel>();

        public MainWindowViewModel()
        {
            var service = new GitHubService();
            var users = service.GetUsers().Result;
            var num = 0;
            if (users != null && users.Count > 0)
            {
                foreach (var user in users)
                {
                    Items.Add(new ItemViewModel(user.Avatar_Url, user.Login, user.Site_Admin, num));
                    num++;
                }
            }
        }
    }
}
