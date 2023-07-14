using System.Collections;
using System.Collections.Generic;
using GameFramework;
using GameFramework.Event;
using GameFramework.Procedure;
using UnityEngine;
using UnityGameFramework.Runtime;
using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;

public class Demo4_ProcedureMenu : ProcedureBase
{
    protected override void OnEnter(ProcedureOwner procedureOwner)
    {
        
        //    对于加载框架自带组件的方式，都是一样的，通过UnityGameFramework.Runtime.GameEntry.GetComponent的方式加载
//
//    为了订阅事件，我们需要加载框架的EventComponent组件。
//
//    订阅事件的方式很简单：Event.Subscribe(事件唯一ID, 回调函数)。
//
//    OpenUIFormSuccessEventArgs是框架自带的事件类，这个事件类处理的是"打开界面成功事件"，而它的EventId只是一个确保唯一的int类型，用于标识这是什么事件。
//
//    而回调函数，当然就是事件发生时我们希望调用的函数了。 
        base.OnEnter(procedureOwner);
        // 加载框架Event组件
        EventComponent Event
            = UnityGameFramework.Runtime.GameEntry.GetComponent<EventComponent>();
        // 加载框架UI组件
        UIComponent UI
            = UnityGameFramework.Runtime.GameEntry.GetComponent<UIComponent>();
        // 订阅UI加载成功事件
        Event.Subscribe(OpenUIFormSuccessEventArgs.EventId, OnOpenUIFormSuccess);
        // 加载UI
        UI.OpenUIForm("Assets/Demo4/UI_Menu.prefab", "DefaultGroup", this);//最后一个参数是UserData，这是一个自定义的数据，你想传什么都行，在事件发生时，它会通过回调函数传回来。 
    }
    private void OnOpenUIFormSuccess(object sender, GameEventArgs e)//可以做成生命周期
    {
        OpenUIFormSuccessEventArgs ne = (OpenUIFormSuccessEventArgs)e;
        // 判断userData是否为自己
        if (ne.UserData != this)
        {
            return;
        }
        Log.Debug("UI_Menu：恭喜你，成功地召唤了我。");
    }

}