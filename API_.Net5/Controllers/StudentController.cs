using API_.Net5.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_.Net5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private MVC_Core5Context _context;

        public StudentController(MVC_Core5Context context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult Get()
        {
            var StdList = _context.Students.ToList();
            if (StdList.Count == 0)
                return NotFound();
            else
                return Ok(StdList);
        }

        [HttpPut]
        public ActionResult Put(int id , Student s)
        {
            _context.Entry(s).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return null;
        }
    }
}
