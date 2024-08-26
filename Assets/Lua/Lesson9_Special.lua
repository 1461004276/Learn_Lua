print("*********Lua调用C# nil和null比较的相关知识点***********")

-- lua中声明全局函数判空方法 也可以在csharp中扩展object 类 有 isnull方法
function IsNull(obj)
	if obj == nil or obj:Equals(nil) then
		return true
	end
	return false
end


--往场景对象上添加一个脚本 如果存在就不加 如果不存在再加
GameObject = CS.UnityEngine.GameObject
Debug = CS.UnityEngine.Debug
Rigidbody = CS.UnityEngine.Rigidbody
Image = CS.UnityEngine.UI.Image

local obj = GameObject("测试加脚本")
--得到身上的刚体组件  如果没有 就加 有就不管
local rig = obj:GetComponent(typeof(Rigidbody))
print(rig)
Debug.Log(rig)
--nil和null 没法进行==比较 !!!
if rig == nil then
	print(true)
end

local img = obj:GetComponent(typeof(Image))
print(img)
Debug.Log(img)
--判断空
--nil和null 没法进行==比较 !!!
--第一种方法
--if rig:Equals(nil) then
--if IsNull(rig) then -- 除了在cs中声明isnull方法 也可以声明lua中的全局函数isnull
if rig:IsNull() then
	print("123")
	rig = obj:AddComponent(typeof(Rigidbody))
end
print(rig)
