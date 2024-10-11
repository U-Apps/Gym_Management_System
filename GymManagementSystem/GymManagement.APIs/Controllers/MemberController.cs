using GymManagement.APIs.DTOs;
using GymManagement.BusinessCore.Models;
using Microsoft.AspNetCore.Mvc;
using GymManagement.BusinessCore.Contracts.Services;
using Microsoft.AspNetCore.Authorization;
using GymManagement.APIs.Authentication;
using GymManagement.APIs.DTOs.Mappers;
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

            _memberService.AddNewMember(createMemberDTO.AsMember(),
                createMemberDTO.SubscriptionInfo.AsSubscription());

            return Ok();
        }

        [HttpGet]
        [Route("[action]")]
        public ActionResult<IEnumerable<MemberResponse>> GetMembers()
        {

            var members = _memberService.GetAllMembers();

            return Ok(members);
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public ActionResult<MemberResponse> GetById(int id)
        {
            var member = _memberService.GetMemberById(id);
            return member is null ? NotFound($"Member with id = {id} is not found") : Ok(member);
        }

        //[HttpPut]
        //[Route("[action]")]

        //public ActionResult UpdateMember(UpdateMemberDTO updateMemberDTO)
        //{
        //    var existingMember = _memberService.GetById(updateMemberDTO.MemberId);
        //    if (existingMember == null)
        //        return NotFound();

        //    //var existingPerson = _personService.GetById(existingMember.PersonId);

        //    //existingPerson.Name = updateMemberDTO.Name;
        //    existingMember.PhoneNumber = updateMemberDTO.PhoneNumber;
        //    existingMember.BirthDate = updateMemberDTO.BirthDate;
        //    existingMember.Email = updateMemberDTO.Email;
        //    //_personService.Update(existingPerson);

        //    //existingMember.Person = existingPerson;
        //    existingMember.MemberWeight = updateMemberDTO.MemberWeight;
        //    existingMember.IsActive = updateMemberDTO.IsActive;

        //    _memberService.Update(existingMember);
        //    return Ok();
        //}




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
