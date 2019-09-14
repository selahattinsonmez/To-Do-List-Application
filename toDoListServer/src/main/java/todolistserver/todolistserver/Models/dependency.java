package todolistserver.todolistserver.Models;

import javax.persistence.*;

@Entity
@Table(name ="dependency")
public class dependency {

    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private long dependencyId;

    private long itemId;
    private long itemId2;
    private long listId;

    public long getListId() {
        return listId;
    }

    public void setListId(long listId) {
        this.listId = listId;
    }


    public long getDependencyId() {
        return dependencyId;
    }

    public void setDependencyId(long dependencyId) {
        this.dependencyId = dependencyId;
    }

    public long getItemId() {
        return itemId;
    }

    public void setItemId(long itemId) {
        this.itemId = itemId;
    }

    public long getItemId2() {
        return itemId2;
    }

    public void setItemId2(long itemId2) {
        this.itemId2 = itemId2;
    }
}
