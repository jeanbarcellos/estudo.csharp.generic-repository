using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using GenericRepository.Models;
using GenericRepository.Repositories;

namespace GenericRepository.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private IRepository<Book> _bookRepository;

        public BookController(IRepository<Book> bookRepository)
        {
            _bookRepository = bookRepository;
        }

        [HttpGet]
        [Route("")]
        public IEnumerable<Book> GetAllBooks() => _bookRepository.GetAll();

        [HttpPost]
        [Route("")]
        [AllowAnonymous]
        public void InsertBook([FromBody] Book book) => _bookRepository.Insert(book);

        [HttpGet]
        [Route("{id}")]
        public Book GetBookById(Guid id) => _bookRepository.GetById(id);

        [HttpPut]
        [Route("{id}")]
        [AllowAnonymous]
        public void UpdateBook([FromBody] Book book) => _bookRepository.Update(book);

        [HttpDelete]
        [Route("{id}")]
        [AllowAnonymous]
        public void DeleteBook(Guid id) => _bookRepository.Delete(id);
    }
}