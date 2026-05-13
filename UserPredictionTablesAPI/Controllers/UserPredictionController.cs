using Business.Models;
using Business.Services;
using Data;
using Microsoft.AspNetCore.Mvc;

namespace UserPredictionTablesAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserPredictionController : Controller
{
   private readonly IPredictionTableService _predictionTableService;
   public UserPredictionController(IPredictionTableService predictionTableService)
   {
      _predictionTableService = predictionTableService;
   }

   [HttpPost]
   public async Task<IActionResult> CreatePredictionAsync(AddUserPredictionData data)
   {
      if (!ModelState.IsValid)
         return BadRequest(ModelState);
      
      var result = await _predictionTableService.CreatePredictionAsync(data);
      return result == true ? Ok(result) : BadRequest();
   }

   [HttpGet("userId")]
   public async Task<IActionResult> GetUserPredictionAsync(string userId)
   {
      var predictions = await _predictionTableService.GetPredictionByUserIdAsync(userId);
      return predictions != null ? Ok(predictions) : NotFound();
   }

   [HttpPut]
   public async Task<IActionResult> UpdatePredictionAsync(UpdateUserPredictionData data)
   {
      if (!ModelState.IsValid)
         return BadRequest(ModelState);
      
      var result = await _predictionTableService.UpdatePredictionAsync(data);
      return result ? Ok(result) : BadRequest();
   }
}