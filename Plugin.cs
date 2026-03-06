using BepInEx;
using HarmonyLib;
using UnityEngine;

[BepInPlugin("com.connor.customgtagmenu", "Connor's Custom Mod Menu", "1.0.0")]
public class CustomModMenu : BaseUnityPlugin
{
    private bool showMenu = false;
    private bool speedBoost = false;
    private float speedMultiplier = 2f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1)) // Toggle menu with F1 (adapt for VR if needed)
        {
            showMenu = !showMenu;
        }
    }

    void OnGUI()
    {
        if (showMenu)
        {
            GUILayout.BeginArea(new Rect(10, 10, 200, 200));
            GUILayout.Label("Connor's Mod Menu");
            if (GUILayout.Button("Toggle Speed Boost"))
            {
                speedBoost = !speedBoost;
                // Apply to player (use decompiled game refs)
                // e.g., GorillaLocomotion.Player.Instance.maxArmLength *= speedBoost ? speedMultiplier : 1/speedMultiplier;
            }
            // Add more buttons: e.g., high jump, fly, etc.
            GUILayout.EndArea();
        }
    }
}
