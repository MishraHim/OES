using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MOCKAPP.Server.Data;
using MOCKAPP.Server.Dto;
using MOCKAPP.Server.Model;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace MOCKAPP.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizController : ControllerBase
    {
        private readonly Dbcontext _context;
        public QuizController(Dbcontext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("getquiz")]
        public async Task<IActionResult> getquiz()
        {
            var ques = await _context.Question
                //.Where(x => x.QuesId == qid)
                .Select(ques => new quizquestion
                {
                    QuesId = ques.QuesId,
                    QuesName = ques.QuesName,
                    Options = ques.Options.Select(opt => new quizoption
                    {
                        optionID = opt.optionID,
                        optionName = opt.optionName
                    }).ToList()
                }).ToListAsync();
            return Ok(ques);


            //var ques = await _context.Question.Select(ques => new quizquestion
            //{
            //    QuesId = ques.QuesId,
            //    QuesName = ques.QuesName,
            //    Options = _context.Options.Select(option => new quizoption
            //    {
            //        optionID = option.optionID,
            //        optionName = option.optionName,
            //    }).ToList()

            //}).ToListAsync();

            //return Ok(ques);



            //var quiz = (from course in _context.course
            //            join coursetype in _context.coursetype
            //            on course.typeId equals coursetype.typeId
            //            join section in _context.section
            //            on course.courseId equals section.courseId
            //            join paper in _context.Paper
            //            on section.courseId equals paper.courseId
            //            join question in _context.Question
            //            on paper.PaperID equals question.PaperID
            //            join options in _context.Options
            //            on question.QuesId equals options.QuesId
            //            where course.courseId == courseID                        

            //            select new
            //            {
            //                Id = course.typeId,
            //                CourseName = course.courseName,
            //                section = section.sectionName,
            //                Paper = paper.Papercode,
            //                QuestionID = question.QuesId,
            //                question=question.QuesName,
            //                optionsID = options.optionID,
            //                options=options.QuesName,

            //            }).ToListAsync();
            //return Ok(await quiz);


        }
    }
}
