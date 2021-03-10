using UnityEngine;
using UnityEngine.UI;

public class ExitButton : MonoBehaviour 
{
    private void Awake()
    {
        GetComponent<Button>().onClick.AddListener(ExitCallback);
    }

    private void ExitCallback()
    {
    #if UNITY_EDITOR
        if(UnityEditor.EditorApplication.isPlaying)
            UnityEditor.EditorApplication.ExitPlaymode();
    #else
        Application.Quit();
    #endif
    }
}
