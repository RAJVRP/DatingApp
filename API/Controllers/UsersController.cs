using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserssController : ControllerBase
    {
        private readonly DataContext _context;
        public UserssController(DataContext context)
        {
            _context = context;
        } 
   

      [HttpGet]
        public ActionResult <IEnumerable<AppUser>> GetUsers()
        {
        var users= _context.Users.ToList();
        return users;
    
        }

        //api/users/3
         [HttpGet("{id}")]
        public ActionResult <AppUser> GetUser(int id)
        {
        var user= _context.Users.Find(id);
        return user;
    
        }
    }

}