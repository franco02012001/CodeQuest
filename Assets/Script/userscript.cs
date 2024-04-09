using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class userscript : MonoBehaviour
{
    //public TextMeshProUGUI output;
    public TMP_InputField playername;

    public void ButtonDone()
    {
        Debug.Log("Player Name is:" +  playername.text);
        ReadInput.playernamestr = playername.text;
        //output.text = userName.text;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
