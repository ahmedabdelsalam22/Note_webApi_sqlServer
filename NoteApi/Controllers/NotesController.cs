﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NoteApi.Dtos;
using NoteApi.Models;
using static System.Reflection.Metadata.BlobBuilder;

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



        [HttpGet("gellAllNotes")]
        public async Task<IActionResult> GetAllAsync() 
        {
            var note =await _context.Notes.OrderBy(m=>m.Title).ToListAsync();

            if (note == null) return NotFound("No Notes found");


            return Ok(note);
        }



        [HttpPost]

        public async Task<IActionResult> CreateAsync(NoteDto dto)
        {
            Note note = new Note
            {
                Id = dto.Id,
                Content = dto.Content,
                Title = dto.Title,
                Time = dto.Time,
                Date = dto.Date,
            };

            await _context.Notes.AddAsync(note);
            _context.SaveChanges();
             return Ok(note);
        }




    }
}
