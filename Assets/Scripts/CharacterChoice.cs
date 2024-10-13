using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterChoice : MonoBehaviour
{
    public void MyCharacter()
    {
        SceneManager.LoadScene("CharacterChoice");
    }
}
