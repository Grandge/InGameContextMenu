using SI_UnityUtils;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Encord UTF-8
/// <summary>
/// ヒエラルキーにある適当なGameObjectにアタッチしてご利用ください
/// </summary>
public class Sample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            ContextMenuProc();
        }

    }
    private void ContextMenuProc()
    {
        //二度目の右クリックで閉じるための処理
        if (InGameContextMenu.IsActive)
        {
            InGameContextMenu.Close();
            return;
        }
        //データ無しの処理のサンプル
        InGameContextMenu.OpenMenu(Input.mousePosition);
        InGameContextMenu.AddContextMenu("テスト1", (dummy) => { Debug.Log("テスト1"); InGameContextMenu.Close(); });
        InGameContextMenu.AddContextMenu("テスト2", (dummy) => { Debug.Log("テスト2"); InGameContextMenu.Close(); });
        InGameContextMenu.AddContextMenu("テスト3", (dummy) => { Debug.Log("テスト3"); InGameContextMenu.Close(); });
        InGameContextMenu.AddContextMenu("テスト4", (dummy) => { Debug.Log("テスト4"); InGameContextMenu.Close(); });

        ////データ付きの処理のサンプル
        //MenuRelatedFloatData data1 = new MenuRelatedFloatData();
        //MenuRelatedFloatData data2 = new MenuRelatedFloatData();
        //MenuRelatedFloatData data3 = new MenuRelatedFloatData();
        //MenuRelatedFloatData data4 = new MenuRelatedFloatData();
        //data1.Data = 1f;
        //data2.Data = 2f;
        //data3.Data = 3f;
        //data4.Data = 4f;
        //InGameContextMenu.OpenMenu(Input.mousePosition, 80f);//横幅(80f)を指定
        //InGameContextMenu.AddContextMenu("テスト1", CbButtonAction, data1);
        //InGameContextMenu.AddContextMenu("テスト2", CbButtonAction, data2);
        //InGameContextMenu.AddContextMenu("テスト3", CbButtonAction, data3);
        //InGameContextMenu.AddContextMenu("テスト4", CbButtonAction, data4);

    }
    void CbButtonAction(InGameContextMenuData data)
    {
        MenuRelatedFloatData f = (MenuRelatedFloatData)data;
        Debug.Log(string.Format("データ={0}", f.Data));
        InGameContextMenu.Close();
    }
}
