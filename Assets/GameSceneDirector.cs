using UnityEngine;
using UnityEngine.UI;

// ゲームシーンを統括するスクリプト
public class GameSceneDirector : MonoBehaviour
{
    // UI関連
    [SerializeField] Text textTurnInfo;
    [SerializeField] Text textResultInfo;
    [SerializeField] Button buttonTitle;
    [SerializeField] Button buttonRematch;
    [SerializeField] Button buttonEvolutionApply;
    [SerializeField] Button buttonEvolutionCancel;

    // ゲーム設定
    const int PlayerMax = 2; // プレイヤー数
    int boardWidth;
    int boardHeight;

    // タイルのプレハブ
    [SerializeField] GameObject prefabTile;
    void Start()
    {
        // UI関連初期値設定
        buttonTitle.gameObject.SetActive(false);
        buttonRematch.gameObject.SetActive(false);
        buttonEvolutionApply.gameObject.SetActive(false);
        buttonEvolutionCancel.gameObject.SetActive(false);
        textTurnInfo.text = "";

        // ボードサイズ
        boardWidth = 9;
        boardHeight = 9;

        // タイル(将棋盤)の生成
        for (int i = 0; i < boardWidth; i++)
        {
            for (int j = 0; j < boardHeight; j++)
            {
                // タイルとユニットのポジション
                float x = i - boardWidth / 2;
                float y = j - boardHeight / 2;

                // ポジション(3D空間のどこに配置するか)
                Vector3 pos = new Vector3(x, 0, y);

                // タイル(将棋盤のマス目)生成
                GameObject tile = Instantiate(prefabTile, pos, Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
