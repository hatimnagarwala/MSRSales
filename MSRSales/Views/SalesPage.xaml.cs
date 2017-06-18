using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MSRSales.Views
{
    public partial class SalesPage : ContentPage
    {
        public SalesPage()
        {
            InitializeComponent();
            PickerItemSetter();



        }

        public void PickerItemSetter (){

            string []Locations = {"SharafDG","Carrfour","Jumbo"};

            var LocationList = new List<string>();

            for (int i = 0; i < Locations.Length;i++)
            {
                LocationList.Add(Locations[i]);
            }

            LocationPicker.ItemsSource = Locations;

        }

    }
}
