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
[HttpGet("allNinja")]
public IActionResult AllNinja(){
    List<Ninja> ninjas=new List<Ninja>();
    ninjas.Add(new Ninja("Reena","dangi","Java","On"));
    ninjas.Add(new Ninja("Re","dangi","Python","On"));
    ninjas.Add(new Ninja("R","dangi","C#","On"));
    ninjas.Add(new Ninja("na","dangi","Javascript","On"));
    return View("AllNinja",ninjas);

}
[HttpPost("profile")]
// Mostly after form submition
public IActionResult Profile(Ninja newNinja){
    // Console.WriteLine(Login+Password+Track+IsDojo);
    // Ninja Ninja=new Ninja(){
    //     Name=Login,
    //     Password=Password,
    //     Track=Track,
    //     IsDojo
    // };
    Console.WriteLine(newNinja.Name+newNinja.Password+newNinja.IsDojo+newNinja.Track);
    ViewBag.Ninja=newNinja;
    
    return View("Profile",newNinja);
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