<template>
  <el-container style="height: 100%; border: 1px solid #eee">
    <el-aside :width="sideWidth + 'px' " style=" background-color: rgb(238, 241, 246);">
      <el-menu :default-openeds="['1', '3']" style="min-height: 100%; overflow-x:hidden"
      background-color="rgb(48, 65, 86)"
      text-color="#fff"
      active-text-color="#ffd04c"
      :collapse-transition="false"
      :collapse="isCollapse"
      >
      <div style="height: 60px; line-height: 60px; text-align: center">
        <img src="../assets/logo.png" style="width: 20px; position: relative; top:5px; margin-right:5px">
        <b style="color:white" v-show="logoTextShow">后台管理系统</b>
      </div>
        <el-submenu index="1">
          <template slot="title"><i class="el-icon-message"></i>
          <span slot="title">导航一</span>
          </template>
          <el-menu-item-group>
            <template slot="title">分组一</template>
            <el-menu-item index="1-1">选项1</el-menu-item>
            <el-menu-item index="1-2">选项2</el-menu-item>
          </el-menu-item-group>
          <el-menu-item-group title="分组2">
            <el-menu-item index="1-3">选项3</el-menu-item>
          </el-menu-item-group>
          <el-submenu index="1-4">
            <template slot="title">选项4</template>
            <el-menu-item index="1-4-1">选项4-1</el-menu-item>
          </el-submenu>
        </el-submenu>
        <el-submenu index="2">
          <template slot="title"><i class="el-icon-menu"></i>
          <span slot="title">导航二</span>
          </template>
          <el-menu-item-group>
            <template slot="title">分组一</template>
            <el-menu-item index="2-1">选项1</el-menu-item>
            <el-menu-item index="2-2">选项2</el-menu-item>
          </el-menu-item-group>
          <el-menu-item-group title="分组2">
            <el-menu-item index="2-3">选项3</el-menu-item>
          </el-menu-item-group>
          <el-submenu index="2-4">
            <template slot="title">选项4</template>
            <el-menu-item index="2-4-1">选项4-1</el-menu-item>
          </el-submenu>
        </el-submenu>
        <el-submenu index="3">
          <template slot="title"><i class="el-icon-setting"></i>
          <span slot="title">导航三</span>
          </template>
          <el-menu-item-group>
            <template slot="title">分组一</template>
            <el-menu-item index="3-1">选项1</el-menu-item>
            <el-menu-item index="3-2">选项2</el-menu-item>
          </el-menu-item-group>
          <el-menu-item-group title="分组2">
            <el-menu-item index="3-3">选项3</el-menu-item>
          </el-menu-item-group>
          <el-submenu index="3-4">
            <template slot="title">选项4</template>
            <el-menu-item index="3-4-1">选项4-1</el-menu-item>
          </el-submenu>
        </el-submenu>
      </el-menu>
    </el-aside>
    
    <el-container>
      <el-header style=" font-size: 12px; border-bottom:1px solid #ccc;line-height: 60px;display:flex">
        <div style="flex:1;font-size:20px">
          <span :class="collapseBtnClass" style="cursor:pointer" @click="collapse"></span>
        </div>
        <el-dropdown style="width: 90px; cursor: pointer">
          <i class="el-icon-setting" style="margin-right: 15px"></i>
          <span>王小虎</span>
          <el-dropdown-menu slot="dropdown">
            <el-dropdown-item>查看</el-dropdown-item>
            <el-dropdown-item>新增</el-dropdown-item>
            <el-dropdown-item>删除</el-dropdown-item>
          </el-dropdown-menu>
        </el-dropdown> 
      </el-header>
      <el-main>
        <div style="margin-bottom: 30px">
          <el-breadcrumb separator="/">
            <el-breadcrumb-item :to="{ path: '/' }">首页</el-breadcrumb-item>
            <el-breadcrumb-item>用户管理</el-breadcrumb-item>
          </el-breadcrumb>
        </div>
        <div style="margin: 10px 0">
          <el-input style="width: 200px;" placeholder="请输入名称" v-model="username" suffix-icon="el-icon-search" ></el-input>
          <el-input style="width: 200px;" placeholder="请输入邮箱" v-model="email" suffix-icon="el-icon-message" class="ml-5"></el-input>
          <el-input style="width: 200px;" placeholder="请输入地址" v-model="address" suffix-icon="el-icon-position" class="ml-5"></el-input>
          <el-button class="ml-5" type="primary" @click="load">搜索</el-button>
          <el-button type="warning" @click="reset">重置</el-button>
        </div>
        <div style="margin: 10px 0">
          <el-button type="primary" @click="handleAdd">新增<i class="el-icon-circle-plus-outline"></i></el-button>
          <el-popconfirm
              class="ml-5"
              confirm-button-text='确定'
              cancel-button-text='我再想想'
              icon="el-icon-info"
              icon-color="red"
              title="您确定批量删除这些数据吗？"
              @confirm="delBatch"
          >
          <el-button type="danger" slot="reference">批量删除<i class="el-icon-remove-outline"></i></el-button>
          </el-popconfirm>
          <el-button type="primary">导入<i class="el-icon-bottom"></i></el-button>
          <el-button type="primary">导出<i class="el-icon-top"></i></el-button>
        </div>
        <el-table :data="tableData" border stripe :header-cell-class-name="headerBg">
          <el-table-column prop="id" label="ID" width="80">
          </el-table-column>
          <el-table-column prop="username" label="姓名" width="120">
          </el-table-column>
          <el-table-column prop="email" label="邮箱">
          </el-table-column>
          <el-table-column prop="phone" label="电话">
          </el-table-column>
          <el-table-column prop="address" label="地址">
          </el-table-column>
          <el-table-column label="操作" width="200px" align="center">
            <template slot-scope="scope">
              <el-button type="success" @click="handleEdit(scope.row)">编辑 <i class="el-icon-edit"></i></el-button>
              <el-popconfirm
                  class="ml-5"
                  confirm-button-text='确定'
                  cancel-button-text='我再想想'
                  icon="el-icon-info"
                  icon-color="red"
                  title="您确定删除吗？"
                  @confirm="del(scope.row.id)"
              >
              <el-button type="danger" slot="reference" >删除 <i class="el-icon-remove-outline"></i></el-button>
            </el-popconfirm>
            </template>
          </el-table-column>                                                                                                                                                                                                                                                               
        </el-table>
        <div class="block">
          <span class="demonstration">完整功能</span>
          <el-pagination
            @size-change="handleSizeChange"
            @current-change="handleCurrentChange"
            :current-page="pageNum"
            :page-sizes="[2, 5, 10, 20]"
            :page-size="pageSize"
            layout="total, sizes, prev, pager, next, jumper"
            :total="total">
          </el-pagination>
        </div>
      </el-main>
    </el-container>
  </el-container>
