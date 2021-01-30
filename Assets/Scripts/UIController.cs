using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    // Create element classes
    [System.Serializable]
    public class suspicionElements
    {
        public Color suspicionOff = new Color(58, 58, 58);
        public Color suspicionOn = new Color(255, 0, 0);

        // Suspicion bar images
        public RawImage susBar1;
        public RawImage susBar2;
        public RawImage susBar3;
        public RawImage susBar4;
        public RawImage susBar5;

        public void clearSuspicion()
        {
            susBar1.color = suspicionOff;
            susBar2.color = suspicionOff;
            susBar3.color = suspicionOff;
            susBar4.color = suspicionOff;
            susBar5.color = suspicionOff;
        }

        public void updateSuspicion(int newSuspicion)
        {
            clearSuspicion();
            if (newSuspicion > 0)
            {
                susBar1.color = suspicionOn;
            }
            if (newSuspicion > 1)
            {
                susBar2.color = suspicionOn;
            }
            if (newSuspicion > 2)
            {
                susBar3.color = suspicionOn;
            }
            if (newSuspicion > 3)
            {
                susBar4.color = suspicionOn;
            }
            if (newSuspicion > 4)
            {
                susBar5.color = suspicionOn;
            }
        }
    }

    [System.Serializable]
    public class timeElements
    {
        public Text timeText;

        public void updateTime (string newTime)
        {
            timeText.text = newTime;
        }
    }
    
    [System.Serializable]
    public class scoreElements {
        public Text scoreText;

        public void updateScore(string newScore)
        {
            scoreText.text = newScore;
        } 
    }

    [System.Serializable]
    public class bottomBarElements {
        public Text introText;
        public Text objectText;

        public void showHideText() {
            introText.enabled = !introText.enabled;
            objectText.enabled = !objectText.enabled;
        }

        public void updateObjectText (string newObjectText)
        {
            objectText.text = newObjectText;
        }
    }

    [System.Serializable]
    public class objectsElements { }

    // Generate element instances
    public suspicionElements suspicion;
    public timeElements time;
    public scoreElements score;
    public bottomBarElements bottomBar;
    public objectsElements objects;

    public void Start ()
    {
        suspicion.clearSuspicion();
        time.updateTime("09:00");
        score.updateScore("0");
    }
}
