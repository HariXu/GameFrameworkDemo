/*
 * 名称：DRHero.cs
 * 作者：HanXu
 * 功能：
*/

using System.Collections;
using System.Collections.Generic;
using GameFramework.DataTable;
using UnityEngine;
public class DRHero : IDataRow
{
    public bool ParseDataRow(string dataRowString, object userData)
    {
        string[] text = dataRowString.Split('\t');

        int index = 0;
        index++; // 跳过#注释列

        Id = int.Parse(text[index++]);
        Name = text[index++];
        Atk = int.Parse(text[index++]);

        return true;
    }

    public bool ParseDataRow(byte[] dataRowBytes, int startIndex, int length, object userData)
    {
        return false;
    }

    public int Id { get; protected set; }
    public string Name { get; private set; }
    public int Atk { get; private set; }
    
}

