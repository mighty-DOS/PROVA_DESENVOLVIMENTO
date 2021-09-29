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

        //GET: api/tarefa/getbyid/1
        [HttpGet]
        [Route("getbyid/{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            Tarefa tarefa = _context.Tarefas.Find(id);
            if (tarefa == null)
            {
                return NotFound();
            }
            return Ok(tarefa);
        }

        //DELETE: /api/tarefa/delete/bolacha
        [HttpDelete]
        [Route("delete/{name}")]
        public IActionResult Delete([FromRoute] string name)
        {

            Tarefa tarefa = _context.Tarefas.FirstOrDefault(tarefa => tarefa.Nome == name);

            if (tarefa == null)
            {
                return NotFound();
            }
            _context.Tarefas.Remove(tarefa);
            _context.SaveChanges();
            return Ok(_context.Tarefas.ToList());
        }


        //PUT: api/tarefa/update
        [HttpPut]
        [Route("update")]
        public IActionResult Update([FromBody] Tarefa tarefa)
        {
            _context.Tarefas.Update(tarefa);
            _context.SaveChanges();
            return Ok(tarefa);
        }
    }
}