package com.qingge.springboot.service.impl;

import com.baomidou.mybatisplus.core.conditions.query.QueryWrapper;
import com.qingge.springboot.controller.dto.UserDTO;
import com.qingge.springboot.entity.User;
import com.qingge.springboot.mapper.UserMapper;
import com.qingge.springboot.service.IUserService;
import com.baomidou.mybatisplus.extension.service.impl.ServiceImpl;
import org.springframework.stereotype.Service;

/**
 * <p>
 *  服务实现类
 * </p>
 *
 * @author foling
 * @since 2023-11-07
 */
@Service
public class UserServiceImpl extends ServiceImpl<UserMapper, User> implements IUserService {

    @Override
    public boolean login(UserDTO userDTO) {
        QueryWrapper<User> queryWrapper = new QueryWrapper<>();
        queryWrapper.eq("username",userDTO.getUsername());
        queryWrapper.eq("password",userDTO.getPassword());
        // 处理异常情况
        try {
            User one = getOne(queryWrapper);
            return one != null;
        } catch (Exception e) {
            System.out.println(e);
            return false;
        }
    }
}
