/*
 * 名称：Demo2.cs
 * 作者：HanXu
 * 功能：
*/
// SceneComponent是专门用于处理场景逻辑的框架组件
//初始化场景是不会被销毁的
//因为初始场景是用来存放框架基础组件的，所以这个场景是不会被卸载的。在切换场景的时候，实际上只是加载了新场景，初始场景并不会消失（否则那些基础组件不就没了）。 
using System.Collections;
using System.Collections.Generic;
using GameFramework;
using GameFramework.Procedure;
using UnityEngine;
using UnityGameFramework.Runtime;
using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;

public class Demo2_ProcedureLaunch : ProcedureBase {
    protected override void OnEnter(ProcedureOwner procedureOwner)
    {
        base.OnEnter(procedureOwner);

        Log.Debug("初始！！");

        SceneComponent scene = GameEntry.GetComponent<SceneComponent>();//SceneComponent是专门用于处理场景逻辑的框架组件
        Log.Debug(scene.name);

        // 切换场景
//        scene.LoadScene("Demo2_Menu");  无法使用，要全路径 ，可以封装一个获取场景的方法
        scene.LoadScene("Assets/Demo2/Demo2_Menu.unity");//切换场景的函数
//        LoadScene还可以传参数
        // 切换流程
        ChangeState<Demo2_ProcedureMenu>(procedureOwner);
        //ChangeState函数用于切换流程。
        //按照官方的示例项目，应该是先在OnEnter切换场景，然后在Update里切换流程，而且有一个专门的流程用于处理这些切换。
        //本Demo仅作演示功能，不代表最佳实践，请不要随意学习。
        //我们在进入初始场景时，立刻就切换到菜单场景（旁白：那为什么不直接把菜单场景设为初始场景？）
        //对，为什么不把菜单场景设为初始场景呢？*****因为初始场景是用来存放框架基础组件的，所以这个场景是不会被卸载的。******
        //在切换场景的时候，实际上只是加载了新场景，初始场景并不会消失（否则那些基础组件不就没了）。 
    }
}


//1.切换流程和场景
//2.设置流程