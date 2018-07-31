using UnityEngine;
using UnityEngine.UI;
public class Test : MonoBehaviour
{
    private AndroidJavaObject crtActivity;
    public Text message;
    public Button button;
    // 放在MsgController的游戏物体上
    void Start()
    {
        AndroidJavaClass javaClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        crtActivity = javaClass.GetStatic<AndroidJavaObject>("currentActivity");

        message = GameObject.Find("Canvas/Text").GetComponent<Text>();
        button = GameObject.Find("Canvas/Button").GetComponent<Button>();
        button.onClick.AddListener(BeginListen);
    }
    //绑定按钮
    public void BeginListen()
    {
        crtActivity.Call("beginListen");
    }
    //java中 UnityPlayer.UnitySendMessage("MsgController", "OnResult", resultBuffer.toString());来调用
    void OnResult(string str)
    {
        message.text = str;
    }
}