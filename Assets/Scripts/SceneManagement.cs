using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    //Methode pour changer de scene enutilisant le bouton dans la scene "ExamenC_01"

    public void GoToNextScene()
    {
        SceneManager.LoadScene("ExamenC_02");
    }
}
