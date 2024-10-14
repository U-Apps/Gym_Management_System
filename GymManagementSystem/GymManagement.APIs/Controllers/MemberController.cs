using Microsoft.AspNetCore.Mvc;
using GymManagement.BusinessCore.Contracts.Services;
using Microsoft.AspNetCore.Authorization;
using GymManagement.APIs.Authentication;
using GymManagement.BusinessCore.DTOs;

namespace GymManagement.APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles = (clsSystemRoles.User + "," + clsSystemRoles.Admin))]
    public class MemberController(IMemberService _memberService) : ControllerBase
    {
        [HttpPost]
        [Route("[action]")]

        public ActionResult CreateMember(CreateMemberDTO createMemberDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var NewMember = _memberService.AddNewMember(createMemberDTO);

            return Created(Url.Link("GetMemberByIdRoute", new {id = NewMember.MemberId}), NewMember);
        }

        [HttpGet]
        [Route("[action]")]
        public ActionResult<IEnumerable<MemberResponse>> GetMembers()
        {

            var members = _memberService.GetAllMembers();

            return Ok(members);
        }

        [HttpGet]
        [Route("[action]/{id}", Name = "GetMemberByIdRoute")]
        public ActionResult<MemberResponse> GetMemberById(int id)
        {
            var member = _memberService.GetMemberById(id);
            return member is null ? NotFound($"Member with id = {id} is not found") : Ok(member);
        }

        [HttpPut]
        [Route("[action]/{id:int}")]

        public ActionResult UpdateMember([FromRoute]int id,[FromBody] UpdateMemberDTO updateMemberDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return !_memberService.updateMember(id, updateMemberDTO)? NotFound($"member with id = {id} is no longer exist"): NoContent();
        }




        //[HttpDelete]
        //[Route("[action]/{id}")]
        //public ActionResult Delete(int id)
        //{
        //    Member member = _memberService.GetById(id);

        //    if (member is null)
        //        return NotFound();

        //    _memberService.DeleteById(member.Id);

        //    return Ok();
        //}
    }
}
