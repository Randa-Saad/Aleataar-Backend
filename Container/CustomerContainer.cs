
using SalesOrderAPI.Models;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using Microsoft.AspNetCore.Mvc.Infrastructure;

public class CustomerContainer : ICustomerContainer
{

    private readonly Sales_DBContext _DBContext;
    private readonly IMapper mapper;
    public CustomerContainer(Sales_DBContext dBContext, IMapper mapper)
    {

        this._DBContext = dBContext;
        this.mapper = mapper;
    }

    public async Task<List<CustomerEntity>> Getall()
    {
        var customerdata = await this._DBContext.TblCustomers.ToListAsync();
        if (customerdata != null && customerdata.Count > 0)
        {
            // we need use automapper

            return this.mapper.Map<List<TblCustomer>, List<CustomerEntity>>(customerdata);
        }
        return new List<CustomerEntity>();

    }

    public async Task<CustomerEntity> Getbycode(string code)
    {
        int c=Convert.ToInt32(code);
        var customerdata = await this._DBContext.TblCustomers.FirstOrDefaultAsync(item => item.Code == code);
        if (customerdata != null)
        {
            return this.mapper.Map<TblCustomer, CustomerEntity>(customerdata);
        }
        return new CustomerEntity();

    }

    public async Task<ResponseType> SaveCustomer(CustomerEntity customer)
    {

        try
        {
            string Result = string.Empty;
            string resultStatusMsg = "";

            if (customer != null)
            {
                using (var dbtransaction = await this._DBContext.Database.BeginTransactionAsync())
                {
                    // check exist customer
                    var _customer = await this._DBContext.TblCustomers.FirstOrDefaultAsync(item => item.Code == customer.Code);
                    if (_customer != null)
                    {
                        //update here
                        _customer.Name = customer.Name;
                        _customer.Address = customer.Address;
                        _customer.Area = customer.Area;
                        _customer.SpecialMark = customer.SpecialMark;
                        _customer.Phoneno = customer.Phoneno;
                        _customer.Email = customer.Email;

                        _customer.ModifyDate = DateTime.Now;

                        resultStatusMsg = "updated";

                    }
                    else
                    {
                        // create new record
                        var _newcustomer = new TblCustomer()
                        {
                            Code = customer.Code,
                            Name = customer.Name,
                            Address = customer.Address,
                            Area = customer.Area,
                            SpecialMark = customer.SpecialMark,
                            Phoneno = customer.Phoneno,
                            Email = customer.Email,
                            ModifyDate = DateTime.Now
                        };
                        await this._DBContext.TblCustomers.AddAsync(_newcustomer);
                        resultStatusMsg = "added";

                    }

                    await this._DBContext.SaveChangesAsync();
                    await dbtransaction.CommitAsync();
                    return new ResponseType() { Result = resultStatusMsg, KyValue = customer.Code };

                }
             }
            else
            {
                return new ResponseType() { KyValue = string.Empty, Result = "fail" };
            }
        }


        catch (Exception ex)
        {
            throw ex;
        }

        //return new ResponseType() { KyValue = string.Empty, Result = "fail" };
    }

    public async Task<ResponseType> Remove(string customercode)
    {
        try
        {
            using (var dbtransaction = await this._DBContext.Database.BeginTransactionAsync())
            {
                var _data = await this._DBContext.TblCustomers.FirstOrDefaultAsync(item => item.Code == customercode);
                if (_data != null)
                {
                    this._DBContext.TblCustomers.Remove(_data);
                }
                await this._DBContext.SaveChangesAsync();
                await dbtransaction.CommitAsync();
            }
            return new ResponseType() { Result = "pass", KyValue = customercode };
        }
        catch (Exception ex)
        {
            throw ex;
        }

    }

}