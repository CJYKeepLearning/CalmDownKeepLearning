package cn.itcast.user.web;

import cn.itcast.user.pojo.User;
import cn.itcast.user.service.UserService;
import com.alibaba.nacos.api.config.annotation.NacosValue;
import lombok.extern.slf4j.Slf4j;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.beans.factory.annotation.Value;
import org.springframework.web.bind.annotation.*;

import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;

@Slf4j
@RestController
@RequestMapping("/user")
// @RefreshScope
public class UserController {

    @Autowired
    private UserService userService;

    @NacosValue(value = "${pattern.dateformat}") // 使用Value没成功
    private String dateformat;


    @GetMapping("now")
    public String now(){
        System.out.println(dateformat);
        return dateformat;
//        return LocalDateTime.now().format(DateTimeFormatter.ofPattern(dateformat));
//                .format(DateTimeFormatter.ofPattern(properties.getDateformat()));
    }

    /**
     * 路径： /user/110
     *
     * @param id 用户id
     * @return 用户
     */
    @GetMapping("/{id}")
    public User queryById(@PathVariable("id") Long id,
                          @RequestHeader(value = "Truth", required = false) String truth) {
        System.out.println("truth: " + truth);
        return userService.queryById(id);
    }
}