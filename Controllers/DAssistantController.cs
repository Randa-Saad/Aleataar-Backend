using Microsoft.AspNetCore.Mvc;
using SalesOrderAPI.Models;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace SalesOrderAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class DAssistantController : ControllerBase
{
    private readonly IDAssistantContainer _container;
    private readonly ILogger<DAssistantContainer> _logger;
    public DAssistantController(IDAssistantContainer container,ILogger<DAssistantContainer> _logger)
    {
        this._container = container;
        this._logger=_logger;
    }

    [HttpGet("GetAll")]
    public async Task<List<DAssistantEntity>> GetAll()
    {
       this._logger.LogInformation("|Log ||Testing");
        return await this._container.Getall();

    }
      [HttpGet("GetByCode")]
    public async Task<DAssistantEntity> GetByCode(string Code)
    {
        return await this._container.Getbycode(Code);

    }

}
