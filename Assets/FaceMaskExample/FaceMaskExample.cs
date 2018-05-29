﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

#if UNITY_5_3 || UNITY_5_3_OR_NEWER
using UnityEngine.SceneManagement;
#endif

namespace FaceMaskExample
{
    /// <summary>
    /// Face mask example.
    /// </summary>
    public class FaceMaskExample : MonoBehaviour
    {
        public Text exampleTitle;
        public Text versionInfo;
        public ScrollRect scrollRect;
        static float verticalNormalizedPosition = 1f;

        // Use this for initialization
        void Start ()
        {
            exampleTitle.text = "FaceMask Example " + Application.version;

            versionInfo.text = OpenCVForUnity.Core.NATIVE_LIBRARY_NAME + " " + OpenCVForUnity.Utils.getVersion () + " (" + OpenCVForUnity.Core.VERSION + ")";
            versionInfo.text += " / " + "dlibfacelandmarkdetector" + " " + DlibFaceLandmarkDetector.Utils.getVersion ();
            versionInfo.text += " / UnityEditor " + Application.unityVersion;
            versionInfo.text += " / ";

            #if UNITY_EDITOR
            versionInfo.text += "Editor";
            #elif UNITY_STANDALONE_WIN
            versionInfo.text += "Windows";
            #elif UNITY_STANDALONE_OSX
            versionInfo.text += "Mac OSX";
            #elif UNITY_STANDALONE_LINUX
            versionInfo.text += "Linux";
            #elif UNITY_ANDROID
            versionInfo.text += "Android";
            #elif UNITY_IOS
            versionInfo.text += "iOS";
            #elif UNITY_WSA
            versionInfo.text += "WSA";
            #elif UNITY_WEBGL
            versionInfo.text += "WebGL";
            #endif
            versionInfo.text +=  " ";
            #if ENABLE_MONO
            versionInfo.text +=  "Mono";
            #elif ENABLE_IL2CPP
            versionInfo.text += "IL2CPP";
            #elif ENABLE_DOTNET
            versionInfo.text += ".NET";
            #endif

            scrollRect.verticalNormalizedPosition = verticalNormalizedPosition;
        }

        // Update is called once per frame
        void Update ()
        {

        }

        public void OnScrollRectValueChanged ()
        {
            verticalNormalizedPosition = scrollRect.verticalNormalizedPosition;
        }


        public void OnShowLicenseButtonClick ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene ("ShowLicense");
            #else
            Application.LoadLevel ("ShowLicense");
            #endif
        }

        public void OnTexture2DFaceMaskExampleButtonClick ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene ("Texture2DFaceMaskExample");
            #else
            Application.LoadLevel ("Texture2DFaceMaskExample");
            #endif
        }
        
        public void OnVideoCaptureFaceMaskExampleButtonClick ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene ("VideoCaptureFaceMaskExample");
            #else
            Application.LoadLevel ("VideoCaptureFaceMaskExample");
            #endif
        }

        public void OnWebCamTextureFaceMaskExampleButtonClick ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene ("WebCamTextureFaceMaskExample");
            #else
            Application.LoadLevel ("WebCamTextureFaceMaskExample");
            #endif
        }

        public void OnWebCamTextureFaceMaskAdditionalExampleButtonClick ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene ("WebCamTextureFaceMaskAdditionalExample");
            #else
            Application.LoadLevel ("WebCamTextureFaceMaskAdditionalExample");
            #endif
        }
    }
}