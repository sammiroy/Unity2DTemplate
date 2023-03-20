using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreCounterUI : MonoBehaviour
{
    BallBehaviour ball;
    TMP_Text ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        ScoreText = GetComponent<TMP_Text>();
        ball = FindObjectOfType<BallBehaviour>();
        if(ball.gameObject == null) { Destroy(this.gameObject); }
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = $"Score: {ball.points}";
    }
}
