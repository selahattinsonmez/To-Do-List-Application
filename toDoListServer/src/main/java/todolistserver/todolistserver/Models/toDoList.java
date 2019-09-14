package todolistserver.todolistserver.Models;

import javax.persistence.*;

@Entity
@Table(name ="toDoList")
public class toDoList {
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private long listId;
    private long userId;
    private String listName;


    public long getListId() {
        return listId;
    }

    public void setListId(long listId) {
        this.listId = listId;
    }

    public long getUserId() {
        return userId;
    }

    public void setUserId(long userId) {
        this.userId = userId;
    }

    public String getListName() {
        return listName;
    }

    public void setListName(String listName) {
        this.listName = listName;
    }


}
