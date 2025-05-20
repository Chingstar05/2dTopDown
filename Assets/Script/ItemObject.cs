using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemObject : MonoBehaviour
{
    [SerializeField] itemSo data;
    // Start is called before the first frame update
    public int GetPoint()
    {
        return data.point;
    }

}
