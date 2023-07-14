using System.Collections;
using System.Collections.Generic;
using GameFramework;
using GameFramework.Procedure;
using UnityEngine;
using UnityGameFramework.Runtime;
using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;

public class Demo3_ProcedureLaunch : ProcedureBase
{
    protected override void OnEnter(ProcedureOwner procedureOwner)

    {
        base.OnEnter(procedureOwner);

        SceneComponent scene
            = UnityGameFramework.Runtime.GameEntry.GetComponent<SceneComponent>();
        // 切换场景
        scene.LoadScene("Assets/Demo3/Demo3_Menu.unity"); //        *****同时场景要拖到Build Settings的Scenes InBuild*****
        
        // 切换流程  Demo3_ProcedureMenu为切换到的流程脚本
        ChangeState<Demo3_ProcedureMenu>(procedureOwner);
    }
}