package todolistserver.todolistserver.Controllers;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.MediaType;
import org.springframework.web.bind.annotation.*;
import todolistserver.todolistserver.DTOs.filterByNameDTO;
import todolistserver.todolistserver.DTOs.itemAndDependencyDTO;
import todolistserver.todolistserver.DTOs.itemAndDependencyNameDTO;
import todolistserver.todolistserver.DTOs.listAndItemDTO;
import todolistserver.todolistserver.Models.dependency;
import todolistserver.todolistserver.Models.toDoItem;

import todolistserver.todolistserver.Services.itemService;

import javax.transaction.Transactional;
import java.time.LocalDate;
import java.util.ArrayList;
import java.util.List;

@RestController
@RequestMapping("/item")
public class itemController {

    @Autowired
    itemService itemService;

    @RequestMapping(value = "/addItem",method = RequestMethod.POST,produces = MediaType.APPLICATION_JSON_UTF8_VALUE)
    public boolean addItem(@RequestBody List<toDoItem> toDoItems){
        return itemService.addItem(toDoItems);
    }



    @RequestMapping(value = "/saveItem",method = RequestMethod.POST,produces = MediaType.APPLICATION_JSON_UTF8_VALUE)
    public boolean saveItem(@RequestBody toDoItem toDoItem){
        return itemService.saveItem(toDoItem);
    }


    @Transactional
    @RequestMapping(value = "/deleteItem/{itemId}",method = RequestMethod.POST,produces = MediaType.APPLICATION_JSON_UTF8_VALUE)
    public void deleteItem(@PathVariable long itemId){
        itemService.deleteItem(itemId);
    }
    @RequestMapping(value = "/changeStatus/{itemId}",method = RequestMethod.POST,produces = MediaType.APPLICATION_JSON_UTF8_VALUE)
    public void changeStatus(@PathVariable long itemId){
        itemService.changeStatus(itemId);
    }
    @RequestMapping(value = "/addDependency",method = RequestMethod.POST,produces = MediaType.APPLICATION_JSON_UTF8_VALUE)
    public boolean addDependency(@RequestBody List<dependency> dependencies){
        return itemService.addDependency(dependencies);
    }
    @RequestMapping(value = "/getDependency/{itemId}",method = RequestMethod.POST,produces = MediaType.APPLICATION_JSON_UTF8_VALUE)
    public ArrayList<toDoItem> getDependency(@PathVariable long itemId){
        return itemService.getDependency(itemId);
    }

    @RequestMapping(value = "/deleteDependency",method = RequestMethod.POST)
    public void deleteDependency(@RequestBody dependency dependency){
        itemService.deleteDependency(dependency);
    }

    @RequestMapping(value = "/getAllItems",method = RequestMethod.POST)
    public List<toDoItem> getAllItems(){
        return itemService.getAllItems();
    }

    @RequestMapping(value = "/getAllDependencies",method = RequestMethod.POST)
    public List<dependency> getAllDependencies(){
        return itemService.getAllDependencies();
    }


    @RequestMapping(value = "/checkDependency/{itemId}",method = RequestMethod.POST)
    public boolean checkDependency(@PathVariable long itemId){
        return itemService.checkDependency(itemId);
    }

    @RequestMapping(value = "/getItemsByListId/{listId}",method = RequestMethod.POST)
    public List<toDoItem> getItemsByListId(@PathVariable long listId){
        return itemService.getItemsByListId(listId);
    }

    @RequestMapping(value = "/addItemWithDependency",method = RequestMethod.POST)
    public void addItemWithDependency(@RequestBody itemAndDependencyNameDTO dto){
        itemService.addItemWithDependency(dto);
    }

    @RequestMapping(value = "/filterByStatusFalse/{listId}",method = RequestMethod.POST)
    public listAndItemDTO filterByStatusFalse(@PathVariable long listId){
        return itemService.filterByStatusFalse(listId);
    }

    @RequestMapping(value = "/filterByStatusTrue/{listId}",method = RequestMethod.POST)
    public listAndItemDTO filterByStatusTrue(@PathVariable long listId){
        return itemService.filterByStatusTrue(listId);
    }
    @RequestMapping(value = "/filterByExpiredTrue/{listId}",method = RequestMethod.POST)
    public listAndItemDTO filterByExpiredTrue(@PathVariable long listId){
        return itemService.filterByExpiredTrue(listId);
    }
    @RequestMapping(value = "/filterByExpiredFalse/{listId}",method = RequestMethod.POST)
    public listAndItemDTO filterByExpiredFalse(@PathVariable long listId){
        return itemService.filterByExpiredFalse(listId);
    }

    @RequestMapping(value = "/filterByItemName",method = RequestMethod.POST)
    public listAndItemDTO filterByItemName(@RequestBody filterByNameDTO filterByNameDTO){
        return filterByItemName(filterByNameDTO);
    }

    @RequestMapping(value = "/orderByStatus/{listId}",method = RequestMethod.POST)
    public listAndItemDTO orderByStatus(@PathVariable long listId){
        return itemService.orderByStatus(listId);
    }

    @RequestMapping(value = "/orderByItemName/{listId}",method = RequestMethod.POST)
    public listAndItemDTO orderByItemName(@PathVariable long listId){
        return itemService.orderByItemName(listId);
    }

    @RequestMapping(value = "/orderByDeadline/{listId}",method = RequestMethod.POST)
    public listAndItemDTO orderByDeadline(@PathVariable long listId){
        return itemService.orderByDeadline(listId);
    }
}
