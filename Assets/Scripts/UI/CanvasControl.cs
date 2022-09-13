using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasControl : MonoBehaviour {

    public event Action OnPlayClicked = delegate { };
    public event Action OnOptionsClicked = delegate { };
    public event Action OnReturnClicked = delegate { };
    public event Action OnExitClicked = delegate { };
    public event Action OnPauseClicked = delegate { };
    public event Action OnResumeClicked = delegate { };

    [SerializeField] private GameObject background;
    [SerializeField] private GameObject startMenu;
    [SerializeField] private GameObject optionsMenu;
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private GameObject pauseButton;

    private void Awake() {
        Hide();
    }

    public void ShowStartMenu() {
        background.SetActive(true);
        startMenu.SetActive(true);
        optionsMenu.SetActive(false);
        pauseMenu.SetActive(false);
        pauseButton.SetActive(false);
    }

    public void ShowOptionsMenu() {
        background.SetActive(true);
        startMenu.SetActive(false);
        optionsMenu.SetActive(true);
        pauseMenu.SetActive(false);
        pauseButton.SetActive(false);
    }

    public void ShowPauseMenu() {
        background.SetActive(true);
        startMenu.SetActive(false);
        optionsMenu.SetActive(false);
        pauseMenu.SetActive(true);
        pauseButton.SetActive(false);
    }

    public void Hide() {
        background.SetActive(false);
        startMenu.SetActive(false);
        optionsMenu.SetActive(false);
        pauseMenu.SetActive(false);
        pauseButton.SetActive(true);
    }

    public void NotifyPlayClicked() {
        OnPlayClicked();
    }
    
    public void NotifyOptionsClicked() {
        OnOptionsClicked();
    }

    public void NotifyReturnClicked() {
        OnReturnClicked();
    }

    public void NotifyExitClicked() {
        OnExitClicked();
    }

    public void NotifyResumeClicked() {
        OnResumeClicked();
    }

    public void NotifyPauseClicked() {
        OnPauseClicked();
    }
}
