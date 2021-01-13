using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public partial class GameController : MonoBehaviour
{
    /// <summary>
    /// 初期処理
    /// </summary>
    /// <returns></returns>
    IEnumerator Start()
    {
        //最初は設定パネルとゲームエリアを非表示
        settingArea.SetActive(false);
        gameArea.SetActive(false);

        //デフォルト問題数をセット
        txtQuestionAmount.text = questionAmount.ToString();

        //問題数選択エリアをポップアップ
        popupAnimator = pnlPopup.GetComponent<Animator>();
        popupAnimator.SetBool("IsPopup", true);

        //少し待ってから設定エリアを表示
        yield return new WaitForSecondsRealtime(GlobalConst.PANEL_DISPLAY_WAIT);

        //設定パネルを表示
        settingArea.SetActive(true);
    }

    /// <summary>
    /// ゲームメイン処理
    /// </summary>
    /// <returns></returns>
    private IEnumerator GameMain()
    {
        //少し待ってから設定エリアを非表示
        yield return new WaitForSecondsRealtime(GlobalConst.PANEL_DISPLAY_WAIT);
        settingArea.SetActive(false);



        Debug.Log("AAA");
    }

    /// <summary>
    /// 問題数増減ボタンクリック時
    /// </summary>
    /// <param name="isMinus"></param>
    public void ChangeQuestionAmount(bool isMinus)
    {
        if(isMinus && questionAmount > 5)
        {
            questionAmount -= 5;
        }
        else if(!isMinus && questionAmount != GlobalConst.QUESTION_AMOUNT_MAX)
        {
            questionAmount += 5;
        }

        //UI更新
        txtQuestionAmount.text = questionAmount.ToString();
    }

    /// <summary>
    /// スタートボタンクリック時
    /// </summary>
    public void QuestionAmountSelected()
    {
        //ポップダウンアニメーション
        popupAnimator.SetBool("IsPopdown", true);

        //ゲームを開始
        StartCoroutine(GameMain());
    }

}
