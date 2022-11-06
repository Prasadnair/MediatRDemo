﻿using MediatorDemo.Library.Models;
using MediatorDemo.Library.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MediatorDemo.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        IMediator _mediator;
       
        public StudentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<StudentModel>> Get()
        {
            return await _mediator.Send(new GetStudentsListQuery());
        }


    }
}