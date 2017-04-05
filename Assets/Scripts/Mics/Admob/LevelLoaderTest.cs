using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class LevelLoaderTest : MonoBehaviour {

    [SerializeField]
    private Rect m_rect = new Rect();

    [SerializeField]
    private string m_levelToLoad = string.Empty;

    [SerializeField]
    GUIText m_guiText = null;

    void OnGUI()
    {
        m_rect.x = Screen.width - m_rect.width;

        if (GUI.Button(m_rect, "Next Scene", (GUIStyle)"button"))
        {
            Application.LoadLevel(m_levelToLoad);
        }

        if (m_guiText)
        {
            m_guiText.text = "Scene: \n" + Application.loadedLevelName;
        }
    }
}
