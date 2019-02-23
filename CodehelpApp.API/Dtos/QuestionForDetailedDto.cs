using System;
using System.Collections.Generic;

namespace CodehelpApp.API.Dtos
{
    public class QuestionForDetailedDto
    {
        public int Id { get; set; }
        public string QuestionTitle { get; set; }
        public string QuestionDetails { get; set; }
        public DateTime Created { get; set; }
        public string DisplayName { get; set; }
    }
}