using UnityEngine;
using UnityEngine.UI;

public class StartUIController : MonoBehaviour
{
    public Text lastText;
    public Text bestText;
    public Toggle blue;
    public Toggle yellow;
    public Toggle border;
    public Toggle noBorder;

    void Awake()
    {
        lastText.text = "Last：Length" + PlayerPrefs.GetInt("lastl", 0) + "，Score" + PlayerPrefs.GetInt("lasts", 0);
        bestText.text = "Best：Length" + PlayerPrefs.GetInt("bestl", 0) + "，Score" + PlayerPrefs.GetInt("bests", 0);
    }

    void Start()
    {
        if (PlayerPrefs.GetString("snake_head", "head2") == "head2")
        {
            blue.isOn = true;
            PlayerPrefs.SetString("snake_head", "head2");
            PlayerPrefs.SetString("snake_body_01", "body_blue_01");
            PlayerPrefs.SetString("snake_body_02", "body_blue_02");
        }
        else
        {
            yellow.isOn = true;
            PlayerPrefs.SetString("snake_head", "head1");
            PlayerPrefs.SetString("snake_body_01", "body_yellow_01");
            PlayerPrefs.SetString("snake_body_02", "body_yellow_02");
        }
        if (PlayerPrefs.GetInt("border", 1) == 1)
        {
            border.isOn = true;
            PlayerPrefs.SetInt("border", 1);
        }
        else
        {
            noBorder.isOn = true;
            PlayerPrefs.SetInt("border", 0);
        }
    }

    public void BlueSelected(bool isOn)
    {
        if (isOn)
        {
            PlayerPrefs.SetString("snake_head", "head2");
            PlayerPrefs.SetString("snake_body_01", "body_blue_01");
            PlayerPrefs.SetString("snake_body_02", "body_blue_02");
        }
    }

    public void YellowSelected(bool isOn)
    {
        if (isOn)
        {
            PlayerPrefs.SetString("snake_head", "head1");
            PlayerPrefs.SetString("snake_body_01", "body_yellow_01");
            PlayerPrefs.SetString("snake_body_02", "body_yellow_02");
        }
    }

    public void BorderSelected(bool isOn)
    {
        if (isOn)
        {
            PlayerPrefs.SetInt("border", 1);
        }
    }

    public void NoBorderSelected(bool isOn)
    {
        if (isOn)
        {
            PlayerPrefs.SetInt("border", 0);
        }
    }

    public void StartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
}
