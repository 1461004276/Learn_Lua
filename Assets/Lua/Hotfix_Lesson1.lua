print("*********第一个热补丁***********")

--直接写好代码 运行 是会报错的
--我们必须做4个非常重要的操作
--1.加特性 [Hotfix]
--2.加宏 第一次开发热补丁需要加 
--build settings->player setting->other setting -> scripting define symbols 添加 HOTFIX_ENABLE
--3.生成代码
--4.hotfix 注入(工具栏xlua中添加宏之后新按钮注入)  
--注入时可能报错 提示你要引入Tools 将导入的xlua文件夹中的Tools文件夹拖入到工程中与assets同级

--热补丁的缺点：只要我们修改了热补丁类的代码，我们就需要重新执行第4步！！！
--需要重新点击 注入

--lua当中 热补丁代码固定写法
--xlua.hotfix(类, "函数名", lua函数)

--成员函数 第一个参数 self
xlua.hotfix(CS.HotfixMain, "Add", function(self, a, b)
	return a + b
end)

--静态函数 不用传第一个参数
xlua.hotfix(CS.HotfixMain, "Speak", function(a)
	print(a)
end)

