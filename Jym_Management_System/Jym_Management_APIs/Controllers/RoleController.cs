using Jym_Management_APIs.DTO_modules;
using Jym_Management_BussinessLayer.Modules;
using Jym_Management_BussinessLayer.Services;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Jym_Management_BussinessLayer.Services.Base;
using System.Xml.Linq;

namespace Jym_Management_APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IBaseServices<Role> _roleService;


        public RoleController(IBaseServices<Role> roleService)
        {
            _roleService = roleService;
           
        }


        [HttpPost]
        [Route("")]

        public ActionResult CreateRole(CreateRoleDTO createRoleDTO)
        {
            var role = new Role();

            role.RoleName = createRoleDTO.RoleName;
  
            _roleService.Add(role);
            return Ok();
        }

        [HttpPut]
        [Route("")]

        public ActionResult UpdateRole(UpdateRoleDTO updateRoleDTO)
        {
            var existingRole = _roleService.GetById(updateRoleDTO.RoleId);
            if (existingRole == null)
                return NotFound();

            existingRole.RoleName = updateRoleDTO.RoleName;

            _roleService.Update(existingRole);
            return Ok();
        }


        [HttpGet]
        [Route("")]
        public ActionResult<IEnumerable<ReadRoleDTO>> Get()
        {

            var roles = _roleService.GetAll().Select(role => role.AsDTO());

            return Ok(roles);
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<ReadRoleDTO> GetById(int id)
        {
            Role role = _roleService.GetById(id);
            return role is null ? NotFound() : Ok(role.AsDTO());
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult Delete(int id)
        {
            Role role = _roleService.GetById(id);

            if (role is null)
                return NotFound();

            _roleService.DeleteById(role.RoleId);

            return Ok();
        }
    }
}
