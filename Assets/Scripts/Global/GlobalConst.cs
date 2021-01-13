using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalConst
{
    #region シーン名
    /// <summary>
    /// シーン名
    /// </summary>
    public const string SCENE_TITLE = "TitleScene";
    public const string SCENE_GAME = "GameScene";
    #endregion

    /// <summary>
    /// パネルの内容を表示／非表示するタイミング
    /// </summary>
    public const float PANEL_DISPLAY_WAIT = 0.2f;

    /// <summary>
    /// デフォルト問題数
    /// </summary>
    public const int QUESTION_AMOUNT_DEFAULT = 10;

    /// <summary>
    /// 最大問題数
    /// </summary>
    public const int QUESTION_AMOUNT_MAX = 30;
}
