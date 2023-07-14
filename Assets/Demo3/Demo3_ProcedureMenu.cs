using System.Collections;
using System.Collections.Generic;
using GameFramework;
using GameFramework.Procedure;
using UnityEngine;
using UnityGameFramework.Runtime;
using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;

public class Demo3_ProcedureMenu : ProcedureBase
{
    protected override void OnEnter(ProcedureOwner procedureOwner)

    {
        base.OnEnter(procedureOwner);

        // 加载框架UI组件
        UIComponent UI
            = UnityGameFramework.Runtime.GameEntry.GetComponent<UIComponent>();//和GetScenceConponent类似的用法

        // 加载UI，，，，这个Demo的主要东西

        UI.OpenUIForm("Assets/Demo3/UI_Menu.prefab", "DefaultGroup");
        Log.Debug("加载UI完毕");
    }
//    UIComponent是Game Framework框架的基础组件，专门用于处理界面相关的逻辑。

//    比如我们现在要加载UI，就需要用到它的OpenIUIForm的函数。
//
//    函数的第一个参数需要的是UI预制体所在的路径，需要完整路径，从Assets目录开始。
//
//    函数的第二个参数需要的是UI所属的分组，比如不同的UI分组显示的层次会不一样，这里我们先填一个"DefaultGroup"（然后要在框架预制体中找到UI添加这个组）
}