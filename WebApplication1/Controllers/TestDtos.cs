using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using tablesmock;

using Microsoft.CodeAnalysis;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    //[ApiController]
    public class TestDtos : ControllerBase
    {
        private SchoolDB context;

        public TestDtos()
        {
            context = new SchoolDB();
        }

        [HttpGet]
        public DTOtest Function()
        {
            
            var testdto = context.Parent.Where(x => x.Id == 4)
                    .Include(x => x.Students)
                    .ThenInclude(x => x.Student).Select(x => new DTOtest
                    {
                        ParentName = x.ParentName,
                        StudentName = x.Students.Select(x => x.Student.FirstName).ToList()
                    }).SingleOrDefault();

            return testdto;
        }
    }
}
