using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public partial class GameController : MonoBehaviour
{
    /// <summary>
    /// ポップアップエリア
    /// </summary>
    [SerializeField]
    private GameObject pnlPopup;

    /// <summary>
    /// ポップアップエリアのアニメーター
    /// </summary>
    private Animator popupAnimator;

    /// <summary>
    /// 設定エリア
    /// </summary>
    [SerializeField]
    private GameObject settingArea;

    /// <summary>
    /// 問題数
    /// </summary>
    [SerializeField]
    private Text txtQuestionAmount;

    /// <summary>
    /// 問題数
    /// </summary>
    private int questionAmount = GlobalConst.QUESTION_AMOUNT_DEFAULT;
}
