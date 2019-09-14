package todolistserver.todolistserver.DTOs;

import java.util.ArrayList;
import java.util.List;

public class listAndItemDTO {
    private long userId;
    private String listName;
    private long listId;
    private List<itemAndDependencyDTO> toDoItems;



    public long getListId() {
        return listId;
    }

    public void setListId(long listId) {
        this.listId = listId;
    }

    public String getListName() {
        return listName;
    }

    public void setListName(String listName) {
        this.listName = listName;
    }

    public List<itemAndDependencyDTO> getToDoItems() {
        return toDoItems;
    }

    public void setToDoItems(ArrayList<itemAndDependencyDTO> toDoItems) {
        this.toDoItems = toDoItems;
    }

    public long getUserId() {
        return userId;
    }

    public void setUserId(long userId) {
        this.userId = userId;
    }


}
