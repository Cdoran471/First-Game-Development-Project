using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    int score = 0;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Amogu")
        {
            score++;
            Debug.Log(score);
        }
    }
}
