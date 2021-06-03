using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadJogar : MonoBehaviour
{
    public void LoadJogarScene()
    {
        SceneManager.LoadScene("Nivel1");
    }
}
