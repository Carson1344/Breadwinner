using UnityEngine;
using TMPro;

public class HUDManager : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI collectibleText;

    private float elapsedTime;
    private int collectibleCount;

    void Start()
    {
        // Set initial text values the moment the game boots up
        elapsedTime = 0f;
        timerText.text = "00:00";
        collectibleText.text = "Breads: 0";
    }

    void Update()
    {
        // 1. Add time passing every frame
        elapsedTime += Time.deltaTime;

        // 2. Break down the exact seconds and minutes
        int minutes = (int)(elapsedTime / 60f);
        int seconds = (int)(elapsedTime % 60f);

        // 3. Force the layout: MINUTES on left, SECONDS on right
        string minutesDisplay = minutes.ToString("00");
        string secondsDisplay = seconds.ToString("00");

        Debug.Log(minutes);

        // 4. Put them together clearly
        timerText.text = elapsedTime.ToString("0:00");
    }

    // Call this method when the player picks up an item
    public void AddCollectible()
    {
        collectibleCount++;
        collectibleText.text = "Breads: " + collectibleCount;
    }
}