using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using StewartsBlinds.Data;
using StewartsBlinds.Data.Entities;
using StewartsBlinds.Models;

namespace StewartsBlinds.Controllers
{
    [Authorize]
    public class ConfigurationController : Controller
    {
        private ApplicationDbContext context;

        public ConfigurationController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index(ProductType SelectedProductType, String SelectedField, Char? SelectedLetter)
        {
            if(String.IsNullOrEmpty(SelectedField))
            {
                SelectedField = context.ConfigurationOptions.Where(x => x.ProductType == SelectedProductType).Select(x => x.FieldName).Distinct().First();
            }

            var viewModel = new ConfigurationViewModel
            {
                SelectedProductType = SelectedProductType,
                SelectedField = SelectedField,
                SelectedLetter = SelectedLetter,
                Options = context.ConfigurationOptions.Where(x => x.ProductType == SelectedProductType).ToList()
            };
            return View(viewModel);
        }
        
        public IActionResult AddOption(ConfigurationOption option)
        {
            context.ConfigurationOptions.Add(option);
            context.SaveChanges();
            return RedirectToAction("Options");
        }

        public IActionResult AddOptions(ProductType SelectedProductType, String SelectedField)
        {
            var viewModel = new AddConfigurationOptionsViewModel()
            {
                SelectedProductType = SelectedProductType,
                SelectedField = SelectedField
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult AddOptions(ProductType SelectedProductType, String SelectedField, String NewOptions)
        {
            var newOptionsList = NewOptions.Split(",").Select(x => new ConfigurationOption { FieldName = SelectedField, Name = x, ProductType = SelectedProductType }).ToList();
            context.ConfigurationOptions.AddRange(newOptionsList);
            context.SaveChanges();
            
            return RedirectToAction("Index", new { SelectedProductType, SelectedField });
        }

        [HttpPost]
        public IActionResult DeleteOptions(ProductType SelectedProductType, String SelectedField, List<int> SelectedOptions)
        {
            var optionsToDelete = context.ConfigurationOptions.Where(x => SelectedOptions.Contains(x.Id));
            context.ConfigurationOptions.RemoveRange(optionsToDelete);
            context.SaveChanges();

            return RedirectToAction("Index", new { SelectedProductType, SelectedField });
        }
    }
}