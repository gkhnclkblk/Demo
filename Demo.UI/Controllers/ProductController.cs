using AutoMapper;
using Demo.Business.Interfaces;
using Demo.DTO.DTOs.CategoryDtos;
using Demo.DTO.DTOs.ProductDtos;
using Demo.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.UI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        private readonly ICategoryService _categoryService;

        public ProductController(IProductService productService,IMapper mapper,ICategoryService categoryService)
        {
            _productService = productService;
            _mapper = mapper;
            _categoryService = categoryService;
        }
        public async Task<IActionResult> Index()
        {
            return View(_mapper.Map<List<ProductListDto>>(await _productService.GetWithCategoryAsync()));
        }

        public async Task<IActionResult> Create()
        {
            var categories = _mapper.Map<List<CategoryListDto>>(await _categoryService.GetAllAsync());
            return View(categories);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductAddDto productAddDto)
        {
            await _productService.AddAsync(_mapper.Map<Product>(productAddDto));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var updatedProduct = _mapper.Map<ProductUpdateDto>(await _productService.FindByIdAsync(id));

            updatedProduct.Categories = _mapper.Map<List<CategoryListDto>>(await _categoryService.GetAllAsync());
            return View(updatedProduct);
        }

        [HttpPost]
        public async Task<IActionResult> Update(ProductUpdateDto productUpdateDto)
        {
            await _productService.UpdateAsync(_mapper.Map<Product>(productUpdateDto));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Remove(int id)
        {
            await _productService.RemoveAsync(new Product { Id = id });
            return RedirectToAction("Index");
        }
    }
}
