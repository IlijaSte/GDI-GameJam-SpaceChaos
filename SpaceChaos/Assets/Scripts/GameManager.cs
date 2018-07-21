using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager I;

    [SerializeField]
    private Text fuel;

    [SerializeField]
    private float multiplier;

    float currentFuel = 100;

    private void Start()
    {
        I = this;
    }

    public void Play()
    {
        SceneManager.LoadScene("Level");
    }
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void FuelReduction()
    {
        currentFuel -= multiplier * Time.deltaTime;
        fuel.text = Mathf.RoundToInt(currentFuel).ToString();
    }
}
