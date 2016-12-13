using UnityEngine;
using System.Collections;


public class PauseGame : MonoBehaviour {

    public GameObject canvas;
    public Transform player;

	// Update is called once per frame
	void Update () {
        PauseTheGame();

    }

    public void PauseTheGame()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (canvas.gameObject.activeInHierarchy == false)
            {
                canvas.gameObject.SetActive(true);
                Time.timeScale = 0;
                //Disable player movement
                player.GetComponent<playerController>().enabled = false;
            }
            else
            {
                canvas.gameObject.SetActive(false);
                Time.timeScale = 1;
                //Re-enable player movement
                player.GetComponent<playerController>().enabled = false;
            }
        }
    }
}
