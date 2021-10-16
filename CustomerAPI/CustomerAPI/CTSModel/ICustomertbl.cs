﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerAPI.CTSModel
{
    public interface ICustomertbl<Customertbl>
    {
        public Task<int> AddCustomer(Customertbl o);
        public Task<Customertbl> GetAccById(int id);
        public Task<int> UpdateAccount(Customertbl o);
        public Task<int> DeleteAccount(Customertbl o);
        public Task<List<Customertbl>> GetAllCustomer();
    }
}
