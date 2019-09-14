using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;

namespace TODOListApplication.Controllers
{
    public class CreateController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            if (Models.StaticVariables.User == null)
            {
                return RedirectToAction("Index", "Home");

            }
            return View();
        }
        [HttpPost]
        public IActionResult Index(string listName)
        {
            if (Models.StaticVariables.User == null)
            {
                return RedirectToAction("Index", "Home");

            }
            if(listName == null)
            {
                return View();
            }
            Models.ToDoList toDoList = new Models.ToDoList();
            toDoList.listName = listName;
            toDoList.userId = Models.StaticVariables.User.userId;

            RestClient client = new RestClient(Models.StaticVariables.url);
            RestRequest request = new RestRequest("/list/saveList");
            request.Method = Method.POST;
            request.RequestFormat = DataFormat.Json;
            request.AddBody(toDoList);
            request.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
            var response = client.Execute<long>(request);
            var result = JsonConvert.DeserializeObject<long>(response.Content);

            return RedirectToAction("addItem","Create",new {listId = result });
        }
        [HttpGet]
        public IActionResult addItem(long listId)
        {
            ViewBag.listId = listId;
            return View(getItemsByListId(listId));

        }
        
        [HttpPost]
        public IActionResult addItem(String dependencyName,String itemName,String itemDescription,String itemDeadline,long listId)
        {
            if (itemName == null)
            {
                return View();
            }
            Models.itemAndDependency itemAndDependency = new Models.itemAndDependency();
            itemAndDependency.dependencyName = dependencyName;
            itemAndDependency.itemName = itemName;
            itemAndDependency.itemDescription = itemDescription;
            itemAndDependency.listId = listId;
            itemAndDependency.status = false;
            itemAndDependency.expired = false;
            if (itemAndDependency.dependencyName != "No")
            {
                itemAndDependency.dependency = true;
            }
            else
            {
                itemAndDependency.dependency = false;
            }

            itemAndDependency.itemDeadline = DateTime.Parse(itemDeadline);
            int a = 0;
            addItemWithDependency(itemAndDependency);


            return RedirectToAction("Index","ShowLists");
        }
        public void addItemWithDependency(Models.itemAndDependency item)
        {
            RestClient client = new RestClient(Models.StaticVariables.url);
            RestRequest request = new RestRequest("/item/addItemWithDependency");
            request.Method = Method.POST;
            request.RequestFormat = DataFormat.Json;
            request.AddBody(item);
            request.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };


            client.Execute(request);
        }
        public List<Models.ToDoItem> getItemsByListId(long listId)
        {
            RestClient client = new RestClient(Models.StaticVariables.url);
            RestRequest request = new RestRequest("/item/getItemsByListId/" + listId);
            request.Method = Method.POST;
            request.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
            request.RequestFormat = DataFormat.Json;


            var response = client.Execute<List<Models.ToDoItem>>(request);

            var result = JsonConvert.DeserializeObject<List<Models.ToDoItem>>(response.Content);
            return result;
        }

        


        public List<Models.ListAndItemDTO> getLists()
        {
            RestClient client = new RestClient(Models.StaticVariables.url);
            RestRequest request = new RestRequest("/list/getAllListsByUserName/" + Models.StaticVariables.User.userName);
            request.Method = Method.POST;


            var response = client.Execute<List<Models.ListAndItemDTO>>(request);

            var result = JsonConvert.DeserializeObject<List<Models.ListAndItemDTO>>(response.Content);
            return result;
        }
    }
}
