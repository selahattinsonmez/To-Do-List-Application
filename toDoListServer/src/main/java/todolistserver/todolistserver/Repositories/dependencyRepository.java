package todolistserver.todolistserver.Repositories;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;
import todolistserver.todolistserver.Models.dependency;

import java.util.ArrayList;
import java.util.List;

@Repository
public interface dependencyRepository extends JpaRepository<dependency,Long> {
    List<dependency> findByItemId(long itemId);
    List<dependency> findByItemId2(long itemId2);
    void deleteAllByListId(long listId);
    ArrayList<dependency> findAllByItemId(long itemId);
    ArrayList<dependency> deleteAllByItemId2(long itemId2);
    ArrayList<dependency> deleteAllByItemId(long itemId);
    boolean existsByItemIdAndItemId2(long itemId,long itemId2);


}
