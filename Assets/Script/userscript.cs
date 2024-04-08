using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class userscript : MonoBehaviour
{
    public TextMeshProUGUI output;
    public TMP_InputField userName;

    public void ButtonDone()
    {
        output.text = userName.text;
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
