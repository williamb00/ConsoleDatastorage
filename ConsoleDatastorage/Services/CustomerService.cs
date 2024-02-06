using ConsoleApp.Services;
using ConsoleDatastorage.Entities; // Importera rätt namespace för dina entiteter
using ConsoleDatastorage.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDatastorage.Services
{
    internal class CustomerService
    {
        private readonly CustomerRepository _customerRepository;
        private readonly AddressService _adressService;

        public CustomerService(CustomerRepository customerRepository, AddressService addressService)
        {
            _customerRepository = customerRepository;
            _adressService = addressService;
        }

        public CustomerEntity CreateCustomer(string firstName, string lastName, string phoneNumber, string socialSecurityNumber, int addressId)
        {
            // Skapa en ny kundentitet med de angivna parametrarna
            var customerEntity = new CustomerEntity
            {
                FirstName = firstName,
                LastName = lastName,
                PhoneNumber = phoneNumber,
                SocialSecurityNumber = socialSecurityNumber,
                AddressId = addressId
            };

            // Lägg till den nya kunden i databasen
            customerEntity = _customerRepository.Create(customerEntity);

            return customerEntity;
        }

        public CustomerEntity GetCustomerById(int id)
        {
            // Hämta kunden med det angivna ID:et
            var customerEntity = _customerRepository.GetById(id);
            return customerEntity;
        }

        public IEnumerable<CustomerEntity> GetAllCustomers()
        {
            // Hämta alla kunder från databasen
            var customers = _customerRepository.GetAll();
            return customers;
        }

        public CustomerEntity UpdateCustomer(CustomerEntity customerEntity)
        {
            // Uppdatera kundens information i databasen
            var updatedCustomerEntity = _customerRepository.Update(customerEntity);
            return updatedCustomerEntity;
        }

        public void DeleteCustomer(int id) =>
            // Ta bort kunden med det angivna ID:et från databasen
            _customerRepository.Delete(id);
    }
}
