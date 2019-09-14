using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;
using TODOListApplication.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TODOListApplication.Controllers
{
    public class ShowListsController : Controller
    {
        public IActionResult Index()
        {
            if (Models.StaticVariables.User == null)
            {
                return RedirectToAction("Index", "Home");

            }


            return View(getLists());
        }
        public ActionResult indexButtons(String button,long id)
        {
            if (Models.StaticVariables.User == null)
            {
                return RedirectToAction("Index", "Home");

            }
            if (button == "complete")
            {
                if (!changeStatus(id)){
                    ViewBag.Message = ("This item has dependency");
                    return RedirectToAction("Index","ShowLists");
                }
            }
            else
            {
                deleteİtem(id);

            }


            return RedirectToAction("Index", "ShowLists");
        }

        [HttpGet]
        public ActionResult showList(long listId)
        {
            if (Models.StaticVariables.User == null)
            {
                return RedirectToAction("Index", "Home");

            }

            return View(getList(listId));
        }
        [HttpPost]
        public ActionResult showList(String submitButton,String itemName, long listId)
        {
            if (Models.StaticVariables.User == null)
            {
                return RedirectToAction("Index", "Home");

            }
            Models.ListAndItemDTO listAndItemDTO = new ListAndItemDTO();

            if (submitButton == "trueStatus")
            {
                RestClient client = new RestClient(Models.StaticVariables.url);
                RestRequest request = new RestRequest("/item/filterByStatusTrue/" + listId);
                request.Method = Method.POST;


                var response = client.Execute(request);

                listAndItemDTO = JsonConvert.DeserializeObject<ListAndItemDTO>(response.Content);
            }
            else if(submitButton == "falseStatus")
            {
                RestClient client = new RestClient(Models.StaticVariables.url);
                RestRequest request = new RestRequest("/item/filterByStatusFalse/" + listId);
                request.Method = Method.POST;


                var response = client.Execute(request);

                listAndItemDTO = JsonConvert.DeserializeObject<ListAndItemDTO>(response.Content);
            }
            else if (submitButton == "trueExpired")
            {
                RestClient client = new RestClient(Models.StaticVariables.url);
                RestRequest request = new RestRequest("/item/filterByExpiredTrue/" + listId);
                request.Method = Method.POST;


                var response = client.Execute(request);

                listAndItemDTO = JsonConvert.DeserializeObject<ListAndItemDTO>(response.Content);
            }
            else if (submitButton == "falseExpired")
            {
                RestClient client = new RestClient(Models.StaticVariables.url);
                RestRequest request = new RestRequest("/item/filterByExpiredFalse/" + listId);
                request.Method = Method.POST;


                var response = client.Execute(request);

                listAndItemDTO = JsonConvert.DeserializeObject<ListAndItemDTO>(response.Content);
            }
            else if (submitButton == "complete")
            {
                RestClient client = new RestClient(Models.StaticVariables.url);
                RestRequest request = new RestRequest("/item/orderByStatus/" + listId);
                request.Method = Method.POST;


                var response = client.Execute<ListAndItemDTO>(request);

                listAndItemDTO = JsonConvert.DeserializeObject<ListAndItemDTO>(response.Content);
            }
            else if (submitButton == "itemname")
            {
                RestClient client = new RestClient(Models.StaticVariables.url);
                RestRequest request = new RestRequest("/item/orderByItemName/" + listId);
                request.Method = Method.POST;


                var response = client.Execute(request);

                listAndItemDTO = JsonConvert.DeserializeObject<ListAndItemDTO>(response.Content);
            }
            else if (submitButton == "deadline")
            {
                RestClient client = new RestClient(Models.StaticVariables.url);
                RestRequest request = new RestRequest("/item/orderByDeadline/" + listId);
                request.Method = Method.POST;


                var response = client.Execute(request);

                listAndItemDTO = JsonConvert.DeserializeObject<ListAndItemDTO>(response.Content);
            }
            else if (submitButton == "name")
            {
                filterByNameDTO filter = new filterByNameDTO();
                RestClient client = new RestClient(Models.StaticVariables.url);
                RestRequest request = new RestRequest("/item/filterByItemName/");
                request.Method = Method.POST;
                request.RequestFormat = DataFormat.Json;
                filter.listId = listId;
                filter.itemName = itemName;
                request.AddBody(filter);
                request.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };

                var response = client.Execute<ListAndItemDTO>(request);

                listAndItemDTO = JsonConvert.DeserializeObject<ListAndItemDTO>(response.Content);
            }
            if (listAndItemDTO.listName!=null)
            {
                return View(listAndItemDTO);

            }
            else
            {
                return View(getList(listId));

            }
        }


        public ActionResult deleteList(long listId)
        {

            RestClient client = new RestClient(Models.StaticVariables.url);
            RestRequest request = new RestRequest("/list/deleteList/" + listId);

            request.Method = Method.POST;


            client.Execute(request);
            return RedirectToAction("Index", "ShowLists");
        }
        public Boolean changeStatus(long id)
        {
            if (!checkDependency(id))
            {
                return false;

            }
            RestClient client = new RestClient(Models.StaticVariables.url);
            RestRequest request = new RestRequest("/item/changeStatus/" +id);
            
            request.Method = Method.POST;


            client.Execute(request);
            return true;

        }
        public Boolean checkDependency(long id)
        {
            RestClient client = new RestClient(Models.StaticVariables.url);
            RestRequest request = new RestRequest("/item/checkDependency/" + id);
            request.Method = Method.POST;


            var response = client.Execute(request);

            var result = JsonConvert.DeserializeObject<Boolean>(response.Content);
            return result;
        }
        public void deleteİtem(long id)
        {
            RestClient client = new RestClient(Models.StaticVariables.url);
            RestRequest request = new RestRequest("/item/deleteItem/" + id);

            request.Method = Method.POST;


            client.Execute(request);

        }
        public Models.ListAndItemDTO getList(long listId)
        {
            RestClient client = new RestClient(Models.StaticVariables.url);
            RestRequest request = new RestRequest("/list/getListById/" + listId);
            request.Method = Method.POST;


            var response = client.Execute(request);

            var result = JsonConvert.DeserializeObject<ListAndItemDTO>(response.Content);
            return result;


        }
        public List<Models.ListAndItemDTO> getLists()
        {
            RestClient client = new RestClient(Models.StaticVariables.url);
            RestRequest request = new RestRequest("/list/getAllListsByUserName/" + Models.StaticVariables.User.userName);
            request.Method = Method.POST;  


            var response = client.Execute<List<Models.ListAndItemDTO>>(request);
            
            var result= JsonConvert.DeserializeObject<List<Models.ListAndItemDTO>>(response.Content);
            return result;
        }   
    }
}
