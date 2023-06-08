using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public int clicks = 0;
    public TMP_Text clickText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        clickText.text = "" + clicks;
    }

    public void Click1()
    {
        clicks += 1000;
    }
    public void Click2()
    {
        clicks += 3000;
    }
    public void Click3()
    {
        clicks += 10000;
    }
    public void Click4()
    {
        clicks += 50000;
    }
}