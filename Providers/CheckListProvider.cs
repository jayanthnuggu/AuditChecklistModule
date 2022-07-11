using AuditChecklistModule.Models;
using AuditChecklistModule.Repository;
using System.Collections.Generic;

namespace AuditChecklistModule.Providers
{
    public class CheckListProvider: ICheckListProvider
    {
        private readonly ICheckListRepo checkListRepo;
        public CheckListProvider(ICheckListRepo _checkListRepo)
        {
            checkListRepo = _checkListRepo;
        }
        List<Questions> listOfQuestions = new List<Questions>();

        public List<Questions> QuestionsProvider(string auditType)
        {
            listOfQuestions = checkListRepo.GetQuestions(auditType);
            return listOfQuestions;
        }
    }
}
