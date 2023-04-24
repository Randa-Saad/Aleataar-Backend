
using Microsoft.EntityFrameworkCore;
using SalesOrderAPI.Models;
public interface ICustomerContainer{

    Task<List<CustomerEntity>> Getall();
    Task<CustomerEntity> Getbycode(string code);
    Task<ResponseType> SaveCustomer(CustomerEntity customer);
    Task<ResponseType> Remove(string code);

}