using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ContadorMaunal.Maui.Models
{
    class Contador : INotifyPropertyChanged
    {
        private int _conteo;
        private int _incremento;

        public event PropertyChangedEventHandler? PropertyChanged;

        public int Conteo
        {
            get => _conteo;
            set
            {
                if (_conteo != value)
                {
                    _conteo = value;
                    OnPropertyChanged(nameof(Conteo));
                }
            }
        }

        public int Incremento
        {
            get => _incremento;
            set
            {
                if(_incremento != value)
                {
                    _incremento = value;
                    OnPropertyChanged(nameof(Incremento));
                }
            }
        }

        public  Contador()
        {
            Conteo = 0;
            Incremento = 1;
        }

        public void Contar()
        {
            Conteo = Conteo + 1;
        }

        public void Reiniciar()
        {
            Conteo = 0;
        }


        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null) 
            {
                PropertyChanged(this, 
                    new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
