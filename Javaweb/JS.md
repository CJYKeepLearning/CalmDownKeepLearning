## DOM对象

一切皆对象

对标签进行操作：

| 方法                                   |                     | 备注                          |
| -------------------------------------- | ------------------- | ----------------------------- |
| document.getElementById(elementId)     | id属性查找dom对象   | elementId是标签的id属性值     |
| document.getElementByName(elementName) | name属性查找dom对象 | elementName是标签的name属性值 |
| document.getElementByTagName(tagname)  | 标签名查找dom对象   | tagname是标签名               |
| document.createElement（tagname）      | 创建标签对象        | tagname为创建的标签名         |

注：前三个查询方法页面加载结束后，才能查询到。

补充：

节点就是标签对象，通过具体的元素节点调用 

| 方法                     |                                               |
| ------------------------ | --------------------------------------------- |
| getElementsByTagName()   | 获取当前节点的指定标签名孩子节点              |
| appendChild( oChildNode) | 添加一个子节点，oChildNode 是要添加的孩子节点 |

| 属性            |                                     |      |
| --------------- | ----------------------------------- | ---- |
| childNodes      | 获取当前节点的所有子节点            |      |
| firstChild      | 获取当前节点的第一个子节点          |      |
| lastChild       | 获取当前节点的最后一个子节点        |      |
| parentNode      | 获取当前节点的父节点                |      |
| nextSibling     | 获取当前节点的下一个节点            |      |
| previousSibling | 获取当前节点的上一个节点            |      |
| className       | 获取或设置标签的 class 属性值       |      |
| innerHTML       | 获取/设置起始标签和结束标签中的内容 |      |
| innerText       | 获取/设置起始标签和结束标签中的文本 |      |

## 正则表达式

### 概念

- 描述字符模式的对象

- 用于字符串模式匹配及检索替换语法

### 语法

|                 |                        |
| --------------- | ---------------------- |
| var patt = / /; | 两个//之间放置规则     |
| \w              | 是否包含字母数字下划线 |
| n*              | 包含零个或多个         |
| n?              |                        |
| n{}             |                        |

