using SI_UnityUtils;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MenuItemOperator : MonoBehaviour
{
    public Button button;
    public TMP_Text button_Label;
    private InGameContextMenuData _relatedData = null;
    ContextMenuAction _action;
    private float _baseWidth;
    public float BaseWidth
    {
        get { return _baseWidth; }
        set
        {
            _baseWidth = value;
            var panelRect = (RectTransform)transform;
            panelRect.sizeDelta = new Vector2(_baseWidth - 2f, panelRect.sizeDelta.y);
            var buttonRect = (RectTransform)button.transform;
            buttonRect.sizeDelta = new Vector2(_baseWidth -2f, panelRect.sizeDelta.y);
            var textRect = (RectTransform)button_Label.transform;
            textRect.sizeDelta = new Vector2(_baseWidth - 2f, panelRect.sizeDelta.y);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetAction(ContextMenuAction action, InGameContextMenuData relatedObject = null)
    {
        button.onClick.AddListener(Callback);
        _action = action;
        if(relatedObject != null)
        {
            _relatedData = relatedObject;
        }
    }
    void Callback()
    {
        if(_action != null)
        {
            _action(_relatedData);
        }
    }

}
