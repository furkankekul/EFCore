using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        IRepository<Account> repository;

        public AccountController(IRepository<Account> repository)
        {
              
        }
        public AccountController()
        {
            
        }
        [HttpGet]
        public ActionResult add()
        {


        }


    }
}
