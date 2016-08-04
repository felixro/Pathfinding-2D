using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public abstract class KeyboardManager
{
    public static KeyCode restartGameKey;

    public static KeyCode player1LeftKey = KeyCode.LeftArrow;
    public static KeyCode player1RightKey = KeyCode.RightArrow;
    public static KeyCode player1JumpKey = KeyCode.UpArrow;
    public static KeyCode player1DownKey = KeyCode.DownArrow;
    public static KeyCode player1ShootKey = KeyCode.S;
    public static KeyCode player1SwitchWeaponKey = KeyCode.RightShift;

    public static KeyCode mainMenuKey = KeyCode.Escape;
}
