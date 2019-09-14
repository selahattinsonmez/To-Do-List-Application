using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;
using TODOListApplication.Models;

namespace TODOListApplication.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            StaticVariables.User = null;

            return View();
        }

        [HttpPost]
        public IActionResult Index(User user, String submitButton)
        {
            StaticVariables.User = null;    
            Boolean control = true;

            if(submitButton == "register")
            {

                if (!Register(user))
                {
                    control = false;
                }

            }
            else
            {

                user= login(user);
                StaticVariables.User = user;
                if( user.userName== null && StaticVariables.User == null )
                {
                    control = false;
                }
            }
            int a= 5;

            if (control)
            {
                return RedirectToAction("Index", "ShowLists");
            }
            else
            {
                return View();

            }
        }
        public Boolean Register(User user)
        {
            RestClient client = new RestClient(StaticVariables.url);
            RestRequest request = new RestRequest("/user/Register");
            request.Method = Method.POST;
            request.RequestFormat = DataFormat.Json;
            request.AddBody(user);
            request.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };


            var response = client.Execute<Boolean>(request);
            return JsonConvert.DeserializeObject<Boolean>(response.Content);
        }
        public User login(User user)
        {
            RestClient client = new RestClient(StaticVariables.url);
            RestRequest request = new RestRequest("/user/Login");
            request.Method = Method.POST;
            request.RequestFormat = DataFormat.Json;
            request.AddBody(user);
            request.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };


            var response = client.Execute<User>(request);
            return JsonConvert.DeserializeObject<User>(response.Content);
        }
    }
}