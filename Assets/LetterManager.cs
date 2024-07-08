using UnityEngine;

public class LetterManager : MonoBehaviour
{
    private static int childCount;
    private static int _currentIndex;
    public static int CurrentIndex
    {
        get => _currentIndex;
        set => _currentIndex = Mathf.Clamp(value, 0, childCount);
    }

    private void UpdateControl()
    {
        if (!IsControlled) return;

        if (Input.GetKeyDown(KeyCode.LeftArrow)) CurrentIndex--;
        else if (Input.GetKeyDown(KeyCode.RightArrow)) CurrentIndex++;
    }

    void Update() => UpdateControl();
}
