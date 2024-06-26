﻿using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract;

public interface ICustomerService
{
    IResult Add(Customer customer);
    IResult Update(Customer customer);
    IResult Delete(Customer customer);
    IDataResult<List<Customer>> GetAll();
    IDataResult<Customer> Get(int id);
    IDataResult<Customer> UniqueTaxNo(string taxNo);
}
