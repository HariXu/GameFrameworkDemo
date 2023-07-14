/*
 * 名称：Demo2_Controller.cs
 * 作者：HanXu
 * 功能：
*/

//此UI只是作为过度
//由于切换流程需要在继承了ProcedureBase的类里操作，而我们的Demo2_Controller类只是一个普通的MonoBehavior类，所以没法在切换场景的时候同时切换流程。
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityGameFramework.Runtime;

//public class Demo2_Controller : MonoBehaviour
//{
//    public void EnterGame()
//    {
//        SceneComponent scene = GameEntry.GetComponent<SceneComponent>();//这个是获取到当前场景的SceneComponent
//        scene.LoadScene("Assets/Demo2/Demo2_Game.unity");
//        Log.Debug("切换场景到Demo2_Game");
//    }
//}







using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityGameFramework.Runtime;
public class Demo2_Controller : MonoBehaviour {
    public void EnterGame() {
        // 获取框架场景组件
        SceneComponent Scene
            = UnityGameFramework.Runtime.GameEntry.GetComponent<SceneComponent>();

        // 卸载所有场景
        string[] loadedSceneAssetNames = Scene.GetLoadedSceneAssetNames();//官方给的获取所有场景的方法
        for (int i = 0; i < loadedSceneAssetNames.Length; i++)
        {
            Scene.UnloadScene(loadedSceneAssetNames[i]);//卸载方法
        }

        // 加载游戏场景
        Scene.LoadScene("Assets/Demo2/Demo2_Game.unity");
    }
}
