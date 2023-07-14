using System;
using System.Collections;
using System.Collections.Generic;
using GameFramework;
using GameFramework.DataTable;
using GameFramework.Event;
using GameFramework.Procedure;
using UnityEngine;
using UnityGameFramework.Runtime;
using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;

public class Demo6_ProcedureLaunch : ProcedureBase
{
    protected override void OnEnter(ProcedureOwner procedureOwner)
    {
        base.OnEnter(procedureOwner); // 获取框架实体组件
        EntityComponent entityComponent
            = UnityGameFramework.Runtime.GameEntry.GetComponent<EntityComponent>(); // 创建实体
        entityComponent.ShowEntity<Demo6_HeroLogic>(1, "Assets/Demo6/CubeEntity.prefab", "EntityGroup");
        //和加载UI类似 也要创建一个Group
    }
}