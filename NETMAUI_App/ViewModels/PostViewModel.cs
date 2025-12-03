using NETMAUI_App.Models;
using NETMAUI_App.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETMAUI_App.ViewModels
{
    public class PostViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Posts> Posts { get; } = new();
        private bool isLoading;
        public bool IsLoading
        {
            get => isLoading;
            set
            {
                isLoading = value;
                OnPropertyChanged(nameof(IsLoading));
            }
        }
        private bool hasError;
        public bool HasError
        {
            get => hasError;
            set
            {
                hasError = value;
                OnPropertyChanged(nameof(HasError));
            }
        }

        private readonly ApiService api = new();

        public async Task LoadPostsAsync()
        {
            try
            {
                IsLoading = true;
                HasError = false;
                OnPropertyChanged(nameof(IsLoading));

                var posts = await api.GetPostsAsync();
                Posts.Clear();

                foreach (var post in posts)
                {
                    Posts.Add(post);
                }
            }
            catch
            {
                HasError = true;
            }
            finally
            {
                IsLoading = false;
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
