using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class A
{
    public int v;
}

class B
{
    public int v;
}

public class Test : MonoBehaviour
{
    void SayHello()
    {
        Debug.Log("Hello");
    }

    // Start is called before the first frame update
    void Start()
    {
        SayHello();
        Debug.Log("Hello World");

        A a = new A();
        A b = null;
        a.v = 100;

        Debug.Log("1: a.v = " + a.v);

        b = a;
        Debug.Log("2: a.v = " + a.v + ", b.v = " + b.v);

        b.v = 200;
        Debug.Log("3: a.v = " + a.v + ", b.v = " + b.v);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
