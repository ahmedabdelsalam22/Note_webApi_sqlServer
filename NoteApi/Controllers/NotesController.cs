﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NoteApi.Dtos;
using NoteApi.Models;

namespace NoteApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public NotesController(ApplicationDbContext context)
        {
            _context = context;
        }


      //  [HttpPost]

        //public async Task<IActionResult> createAsync(NoteDto dto) 
        //{
        //    Note note = new Note 
        //    {
        //      Id= dto.Id,
        //      Content= dto.Content,
        //      Title= dto.Title,
        //    };
        //}


    }
}
