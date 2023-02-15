﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WiredBrainCoffee.Model;

namespace WiredBrainCoffee.Data
{
    public interface ICustomerDataProvider
    {
        Task<IEnumerable<Customer>?> GetAllAsync();
    }

    public class CustomerDataProvider : ICustomerDataProvider
    {
        public async Task<IEnumerable<Customer>?> GetAllAsync()
        {
            await Task.Delay(100); // Simulate a bit of server work

            return new List<Customer>
            {
                new Customer { Id = 0, FirstName = "Julia", LastName = "Other", IsDeveloper = true },
                new Customer { Id = 1, FirstName = "Jack", LastName = "Shepard", IsDeveloper = true },
                new Customer { Id = 2, FirstName = "Hurley", LastName = "Mexican", IsDeveloper = false },
                new Customer { Id = 3, FirstName = "Sawyer", LastName = "Developer", IsDeveloper = true },
                new Customer { Id = 4, FirstName = "Kate", LastName = "Austen", IsDeveloper = false },
                new Customer { Id = 5, FirstName = "Desmond", LastName = "Miles", IsDeveloper = true }
            };
        }
    }
}
