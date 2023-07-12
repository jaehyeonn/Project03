using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public static partial class GFunc 
{
    [System.Diagnostics.Conditional("DEBUG_MODE")]
    public static void Log(object message)
    {
#if DEBUG_MODE
        Debug.Log(message);
#endif
    }
    [System.Diagnostics.Conditional("DEBUG_MODE")]
    public static void LogWarning(object message)
    {
#if DEBUG_MODE
        Debug.LogWarning(message);
#endif
    }
    [System.Diagnostics.Conditional("DEBUG_MODE")]
    public static void Assert (bool condition)
    {
#if DEBUG_MODE
        Debug.Assert(condition);
#endif
    }

    //! GameO �޾Ƽ� Text ������Ʈ ã�Ƽ� text �ʵ� �� �������ϴ� �Լ�

    public static void SetText(this GameObject target, string text)
    {
        Text textComponent = target.GetComponent<Text>();
        if (textComponent == null || textComponent == default) { return; }

        textComponent.text = text;
    }
    public static void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public static string GetActiveSceneName()
    {
        return SceneManager.GetActiveScene().name;
    }
    //�� ���͸� ���Ѵ�
    public static Vector2 AddVector(this Vector3 origin, Vector2 addVector)
    {
        Vector2 result = new Vector2(origin.x, origin.y);
        result += addVector;
            return result;
    }
    // ������Ʈ�� �����ϴ��� ���θ� üũ�ϴ� �Լ�
    public static  bool Isvalid<T>(this T target) where T: Component
    {
        if(target == null || target == default) { return false; }
        else { return true; }
    }
    //����Ʈ�� ��ȿ���� ���θ� üũ�ϴ� �Լ�
    public static bool Isvalid<T>(this List<T> target) where T : Component
    {
        bool isInvalid = (target == null || target == default);
        isInvalid = isInvalid || target.Count == 0;

        if (isInvalid == true) { return false; }
        else { return true; }
    }
}