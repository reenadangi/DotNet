using Microsoft.AspNetCore.Mvc;
public class HelloController:Controller{
[Route("")]
public ViewResult Index(){
    // ViewResult myView=View();
    // return "Hello Bello";
    return View();
}
[Route("profile{name}")]
// Mostly after form submition
public IActionResult Profile(string name){
    return RedirectToAction("Profile",new {name=name});
}


}