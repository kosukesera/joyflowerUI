using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class GameDirector : MonoBehaviour {

    private int num_obj;
    public Text ObjText;
    //    private ObjImg;
    //public Canvas canvas;

    void SetNum(int num)
    {
        num_obj = num;
    }

    int GetNum(){
     return num_obj;
    }

    // Use this for initialization
    void Start () {
        num_obj = 0;

        ObjText.text = "aaa";

    }

    void SetUI(int num)
    {
        ObjText.text = num.ToString();
    }

    public void CountObj()
    {
        int num = 0;
        num = GetNum();
        SetNum(num + 1);
        SetUI(num + 1);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
