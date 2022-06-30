using MathematicalCalculations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using ProjectAPI.DataLayer;
using ProjectAPI.Models;
using ProjectAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectAPI.Filters;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuoteController : ControllerBase
    {
        List<Quotes> _quotes = new List<Quotes>()
        {
            new Quotes(){AuthorId = 1, AuthorName = "Seth" , Phone = 99},
            new Quotes(){AuthorId = 2, AuthorName = "Hi" , Phone = 91}
        };
        public QuotesDbContext _quotesDbContext;
        private IMemoryCache memoryCache;
        private IMockRepository mockRepository;
        string a, b, c;
        public QuoteController(QuotesDbContext quotesDbContext, IMemoryCache memoryCache,IMockRepository mockRepository,
            IScoped scoped,IMaths maths)
        {
            this._quotesDbContext = quotesDbContext;
            this.memoryCache = memoryCache;
             a = mockRepository.GetList();
             c = scoped.GetList();
            var k = maths.sum(2, 3);
            
        }
        // GET: api/<QuoteController>
        [HttpGet]
        [MyFilter("seth")]
        public async Task<ActionResult<List<Quotes>>> Get()
        {
            List<Quotes> output;
            output = this.memoryCache.Get<List<Quotes>>(key: "quotes");

            if (output is null)
            {
                
                output = await _quotesDbContext.Quotes.ToListAsync();

                await Task.Delay(3000);

                memoryCache.Set(key: "quotes", output, TimeSpan.FromMinutes(1));
            }
            
            
            return Ok(output);
        }

        // GET api/<QuoteController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Quotes>> Get(int id)
        {
            var Quote = await _quotesDbContext.Quotes.FindAsync(id);
            if (Quote == null)
                return BadRequest("Bad Request");
            return Ok(Quote);
        }

        // POST api/<QuoteController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Quotes quotes)
        {
            //_quotesDbContext.Quotes.Add(quotes);
            var procedure = $"EXECUTE names  @pm = ' aslkfjd vndv', @tl = 90";
            
            //_quotesDbContext.Quotes.FromSqlRaw(procedure);
            await _quotesDbContext.Database.ExecuteSqlRawAsync(procedure);
            return Ok();
        }

        // PUT api/<QuoteController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Quotes quotes)
        {
            _quotes[id] = quotes;
        }

        // DELETE api/<QuoteController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var valuePresent = await _quotesDbContext.Quotes.FindAsync(id);
            if (valuePresent != null)
            {
                _quotesDbContext.Quotes.Remove(valuePresent);
                await _quotesDbContext.SaveChangesAsync();
                return Ok();
            }
            return NotFound();

        }
    }
}
