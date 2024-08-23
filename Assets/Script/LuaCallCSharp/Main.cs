using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Lua没有办法直接访问C#  一定是先从C#调用Lua脚本后
/// 才把核心逻辑 交给了Lua来编写
/// </summary>
public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LuaMgr.GetInstance().Init();
        LuaMgr.GetInstance().DoLuaFile("Main");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            LuaMgr.GetInstance().Dispose();
    }
}
