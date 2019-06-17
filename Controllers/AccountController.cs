    
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Patitas.Data;
using Patitas.Models;
namespace Patitas.Controllers
{
    public class AccountController:Controller
    {
      private MascotaContext _context; //el contexto 

      public AccountController (MascotaContext c){ //el constructor del contexto
            _context = c;

      }
  
    public IActionResult RecuperarContraseña()
    {
      //TODO: Implement Realistic Implementation
      return View();
    }

        //ESTA ES LA FICHA DE REGISTRO para obtener los datos del adoptante
        public IActionResult Register(){
            return View();
        }
        
        [HttpPost]
        public IActionResult Register(string correo, string nombre, string pass, string direccion){
            TempData["correo"]=correo;
            TempData["nombre"]=nombre;
            TempData["pass"]=pass;
            TempData["direccion"]=direccion;

        
         return RedirectToAction("ConfirmarRegistro");
        }

        //PARA CONFIRMAR EL REGISTRO DEL USUARIO
        public IActionResult ConfirmarRegistro(){
            return View();
        }



         public IActionResult Login(){
            return View();
         }
        
        //  public IActionResult Login(string u, string p){
        //       //  if(u=="") aca el condicional de correo y clave 
            
        //     ViewBag.Error="Datos Incorrectos";
        //     return View();
        // }
        // //


    }    
}