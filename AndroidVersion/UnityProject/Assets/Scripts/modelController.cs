using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class modelController : MonoBehaviour {

    private AndroidJavaObject crtActivity;
    private Animator anim;   //动画控制器
    private string message="";

    // Use this for initialization
    void Start () {
        anim = GameObject.Find("ImageTarget/Misaki").GetComponent<Animator>();
        AndroidJavaClass javaClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        crtActivity = javaClass.GetStatic<AndroidJavaObject>("currentActivity");//初始化
    }
	
	// Update is called once per frame
	void Update () {
        /*if (Input.GetKeyDown("up"))  //检查键盘事件
        {
            anim.SetTrigger("dancing");
        }

        if (Input.GetKeyDown("down"))
        {
            anim.SetTrigger("walk_front");
        }*/
    }

    void OnGUI()
    {
        //speakingButton = GUI.Button(new Rect(Screen.width - 10, 10, 80, 40), "Speaking");
        //content = GUI.Text(new Rect(Screen.width - 10, 100, 80, 80));
        //GUI.Box(new Rect(Screen.width - 110 , 10 ,100 ,90), "Change Motion");
        if (GUI.Button(new Rect((float)(Screen.width*0.8), (float)(Screen.height* 0.08), (float)(0.1 *Screen.width), (float)(0.06*Screen.height)), "成为舞姬"))  //跳舞
        {
            anim.SetTrigger("dancing");
        }
        // Rect(x,y,a,b)  x,y 位置 a,b 框大小 640*480
        if (GUI.Button(new Rect((float)(Screen.width*0.8), (float)(Screen.height * 0.18), (float)(0.1 * Screen.width), (float)(0.06 * Screen.height)), "看风景")) //向前走
        {
            anim.SetTrigger("walking");
        }
        if (GUI.Button(new Rect((float)(Screen.width * 0.8), (float)(Screen.height * 0.28), (float)(0.1 * Screen.width), (float)(0.06 * Screen.height)), "成为歌姬")) //唱歌
        {
            anim.SetTrigger("singing");
        }
        if (GUI.Button(new Rect((float)(Screen.width * 0.8), (float)(Screen.height * 0.38), (float)(0.1 * Screen.width), (float)(0.06 * Screen.height)), "做做运动")) //跑
        {
            anim.SetTrigger("running");
        }
        if (GUI.Button(new Rect((float)(Screen.width * 0.8), (float)(Screen.height * 0.48), (float)(0.1 * Screen.width), (float)(0.06 * Screen.height)), "休息一下")) //停
        {
            anim.SetTrigger("stop");
        }
        GUI.skin.button.fontSize = (int)(Screen.width*0.02);

        //Speaking button
        if(GUI.Button(new Rect((float)(Screen.width * 0.1), (float)(Screen.height * 0.08), (float)(0.1 * Screen.width), (float)(0.06 * Screen.height)), "语音指令"))
        {
            crtActivity.Call("beginListen");
        }

        //Speaking content
        GUIStyle font = new GUIStyle();
        font.normal.background = null;    //这是设置背景填充的
        font.normal.textColor = new Color(255, 255, 255);   //设置字体颜色的
        font.fontSize = (int)(Screen.width * 0.02); 
        GUI.Label(new Rect((float)(Screen.width * 0.1), (float)(Screen.height * 0.18), (float)(0.2 * Screen.width), (float)(0.08 * Screen.height)), message,font);
    }

    //java中 UnityPlayer.UnitySendMessage("MsgController", "OnResult", resultBuffer.toString());来调用
    void OnResult(string str)
    {
        message = str;
        if (str.Contains("跳舞")|| str.Contains("舞"))
        {
            anim.SetTrigger("stop");
            anim.SetTrigger("dancing");
        }
        if (str.Contains("唱歌")|| str.Contains("歌"))
        {
            anim.SetTrigger("stop");
            anim.SetTrigger("singing");
        }
        if (str.Contains("走")|| str.Contains("看风景"))
        {
            anim.SetTrigger("stop");
            anim.SetTrigger("walking");
        }
        if (str.Contains("跑")|| str.Contains("活动一下")|| str.Contains("运动"))
        {
            anim.SetTrigger("stop");
            anim.SetTrigger("running");
        }
        if (str.Contains("停")|| str.Contains("休息")|| str.Contains("好了好了"))
        {
            anim.SetTrigger("stop");
        }
    }
}
