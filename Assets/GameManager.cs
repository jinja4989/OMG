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

    public void Click()
    {
        clicks += 100000;
    }
}