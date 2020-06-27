﻿using Caliburn.Micro;
using FlightTicketManagement.Helper;

using Library.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace FlightTicketManagement.ViewModels
{
    class FlightListViewModel : Screen
    {
        public FlightListViewModel()
        {

        }
        protected override async void OnViewLoaded(object view)
        {
            base.OnViewLoaded(view);
            await LoadFlights();
            await LoadCity();
        }
        private async Task LoadFlights()
        {
            Response <List<FlightModel>> response = await APIHelper<Response<List<FlightModel>>>.Instance.Get(ApiRoutes.Flight.GetAll);
            if (response.IsSuccess)
            {
                var list = response.Result;

                Flights = new BindingList<FlightModel>(list);
            }

        }

        private async Task LoadFlightsForCity()
        {
            Response<List<FlightModel>> response = await APIHelper<Response<List<FlightModel>>>.Instance.Get(ApiRoutes.Flight.Get.Replace(ApiRoutes.Keybase,SelectedCity.Id));
            if (response.IsSuccess)
            {
                var list = response.Result;
                Flights.Clear();
                Flights = new BindingList<FlightModel>(list);
            }

        }
        private async Task LoadCity()
        {
            Response<List<CityModel>> response = await APIHelper<Response<List<CityModel>>>.Instance.Get(ApiRoutes.City.GetAll);
            if (response.IsSuccess)
            {
                var list = response.Result;

                Cities = new BindingList<CityModel>(list);
            }

        }

        private BindingList<FlightModel> _flights;

        public  BindingList<FlightModel> Flights
        {
            get => _flights;
            set
            {
                _flights = value;
                NotifyOfPropertyChange(() => Flights);
            }
        }

        private BindingList<CityModel> _cities;

        public BindingList<CityModel> Cities
        {
            get => _cities;
            set
            {
                _cities = value;
                NotifyOfPropertyChange(() => Cities);
            }
        }

        private CityModel _selectedCity;
        public CityModel SelectedCity
        {
            get { return _selectedCity; }
            set { 
                _selectedCity = value;
                Task.Run(() => LoadFlightsForCity());
                NotifyOfPropertyChange(() => SelectedCity);
                

            }
        }

    }
}