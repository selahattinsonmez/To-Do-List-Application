package todolistserver.todolistserver.Services;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestBody;
import todolistserver.todolistserver.DTOs.itemAndDependencyDTO;
import todolistserver.todolistserver.DTOs.listAndItemDTO;
import todolistserver.todolistserver.Models.dependency;
import todolistserver.todolistserver.Models.toDoItem;
import todolistserver.todolistserver.Models.toDoList;
import todolistserver.todolistserver.Repositories.dependencyRepository;
import todolistserver.todolistserver.Repositories.itemRepository;
import todolistserver.todolistserver.Repositories.listRepository;
import todolistserver.todolistserver.Repositories.userRepository;

import java.time.LocalDate;
import java.util.ArrayList;
import java.util.List;

@Service("listService")
public class listService {
    @Autowired
    listRepository listRepository;
    @Autowired
    itemRepository itemRepository;
    @Autowired
    dependencyRepository dependencyRepository;
    @Autowired
    userRepository userRepository;
    public long saveList( toDoList toDoList){

        if(listRepository.findFirstByUserIdAndListName(toDoList.getUserId(),toDoList.getListName())==null){
            listRepository.save(toDoList);
            return listRepository.findFirstByListName(toDoList.getListName()).getListId();
        }
        return 0;
    }
    public listAndItemDTO getListById( long listId){
        listAndItemDTO listAndItemDTO = new listAndItemDTO();
        toDoList toDoList = listRepository.findFirstByListId(listId);
        listAndItemDTO.setListId(toDoList.getListId());
        listAndItemDTO.setListName(toDoList.getListName());
        listAndItemDTO.setUserId(toDoList.getUserId());
        List<toDoItem> toDoItems = itemRepository.findAllByListId(listId);
        ArrayList<itemAndDependencyDTO> dtos= new ArrayList<itemAndDependencyDTO>();


        for(toDoItem item :toDoItems){
            itemAndDependencyDTO itemAndDependencyDTO = new itemAndDependencyDTO();
            itemAndDependencyDTO.setToDoItem(item);
            itemAndDependencyDTO.setDependencies(getDependencies(item));
            dtos.add(itemAndDependencyDTO);
        }
        listAndItemDTO.setToDoItems(dtos);
        return listAndItemDTO;
    }

    public List<listAndItemDTO> getAllListsByUserName( String userName){
        long userId= userRepository.findFirstByUserName(userName).getUserId();
        List<toDoList> lists= listRepository.findAllByUserId(userId);


        ArrayList<listAndItemDTO> listAndItemDTOS = new ArrayList<listAndItemDTO>();
        for(toDoList list : lists){
            listAndItemDTO listAndItemDTO = new listAndItemDTO();
            listAndItemDTO.setUserId(list.getUserId());
            listAndItemDTO.setListName(list.getListName());
            listAndItemDTO.setListId(list.getListId());
            List<toDoItem> toDoItems = itemRepository.findAllByListId(list.getListId());
            ArrayList<itemAndDependencyDTO> dtos= new ArrayList<itemAndDependencyDTO>();


            for(toDoItem item :toDoItems){
                itemAndDependencyDTO itemAndDependencyDTO = new itemAndDependencyDTO();
                itemAndDependencyDTO.setToDoItem(item);
                itemAndDependencyDTO.setDependencies(getDependencies(item));
                dtos.add(itemAndDependencyDTO);
            }
            listAndItemDTO.setToDoItems(dtos);
            listAndItemDTOS.add(listAndItemDTO);
        }
        return listAndItemDTOS;
    }

    public void deleteList(long listId){

        listRepository.deleteAllByListId(listId);
        itemRepository.deleteAllByListId(listId);
        dependencyRepository.deleteAllByListId(listId);
    }
    public void deleteAll(){
        listRepository.deleteAll();
        itemRepository.deleteAll();
        dependencyRepository.deleteAll();
    }
    public List<toDoList> getAllLists(){

        return listRepository.findAll();
    }
    public ArrayList<String> getDependencies(toDoItem item){
        if(!item.isExpired() && LocalDate.now().isBefore(item.getItemDeadline())){
            item.setExpired(true);
            itemRepository.save(item);
        };
        ArrayList<String> items = new ArrayList<>();
        ArrayList<dependency> dependencies = dependencyRepository.findAllByItemId(item.getItemId());
        for(dependency dependency:dependencies){
            toDoItem toDoItem = itemRepository.findFirstByItemId(dependency.getItemId2());
            items.add(toDoItem.getItemName());
        }
        return items;
    }
}
