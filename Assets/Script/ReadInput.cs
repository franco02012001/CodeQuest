using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReadInput : MonoBehaviour
{
    public static string playernamestr;

    public Text playername;

    private string input;
    // Start is called before the first frame update
    void Start()
    {
        playername.text = playernamestr;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //public void ReadStringInput(string s)
    //{
        //input = s;
        //Debug.Log(input);   
    //}
}
