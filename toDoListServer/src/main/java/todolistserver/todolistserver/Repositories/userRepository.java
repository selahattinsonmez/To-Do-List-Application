package todolistserver.todolistserver.Repositories;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;
import todolistserver.todolistserver.Models.user;

@Repository
public interface userRepository extends JpaRepository<user,Long> {
    user findFirstByUserName(String userName);

}
