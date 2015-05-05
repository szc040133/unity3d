using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        System.Console.WriteLine("hello,World");
	}
    /// <summary>
    /// 初始化更新
    /// </summary>
    void UpdateView()
    {
        int myInt = 10;
        System.Console.WriteLine("instantiate,myint:{0}", myInt);



    }

    

   
}
