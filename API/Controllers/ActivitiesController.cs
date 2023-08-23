using Application;
using Application.Activities;
using Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [AllowAnonymous]
    public class ActivitiesController: BaseApiController
    {
        [HttpGet] //api/activities
        public async Task<IActionResult> GetActivities()
        {
            var result = await Mediator.Send(new List.Query());
            return HandleResult(result);
        }

        [HttpGet("{id}")] //api/activities/{id}
        public async Task<IActionResult> GetActivity(Guid id)
        {
            var result =  await Mediator.Send(new Details.Query(id));
            return HandleResult(result);
        }

        [HttpPost] //api/activities/
        public async Task<ActionResult> CreateActivity(Activity activity)
        {
            var result = await Mediator.Send(new Create.Command(activity));
            return HandleResult(result);
        }

        [HttpPut("{id}")] //api/activities/{id}
        public async Task<ActionResult> EditActivity(Guid id, Activity activity)
        {
            activity.Id = id;
            var result = await Mediator.Send(new Edit.Command(activity));
            return HandleResult(result);
        }

        [HttpDelete("{id}")] //api/activities/{id}
        public async Task<ActionResult> DeleteActivity(Guid id)
        {
            var result = await Mediator.Send(new Delete.Command(id));
            return HandleResult(result);
        }
    }
}