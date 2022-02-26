using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Quize2.Models;
using Quize2.Services;
using System.Collections.Generic;

namespace Quize2.Controllers
{
    //List<Question> questions = new List<Question>();
    [Route("api/[controller]")]
    [ApiController]
   // readonly IEmailService emailService { grt};

    public class QuizeController : ControllerBase
    {
        [HttpGet]
        [Route("GetQuize")]
        public IActionResult GetQuize()
        {
            var data = "";
            Question q = new Question();

            return null;
        }
        [HttpPost]
        [Route("PostQuize")]
        public IActionResult PostQuize(List<Question> ql )
        {

            
            Question question = new Question();

            question.Id = 1; 
            question.QTitle = q.QTitle; 
            question.Masks = q.Masks; 
            question.ISMultiselect = q.ISMultiselect;
            //   questions.Add(question);


            // select * from Question q left join
            // answers a on a.id = q.id
            // where q.QTitle = 



            return Ok(question);
        }
    }
}

/// get 
/// 
