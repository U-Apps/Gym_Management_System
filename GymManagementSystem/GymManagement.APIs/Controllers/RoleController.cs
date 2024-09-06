using Jym_Management_APIs.DTO_modules;
using Jym_Management_BussinessLayer.Modules;
using Jym_Management_BussinessLayer.Services;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Jym_Management_BussinessLayer.Services.Base;
using System.Xml.Linq;
using Microsoft.AspNetCore.Authorization;
using Jym_Management_APIs.Authentication;

namespace GymManagement.APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = clsSystemRoles.Admin)]
    public class RoleController : ControllerBase
    {
        private readonly RoleService _roleService;


        public RoleController(RoleService roleService)
        {
            _roleService = roleService;
           
        }


        [HttpPost]
        [Route("[action]")]

        public ActionResult CreateRole(CreateRoleDTO createRoleDTO)
        {
            if(!ModelState.IsValid)
            {
               return BadRequest(ModelState);
            }
            var role = new Role
            {
                RoleName = createRoleDTO.RoleName
            };

            _roleService.Add(role);
            return Ok();

        }

        [HttpPut]
        [Route("[action]")]

        public ActionResult UpdateRole(UpdateRoleDTO updateRoleDTO)
        {
            var existingRole = _roleService.GetById(updateRoleDTO.RoleId);
            if (existingRole == null)
                return NotFound();
            if(!ModelState.IsValid) { return BadRequest(ModelState); }

            existingRole.RoleName = updateRoleDTO.RoleName;

            _roleService.Update(existingRole);
            return Ok();
        }


        [HttpGet]
        [Route("[action]")]
        public ActionResult<IEnumerable<ReadRoleDTO>> GetAll()
        {

            var roles = _roleService.GetAll().Select(role => role.AsDTO());

            return Ok(roles);
        }

        [HttpGet]
        [Route("[action]/{id:int}")]
        public ActionResult<ReadRoleDTO> GetById(int id)
        {
            Role role = _roleService.GetById(id);
            return role is null ? NotFound() : Ok(role.AsDTO());
        }

        [HttpDelete]
        [Route("[action]/{id:int}")]
        public ActionResult Delete(int id)
        {
            Role role = _roleService.GetById(id);

            if (role is null)
                return NotFound();

            _roleService.Delete(role.RoleId);

            return Ok();
        }
    }
}
