

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.ObjectPool;

namespace LazarB_SayHelloEndpoint.Controllers;
[ApiController]
[Route("controller")]

public class SayHello : ControllerBase{
    public List<string> GreetUser = new();

public SayHello()
    {
     
    }

    [HttpGet]
    [Route("GreetUser")]
    public List<string> GetName(){
        return GreetUser;
    } 


    [HttpPost]
    [Route("AddName/{yourName}")]

    public List<string> AddName(string yourName){
        GreetUser.Add("Hello, " + yourName);
        return GreetUser;
    }


}
    

