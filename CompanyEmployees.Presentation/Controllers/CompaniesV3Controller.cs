//using Application.Commands;
//using Application.Queries;
//using MediatR;
//using Microsoft.AspNetCore.Mvc;
//using Shared.DataTransferObjects;

//namespace CompanyEmployees.Presentation.Controllers
//{
//    [Route("api/v3/companies")]
//    [ApiController]
//    public class CompaniesV3Controller : ControllerBase
//    {
//        private readonly ISender _sender;
//        public CompaniesV3Controller(ISender sender) => _sender = sender;

//        [HttpGet]
//        public async Task<IActionResult> GetCompanies()
//        {
//            var companies = await _sender.Send(new GetCompaniesQuery(TrackChanges: false));
            
//            return Ok(companies);
//        }

//        [HttpGet("{id:guid}", Name = "CompanyById")]
//        public async Task<IActionResult> GetCompany(Guid id)
//        {
//            var company = await _sender.Send(new GetCompanyQuery(id, TrackChanges: false));
            
//            return Ok(company);
//        }

//        [HttpPost]
//        public async Task<IActionResult> CreateCompany([FromBody] CompanyForCreationDto companyForCreationDto)
//        {
//            if (companyForCreationDto is null)
//                return BadRequest("CompanyForCreationDto object is null");

//            var company = await _sender.Send(new CreateCompanyCommand(companyForCreationDto));

//            return CreatedAtRoute("CompanyById", new { Id = company.Id }, company);
//        }

//        [HttpPut]
//        public async Task<IActionResult> UpdateCompany(Guid id, CompanyForUpdateDto companyForUpdateDto)
//        {
//            if (companyForUpdateDto is null)
//                return BadRequest("CompanyForUpdateDto object is null");

//            await _sender.Send(new UpdateCompanyCommand(id, companyForUpdateDto, TrackChanges: true));
//            return NoContent();
//        }

//        [HttpDelete("{id:guid}")]
//        public async Task<IActionResult> DeleteCompany(Guid id)
//        {
//            await _sender.Send(new DeleteCompanyCommand(id, TrackChanges: false));

//            return NoContent();
//        }

//    }
//}
