using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using NLayerProject.API.DTOs.ErrorDTOs;
using NLayerProject.Core.Models;
using NLayerProject.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NLayerProject.API.Filters
{
    public class NotFoundFilter : ActionFilterAttribute
    {
        private readonly IProductService _productService;
        //private readonly IService<Product> _productService;


        public NotFoundFilter(IProductService productService)
        {
            _productService = productService;
        }

        public async override Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var id = (int)context.ActionArguments.Values.FirstOrDefault();

            var product = await _productService.GetByIdAsync(id);

            if (product != null)
                await next();
            else
            {
                var errorDto = new ErrorDto();
                errorDto.Status = 404; //Not Found

                errorDto.Errors.Add($"Id'si {id} olan kayıt veritabanında bulunamadı.");

                context.Result = new NotFoundObjectResult(errorDto);
            }
        }
    }
}
