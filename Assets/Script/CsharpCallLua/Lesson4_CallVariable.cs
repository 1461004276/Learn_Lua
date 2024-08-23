using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson4_CallVariable : MonoBehaviour
{
    void Start()
    {
        LuaMgr.GetInstance().Init();

        LuaMgr.GetInstance().DoLuaFile("Main");

        //int local = LuaMgr.GetInstance().Global.Get<int>("testLocal");
        //Debug.Log("testLocal:" + local);

        //使用lua解析器luaenv中的 Global属性 
        int i = LuaMgr.GetInstance().Global.Get<int>("testNumber");
        Debug.Log("testNumber:" + i);
        i = 10;
        //改值
        LuaMgr.GetInstance().Global.Set("testNumber", 55);
        //值拷贝 不会影响原来Lua中的值
        int i2 = LuaMgr.GetInstance().Global.Get<int>("testNumber");
        Debug.Log("testNumber_i2:" + i2);

        bool b = LuaMgr.GetInstance().Global.Get<bool>("testBool");
        Debug.Log("testBool:" + b);

        float f = LuaMgr.GetInstance().Global.Get<float>("testFloat");
        Debug.Log("testFloat:" + f);

        double d = LuaMgr.GetInstance().Global.Get<double>("testFloat");
        Debug.Log("testFloat_double:" + d);

        string s = LuaMgr.GetInstance().Global.Get<string>("testString");
        Debug.Log("testString:" + s);
    }
}
