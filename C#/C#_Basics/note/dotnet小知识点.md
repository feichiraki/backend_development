## dotnet命令小知识点

#### 1、本章目的

了解可以辅助我们更好地学习C#编程的工具。

* .net SDK
* .net CLI
  * dotnet 命令
* ...





#### 2、global.json

##### 2.1 切换.NET SDK 使用版本

**使用场景**：当我们所使用的C#项目，遇到了版本问题，或者某些程序集因为SDK版本问题出现冲突，导致程序报错。

**解决**：创建global.json文件来配置 .NET CLI 所使用的版本。

切换步骤：

* 命令`dotnet --info`查看SDK版本。
* 根据对应SDK版本号创建对应的 `global.json`文件。



查看SDK版本：

<img src="dotnet小知识点.assets/image-20231002223212774.png" alt="image-20231002223212774" style="zoom:67%;" />

这里本人用的是 `.NET 6`，如果想要切换为 `.net core 3.1`版本使用如下指令：

```bash
# 指令语法
dotnet new globaljson --sdk-version 版本号 --force
# 在当前目录中创建 global.json，将 SDK 版本设置为 3.1.426
# --force:强制生成内容，即使会更改现有文件，也不例外。 当选择的模板将覆盖输出目录中的现有文件时，需要执行此操作。
dotnet new globaljson --sdk-version 3.1.426 --force 
```

切换成功的结果如下：

<img src="dotnet小知识点.assets/image-20231002224325120.png" alt="image-20231002224325120" style="zoom:67%;" />

如果想切换回来，使用同样的方法即可。

> 参考文档：
>
> * [global.json 概述](https://learn.microsoft.com/zh-cn/dotnet/core/tools/global-json)
> * [dotnet new](https://learn.microsoft.com/zh-cn/dotnet/core/tools/dotnet-new)



##### 2.2 切换 .NET版本后，可能会出现的错误

<img src="dotnet小知识点.assets/image-20231002232259561.png" alt="image-20231002232259561" style="zoom:67%;" />

如果你也出现了上图的错误，是因为你实际上使用的SDK版本号和`global.json`文件上的版本号对应不上，将当前global.json文件的`sdk`的版本修改为当前使用的SDK版本号即可。

```json
{
  "sdk": {
    "version": "3.1.426"
  }
}
```





