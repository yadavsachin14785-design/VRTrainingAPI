using Microsoft.AspNetCore.Mvc;
using VRTraining.Data;
using VRTraining.Models;

namespace VRTraining.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QuizController : ControllerBase
    {
        private readonly AppDbContext _context;

        public QuizController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Quiz
        [HttpGet]
        public IActionResult GetResults()
        {
            try
            {
                var results = _context.quiz_results.ToList();
                return Ok(results);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET: api/Quiz/5
        [HttpGet("{id}")]
        public IActionResult GetResult(int id)
        {
            try
            {
                var result = _context.quiz_results.FirstOrDefault(x => x.Id == id);

                if (result == null)
                    return NotFound();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST: api/Quiz
        [HttpPost]
        public IActionResult SaveResult([FromBody] QuizResult result)
        {
            try
            {
                _context.quiz_results.Add(result);
                _context.SaveChanges();

                return Ok("Quiz Result Saved Successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE: api/Quiz/5
        [HttpDelete("{id}")]
        public IActionResult DeleteResult(int id)
        {
            try
            {
                var result = _context.quiz_results.FirstOrDefault(x => x.Id == id);

                if (result == null)
                    return NotFound();

                _context.quiz_results.Remove(result);
                _context.SaveChanges();

                return Ok("Result Deleted Successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}