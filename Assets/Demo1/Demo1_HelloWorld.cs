/*
 * 名称：Demo1.cs
 * 作者：HanXu
 * 功能：
*/


//*****GameFramework这个预制体包含了框架的基本组件*****
//


using GameFramework.Procedure;
using UnityGameFramework.Runtime;
using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;

/// <summary>
/// Demo1_HelloWorld
/// </summary>
public class Demo1_HelloWorld : ProcedureBase //继承ProcedureBase就是一个流程，然后在GameFramework下的Procedure中添加，可以看一下ProcedureBase里面都有什么
{
    protected override void OnEnter(ProcedureOwner procedureOwner)
    {
        base.OnEnter(procedureOwner);

        string welcomeMessage = "HelloWorld!";

        Log.Info(welcomeMessage);

        Log.Warning(welcomeMessage);

        Log.Error(welcomeMessage);
    }
}


/*1.Log日志系统

作者的话：2.流程：流程 (Procedure) – 是贯穿游戏运行时整个生命周期的有限状态机。
通过流程，将不同的游戏状态进行解耦将是一个非常好的习惯。
对于网络游戏，你可能需要如检查资源流程、更新资源流程、检查服务器列表流程、选择服务器流程、
登录服务器流程、创建角色流程等流程，而对于单机游戏，你可能需要在游戏选择菜单流程和游戏实际玩法流程之间做切换。
如果想增加流程，只要派生自 ProcedureBase 类并实现自己的流程类即可使用。

a.Game Framework框架是用流程（Procedure）来处理所有事情的，不同的流程负责不同的工作。

比如菜单流程，负责处理打开、关闭菜单的操作；切换场景流程，负责切换不同的场景。

b.流程的切换是用有限状态机来实现的。

c.切换场景后，初始入口场景不会卸载，因此所有的基础组件功能都仍然生效。

        （GameFramework的状态机以后讲官方Demo的时候讲，目前先会用就行）
        简称FSM系统。
        GameFramework的有限状态机系统提供了一个灵活而可扩展的方式来管理游戏对象或角色的状态和行为。
         它基于Unity的MonoBehaviour组件，允许开发者通过继承和扩展来创建自定义的状态和状态机。
        以下是GameFramework中有限状态机系统的一些关键概念和组件：
        状态（State）：状态表示游戏对象或角色在不同情况下的一种行为模式或状态。
         开发者可以通过继承FsmState<T>类来创建自定义的状态，并实现相应的逻辑和行为。
        状态机（StateMachine）：状态机管理一组状态，并负责处理状态之间的转换。
         开发者可以通过继承Fsm<T>类来创建自定义的状态机，并定义状态之间的转换逻辑。
        转换条件（Transition）：转换条件用于触发状态之间的转换。
         开发者可以通过定义转换条件来控制状态机的行为。GameFramework提供了一些内置的转换条件，如时间到达、消息触发等，同时也支持自定义转换条件。
        动作（Action）：动作是状态之间转换过程中的附加行为。开发者可以通过定义动作来扩展状态机的行为。
         GameFramework提供了一些内置的动作，如播放动画、触发声音等，同时也支持自定义动作。
        使用GameFramework的有限状态机系统，开发者可以创建和管理复杂的游戏对象或角色行为逻辑。
         它提供了一种可扩展和灵活的方式来处理状态和状态转换，并简化了开发过程。
         
         
         
         
         
*/