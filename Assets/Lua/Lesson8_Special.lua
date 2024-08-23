print("*********Lua调用C# 二维数组相关知识点***********")

local obj = CS.Lesson8()

--获取长度
print("行：" .. obj.array:GetLength(0))
print("列：" .. obj.array:GetLength(1))

--获取元素
--不能通过[0,0]或者[0][0]访问元素 会报错
print(obj.array:GetValue(0,0))
print(obj.array:GetValue(1,0))
print("********************")
for i=0,obj.array:GetLength(0)-1 do
	for j=0,obj.array:GetLength(1)-1 do
		print(obj.array:GetValue(i,j))
	end
end

obj:SetValue(obj.array, 99, 0, 0)
print(obj.array:GetValue(0,0))


local m = typeof(CS.System.Array):GetMethod("SetValue", {typeof(CS.System.Int32), typeof(CS.System.Int32), typeof(CS.System.Int32)})
print(m);
local ff = xlua.tofunction(m)
print(ff);
ff(obj.array, 1,0,0)
--print(obj.array:GetValue(0,0))

