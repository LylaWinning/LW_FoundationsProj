using TMPro;
using UnityEngine;

public class PointHUD : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI pointText;

    int points = 0;

    private void Awake ()
    {
        updateHUD();
    }

    public int Points
    {
        get
        {
            return points;
        }
        set
        {
            points = value;
            updateHUD();
        }
    }
    private void updateHUD ()
    {
        pointText.text = points.ToString ();
    }
}
