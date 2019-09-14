package todolistserver.todolistserver.Repositories;

import org.springframework.data.jpa.repository.JpaRepository;
import todolistserver.todolistserver.Models.toDoList;

import java.util.List;

public interface listRepository extends JpaRepository<toDoList,Long> {
    List<toDoList> findAllByUserId(long userId);
    void deleteAllByListId(long listId);
    toDoList findFirstByUserIdAndListName(long id,String ListName);
    void deleteByListId(long listId);
    toDoList findFirstByListId(long listId);
    toDoList findFirstByListName(String listName);
}
