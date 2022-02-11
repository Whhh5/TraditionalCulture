using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doozy.Engine.UI;

public class Fw_FactoryPattern : Wf_SingletonPattern_Mono<Fw_FactoryPattern>
{
    #region Show And Heid ����
    public void ShowPopup(string popupName)
    {
        if (Fw_UIManager.Instance.popups.ContainsKey(popupName))
        {
            return;
        }
        UIPopup tempPopup = null;
        tempPopup = UIPopup.GetPopup(popupName);
        if (tempPopup == null)
        {
            Debug.Log(".......popup �����ڣ����ƴ���.......");
            return;
        }
        Fw_UIManager.Instance.popups.Add(popupName, tempPopup);
        
        tempPopup.Show();
    }

    public void HidePopup(string popupName)
    {
        UIPopup tempPopup = null;
        if (Fw_UIManager.Instance.popups.ContainsKey(popupName))
        {
            tempPopup = Fw_UIManager.Instance.popups[popupName];
            Fw_UIManager.Instance.popups.Remove(popupName);
        }
        else
        {
            Debug.Log(".......popup �����ڣ��޷�����.......");
            return;
        }
        tempPopup.Hide();
    }
    #endregion








    #region "���ɵ�ͼ"


    #endregion
}
