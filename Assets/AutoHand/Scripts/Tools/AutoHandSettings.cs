using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoHandSettings : ScriptableObject{
    [Tooltip("Whether the popup should be ignored on launch or not")]
    public bool ignoreSetup = false;
    public bool usingDynamicTimestep = true;
    public bool useAutomaticControllerOffset = true;
    [Tooltip("-1 is custom, 0 is low, 1 is medium, 2 is high")]
    public float quality = -1;

    public static void ClearSettings() {
        var _handSettings = Resources.Load<AutoHandSettings>("AutoHandSettings");
        _handSettings.ignoreSetup = false;
        _handSettings.usingDynamicTimestep = true;
        _handSettings.quality = -1;
#if UNITY_EDITOR
        UnityEditor.EditorUtility.SetDirty(_handSettings);
#endif
    }
    public static bool UsingDynamicTimestep() {
        var _handSettings = Resources.Load<AutoHandSettings>("AutoHandSettings");
        return _handSettings.usingDynamicTimestep;
    }
}
