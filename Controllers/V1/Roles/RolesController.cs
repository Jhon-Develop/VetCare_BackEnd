using Microsoft.AspNetCore.Mvc;
using VetCare_BackEnd.Data;

namespace VetCare_BackEnd.Controllers.V1.Roles
{
    [ApiController]
    [Route("api/[controller]")]
    public partial class RolesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public RolesController(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}