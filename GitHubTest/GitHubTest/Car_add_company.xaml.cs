
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
   
    public partial class Car_add_company : ContentPage
    {
       // public List<Car> Cars { get; set; }
        public Car_add_company()
        {
           
            InitializeComponent();
            BindingContext = new CarAddCompany(Navigation);
   

        }
 
   
    }
  
}