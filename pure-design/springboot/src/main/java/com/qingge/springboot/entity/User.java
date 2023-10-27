package com.qingge.springboot.entity;

import com.baomidou.mybatisplus.annotation.TableName;
import lombok.Data;
import lombok.NoArgsConstructor;

@Data
@TableName(value = "sys_user")
public class User {
    private Integer id;
    private String username;
    private String password;
    private String nickname;
    private String email;
    private String phone;
    private String address;
}
