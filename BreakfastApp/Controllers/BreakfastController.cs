using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("breakfasts")]
public class BreakfastsController : ControllerBase
{
    [HttpPost()]
    public IActionResult CreateBreakfast(CreateBreakfastRequest request)
    {
        // Create a new breakfast
        return Ok(request);
 
 
   }

   [HttpGet("{id:guid}")]
    public IActionResult GetBreakfast(Guid id)
    {
        // Get a breakfast by id
        return Ok(id);
    }

    [HttpPut("{id:guid}")]
    public IActionResult UpsertBreakfast(Guid id, UpsertBreakfastResponse request)
    {
        // Update a breakfast by id
        return Ok(request);
    }

    [HttpDelete("{id:guid}")]
    public IActionResult DeleteBreakfast(Guid id)
    {
        // Delete a breakfast by id
        return Ok(id);
    }
}