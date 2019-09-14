package todolistserver.todolistserver.Repositories;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;
import todolistserver.todolistserver.Models.toDoItem;

import java.util.ArrayList;
import java.util.List;

@Repository
public interface itemRepository extends JpaRepository<toDoItem,Long> {
    ArrayList<toDoItem> findAllByListId(long listId);
    toDoItem findFirstByItemName(String itemName);
    void deleteByItemId(long itemId);
    void deleteAllByListId(long listId);
    toDoItem findFirstByItemId(long itemId);
    toDoItem findFirstByItemNameAndListId(String itemName,long listId);
    List<toDoItem> findByListIdAndExpiredTrue(long listId);
    List<toDoItem> findByListIdAndExpiredFalse(long listId);
    List<toDoItem> findByListIdAndItemNameContaining(long listId,String itemName);
    List<toDoItem> findByListIdAndStatusTrue(long listId);
    List<toDoItem> findByListIdAndStatusFalse(long listId);

    List<toDoItem> findByListIdOrderByStatus(long listId);
    List<toDoItem> findByListIdOrderByItemName(long listId);
    List<toDoItem> findByListIdOrderByItemDeadline(long listId);

}
