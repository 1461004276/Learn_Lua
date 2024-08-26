using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using XLua;

[Hotfix]
public class HotfixTest
{
    public HotfixTest()
    {
        Debug.Log("HotfixTest构造函数");
    }

    public void Speak(string str)
    {
        Debug.Log(str);
    }
    //热补丁的话 没有析构 可能报错
    ~HotfixTest()
    {

    }
}

[Hotfix]
public class HotfixTest2<T>
{
    public void Test(T str)
    {
        Debug.Log(str);
    }
}


[Hotfix]
public class HotfixMain : MonoBehaviour
{
    HotfixTest hotTest;

    public int[] array = new int[] { 1, 2, 3 };

    //属性
    public int Age
    {
        get
        {
            return 0;
        }
        set
        {
            Debug.Log(value);
        }
    }

    //索引器
    public int this[int index]
    {
        get
        {
            if( index >= array.Length || index < 0)
            {
                Debug.Log("索引不正确");
                return 0;
            }

            return array[index];
        }
        set
        {
            if (index >= array.Length || index < 0)
            {
                Debug.Log("索引不正确");
                return;
            }
            array[index] = value;
        }
    }

    event UnityAction myEvent;

    // Start is called before the first frame update
    void Start()
    {
        LuaMgr.GetInstance().Init();
        LuaMgr.GetInstance().DoLuaFile("Main");

        Debug.Log(Add(10, 20));
        Speak("唐老狮好爱你！");

        hotTest = new HotfixTest();
        hotTest.Speak("嘻嘻嘻嘻");


        //StartCoroutine(TestCoroutine());

        this.Age = 100;
        Debug.Log(this.Age);

        this[99] = 100;
        Debug.Log(this[9999]);

        myEvent += TestTest;
        myEvent -= TestTest;

        HotfixTest2<string> t1 = new HotfixTest2<string>();
        t1.Test("123");

        HotfixTest2<int> t2 = new HotfixTest2<int>();
        t2.Test(1000);
    }

    private void TestTest()
    {

    }

    IEnumerator TestCoroutine()
    {
        while(true)
        {
            yield return new WaitForSeconds(1f);
            Debug.Log("C#协程打印一次");
        }
    }

    public int Add(int a, int b)
    {
        return 0;
    }

    public static void Speak(string str)
    {
        Debug.Log("哈哈哈哈哈");
    }
}
