using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MOCKAPP.Server.Data;
using MOCKAPP.Server.Model;

namespace MOCKAPP.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateExamController : ControllerBase
    {
        private readonly Dbcontext _context;
        public CreateExamController(Dbcontext context)
        {
            _context = context;
        }

        [HttpGet, Authorize(Roles = "Admin")]
        [Route("CourseType")]
        public async Task<IActionResult> GetType()
        {
            var type = await _context.coursetype.ToListAsync();
            return Ok(type);
        }

        [HttpGet]
        [Route("Course")]
        public async Task<IActionResult> Getcourse()
        {
            var type = await _context.course.ToListAsync();
            return Ok(type);
        }

        [HttpGet]
        [Route("Section")]
        public async Task<IActionResult> Getsection()
        {
            var type = await _context.section.ToListAsync();
            return Ok(type);
        }

        [HttpGet]
        [Route("Question")]
        public async Task<IActionResult> GetQuestion()
        {
            var type = await _context.Question.ToListAsync();
            return Ok(type);
        }

        [HttpGet]
        [Route("Options")]
        public async Task<IActionResult> GetOption()
        {
            var type = await _context.Options.ToListAsync();
            return Ok(type);
        }

        [HttpGet]
        [Route("Paper")]
        public async Task<IActionResult> GetPaper()
        {
            var type = await _context.Paper.ToListAsync();
            return Ok(type);
        }

        [HttpGet]
        [Route("Schedule")]
        public async Task<IActionResult> GetSchedule()
        {
            var type = await _context.Schedule.ToListAsync();
            return Ok(type);
        }

        [HttpPost]
        [Route("CreateType")]
        public async Task<ActionResult<coursetype>> CreateType(coursetype type)
        {
            _context.coursetype.Add(type);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetType), new
            {
                id = type.typeId
            }, type);
        }
        
        [HttpPost]
        [Route("CreateCourse")]
        public async Task<ActionResult<course>> CreateCourse(course course)
        {
            _context.course.Add(course);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(Getcourse), new
            {
                id = course.courseId
            }, course);
        }

        [HttpPost]
        [Route("Section")]
        public async Task<ActionResult<section>> CreateSection(section section)
        {
            _context.section.Add(section);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(Getsection), new
            {
                id = section.sectionId
            }, section);
        }

        [HttpPost]
        [Route("Questions")]
        public async Task<ActionResult<Question>> CreateQuestions(Question Question)
        {
            _context.Question.Add(Question);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetQuestion), new
            {
                id = Question.QuesId
            }, Question);
        }

        [HttpPost]
        [Route("options")]
        public async Task<ActionResult<Options>> Createoptions(Options Options)
        {
            _context.Options.Add(Options);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetOption), new
            {
                id = Options.optionID
            }, Options);
        }

        [HttpPost]
        [Route("Schedule")]
        public async Task<ActionResult<Schedule>> CreateSchedule(Schedule Schedule)
        {
            _context.Schedule.Add(Schedule);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetSchedule), new
            {
                id = Schedule.ScheduleId
            }, Schedule);
        }
        
        [HttpPost]
        [Route("Paper")]
        public async Task<ActionResult<Paper>> CreatePaper(Paper Paper)
        {
            _context.Paper.Add(Paper);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetPaper), new
            {
                id = Paper.PaperID
            }, Paper);
        }
    }
}
