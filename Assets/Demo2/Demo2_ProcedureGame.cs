/*
 * 名称：Demo2_Game.cs
 * 作者：HanXu
 * 功能：
*/

using System.Collections;
using System.Collections.Generic;
using GameFramework;
using GameFramework.Procedure;
using UnityEngine;
using UnityGameFramework.Runtime;
using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;

public class Demo2_ProcedureGame : ProcedureBase
{
    protected override void OnEnter(ProcedureOwner procedureOwner)
    {
        base.OnEnter(procedureOwner);
        Log.Debug("进入游戏流程，可以在这里处理游戏逻辑，这条日志不会打印，因为没有切换到Game流程");
    }
}

//由于切换流程需要在继承了ProcedureBase的类里操作，而我们的Demo2_Controller类只是一个普通的MonoBehavior类，
//所以没法在切换场景的时候同时切换流程。
//只好作罢，我们下一个Demo再一起看看怎么用框架的方式加载UI，那样就能进行比较完整的流程和场景切换演示了。