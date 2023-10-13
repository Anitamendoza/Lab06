using Lab06.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Lab06.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}