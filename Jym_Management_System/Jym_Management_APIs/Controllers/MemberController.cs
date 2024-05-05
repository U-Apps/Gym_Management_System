using Jym_Management_APIs.Authentication;
using Jym_Management_APIs.DTO_modules;
using Jym_Management_BussinessLayer.Modules;
using Jym_Management_BussinessLayer.Services.Base;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Jym_Management_APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles = clsSystemRoles.User)]
    public class MemberController : ControllerBase
    {
        private readonly IBaseServices<Member> _memberService;
        private readonly IBaseServices<Person> _personService;


        public MemberController(IBaseServices<Member> memberService, IBaseServices<Person> personService)
        {
            _memberService = memberService;
            _personService = personService;

        }


        [HttpPost]
        [Route("")]

        public ActionResult CreateMember(CreateMemberDTO createMemberDTO)
        {
            var person = new Person()
            {
                Name = createMemberDTO.Name,
                Idcard = createMemberDTO.Idcard,
                PhoneNumber = createMemberDTO.PhoneNumber,
                Email = createMemberDTO.Email,
                BirthDate = createMemberDTO.BirthDate
            };

            

            var member = new Member();

            member.PersonId = _personService.Add(person);
            member.MemberWeight = createMemberDTO.MemberWeight;
            member.IsActive = createMemberDTO.IsActive;

            _memberService.Add(member);
            return Ok();
        }

        [HttpPut]
        [Route("")]

        public ActionResult UpdateMember(UpdateMemberDTO updateMemberDTO)
        {
            var existingMember = _memberService.GetById(updateMemberDTO.MemberId);
            if (existingMember == null)
                return NotFound();

            var existingPerson = _personService.GetById(existingMember.PersonId);

            existingPerson.Name = updateMemberDTO.Name;
            existingPerson.PhoneNumber = updateMemberDTO.PhoneNumber;
            existingPerson.BirthDate = updateMemberDTO.BirthDate;
            existingPerson.Email = updateMemberDTO.Email;
            _personService.Update(existingPerson);

            existingMember.Person = existingPerson;
            existingMember.MemberWeight = updateMemberDTO.MemberWeight;
            existingMember.IsActive = updateMemberDTO.IsActive;

            _memberService.Update(existingMember);
            return Ok();
        }


        [HttpGet]
        [Route("")]
        public ActionResult<IEnumerable<ReadMemberDTO>> Get()
        {

            var members = _memberService.GetAll().Select(member => member.AsDTO());

            return Ok(members);
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<ReadMemberDTO> GetById(int id)
        {
            Member member = _memberService.GetById(id);
            return member is null ? NotFound() : Ok(member.AsDTO());
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult Delete(int id)
        {
            Member member = _memberService.GetById(id);

            if (member is null)
                return NotFound();

            _memberService.DeleteById(member.MemberId);

            return Ok();
        }
    }
}
