package todolistserver.todolistserver.Services;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import org.springframework.web.bind.annotation.RequestBody;
import todolistserver.todolistserver.Models.user;
import todolistserver.todolistserver.Repositories.userRepository;

import java.util.List;
@Service("userService")
public class userService {
    @Autowired
    userRepository userRepository;
    public List<user> findAll(){
        return userRepository.findAll();
    }

    public boolean register( user user){

        if(userRepository.findFirstByUserName(user.getUserName())==null){
            userRepository.save(user);
            return true;
        }
        else{
            return false;
        }

    }
    public user login( user user){
        user user2 = userRepository.findFirstByUserName(user.getUserName());
        if(user2!=null && user.getUserPassword().equals(user2.getUserPassword())){
            return user2;
        }
        else{
            return null;
        }
    }
}
