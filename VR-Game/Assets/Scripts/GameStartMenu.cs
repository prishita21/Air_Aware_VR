using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStartMenu : MonoBehaviour
{
    [Header("UI Pages")]
    public GameObject mainMenu;
    public GameObject options;
    public GameObject about;

    [Header("Main Menu Buttons")]
    public Button scene1Button;
    public Button scene2Button;
    public Button scene3Button;
    public Button scene4Button;
    public Button scene5Button;

    public Button quitButton;

    public List<Button> returnButtons;

    // Start is called before the first frame update
    void Start()
    {
        EnableMainMenu();

        //Hook events
        scene1Button.onClick.AddListener(Scene1);
        scene2Button.onClick.AddListener(Scene2);
        scene3Button.onClick.AddListener(Scene3);
        scene3Button.onClick.AddListener(Scene4);
        scene3Button.onClick.AddListener(Scene5);

        quitButton.onClick.AddListener(QuitGame);

        foreach (var item in returnButtons)
        {
            item.onClick.AddListener(EnableMainMenu);
        }
    }

    public void QuitGame()
    {
        HideAll();
        SceneTransitionManager.singleton.GoToSceneAsync(0);
    }

    public void Scene1()
    {
        HideAll();
        SceneTransitionManager.singleton.GoToSceneAsync(1);
    }
    public void Scene2()
    {
        HideAll();
        SceneTransitionManager.singleton.GoToSceneAsync(2);
    }
    public void Scene3()
    {
        HideAll();
        SceneTransitionManager.singleton.GoToSceneAsync(3);
    }
    public void Scene4()
    {
        HideAll();
        SceneTransitionManager.singleton.GoToSceneAsync(4);
    }
    public void Scene5()
    {
        HideAll();
        SceneTransitionManager.singleton.GoToSceneAsync(5);
    }
    public void HideAll()
    {
        mainMenu.SetActive(false);
        options.SetActive(false);
        about.SetActive(false);
    }

    public void EnableMainMenu()
    {
        mainMenu.SetActive(true);
        options.SetActive(false);
        about.SetActive(false);
    }
    public void EnableOption()
    {
        mainMenu.SetActive(false);
        options.SetActive(true);
        about.SetActive(false);
    }
    public void EnableAbout()
    {
        mainMenu.SetActive(false);
        options.SetActive(false);
        about.SetActive(true);
    }
}
