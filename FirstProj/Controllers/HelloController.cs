using Hello.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic; 
using System;
public class HelloController:Controller{
[Route("")]
[HttpGet]
public IActionResult Index(){
    // ViewResult myView=View();
    // return "Hello Bello";
    return View();
}

[HttpPost("profile")]
// Mostly after form submition
public IActionResult Profile(string Login,string Password,string track,string isDojo){
    Console.WriteLine(Login+Password+track+isDojo);
    Ninja Ninja=new Ninja(){
        Name=Login,
        Password=Password
    };
    ViewBag.Ninja=Ninja;
    
    return View("Profile");
}
[Route("profile/{name}")]
[HttpGet]
// Mostly after form submition
public IActionResult Profile(string name){
    Console.WriteLine("hello");
    string[] languages;
    // if(name.ToLower()=="rina"){
    //     languages=new string[]{"NodeJS","java","c#","python"};
    // }
    // else{
    //     languages=new string[]{"python","Java"};
    // }
    // ViewBag.Languages=languages;
    // ViewBag.Name=name;
    ViewBag.Ninja=new Ninja();
    
    
    return View("Profile");

    // return RedirectToAction("Profile");
}


}