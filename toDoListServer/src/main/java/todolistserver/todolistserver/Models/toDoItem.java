package todolistserver.todolistserver.Models;

import javax.persistence.*;
import java.time.LocalDate;

@Entity
@Table(name ="toDoItem")
public class toDoItem {
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private long itemId;


    private long listId;
    private String itemName;
    private String itemDescription;
    private LocalDate itemDeadline;
    private boolean status;
    private boolean dependency;

    private boolean expired;

    public boolean isExpired() {
        return expired;
    }

    public void setExpired(boolean expired) {
        this.expired = expired;
    }

    public boolean isDependency() {
        return dependency;
    }

    public void setDependency(boolean dependency) {
        this.dependency = dependency;
    }

    public long getItemId() {
        return itemId;
    }

    public void setItemId(long itemId) {
        this.itemId = itemId;
    }

    public long getListId() {
        return listId;
    }

    public void setListId(long listId) {
        this.listId = listId;
    }

    public String getItemName() {
        return itemName;
    }

    public void setItemName(String itemName) {
        this.itemName = itemName;
    }

    public String getItemDescription() {
        return itemDescription;
    }

    public void setItemDescription(String itemDescription) {
        this.itemDescription = itemDescription;
    }

    public LocalDate getItemDeadline() {
        return itemDeadline;
    }

    public void setItemDeadline(LocalDate itemDeadline) {
        this.itemDeadline = itemDeadline;
    }

    public boolean isStatus() {
        return status;
    }

    public void setStatus(boolean status) {
        this.status = status;
    }
}
