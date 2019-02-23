using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using CodehelpApp.API.Data;
using CodehelpApp.API.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CodehelpApp.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        private readonly IQuestionsRepository _repo;
        private readonly IMapper _mapper;
        public QuestionsController(IQuestionsRepository repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetQuestions()
        {
            var questions = await _repo.GetQuestions();

            var questionsToReturn = _mapper.Map<IEnumerable<QuestionForListDto>>(questions);

            return Ok(questionsToReturn);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetQuestion(int id)
        {
            var question = await _repo.GetQuestion(id);

            var questionToReturn = _mapper.Map<QuestionForDetailedDto>(question);

            return Ok(questionToReturn);
        }
    }
} 