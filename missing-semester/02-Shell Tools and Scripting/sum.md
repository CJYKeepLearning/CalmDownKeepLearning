# Sum

1.空格问题

```bash
foo = bar	#不可以
foo=bar		#可以
```

2.” “ 与 ‘ ’

```bash
# 双引号可用来引用其中的值
echo "value is $foo"
value is bar

# 单引号只代表为字符串类型
echo 'value is $foo'
value is foo
```

3.source

```bash
#source可以使某个文件运行
source mcd.sh #里面的方法将会在shell中生效，可以直接进行使用
```

4.()

```bash
#命令组  括号中的命令将会新开一个子shell顺序执行，所以括号中的变量不能被脚本余下的部分使用，括号总多个命令之间用分号隔开，各命令和括号之间不必有空格
# 命令替换 等同于cmd，shell扫描一遍命令行，发现了(cmd)结构，便将(cmd)中的cmd执行一次，得到其标准输出，再将此输出放到原来命令。
# 初始化数组
array=(a b c d)
```

5.<

```bash
#表示的是输入重定向的意思，就是把<后面跟的文件取代键盘作为新的输入设备。
```

6.tldr、ffmpeg

```bash
#帮助手册 有示例
```

7.列出目录

```bash
ls -R
tree
```

# Exercises

1. Write bash functions `marco` and `polo` that do the following. Whenever you execute `marco` the current working directory should be saved in some manner, then when you execute `polo`, no matter what directory you are in, `polo` should `cd` you back to the directory where you executed `marco`. For ease of debugging you can write the code in a file `marco.sh` and (re)load the definitions to your shell by executing `source marco.sh`.

```bash
 #!/bin/bash
 marco(){
     # >> 右边为字符串
     echo "$(pwd)" > $HOME/marco_history.log
 }
 polo(){
     cd "$(cat "$HOME/marco_history.log")"
 } 
```

```bash
 #!/bin/bash
 marco() {
     export MARCO=$(pwd)
 }
 polo() {
     cd "$MARCO"
 }
```

```bash
 #!/bin/bash
 marco(){
        echo "$(pwd)" >> "/home/foling/missing-semester/log.txt"
}
 polo(){
        cd "$(cat "/home/foling/missing-semester/log.txt" | tail -n1)"
}
```

