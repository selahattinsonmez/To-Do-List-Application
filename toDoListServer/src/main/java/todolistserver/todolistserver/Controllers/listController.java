package todolistserver.todolistserver.Controllers;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.MediaType;
import org.springframework.web.bind.annotation.*;

import todolistserver.todolistserver.Models.dependency;
import todolistserver.todolistserver.Models.toDoItem;
import todolistserver.todolistserver.DTOs.itemAndDependencyDTO;
import todolistserver.todolistserver.DTOs.listAndItemDTO;
import todolistserver.todolistserver.Repositories.dependencyRepository;
import todolistserver.todolistserver.Repositories.itemRepository;
import todolistserver.todolistserver.Repositories.listRepository;
import todolistserver.todolistserver.Models.toDoList;
import todolistserver.todolistserver.Repositories.userRepository;
import todolistserver.todolistserver.Services.listService;

import javax.transaction.Transactional;
import java.time.LocalDate;
import java.util.ArrayList;
import java.util.List;

@RestController
@RequestMapping("/list")
public class listController {

    @Autowired
    listService listService;
    @RequestMapping(value = "/saveList",method = RequestMethod.POST,produces = MediaType.APPLICATION_JSON_UTF8_VALUE)
    public long saveList(@RequestBody toDoList toDoList){
        return listService.saveList(toDoList);
    }
    @RequestMapping(value = "/getListById/{listId}",method = RequestMethod.POST,produces = MediaType.APPLICATION_JSON_UTF8_VALUE)
    public listAndItemDTO getListById(@PathVariable long listId){
        return listService.getListById(listId);
    }
    @RequestMapping(value = "/getAllListsByUserName/{userName}",method = RequestMethod.POST,produces = MediaType.APPLICATION_JSON_UTF8_VALUE)
    public List<listAndItemDTO> getAllListsByUserName(@PathVariable String userName){
        return listService.getAllListsByUserName(userName);
    }

    @Transactional
    @RequestMapping(value = "/deleteList/{listId}",method = RequestMethod.POST,produces = MediaType.APPLICATION_JSON_UTF8_VALUE)
    public void deleteList(@PathVariable long listId){

        listService.deleteList(listId);
    }
    @RequestMapping(value = "/deleteAll",method = RequestMethod.POST,produces = MediaType.APPLICATION_JSON_UTF8_VALUE)
    public void deleteAll(){
        listService.deleteAll();
    }


    @RequestMapping(value = "/getAllLists",method = RequestMethod.POST,produces = MediaType.APPLICATION_JSON_UTF8_VALUE)
    public List<toDoList> getAllLists(){

        return listService.getAllLists();
    }

}
