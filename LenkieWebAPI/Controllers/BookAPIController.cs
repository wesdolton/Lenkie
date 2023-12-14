using AutoMapper;
using LenkieWebAPI.Models.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static Azure.Core.HttpHeader;
using System;
using LenkieWebAPI.Data;
using LenkieWebAPI.Models;

namespace LenkieWebAPI.Controllers
{
    [Route("api/bookAPI")]
    [ApiController]
    [Authorize]
    public class BookAPIController : ControllerBase
    {
        private readonly BookDbContext _db;
        private ResponseDTO _response;
        private IMapper _mapper;

        public BookAPIController(BookDbContext db, IMapper mapper)
        {
            _db = db;
            _response = new ResponseDTO();
            _mapper = mapper;
        }

        [HttpGet]
        public ResponseDTO Get()
        {
            try
            {
                IEnumerable<Book> objList = _db.Books.ToList();
                _response.Result = _mapper.Map<IEnumerable<BookDTO>>(objList); ;
            }
            catch (Exception ex)
            {
                _response.IsSuccessful = false;
                _response.Message = ex.Message;
            }

            return _response;
        }

        [HttpGet]
        [Route("{id:int}")]
        public ResponseDTO Get(int id)
        {
            try
            {
                Book objList = _db.Books.FirstOrDefault(u => u.BookId == id);
                _response.Result = _mapper.Map<BookDTO>(objList); ;
            }
            catch (Exception ex)
            {
                _response.IsSuccessful = false;
                _response.Message = ex.Message;
            }

            return _response;
        }

        [HttpGet]
        [Route("GetByTitle/{title}")]
        public ResponseDTO Get(string title)
        {
            try
            {
                Book objList = _db.Books.First(u => u.BookName.ToLower() == title.ToLower());
                _response.Result = _mapper.Map<BookDTO>(objList);
            }
            catch (Exception ex)
            {
                _response.IsSuccessful = false;
                _response.Message = ex.Message;
            }

            return _response;
        }

        [HttpPost]
        [Authorize(Roles = "ADMIN")]
        public ResponseDTO Post([FromBody] BookDTO bookDTO)
        {
            try
            {
                Book obj = _mapper.Map<Book>(bookDTO);
                _db.Books.Add(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<BookDTO>(obj); ;
            }
            catch (Exception ex)
            {
                _response.IsSuccessful = false;
                _response.Message = ex.Message;
            }

            return _response;
        }

        [HttpPut]
        [Authorize(Roles = "ADMIN")]
        public ResponseDTO Put([FromBody] BookDTO bookDTO)
        {
            try
            {
                Book obj = _mapper.Map<Book>(bookDTO);
                _db.Books.Update(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<BookDTO>(obj); ;
            }
            catch (Exception ex)
            {
                _response.IsSuccessful = false;
                _response.Message = ex.Message;
            }

            return _response;
        }

        [HttpDelete]
        [Route("{id:int}")]
        [Authorize(Roles = "ADMIN")]
        public ResponseDTO Delete(int id)
        {
            try
            {
                Book obj = _db.Books.First(u => u.BookId == id);
                _db.Books.Remove(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<BookDTO>(obj); ;
            }
            catch (Exception ex)
            {
                _response.IsSuccessful = false;
                _response.Message = ex.Message;
            }

            return _response;
        }
    }
}
