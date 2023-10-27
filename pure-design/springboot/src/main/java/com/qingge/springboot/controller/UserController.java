package com.qingge.springboot.controller;

import com.baomidou.mybatisplus.core.conditions.query.QueryWrapper;
import com.baomidou.mybatisplus.core.metadata.IPage;
import com.baomidou.mybatisplus.extension.plugins.pagination.Page;
import com.qingge.springboot.entity.User;
import com.qingge.springboot.mapper.UserMapper;
import com.qingge.springboot.service.UserService;
import com.qingge.springboot.service.impl.UserServiceImpl;
import io.swagger.models.auth.In;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import java.util.HashMap;
import java.util.List;
import java.util.Map;

@RestController
@RequestMapping("/user")
public class UserController {
    @Autowired
    private UserMapper userMapper;

    @Autowired
    private UserServiceImpl userService;
    // 查询所有数据
    @GetMapping
    public List<User> findAll(){
        List<User> all = userService.list();
        return all;
    }

    //新增和修改
    @PostMapping
    public Boolean save(@RequestBody User user){
        return userService.save(user);
    }
    // 分页查询 - mybatis-plus的方式

    @GetMapping("/page")
    public IPage<User> findPage(@RequestParam Integer pageNum, @RequestParam Integer pageSize,
                                @RequestParam(defaultValue = "") String username,
                                @RequestParam(defaultValue = "") String nickname,
                                @RequestParam(defaultValue = "") String address){
        IPage<User> page = new Page<>(pageNum,pageSize);
        QueryWrapper<User> queryWrapper = new QueryWrapper<>();
        if (!"".equals(username)){
            queryWrapper.like("username",username);
        }
        if (!"".equals(username)){
            queryWrapper.like("nickname",nickname);
        }
        if (!"".equals(username)){
            queryWrapper.like("address",address);
        }
        return userService.page(page,queryWrapper);
    }
//    @GetMapping("/page")
//    public Map<String, Object> findPage(@RequestParam Integer pageNum,
//                        @RequestParam Integer pageSize,
//                        @RequestParam String username){
//        pageNum = (pageNum - 1) * pageSize;
//        username = "%" + username + "%";
//        List<User> data = userMapper.selectPage(pageNum,pageSize);
//        Integer total = userMapper.selectTotal(username);
//        Map<String,Object> res = new HashMap<>();
//        res.put("data",data);
//        res.put("total",total);
//        return res;
//    }
    //删除
    @DeleteMapping("/{id}")
    public boolean delete(@PathVariable Integer id){
        return userService.removeById(id);
    }

}
