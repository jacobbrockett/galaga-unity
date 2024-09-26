using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Must Include:
using UnityEngine.UI;
using TMPro;

public class PointCounter : MonoBehaviour
{
    [SerializeField] PlayerInputHandler playerInputHandler; // always connected to what player is controlling

    [SerializeField] TextMeshProUGUI pointText;

    // Update is called once per frame
    void Update()
    {
        int currentPoints = playerInputHandler.GetCurrentPoints();

        pointText.text = "Point: " + currentPoints.ToString();
    }
}
