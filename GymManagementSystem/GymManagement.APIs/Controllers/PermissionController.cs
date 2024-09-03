﻿using Jym_Management_APIs.DTO_modules;
using Jym_Management_BussinessLayer.Modules;
using Jym_Management_BussinessLayer.Services;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Jym_Management_BussinessLayer.Services.Base;
using System.Xml.Linq;
using Microsoft.AspNetCore.Authorization;
using Jym_Management_APIs.Authentication;

namespace Jym_Management_APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = clsSystemRoles.Admin)]
    public class PermissionController : ControllerBase
    {
        private readonly IBaseServices<Permssion> _permissionService;


        public PermissionController(IBaseServices<Permssion> permissionService)
        {
            _permissionService = permissionService;
           
        }


        [HttpPost]
        [Route("[action]")]

        public ActionResult CreatePermission(CreatePermssionDTO createPermissionDTO)
        {
            var permission = new Permssion();

            permission.Name = createPermissionDTO.Name;
            permission.RoleId = createPermissionDTO.RoleId;
  
            _permissionService.Add(permission);
            return Ok();
        }

        [HttpPut]
        [Route("[action]")]

        public ActionResult UpdatePermission(UpdatePermssionDTO updatePermissionDTO)
        {
            var existingPermission = _permissionService.GetById(updatePermissionDTO.Id);
            if (existingPermission == null)
                return NotFound();

            existingPermission.Name = updatePermissionDTO.Name;
            existingPermission.RoleId = updatePermissionDTO.RoleId;

            _permissionService.Update(existingPermission);
            return Ok();
        }


        [HttpGet]
        [Route("[action]")]
        public ActionResult<IEnumerable<ReadPermssionDTO>> Get()
        {

            var permissions = _permissionService.GetAll().Select(permission => permission.AsDTO());

            return Ok(permissions);
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public ActionResult<ReadPermssionDTO> GetById(int id)
        {
            Permssion permission = _permissionService.GetById(id);
            return permission is null ? NotFound() : Ok(permission.AsDTO());
        }

        [HttpDelete]
        [Route("[action]/{id}")]
        public ActionResult Delete(int id)
        {
            Permssion permission = _permissionService.GetById(id);

            if (permission is null)
                return NotFound();

            _permissionService.DeleteById(permission.Id);

            return Ok();
        }
    }
}
