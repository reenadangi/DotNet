using Microsoft.AspNetCore.Mvc;
public class HelloController:Controller{
    // localhost:5000
    [Route("")]
    public string index(){
        return "Hello From controller";
    }
}