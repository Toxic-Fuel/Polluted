using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GraphicalOptions : MonoBehaviour
{
   public TMPro.TMP_Dropdown TextureDropDown;
    public TMPro.TMP_InputField FPSCapInputField;
    public Toggle VSyncTog;
   public void TextureChanged()
   {
        QualitySettings.globalTextureMipmapLimit = TextureDropDown.value;
   }
    public void OnChangedVsyncFps()
    {
        if (VSyncTog.isOn)
        {
            QualitySettings.vSyncCount = 1;
        }
        else
        {
            QualitySettings.vSyncCount = 0;
            Application.targetFrameRate = int.Parse(FPSCapInputField.text);
        }
    }
}
