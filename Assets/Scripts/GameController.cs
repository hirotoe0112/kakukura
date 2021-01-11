using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public partial class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    IEnumerator Start()
    {
        //最初は設定パネルを非表示
        settingArea.SetActive(false);

        //デフォルト問題数をセット
        txtQuestionAmount.text = questionAmount.ToString();

        //問題数選択エリアをポップアップ
        popupAnimator = pnlPopup.GetComponent<Animator>();
        popupAnimator.SetBool("IsPopup", true);

        //設定エリアを表示するまで少し待つ
        yield return new WaitForSecondsRealtime(0.2f);

        //設定パネルを表示
        settingArea.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// 問題数増減
    /// </summary>
    /// <param name="isMinus"></param>
    public void ChangeQuestionAmount(bool isMinus)
    {
        if(isMinus && questionAmount != 5)
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

    public void QuestionAmountSelected()
    {
        popupAnimator.SetBool("IsPopdown", true);
        settingArea.SetActive(false);
    }

}
