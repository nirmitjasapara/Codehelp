using System;
using System.Collections.Generic;

namespace CodehelpApp.API.Dtos
{
    public class QuestionForListDto
    {
        public int Id { get; set; }
        public string QuestionTitle { get; set; }
        public DateTime Created { get; set; }
        public string DisplayName { get; set; }
        public int Votes { get; set; }
        public int Answers { get; set; }
        public int Views { get; set; }
    }
}