</template>

<script>
// @ is an alias to /src
import HelloWorld from '@/components/HelloWorld.vue'
import request from '@/utils/request';


export default {
  name: 'HomeView',
  components: {
    HelloWorld
  },
  created(){
    this.load()
  },
  data(){
    const item = {
        date: '2016-05-02',
        name: '王小虎',
        address: '上海市普陀区金沙江路 1518 弄'
      };
    return{
      msg:"hhhh",
      tableData: [],
      total:0,
      pageNum:1,
      pageSize:2,
      username:"",
      email:"",
      address:"",
      collapseBtnClass: 'el-icon-s-fold',
      isCollapse:false,
      sideWidth:200,
      logoTextShow:true,
      headerBg: 'headerBg',
      form:{},
      dialogFormVisible : false
    }
  },
  methods:{
    collapse(){
      this.isCollapse = !this.isCollapse
      if(this.isCollapse){
        this.sideWidth=64
        this.collapseBtnClass = 'el-icon-s-unfold'
        this.logoTextShow = false
      }else{
        this.sideWidth=200
        this.collapseBtnClass = 'el-icon-s-fold'
        this.logoTextShow = true
      }
    },
    load(){
    //请求分页查询数据
    request.get("http://localhost:9090/user/page",{
      params:{
        pageNum:this.pageNum,
        pageSize:this.pageSize,
        username:this.username,
        email:this.email,
        address:this.address
      }
    }).then(res=>{
      console.log(res),
      this.tableData = res.records,
      this.total = res.total
    })
    },
    //重置搜索框
    reset(){
      this.username = "",
      this.email = "",
      this.address = ""
    },
    //新增
    handleAdd(){
      this.dialogFormVisible = true
      this.form={}
    },
        
    handleEdit(row){
      this.form = row
      this.dialogFormVisible = true
    },
    handleSizeChange(pageSize){
      console.log(pageSize)
      this.pageSize = pageSize
      this.load()
    },
    handleCurrentChange(pageNum){
      console.log(pageNum)
      this.pageNum = pageNum
      this.load()
    },

  }
}
</script>
<style>
.headerBg{
  background:#afe!important;
}
</style>
