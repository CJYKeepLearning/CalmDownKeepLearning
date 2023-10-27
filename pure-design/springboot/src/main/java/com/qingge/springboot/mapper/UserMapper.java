package com.qingge.springboot.mapper;

import com.baomidou.mybatisplus.core.mapper.BaseMapper;
import com.qingge.springboot.entity.User;
import org.apache.ibatis.annotations.*;

import java.util.List;

public interface UserMapper extends BaseMapper<User> {
}
