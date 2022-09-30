
#pragma warning disable 0649
using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UIElements;

public class FriendsPopup : MonoBehaviour
{
    [SerializeField]
    private FriendItemView[] _views;

    [SerializeField]
    private RectTransform _content;

    public event Action<int, FriendItemView> ItemShowed = delegate { };
    public List<FriendItemView> items;
    [SerializeField]
    private GameObject _scrollItem;

    [SerializeField]
    private List<GameObject> _scrollItemsList;

    public ScrollRect scrollRect;
    private float value = 1f;

    public void AddItem(Vector2 value)
    {
        GameObject temp;
        Debug.Log(value);
        if (scrollRect.verticalNormalizedPosition >= value.y)
        {
            //Debug.Log(value);
            temp = Instantiate(_scrollItem, this.transform); ;
            temp.GetComponent<FriendItemView>().SetData(items.Count + 1, "Item " + items[items.Count - 1].GetId().ToString());
            items.Add(temp.GetComponent<FriendItemView>());
            _scrollItemsList.Add(temp);

        }
        if (this.value < value.y)
        {
            Debug.Log("123");
            Destroy(_scrollItemsList[_scrollItemsList.Count - 1]);
            _scrollItemsList.Remove(_scrollItemsList[_scrollItemsList.Count - 1]);
            items.Remove(items[items.Count - 1]);

        }
    }


    void OnEnable()
    {

        scrollRect.onValueChanged.AddListener(AddItem);
    }

    void OnDisable()
    {

        scrollRect.onValueChanged.RemoveListener(AddItem);
    }


}