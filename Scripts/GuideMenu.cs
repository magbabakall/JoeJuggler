using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuideMenu : MonoBehaviour
{
    public GameObject guideMenu;
    public GuideButton guideButton;

    // Start is called before the first frame update
    void Start()
    {
        guideButton = GameObject.FindGameObjectWithTag("GuideButton").GetComponent<GuideButton>();
        guideMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void guideTab()
    {
        guideMenu.SetActive(true);
        Time.timeScale = 0;
        guideButton.isGuide = false;
    }

    public void backGame()
    {
        guideMenu.SetActive(false);
        Time.timeScale = 1;

    }
}
