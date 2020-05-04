using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChatApp.API.Data;
using Microsoft.AspNetCore.Mvc;

namespace ChatApp.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]

public class ValuesController : ControllerBase
{
	private readonly DataContext _context;
	public ValuesController(DataContext context)
	{
		_context = context;
	}
	[HttpGet]
	public IActionResult GetValues()
{
	var values = _context.Values.ToList();
	return Ok(values);
}
	[HttpGet("{id}")]
	public IActionResult GetValue(int id)
{
	var value = _context.Values.FirstOrDefault(x => x.id == id);
	return Ok(value);
}	
[HttpPost]
	public void post([FromBody] string value)
{
}
	[HttpPut]
	public void Put(int id,[FromBody] string value)
{
}

	[HttpDelete ("{id}")]
	public void Delete(int id)
{
}
}
}