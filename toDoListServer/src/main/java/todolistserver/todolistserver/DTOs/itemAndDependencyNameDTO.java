package todolistserver.todolistserver.DTOs;

import java.time.LocalDate;

public class itemAndDependencyNameDTO {
    private long itemId;
    private long listId;
    private String itemName;
    private String dependencyName;
    private String itemDescription;
    private LocalDate itemDeadline;
    private Boolean status;
    private Boolean dependency;
    private Boolean expired;

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

    public String getDependencyName() {
        return dependencyName;
    }

    public void setDependencyName(String dependencyName) {
        this.dependencyName = dependencyName;
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

    public Boolean getStatus() {
        return status;
    }

    public void setStatus(Boolean status) {
        this.status = status;
    }

    public Boolean getDependency() {
        return dependency;
    }

    public void setDependency(Boolean dependency) {
        this.dependency = dependency;
    }

    public Boolean getExpired() {
        return expired;
    }

    public void setExpired(Boolean expired) {
        this.expired = expired;
    }
}
