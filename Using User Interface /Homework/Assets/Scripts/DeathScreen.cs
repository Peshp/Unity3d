using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DeathScreen : MonoBehaviour
{
    public TMP_Text timer;
    private Image deathScreen;

    // Update is called once per frame
    void Update()
    {
        if (timer != null)
        {
            if (timer.ToString() == "0:00")
            {
                deathScreen.transform.position = new Vector3(-83f, -2.5f, 0f);
            }
        }        
    }
}
