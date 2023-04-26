using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AinuParsledzejs : MonoBehaviour {

    //metode lauj parslegties np UI ainas uz sakumu

    public void UzSakumu()
    {
        SceneManager.LoadScene("Sakums", LoadSceneMode.Single);
    }
    public void Apturet() {
        Application.Quit();
    }
    public void UzScene()
    {
        SceneManager.LoadScene("UI elementi", LoadSceneMode.Single);
    }

}
