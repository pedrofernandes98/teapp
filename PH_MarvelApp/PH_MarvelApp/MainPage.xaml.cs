using PH_MarvelApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PH_MarvelApp
{
    public partial class MainPage : ContentPage
    {
        private MainViewModel ViewModel => BindingContext as MainViewModel; //Define que o Binding de Dados será realizado por essa ViewModel

        public MainPage()
        {
            InitializeComponent();

            this.BindingContext = new MainViewModel();//Ao instânciar esta classe de ViewModel, o sistema reconhece que esta View irá receber Binding da ViewModel instânciada 
        }
    }
}
