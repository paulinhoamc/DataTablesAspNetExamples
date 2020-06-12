using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataTables.AspNet.AspNetCore;
using DataTables.AspNet.Core;
using DataTablesMvcCore.Data;
using DataTablesMvcCore.DataModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DataTablesMvcCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProdutosController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _context.Produtos.ToListAsync());
        }

        [HttpGet("{qtd}")]
        public async Task<IActionResult> Get(int qtd)
        {
            return Ok(new { data = await _context.Produtos.Take(qtd).ToListAsync() });
        }

        [HttpGet("datatables")]
        public IActionResult GetDataTables(IDataTablesRequest request)
        {
            var data = _context.Produtos.AsQueryable();

            IQueryable<Produto> dataFiltered = string.IsNullOrWhiteSpace(request.Search.Value) ? data : data.Where(x => x.NCM.Contains(request.Search.Value) || x.Nome.Contains(request.Search.Value));

            var dataPage = dataFiltered.Skip(request.Start).Take(request.Length).ToList();

            var response = DataTablesResponse.Create(request, data.Count(), dataFiltered.Count(), dataPage);

            return new DataTablesJsonResult(response, true);
        }
    }
}
