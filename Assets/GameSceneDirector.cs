using UnityEngine;
using UnityEngine.UI;

public class GameSceneDirector : MonoBehaviour
{
    // UI関連
    [SerializeField] Text textTurnInfo;
    [SerializeField] Text textResultInfo;
    [SerializeField] Button buttonTitle;
    [SerializeField] Button buttonRematch;
    [SerializeField] Button buttonEvolutionApply;
    [SerializeField] Button buttonEvolutionCancel;
    void Start()
    {
        // UI関連初期値設定
        buttonTitle.gameObject.SetActive(false);
        buttonRematch.gameObject.SetActive(false);
        buttonEvolutionApply.gameObject.SetActive(false);
        buttonEvolutionCancel.gameObject.SetActive(false);
        textTurnInfo.text = "";
    }

    // Update is called once per frame
    void Update()
    {

    }
}
