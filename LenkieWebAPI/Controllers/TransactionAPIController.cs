﻿using AutoMapper;
using LenkieWebAPI.Data;
using LenkieWebAPI.Models;
using LenkieWebAPI.Models.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LenkieWebAPI.Controllers
{
    [Route("api/transactionAPI")]
    [ApiController]
    [Authorize]
    public class TransactionAPIController : ControllerBase
    {
        private readonly AppDbContext _db;
        private ResponseDTO _response;
        private IMapper _mapper;

        public TransactionAPIController(AppDbContext db, IMapper mapper)
        {
            _db = db;
            _response = new ResponseDTO();
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetBookReseversationTracking")]
        public ResponseDTO GetBookReseversationTracking()
        {
            try
            {
                IEnumerable<BookReservationTracking> objList = _db.BookReservationTracking.ToList();
                _response.Result = _mapper.Map<IEnumerable<BookReservationTrackingDTO>>(objList); ;
            }
            catch (Exception ex)
            {
                _response.IsSuccessful = false;
                _response.Message = ex.Message;
            }

            return _response;
        }

        [HttpGet]
        [Route("GetBorrowedBooks")]
        public ResponseDTO GetBorrowedBooks()
        {
            try
            {
                IEnumerable<BorrowedBook> objList = _db.BorrowedBooks.ToList();
                _response.Result = _mapper.Map<IEnumerable<BorrowedBookDTO>>(objList); ;
            }
            catch (Exception ex)
            {
                _response.IsSuccessful = false;
                _response.Message = ex.Message;
            }

            return _response;
        }

        [HttpPost]
        [Route("AssignBook")]
        [Authorize(Roles = "ADMIN")]
        public async Task<ResponseDTO> PostAsync([FromBody] BorrowedBookDTO borrowedBookDTO)
        {
            try
            {
                //Search if book exists
                var bookFromDB = await _db.Books.AsNoTracking().FirstOrDefaultAsync(book => book.BookId == borrowedBookDTO.BookId);

                if (bookFromDB.InventoryCount > 1)
                {
                    //Reserve Book if there's an inventory
                    BorrowedBook obj = _mapper.Map<BorrowedBook>(borrowedBookDTO);
                    _db.BorrowedBooks.Add(obj);

                    bookFromDB.InventoryCount--;
                    _db.Books.Update(bookFromDB);

                    _db.SaveChanges();
                    _response.Result = _mapper.Map<BorrowedBookDTO>(obj);
                }

            }
            catch (Exception ex)
            {
                _response.IsSuccessful = false;
                _response.Message = ex.Message;
            }

            return _response;
        }

        [HttpPost]
        [Route("ReserveBook")]
        [Authorize(Roles = "ADMIN")]
        public async Task<ResponseDTO> PostAsync([FromBody] BookReservationTrackingDTO bookReservationTrackingDTO)
        {
            try
            {
                //Search if book exists
                var bookFromDB = await _db.Books.AsNoTracking().FirstOrDefaultAsync(book => book.BookId == bookReservationTrackingDTO.BookId);

                if (bookFromDB == null)
                {

                }

                if (bookFromDB.InventoryCount > 1)
                {
                    //Reserve Book if there's an inventory count > 1
                    BookReservationTracking obj = _mapper.Map<BookReservationTracking>(bookReservationTrackingDTO);
                    _db.BookReservationTracking.Add(obj);

                    bookFromDB.InventoryCount--;
                    _db.Books.Update(bookFromDB);

                    _db.SaveChanges();
                    _response.Result = _mapper.Map<BookReservationTrackingDTO>(obj);
                }
                
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
