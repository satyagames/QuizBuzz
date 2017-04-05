using UnityEngine;
using System.Collections;
using UnityEditor;

namespace com.microeyes.admob
{
    public class EditorAdmobSettingsWizard : ScriptableWizard
    {
        AdmobSettings m_settings;

        [MenuItem("Window/Create Admob Settings")]
        static void OpenWindow()
        {
            AdmobSettings m_settings = AssetDatabase.LoadAssetAtPath(AdmobConstants.SettingsLocation, typeof(AdmobSettings)) as AdmobSettings;
            if (m_settings == null)
            {
                m_settings = ScriptableObject.CreateInstance<AdmobSettings>();
                AssetDatabase.CreateAsset(m_settings, AdmobConstants.SettingsLocation);
                Debug.Log("Admob Settings saved in 'Resources' folder in Assets");
            }
            else
            {
                Debug.Log("Admob Settings already present in 'Resource' folder in Assets");
            }
        }

    }

}