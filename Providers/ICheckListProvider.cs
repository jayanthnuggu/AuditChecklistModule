using AuditChecklistModule.Models;
using System.Collections.Generic;

namespace AuditChecklistModule.Providers
{
    public interface ICheckListProvider
    {
        public List<Questions> QuestionsProvider(string auditType);
    }
}
