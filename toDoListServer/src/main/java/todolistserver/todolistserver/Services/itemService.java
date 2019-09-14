package todolistserver.todolistserver.Services;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestBody;
import todolistserver.todolistserver.DTOs.filterByNameDTO;
import todolistserver.todolistserver.DTOs.itemAndDependencyDTO;
import todolistserver.todolistserver.DTOs.itemAndDependencyNameDTO;
import todolistserver.todolistserver.DTOs.listAndItemDTO;
import todolistserver.todolistserver.Models.dependency;
import todolistserver.todolistserver.Models.toDoItem;
import todolistserver.todolistserver.Models.toDoList;
import todolistserver.todolistserver.Repositories.dependencyRepository;
import todolistserver.todolistserver.Repositories.itemRepository;
import todolistserver.todolistserver.Repositories.listRepository;

import java.time.LocalDate;
import java.util.ArrayList;
import java.util.List;

@Service("itemService")
public class itemService {
    @Autowired
    itemRepository itemRepository;
    @Autowired
    dependencyRepository dependencyRepository;
    @Autowired
    listRepository listRepository;
    public boolean addItem( List<toDoItem> toDoItems){
        boolean control=true;
        for(toDoItem toDoItem:toDoItems){
            if(itemRepository.findFirstByItemName(toDoItem.getItemName())==null){
                toDoItem.setStatus(false);
                toDoItem.setExpired(false);
                itemRepository.save(toDoItem);
            }
            else{
                control=false;
            }
        }
        return control;
    }
    public boolean saveItem( toDoItem toDoItem){

        itemRepository.save(toDoItem);
        return true;
    }
    public void deleteItem( long itemId){
        itemRepository.deleteByItemId(itemId);
        dependencyRepository.deleteAllByItemId(itemId);
        dependencyRepository.deleteAllByItemId2(itemId);
    }
    public void changeStatus( long itemId){
        toDoItem toDoItem = itemRepository.findFirstByItemId(itemId);
        toDoItem.setStatus(true);
        itemRepository.save(toDoItem);
    }
    public boolean addDependency(List<dependency> dependencies){
        boolean control=true;
        for(dependency dependency:dependencies){
            if(!dependencyRepository.existsByItemIdAndItemId2(dependency.getItemId(),dependency.getItemId2())){
                dependencyRepository.save(dependency);
            }
            else{
                control=false;
            }
        }
        return control;
    }
    public ArrayList<toDoItem> getDependency( long itemId){
        ArrayList<toDoItem> items = new ArrayList<>();
        ArrayList<dependency> dependencies = dependencyRepository.findAllByItemId(itemId);
        for(dependency dependency:dependencies){
            toDoItem toDoItem = itemRepository.findFirstByItemId(dependency.getItemId2());
            items.add(toDoItem);
        }
        return items;
    }
    public void deleteDependency( dependency dependency){
        dependencyRepository.delete(dependency);

    }
    public List<toDoItem> getAllItems(){
        List<toDoItem> items = itemRepository.findAll();


        return items;
    }
    public List<dependency> getAllDependencies(){

        return dependencyRepository.findAll();
    }
    public boolean checkDependency( long itemId){
        ArrayList<toDoItem> items = new ArrayList<>();
        ArrayList<dependency> dependencies = dependencyRepository.findAllByItemId(itemId);
        for(dependency dependency:dependencies){
            if(!itemRepository.findFirstByItemId(dependency.getItemId2()).isStatus()){
                return false;
            }
        }
        return true;
    }
    public List<toDoItem> getItemsByListId( long listId){
        return itemRepository.findAllByListId(listId);
    }
    public void addItemWithDependency( itemAndDependencyNameDTO dto){
        toDoItem toDoItem = new toDoItem();
        toDoItem.setExpired(dto.getExpired());
        toDoItem.setStatus(dto.getStatus());
        toDoItem.setDependency(dto.getDependency());
        toDoItem.setItemDeadline(dto.getItemDeadline());
        toDoItem.setItemDescription(dto.getItemDescription());
        toDoItem.setItemName(dto.getItemName());
        toDoItem.setListId(dto.getListId());
        itemRepository.save(toDoItem);
        toDoItem = itemRepository.findFirstByItemNameAndListId(toDoItem.getItemName(),toDoItem.getListId());
        toDoItem toDoItem2 = itemRepository.findFirstByItemName(dto.getDependencyName());
        dependency dependency = new dependency();
        dependency.setItemId(toDoItem.getItemId());
        dependency.setItemId2(toDoItem2.getItemId());
        dependency.setListId(dto.getListId());
        dependencyRepository.save(dependency);
    }
    public listAndItemDTO filterByStatusFalse( long listId){
        listAndItemDTO listAndItemDTO = new listAndItemDTO();
        toDoList toDoList = listRepository.findFirstByListId(listId);
        listAndItemDTO.setListId(toDoList.getListId());
        listAndItemDTO.setListName(toDoList.getListName());
        listAndItemDTO.setUserId(toDoList.getUserId());
        List<toDoItem> toDoItems = itemRepository.findByListIdAndStatusFalse(listId);
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
    public listAndItemDTO filterByStatusTrue( long listId){
        listAndItemDTO listAndItemDTO = new listAndItemDTO();
        toDoList toDoList = listRepository.findFirstByListId(listId);
        listAndItemDTO.setListId(toDoList.getListId());
        listAndItemDTO.setListName(toDoList.getListName());
        listAndItemDTO.setUserId(toDoList.getUserId());
        List<toDoItem> toDoItems = itemRepository.findByListIdAndStatusTrue(listId);
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
    public listAndItemDTO filterByExpiredTrue(long listId){
        listAndItemDTO listAndItemDTO = new listAndItemDTO();
        toDoList toDoList = listRepository.findFirstByListId(listId);
        listAndItemDTO.setListId(toDoList.getListId());
        listAndItemDTO.setListName(toDoList.getListName());
        listAndItemDTO.setUserId(toDoList.getUserId());
        List<toDoItem> toDoItems = itemRepository.findByListIdAndExpiredTrue(listId);
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
    public listAndItemDTO filterByExpiredFalse( long listId){
        listAndItemDTO listAndItemDTO = new listAndItemDTO();
        toDoList toDoList = listRepository.findFirstByListId(listId);
        listAndItemDTO.setListId(toDoList.getListId());
        listAndItemDTO.setListName(toDoList.getListName());
        listAndItemDTO.setUserId(toDoList.getUserId());
        List<toDoItem> toDoItems = itemRepository.findByListIdAndExpiredFalse(listId);
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
    public listAndItemDTO filterByItemName(filterByNameDTO filterByNameDTO){
        listAndItemDTO listAndItemDTO = new listAndItemDTO();
        toDoList toDoList = listRepository.findFirstByListId(filterByNameDTO.getListId());
        listAndItemDTO.setListId(toDoList.getListId());
        listAndItemDTO.setListName(toDoList.getListName());
        listAndItemDTO.setUserId(toDoList.getUserId());
        List<toDoItem> toDoItems = itemRepository.findByListIdAndItemNameContaining(filterByNameDTO.getListId(),filterByNameDTO.getItemName());
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
    public listAndItemDTO orderByStatus( long listId){
        listAndItemDTO listAndItemDTO = new listAndItemDTO();
        toDoList toDoList = listRepository.findFirstByListId(listId);
        listAndItemDTO.setListId(toDoList.getListId());
        listAndItemDTO.setListName(toDoList.getListName());
        listAndItemDTO.setUserId(toDoList.getUserId());
        List<toDoItem> toDoItems = itemRepository.findByListIdOrderByStatus(listId);
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
    public listAndItemDTO orderByItemName( long listId){
        listAndItemDTO listAndItemDTO = new listAndItemDTO();
        toDoList toDoList = listRepository.findFirstByListId(listId);
        listAndItemDTO.setListId(toDoList.getListId());
        listAndItemDTO.setListName(toDoList.getListName());
        listAndItemDTO.setUserId(toDoList.getUserId());
        List<toDoItem> toDoItems = itemRepository.findByListIdOrderByItemName(listId);
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
    public listAndItemDTO orderByDeadline( long listId){
        listAndItemDTO listAndItemDTO = new listAndItemDTO();
        toDoList toDoList = listRepository.findFirstByListId(listId);
        listAndItemDTO.setListId(toDoList.getListId());
        listAndItemDTO.setListName(toDoList.getListName());
        listAndItemDTO.setUserId(toDoList.getUserId());
        List<toDoItem> toDoItems = itemRepository.findByListIdOrderByItemDeadline(listId);
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
