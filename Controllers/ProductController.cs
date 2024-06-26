﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using MOCKAPP.Server.Data;
using MOCKAPP.Server.Model;

namespace MOCKAPP.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController, Authorize]
    public class ProductController : ControllerBase
    {

        private readonly Dbcontext _context;

        public ProductController(Dbcontext context)
        {
            _context = context;

        }
        //    [HttpGet]
        //    [Route("ProductsList")]
        //    public async Task<ActionResult<IEnumerable<Product>>> Get()
        //    {
        //        var productCache = new List<Product>();

        //        if (productCache == null)
        //        {
        //            var product = await _context.Products.ToListAsync();

        //        }
        //        return productCache;
        //    }
        //    [HttpGet]
        //    [Route("ProductDetail")]
        //    public async Task<ActionResult<Product>> Get(int id)
        //    {
        //        var productCache = new Product();
        //        var productCacheList = new List<Product>();

        //        productCache = productCacheList.Find(x => x.ProductId == id);
        //        if (productCache == null)
        //        {
        //            productCache = await _context.Products.FindAsync(id);
        //        }
        //        return productCache;
        //    }
        //    [HttpPost]
        //    [Route("CreateProduct")]
        //    public async Task<ActionResult<Product>> POST(Product product)
        //    {
        //        _context.Products.Add(product);
        //        await _context.SaveChangesAsync();
        //       // _cacheService.RemoveData("Product");
        //        return CreatedAtAction(nameof(Get), new
        //        {
        //            id = product.ProductId
        //        }, product);
        //    }
        //    [HttpPost]
        //    [Route("DeleteProduct")]
        //    public async Task<ActionResult<IEnumerable<Product>>> Delete(int id)
        //    {
        //        var product = await _context.Products.FindAsync(id);
        //        if (product == null)
        //        {
        //            return NotFound();
        //        }
        //        _context.Products.Remove(product);
        //       // _cacheService.RemoveData("Product");
        //        await _context.SaveChangesAsync();
        //        return await _context.Products.ToListAsync();
        //    }
        //    [HttpPost]
        //    [Route("UpdateProduct")]
        //    public async Task<ActionResult<IEnumerable<Product>>> Update(int id, Product product)
        //    {
        //        if (id != product.ProductId)
        //        {
        //            return BadRequest();
        //        }
        //        var productData = await _context.Products.FindAsync(id);
        //        if (productData == null)
        //        {
        //            return NotFound();
        //        }
        //        productData.ProductCost = product.ProductCost;
        //        productData.ProductDescription = product.ProductDescription;
        //        productData.ProductName = product.ProductName;
        //        productData.ProductStock = product.ProductStock;
        //       // _cacheService.RemoveData("Product");
        //        await _context.SaveChangesAsync();
        //        return await _context.Products.ToListAsync();
        //    }
        //}
    }
}

