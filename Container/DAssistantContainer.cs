
using SalesOrderAPI.Models;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
public class DAssistantContainer : IDAssistantContainer
{

    private readonly Sales_DBContext _DBContext;
    private readonly IMapper mapper;
    public DAssistantContainer(Sales_DBContext dBContext, IMapper mapper)
    {

        this._DBContext = dBContext;
        this.mapper = mapper;
    }

    public async Task<List<DAssistantEntity>> Getall()
    {
        var DAssistantdata = await this._DBContext.TblDAssistants.ToListAsync();
        if (DAssistantdata != null && DAssistantdata.Count > 0)
        {
            // we need use automapper

            return this.mapper.Map<List<TblDAssistant>, List<DAssistantEntity>>(DAssistantdata);
        }
        return new List<DAssistantEntity>();

    }

    public async Task<DAssistantEntity> Getbycode(string code)
    {
        int c=Convert.ToInt32(code);
        var DAssistantdata = await this._DBContext.TblDAssistants.FirstOrDefaultAsync(item => item.Code == code);
        if (DAssistantdata != null)
        {
            return this.mapper.Map<TblDAssistant, DAssistantEntity>(DAssistantdata);
        }
        return new DAssistantEntity();

    }

}