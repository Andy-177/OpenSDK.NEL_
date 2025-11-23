# 概括
## 基于[这里](https://github.com/corpnetease/OpenSDK.NEL)制作的nel

## 特性
可以兼容并加载 Codexus.Gateway 的多数插件。

## 构建教程
1.下载dotnet10.0

2.删除`OpenSDK.NEL_-master\OpenSDK.NEL\bin`和`OpenSDK.NEL_-master\OpenSDK.NEL\obj`

3.输入`dotnet nuget locals all --clear`清除nuget缓存

4.输入`dotnet build`构建，这可能需要几分钟

5.打开`OpenSDK.NEL_-master\OpenSDK.NEL\bin\Debug\net9.0\win-x64`，复制全部文件到一个自己新建的文件夹,比如`OpenSDK.NEL`，新建的文件夹要放在项目文件夹之外

6.双击`OpenSDK.NEL.exe`这时候会初始化，等待一会后关闭终端，会看见在`OpenSDK.NEL.exe`同目录下有个`plugins`文件夹

7.打开`plugins`，把项目里`nel_plugins`里的文件全部复制到`plugins`文件夹里

8.再次运行`OpenSDK.NEL.exe`，即可正常运行，可以使用[4399Cokkie获取器](https://freecookie.studio/)获取账号
## 注意
**nel_plugins是存放插件的文件夹，本身不参与构建**
