using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GateCount : MonoBehaviour
{
    private int gates;
    public TMP_Text text;

    void Start()
    {
        gates = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        string textGate = string.Format($"{gates}");

        if (other.name == "GateDetector")
        {
            gates++;
            text.text = textGate;
        }
    }
}
