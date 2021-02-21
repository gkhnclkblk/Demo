using AutoMapper;
using Demo.Business.Interfaces;
using Demo.DTO.DTOs.CategoryDtos;
using Demo.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.UI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService categoryService,IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            return View(_mapper.Map<List<CategoryListDto>>(await _categoryService.GetAllAsync()));
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CategoryAddDto categoryAddDto)
        {
            await _categoryService.AddAsync(_mapper.Map<Category>(categoryAddDto));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var updatedCategory = _mapper.Map<CategoryUpdateDto>(await _categoryService.FindByIdAsync(id));
            return View(updatedCategory);
        }

        [HttpPost]
        public async Task<IActionResult> Update(CategoryUpdateDto categoryUpdateDto)
        {
            await _categoryService.UpdateAsync(_mapper.Map<Category>(categoryUpdateDto));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Remove(int id)
        {
            await _categoryService.RemoveAsync(new Category { Id = id });
            return RedirectToAction("Index");
        }
    }
}
