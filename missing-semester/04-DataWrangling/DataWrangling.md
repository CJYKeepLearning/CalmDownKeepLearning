# sum

1.sed

```bash
# sed'' 单引号中的是内容
# s 代表用后面字符串替换前面字符串
# /代表一个空格。 其实在这里可以认为是一个字符串的开始
# g代表替换多个
# -E可以转义括号，只替换一次
# .* 从第一个匹配的开始到最后一个匹配结束  z
echo 'abcaba' | sed 's/a//'
bcaba	#只替换一个
echo 'abcaba' | sed 's/a//g'
bcb		#替换全部
echo 'abcaba' | sed 's/(ab)*//'
abcaba	#不支持 ()
echo 'abcaba' | sed -E 's/(ab)//'
ca		#-e支持
echo 'abcaba' | sed 's/\(ab\)//'
caba	#或者使用 \ 来转义括号 ，注意此时不必有*，因为并不是正则表达式，只是把ab看成了一个字符。
echo 'abcaba' | sed 's/\(ab\)//g'
ca		#如果想达到(ab)*效果。可以使用g
```

2.