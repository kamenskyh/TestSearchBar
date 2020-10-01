using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
namespace App1
{
    class CarAddCompany  : INotifyPropertyChanged
    {
        private List<Car> Cars = new List<Car>();

        public List<Car> SearchedCars { get => Cars; set { Cars = value; OnPropertyChanged("SearchedCars"); } }
        public ICommand ChangeMark { protected set; get; }
       INavigation Navigation { get; set; }

        public ICommand SearchBarTextChangedCommand { get; set; }

        private void OnSearchBarTextChanged(object obj)
        {
            if (obj is TextChangedEventArgs args)
            {
                string filter = args.NewTextValue;
                SearchedCars = Cars.Where(x => x.Name.ToLower().Contains(filter.Trim().ToLower())).ToList();
            }
        }
        public CarAddCompany(INavigation navigation)
        {
          

            this.Navigation = navigation;

            SearchBarTextChangedCommand = new Command<object>(OnSearchBarTextChanged);
            Cars = new List<Car>();
            Cars.Add(new Car() { Name = "Ford", CustButtonColor = Color.White });
            Cars.Add(new Car() { Name = "Toyota", CustButtonColor = Color.White });
            Cars.Add(new Car() { Name = "Honda",  CustButtonColor = Color.White });
            Cars.Add(new Car() { Name = "Tesla",  CustButtonColor = Color.White });
            Cars.Add(new Car() { Name = "Chevrolet",  CustButtonColor = Color.White });
            Cars.Add(new Car() { Name = "BMW", CustButtonColor = Color.White });
            Cars.Add(new Car() { Name = "Audi", CustButtonColor = Color.White });
            Cars.Add(new Car() { Name = "Mercedes",CustButtonColor = Color.White });
            Cars.Add(new Car() { Name = "Lexus",  CustButtonColor = Color.White });

        

            
            ChangeMark = new Command<Car>((key) =>
            {

                foreach (var item in Cars)
                {

                    item.CustButtonColor = Color.White;
                }
                    
                    var car = key as Car;
                    car.CustButtonColor = Color.FromHex("#D1DAED");
                   

                
            });
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
