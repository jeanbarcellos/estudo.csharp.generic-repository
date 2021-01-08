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
        private IRepository<Book> bookRepository;

        public BookController(IRepository<Book> bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        [HttpGet]
        [Route("")]
        public IEnumerable<Book> GetAllBooks() => bookRepository.GetAll();

        [HttpGet]
        [Route("{id}")]
        public Book GetBookById(Guid id) => bookRepository.GetById(id);

        [HttpPost]
        [Route("")]
        [AllowAnonymous]
        public void AddBook([FromBody] Book book) => bookRepository.Insert(book);

        [HttpPut]
        [Route("{id}")]
        [AllowAnonymous]
        public void UpdateBook([FromBody] Book book) => bookRepository.Update(book);

        [HttpDelete]
        [Route("{id}")]
        [AllowAnonymous]
        public void DeleteBook(Guid id) => bookRepository.Delete(id);
    }
}