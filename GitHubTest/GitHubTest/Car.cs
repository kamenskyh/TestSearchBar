using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
namespace App1
{
    public class Car : INotifyPropertyChanged
    {
        public string Name { get; set; }

        Color _custButtonColor;
        public Color CustButtonColor
        {
            set
            {
                if (_custButtonColor != value)
                {
                    _custButtonColor = value;
                    OnPropertyChanged("CustButtonColor");

                }
            }
            get
            {
                return _custButtonColor;
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
