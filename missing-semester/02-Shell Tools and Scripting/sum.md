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

