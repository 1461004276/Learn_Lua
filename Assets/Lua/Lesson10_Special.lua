GameObject = CS.UnityEngine.GameObject
UI = CS.UnityEngine.UI
-- csharp 中 xlua 提供的特性
-- CSharpCallLua 委托 接口
-- LuaCallCSharp 该特性加在c#类上 可以提升性能 一般用于拓展方法
-- 这两个特性 都无法直接往系统类或者第三方库上添加

local slider = GameObject.Find("Slider")
print(slider)
local sliderScript = slider:GetComponent(typeof(UI.Slider))
print(sliderScript)
sliderScript.onValueChanged:AddListener(function(f)
	print(f)
end)


