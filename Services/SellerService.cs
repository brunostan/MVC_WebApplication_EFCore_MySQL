﻿using MVC_WebApplication.Data;
using MVC_WebApplication.Models;

namespace MVC_WebApplication.Services
{
    public class SellerService
    {
        private readonly MVC_WebApplicationContext _context;

        public SellerService(MVC_WebApplicationContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller seller)
        {
            _context.Add(seller);
            _context.SaveChanges();
        }
    }
}
