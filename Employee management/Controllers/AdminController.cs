using Employee_management.Models;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;

namespace Employee_management.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")] // tune to your needs
    [RoutePrefix("")]
    public class AdminController : ApiController
    {

        private AdminLoginEntities db = new AdminLoginEntities();
        /// <summary>
        /// localhost:44337/Api/Admin
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ResponseType(typeof(Admin_Table))]
        public async Task<IHttpActionResult> GetAdminData()
        {

            return Ok(db.Admin_Table);
        }

        [HttpPost]
        [ResponseType(typeof(string))]
        public async Task<IHttpActionResult> Authenticate( Admin_Table data , int dummy)
        {
            if(data == null)
            {
                return BadRequest();
            }

            var admin = db.Admin_Table.Where(e => e.AdminPassword == data.AdminPassword && e.AdminName == data.AdminName ).FirstOrDefault();

            if (admin == null) 
            {
                return Ok("User is Not valid");
            }

            return Ok("Authenticate done");
              
        }


    }
}