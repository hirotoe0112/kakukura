using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleController : MonoBehaviour
{
    /// <summary>
    /// ゲーム開始
    /// </summary>
    public void GameStart()
    {
        SceneManager.LoadScene(GlobalConst.SCENE_GAME);
    }

    /// <summary>
    /// ランキング表示
    /// </summary>
    public void Ranking()
    {

    }

    /// <summary>
    /// 図鑑
    /// </summary>
    public void DisplayBook()
    {

    }

    /// <summary>
    /// 遊び方
    /// </summary>
    public void Tutorial()
    {

    }

    /// <summary>
    /// 設定
    /// </summary>
    public void Settings()
    {

    }
}
