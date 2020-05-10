using System;
namespace Hello.Models{
public class Ninja{
    public string Name{get;set;}
    // public string[] languages{get;set;}
    public string Password{get;set;}
    public string Track{get;set;}
    public string IsDojo{get;set;}
    public Ninja(){
        // Name="Dev";
        // languages=new string[]{"NodeJS","java","c#","python"};

    }
     public Ninja(string name,string password,string track,string isDojo){
        this.Name=name;
        this.Password=password;
        this.Track=track;
        this.IsDojo=isDojo;
    }


}
}