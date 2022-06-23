using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("apii/[controller]")]
    public class PandiController : ControllerBase
    {
      
        private readonly DataContext _conte;
        public PandiController(DataContext conte)
        {
            _conte = conte;
        }


    [HttpGet]
    public async Task< ActionResult<IEnumerable<AppUser>>> GettUsers()
    {

      return await _conte.Users.ToListAsync();
      
    } 


 [HttpGet("{id}") ]
    public async Task<ActionResult<AppUser>> GettUser(int id)
    {

      return await _conte.Users.FindAsync(id);
    
    } 


    }
}