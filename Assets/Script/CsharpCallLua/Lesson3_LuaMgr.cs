﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson3_LuaMgr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //初始化解析器
        LuaMgr.GetInstance().Init();

        LuaMgr.GetInstance().DoLuaFile("Main");
    }

}
