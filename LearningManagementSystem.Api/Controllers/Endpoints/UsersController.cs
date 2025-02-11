﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using LearningManagementSystem.DataBase.Models;
using LearningManagementSystem.DataBase.Data;
using LearningManagementSystem.Domain.Service.UsersServices;
using LearningManagementSystem.Domain.ViewModels;
using LearningManagementSystem.DataBase.Migrations;

namespace LearningManagementSystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet("HelloWorld")]
        public IActionResult HelloWorld()
        {
            return Ok("Hello Worlds");
        }

        [HttpGet("GetStudents")]
        public IActionResult GetStudents()
        {
            var items = _userRepository.GetStudents();

            return Ok(items);
        }

        [HttpGet("GetInstructors")]
        public IActionResult GetInstructors()
        {
            var items = _userRepository.GetInstructors();

            return Ok(items);
        }

        [HttpGet("GetStudent/{id}")]
        public IActionResult GetStudent(string id)
        {
            var items = _userRepository.GetStudent(id);

            return Ok(items);
        }

        [HttpGet("GetInstructor/{id}")]
        public IActionResult GetInstructor(string id)
        {
            var items = _userRepository.GetInstructor(id);

            return Ok(items);
        }

        [HttpPost("Register")]
        public IActionResult CreateUser(UsersViewModels user)
        {
            var items = _userRepository.CreateUser(user);

            return Ok(items);
        }

    }
}
