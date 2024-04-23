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
    [Authorize]
    public class MemberController : ControllerBase
    {
        private readonly IBaseServices<Member> _memberService;


        public MemberController(IBaseServices<Member> memberService)
        {
            _memberService = memberService;

        }


        [HttpPost]
        [Route("")]

        public ActionResult CreateMember(CreateMemberDTO createMemberDTO)
        {
            var member = new Member();

            member.PersonId = createMemberDTO.PersonId;
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
