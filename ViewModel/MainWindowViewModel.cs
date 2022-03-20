﻿using WpfPetarShatanovski.Infrastructure;
using WpfPetarShatanovski.Model;
using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Collections.Generic;
using System.Net.Http;
using System.Configuration;
using System.Net.Http.Headers;
using System.Windows.Markup;
using WpfPetarShatanovski.View;
using System.Xml.Linq;
using System.Windows.Controls;
using System.ComponentModel;
using System.Security.Cryptography;

namespace WpfPetarShatanovski.ViewModel
{
    public class MainWindowViewModel : NotificationClass
    {
        CRUD _business;
        
        private Client _client;
        private Address _address;
        public EventHandler ShowMessageBox = delegate { };

        public MainWindowViewModel()
        {
            _business = new CRUD();
            ObservableCollection<ClientData> clientdata = new ObservableCollection<ClientData>();
            ClientCollection = new ObservableCollection<Client>(_business.Get());
            AddressesCollection = new ObservableCollection<Address>(_business.GetAddresses());
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private ObservableCollection<Client> clientCollection;
        private ObservableCollection<Address> addresses;
        public ObservableCollection<Client> ClientCollection
            {
                get { return clientCollection; }
                set {
                    clientCollection = value;
                    OnProprtyChanged();
                }
            }
        public ObservableCollection<Address> AddressesCollection
        {
            get { return addresses; }
            set
            {
                addresses = value;
                OnProprtyChanged();
            }
        }
        public Client SelectedClient
        {
            get
            {
                return _client;
            }
            set
            {
                _client = value;
                OnProprtyChanged();
            }
        }
        public Address SelectedAddress
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
                OnProprtyChanged();
            }
        }

        public RelayCommand AddAddress
        {
            get
            {
                return new RelayCommand(AddAddressNew, true);
            }
        }
        private void AddAddressNew()
        {
            try
            {
                SelectedAddress = new Address();
            }
            catch (Exception ex)
            {
                ShowMessageBox(this, new MessageEventArgs()
                {
                    Message = ex.Message
                });
            }
        }

        public RelayCommand Add
        {
            get
            {
                return new RelayCommand(AddClient, true);
            }        
        }
  
        public string FirstName
        {
            get { return FirstName; }
            set
            {
                FirstName = value;
                NotifyPropertyChanged(nameof(FirstName));
            }
        }

        private void AddClient()
        {
            try
            {
                Client client = new Client();
                client.FirstName = SelectedClient.FirstName;
                SelectedClient.FirstName = _client.FirstName;


            }
            catch (Exception ex)
            {
                ShowMessageBox(this, new MessageEventArgs()
                {
                    Message = ex.Message
                });
            }            
        }
        public RelayCommand GetWorldClock
        {
            get
            {
                return new RelayCommand(GetWCData, true);
            }
        }

        public RelayCommand Xml
        {
            get
            {
                return new RelayCommand(ImportClient, true);
            }
        }

       

        private void ImportClient()
        {
            try
            {
                DataSet ds = new DataSet();
                ds.ReadXml("C:\\Users\\petar\\source\\repos\\WpfPetarShatanovski\\XMLClients.xml");
                List<Client> empList = new List<Client>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Client tmp = new Client();
                    tmp.FirstName = Convert.ToString(dr["FirstName"]);
                    tmp.LastName = Convert.ToString(dr["LastName"]);
                    tmp.BirthDate = Convert.ToDateTime(dr["BirthDate"]);
                    tmp.Created = DateTime.UtcNow;

                    empList.Add(tmp);
                }

                foreach (Client c in empList)
                {
                    _business.Update(c);
                }
               
                ClientCollection = new ObservableCollection<Client>(_business.Get());
                ShowMessageBox(this, new MessageEventArgs()
                {
                    Message = "Import from xml finished !"
                });
            }
            catch (Exception ex)
            {
                ShowMessageBox(this, new MessageEventArgs()
                {
                    Message = ex.Message
                });
            }

        }
        public RelayCommand Save
        {
            get
            {
                return new RelayCommand(SaveClient, true);
            }
        }

        private void SaveClient()
        {
            try
            {
                _business.Update(SelectedClient);
                ClientCollection = new ObservableCollection<Client>(_business.Get());
                ShowMessageBox(this, new MessageEventArgs()
                {
                    Message = "Changes are saved !"
                });
            }
            catch (Exception ex)
            {
                ShowMessageBox(this, new MessageEventArgs()
                {
                    Message = ex.Message
                });
            }               
          
        }

        public RelayCommand Delete
        {
            get
            {
                return new RelayCommand(DeleteClient, true);
            }
        }

        public object fnTbt { get; private set; }
        public object lnTbt { get; private set; }
        public object bdTbt { get; private set; }

        private void DeleteClient()
        {
            _business.Delete(SelectedClient);
        }
        private void GetWCData()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://worldclockapi.com/api/json/utc/now");

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("http://worldclockapi.com/api/json/utc/now").Result;

            if (response.IsSuccessStatusCode)
            {
                var wc=response.Content.ReadAsStringAsync();
                ShowMessageBox(this, new MessageEventArgs()
                {
                
                    Message = wc.Result
                }); 

            }
            else
            {
                ShowMessageBox(this, new MessageEventArgs()
                {
                    Message = "No Data"
                });
            }
        }
        

}
}
