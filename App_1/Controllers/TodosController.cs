﻿using Microsoft.AspNetCore.Mvc;
//using System.Colloctions.Generic;

using App_1.Models;
using App_1.Services;

namespace App_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {

        private TodoService _todoService;

        public TodosController()
        {
            _todoService = new TodoService();

        }

        [HttpGet("{id?}")]

        public IActionResult GetTodos(int? id)
        {
            var myTodos = _todoService.AllTodos();

            if (id is null) return Ok(myTodos);


            myTodos = myTodos.Where(t => t.Id == id).ToList();
            return Ok(myTodos);
        }

         //Get Todos



    }
}
