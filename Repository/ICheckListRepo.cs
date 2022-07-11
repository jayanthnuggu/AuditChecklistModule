using AuditChecklistModule.Models;
using System.Collections.Generic;

namespace AuditChecklistModule.Repository
{
    public interface ICheckListRepo
    {
        public List<Questions> GetQuestions(string auditType);
    }
}
