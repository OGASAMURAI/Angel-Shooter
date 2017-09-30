using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Button))]
public class StartButton : UIBehaviour
{
    protected override void Start()
    {
        base.Start();

        // Buttonクリック時、OnClickメソッドを呼び出す
        GetComponent<Button>().onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        // shootシーンに遷移する
        SceneManager.LoadScene("shoot");
    }
}