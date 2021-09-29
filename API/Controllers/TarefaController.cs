using System;
using System.Collections.Generic;
using System.Linq;
using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/tarefa")]
    public class TarefaController : ControllerBase
    {
        private readonly DataContext _context;
        public TarefaController(DataContext context)
        {
            _context = context;
        }

        //POST: api/tarefa/create
        [HttpPost]
        [Route("create")]
        public IActionResult Create([FromBody] Tarefa tarefa)
        {
            _context.Tarefas.Add(tarefa);
            _context.SaveChanges();
            return Created("", tarefa);
        }

        //GET: api/tarefa/list
        [HttpGet]
        [Route("list")]
        public IActionResult List() => Ok(_context.Tarefas.ToList());

       
    }
}