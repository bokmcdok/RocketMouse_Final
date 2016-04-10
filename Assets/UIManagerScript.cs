//------------------------------------------------------------------------------
//  UI Manager Script
//      The main script for our UI.
//------------------------------------------------------------------------------

using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManagerScript : MonoBehaviour
{
    //------------------------------------------------------------------------------
    //  Start Game
    //      Loads the main game scene.
    //------------------------------------------------------------------------------

    public void StartGame()
    {
        SceneManager.LoadScene("RocketMouse");
    }
}
