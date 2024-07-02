using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cambiodescena : MonoBehaviour
{

    public void ControlScena(string escena)
    {
        SceneManager.LoadScene(escena);
    }

}
