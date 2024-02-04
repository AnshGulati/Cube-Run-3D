using UnityEngine;
using UnityEngine.UI; // Imports all the necessary functions of UI into the code.
using TMPro; // Imports all the necessary functions of TextMesh Editor into the code.
public class Score : MonoBehaviour
{
    public Transform player; // This is a reference of Transform as player.

    public TextMeshProUGUI ScoreText; // This is a reference of TextMesh as Score text.
    // Update is called once per frame
    void Update()
    {
        // the text inside ScoreText is equal to position of player according to z-axis.
        ScoreText.text = player.position.z.ToString("0"); // ToString is used here to convert float to string.And 0 is entered to remove the decimals in the score displayed.
    }
}