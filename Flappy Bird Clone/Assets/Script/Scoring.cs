using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scoring : MonoBehaviour
{
    public int score = 0;
    public TMP_Text text;

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Score")
        {
            score++;
            text.text = score.ToString();
        }
    }
}
