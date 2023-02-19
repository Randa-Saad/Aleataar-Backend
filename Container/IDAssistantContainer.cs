
using Microsoft.EntityFrameworkCore;
using SalesOrderAPI.Models;
public interface IDAssistantContainer{

    Task<List<DAssistantEntity>> Getall();
    Task<DAssistantEntity> Getbycode(string code);

}