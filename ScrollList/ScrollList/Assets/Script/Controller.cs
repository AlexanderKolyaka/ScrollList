using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField]
    private FriendsPopup _popup;


    void Start()
    {

        InitList(_popup.items);
    }

    public void InitList(List<FriendItemView> list)
    {
        for(int i = 0; i < list.Count; i++)
        {
            list[i].SetData(i,"item " + i);
        }
    }

}
