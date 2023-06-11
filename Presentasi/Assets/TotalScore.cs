using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalScore : MonoBehaviour
{
    [SerializeField] private Text chestText;

    public void GetPoints() {
        int receivedPoints = ItemCollector.point;
        chestText.text = "Point : " + receivedPoints;
    }
}
