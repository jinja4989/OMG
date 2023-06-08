using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManagerB : MonoBehaviour
{

    public int clicks = 0;
    public TMP_Text clickText;
    public TMP_Text clickText1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        clickText.text = "" + clicks;
        clickText1.text = "" + clicks;
    }

    public void Click()
    {
        clicks += 1;
    }
}