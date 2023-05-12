using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using SuperWarriorsAPI.Services;
using WarriorLibrary;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace SuperWarriorsAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {

        private IProjectRepository __emprepo;

        public ProjectController(IProjectRepository emprepo)
        {
            __emprepo = emprepo;

        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await __emprepo.GetAll());
        }


        [HttpPut("UpdateProject")]
        public async Task<IActionResult> UpdateProject(int id, Project emp)
        {
            var project = await __emprepo.UpdateProject(id, emp);
            if (project != null)
            {
                return Ok(project);
            }
            return NotFound("not found");
        }

        [HttpPost("AddProject")]
        public async Task<IActionResult> AddProject(Project emp)
        {
            var aProject = await __emprepo.AddProject(emp);
            if (aProject != null)
            {
                return Ok(aProject);
            }
            return NotFound("not found");

        }

        [HttpDelete("DeleteProject")]

        public async Task<IActionResult> Delete(int id)
        {
            var deletePro = await __emprepo.DeleteProject(id);

            if (deletePro != null)
            {
                return Ok(deletePro);
            }
            return NotFound("not found");
        }
    }
}
