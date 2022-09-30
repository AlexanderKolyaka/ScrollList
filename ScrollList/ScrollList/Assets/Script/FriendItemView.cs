using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FriendItemView : MonoBehaviour
{
    [SerializeField]
    private string _nameText;
    private int id;

    public void SetData(int index, string friendName)
    {
        this.id = index;
        _nameText = friendName;
        this.gameObject.GetComponentInChildren<Text>().text = _nameText;
    }

    public int GetId()
    {
        return id;
    }
}

