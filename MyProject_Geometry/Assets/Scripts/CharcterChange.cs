using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CharcterChange : MonoBehaviour
{
    public void ChangeChar()
    {
        SceneManager.LoadScene("CharacterScene");
    }
}
