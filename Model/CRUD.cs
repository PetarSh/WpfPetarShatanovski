using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WpfPetarShatanovski.Model;

namespace WpfPetarShatanovski.Model
{
    public class CRUD
    {
        ClientDB _dbContext = null;
        public CRUD()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory",
             Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData));
            _dbContext = new ClientDB();
        }

        public IEnumerable<Client> Get()
        {
            return _dbContext.Clients.ToList();
        }
        public IEnumerable<Address> GetAddresses()
        {
            return _dbContext.Addresses.ToList();
        }

        public void Delete(Client client)
        {
            _dbContext.Clients.Remove(client);
        }

        public void Update(Client updatedClient)
        {
            CheckValidations(updatedClient);
            if (updatedClient.Id > 0)
            {
                Client selected = _dbContext.Clients.First(p => p.Id == updatedClient.Id);
                selected.FirstName = updatedClient.FirstName;
                selected.LastName = updatedClient.LastName;
                selected.BirthDate = updatedClient.BirthDate;
                selected.Created = DateTime.UtcNow;
                _dbContext.SaveChanges();
            }
            else
            {
                Client newC = new Client();
                newC.FirstName = updatedClient.FirstName;
                newC.LastName = updatedClient.LastName;
                newC.BirthDate = updatedClient.BirthDate;
                newC.Created = DateTime.UtcNow;

                _dbContext.Clients.Add(newC);
                _dbContext.SaveChanges();

                Client insertedCl= _dbContext.Clients.First(p => p.Id == newC.Id);

                Address adr = new Address();
                
                
            }
            _dbContext.SaveChanges();

        }

        private void CheckValidations(Client client)
        {
            if(client == null)
            {
                throw new ArgumentNullException("Client", "Please select record from the View or Add New");
            }

            if (string.IsNullOrEmpty(client.FirstName))
            {
                throw new ArgumentNullException("First Name", "Please enter FirstName");
            }
            else if (string.IsNullOrEmpty(client.LastName))
            {
                throw new ArgumentNullException("Last Name", "Please enter LastName");
            }
            
        }
    }
}
