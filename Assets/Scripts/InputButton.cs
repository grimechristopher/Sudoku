using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputButton : MonoBehaviour
{
    public static InputButton instance;
    SudokuCell lastCell;
    [SerializeField] GameObject wrongText;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(false);
    }

    public void ActivateInputButton(SudokuCell cell)
    {
        this.gameObject.SetActive(true);
        lastCell= cell;
    }

    public void ClickedButton(int num)
    {
        lastCell.UpdateValue(num);
        wrongText.SetActive(false);
        this.gameObject.SetActive(false);
    }



}
