using AuditChecklistModule.Models;
using System;
using System.Collections.Generic;

namespace AuditChecklistModule.Repository
{
    public class CheckListRepo:ICheckListRepo
    {
        public static List<Questions> InternalQuestionsList = new List<Questions>()
        {
            new Questions
            {
                QuestionNo=1,
                Question="Have all Change requests followed SDLC before PROD move?"
            },
            new Questions
            {
                QuestionNo=2,
                Question="Have all Change requests been approved by the application owner?"
            },
            new Questions
            {
                QuestionNo=3,
                Question="Are all artifacts like CR document, Unit test cases available?"
            },
            new Questions
            {
                QuestionNo=4,
                Question="Is the SIT and UAT sign-off available?"
            },
            new Questions
            {
                QuestionNo=5,
                Question="Is data deletion from the system done with application owner approval?"
            }

        };
        private static List<Questions> SOXQuestionsList = new List<Questions>()
        {
            new Questions
            {
                QuestionNo=1,
                Question="Have all Change requests followed SDLC before PROD move?"
            },
            new Questions
            {
                QuestionNo=2,
                Question="Have all Change requests been approved by the application owner?"
            },
            new Questions
            {
                QuestionNo=3,
                Question="For a major change, was there a database backup taken before and after PROD move?"
            },
            new Questions
            {
                QuestionNo=4,
                Question="Has the application owner approval obtained while adding a user to the system?"
            },
            new Questions
            {
                QuestionNo=5,
                Question="Is data deletion from the system done with application owner approval?"
            }
        };

        public List<Questions> GetQuestions(string auditType)
        {
            try
            {
                List<Questions> listOfQuestions=new List<Questions>();

                if (auditType == "Internal")
                    listOfQuestions = InternalQuestionsList;
                else
                    listOfQuestions = SOXQuestionsList;

                return listOfQuestions;
            }
            catch (Exception ex)
            {
                return null;

            }
        }

    }

    
}
