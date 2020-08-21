using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shop.Models;
using Shop.Repositories;
using Shop.Services;

namespace Shop.Controllers
{
   [ApiController] 
   [Route("v1/account")]
   public class HomeController : ControllerBase  
   {
      [HttpPost]
      [Route("login")]
      public ActionResult<dynamic> Authenticate([FromBody] User model)
      {
         var user = UserRepository.Get(model.Username, model.Password);

         if(user == null)
            return NotFound(new { message = "Usuário ou senha inválidos"});
         
         var token = TokenService.GenerateToken(user);
         user.Password = "******";
         return new {
            user,
            token
         };
      }


      [HttpGet]
      [Route("anonymous")]
      [AllowAnonymous]
      public string Anonymous() => "Anônimo";

      [HttpGet]
      [Route("authenticated")]
      [Authorize]
      public string Authenticated() => String.Format("Autenticado - {0}", User.Identity.Name);

      [HttpGet]
      [Route("employee")]
      [Authorize(Roles = "employee,manager")]
      public string Employee() => "Funcionário";

      [HttpGet]
      [Route("manager")]
      [Authorize(Roles = "manager")]
      public string Manager() => "Gerente";

      
   }
}