using System;
using System.Collections.Generic;

namespace CodehelpApp.API.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string QuestionTitle { get; set; }
        public string QuestionDetails { get; set; }
        public DateTime Created { get; set; }
        public string DisplayName { get; set; }
        public int Votes { get; set; }
        public int Answers { get; set; }
        public int Views { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
    }
}