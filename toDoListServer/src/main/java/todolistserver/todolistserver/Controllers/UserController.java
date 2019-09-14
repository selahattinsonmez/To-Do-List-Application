package todolistserver.todolistserver.Controllers;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.MediaType;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RestController;
import todolistserver.todolistserver.Models.user;
import todolistserver.todolistserver.Repositories.userRepository;
import todolistserver.todolistserver.Services.userService;

import java.util.List;

@RestController
@RequestMapping("/user")
public class UserController {
    @Autowired
    userService userService;

    @RequestMapping(value = "/findAll",method = RequestMethod.POST,produces = MediaType.APPLICATION_JSON_UTF8_VALUE)
    public List<user> findAll(){
        return userService.findAll();
    }
    @RequestMapping(value = "/Register",method = RequestMethod.POST,produces = MediaType.APPLICATION_JSON_UTF8_VALUE)
    public boolean register(@RequestBody user user){
        return userService.register(user);
    }
    @RequestMapping(value = "/Login",method = RequestMethod.POST,produces = MediaType.APPLICATION_JSON_UTF8_VALUE)
    public user login(@RequestBody user user){
        return userService.login(user);
    }
}
