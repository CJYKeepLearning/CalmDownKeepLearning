package com.qingge.springboot.service.impl;

import com.baomidou.mybatisplus.extension.service.impl.ServiceImpl;
import com.qingge.springboot.entity.User;
import com.qingge.springboot.mapper.UserMapper;
import com.qingge.springboot.service.UserService;
import org.springframework.stereotype.Service;

@Service
public class UserServiceImpl extends ServiceImpl<UserMapper, User> implements UserService {
}
