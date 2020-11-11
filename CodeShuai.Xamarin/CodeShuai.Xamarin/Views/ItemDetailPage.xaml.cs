using CodeShuai.Xamarin.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace CodeShuai.Xamarin.Views
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