using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InGameContextMenuData
{
}

public class MenuRelatedFloatData : InGameContextMenuData
{
    public float Data { get; set; }
}
public class MenuRelatedObjectData : InGameContextMenuData
{
    public GameObject Data { get; set; }
}
