package todolistserver.todolistserver.DTOs;

import todolistserver.todolistserver.Models.toDoItem;

import java.util.ArrayList;

public class itemAndDependencyDTO {
    private toDoItem toDoItem;
    private ArrayList<String> dependencies;

    public toDoItem getToDoItem() {
        return toDoItem;
    }

    public void setToDoItem(toDoItem toDoItem) {
        this.toDoItem = toDoItem;
    }

    public ArrayList<String> getDependencies() {
        return dependencies;
    }

    public void setDependencies(ArrayList<String> dependencies) {
        this.dependencies = dependencies;
    }
}
