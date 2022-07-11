using AuditChecklistModule.Models;
using AuditChecklistModule.Providers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AuditChecklistModule.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuditCheckListController : ControllerBase
    {
        private readonly ICheckListProvider checkListProvider;
        public AuditCheckListController(ICheckListProvider _checkListProvider)
        {
            checkListProvider=_checkListProvider;
        }
        [HttpGet]
        public IActionResult AuditCheckListQuestions([FromHeader]string auditType)
        {
            if (string.IsNullOrEmpty(auditType))
            {
                return BadRequest("No Input");
            }
            if ((auditType != "Internal") && (auditType != "SOX"))
            {
                return Ok("Wrong Input");

            }
            try
            {
                List<Questions> list=checkListProvider.QuestionsProvider(auditType);
                return Ok(list);
            }
            catch
            {
                return StatusCode(500);
            }
            
        }
    }
}
