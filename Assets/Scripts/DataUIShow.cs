using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DataUIShow : MonoBehaviour
{
    TextMeshProUGUI text;

    private void Start()
    {
        text = this.gameObject.GetComponent<TextMeshProUGUI>();
    }
    void Update()
    {
        text.text = $"Your score: {Player.score}";
    }
}
