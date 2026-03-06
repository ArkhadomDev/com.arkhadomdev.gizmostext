# Gizmos Pixel Text 🎨
Lightweight tool for visual debugging in Scene View.

## Installation
In the Unity Package Manager, select `Add package from git URL` and paste:
`https://github.com/ArkhadomDev/com.arkhadomdev.gizmostext.git`

## Use Example
```csharp
using UnityEngine;

public class EnemyDebug : MonoBehaviour {
    void OnDrawGizmos() {
        GizmosUtility.DrawText("Alive Enemy", transform.position + Vector3.up * 2f, 0.25f);
    }
}
```

## Credits and Attributions
This package utilises the font **Pixellari**, created by **Zacchary Dempsey-Plante**.
The **Pixellari** font is used on the assets present on `Gizmos` folder.
The **Pixellari** was aquired from `dafont.com`, here is a link to it's creator page: `https://ztdp.ca/`.