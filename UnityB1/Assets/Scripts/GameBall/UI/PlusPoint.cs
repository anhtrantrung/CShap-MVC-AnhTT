using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlusPoint : MonoBehaviour
{
    public Text scoreTxt;
    int score = 0;
   
    public void GetScore()
    {
        if(scoreTxt != null)
        {
            score++;
            scoreTxt.text = ("Score: " + score);
        }    
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other != null && other.gameObject.tag == "Coin")
        {
            other.gameObject.SetActive(false);
            GetScore();
        }

        if (other != null && other.gameObject.tag == "Enemy")
        {
            GameControler.Instance.GameOver();

        }
    }
}
