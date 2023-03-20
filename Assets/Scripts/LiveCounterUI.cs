using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LiveCounterUI : MonoBehaviour
{
    BallBehaviour ball;
    TMP_Text LivesText;
    // Start is called before the first frame update
    void Start()
    {
        LivesText = GetComponent<TMP_Text>();
        ball = FindObjectOfType<BallBehaviour>();
        if (ball.gameObject == null) { Destroy(this.gameObject); }
    }

    // Update is called once per frame
    void Update()
    {
        LivesText.text = $"Lives: {ball.lives}";
    }
}
