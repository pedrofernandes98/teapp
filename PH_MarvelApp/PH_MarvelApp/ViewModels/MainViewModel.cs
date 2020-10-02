using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PH_MarvelApp.ViewModels
{
    class MainViewModel : INotifyPropertyChanged //Interface responsável por comunicar à View de que alguma propriedade da sua ViewModel foi alterada
    {

        public event PropertyChangedEventHandler PropertyChanged;//Evento lançado a cada alteração de propriedade na ViewModel

        public string Titulo { get; set; }

        public MainViewModel()
        {
            Titulo = "Página Inicial";
        }

        
        
    }
}
