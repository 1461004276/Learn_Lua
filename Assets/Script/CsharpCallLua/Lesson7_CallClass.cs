﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using XLua;

public class CallLuaClass
{
    //在这个类中去声明成员变量
    //名字一定要和 Lua那边的一样
    //公共 私有和保护 没办法赋值
    //这个自定义中的 变量 可以更多也可以更少
    //如果变量比 lua中的少 就会忽略它
    //如果变量比 lua中的多 不会赋值 也会忽略
    public int testInt;
    public bool testBool;
    //public float testFloat;
    public float testString;
    public UnityAction testFun;

    public CallLuaInClass testInClass;

    public int i;

    public void Test()
    {
        Debug.Log(testInt);
    }
}

public class CallLuaInClass
{
    public int testInInt;
}

public class CallLuaInClassDic
{
    public Dictionary<string, int> testDic;
}

public class Lesson7_CallClass : MonoBehaviour
{
    void Start()
    {
        LuaMgr.GetInstance().Init();
        LuaMgr.GetInstance().DoLuaFile("Main");

        CallLuaClass obj = LuaMgr.GetInstance().Global.Get<CallLuaClass>("testClas");
        Debug.Log(obj.testInt);
        Debug.Log(obj.testBool);
        //Debug.Log(obj.testFloat);
        Debug.Log(obj.testString);
        Debug.Log(obj.i);
        //Debug.Log("嵌套：" + obj.testInClass.testInInt);
        obj.testFun();
        //值拷贝 改变了它 不会改变Lua表里的内容
        obj.testInt = 100;
        CallLuaClass obj2 = LuaMgr.GetInstance().Global.Get<CallLuaClass>("testClas");
        Debug.Log(obj2.testInt);

        CallLuaInClassDic obj3 = LuaMgr.GetInstance().Global.Get<CallLuaInClassDic>("testClass");
        Debug.Log(obj3.testDic);
        Debug.Log(obj3.testDic.Count);

        foreach(string item in obj3.testDic.Keys)
        {
            Debug.Log(obj3.testDic[item]);
        }
    }

}
