using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TestText : MonoBehaviour {
    public Transform canvas_t;
    public Color textColor;
    public Font aFont;
    private GameObject textFunction; // 
    private int numOfTexts = 5; // this will be # of rows in csv file
	// Use this for initialization
	void Start () {

        for (int i = 0; i < numOfTexts; i++)
        {
            textFunction = CreateText(canvas_t, 10, 10, "hello", 20, aFont, textColor);
            //Instantiate(textFunction);
        }
    }
	
	// Update is called once per frame
	void Update () {
	    
	}

    GameObject CreateText(Transform canvas_transform, float x, float y, string text_to_print, int font_size, Font someFont, Color text_color)
    {
        GameObject UItextGO = new GameObject("Text2");
        UItextGO.transform.SetParent(canvas_transform);

        RectTransform trans = UItextGO.AddComponent<RectTransform>();
        trans.anchoredPosition = new Vector2(x, y);

        Text text = UItextGO.AddComponent<Text>();
        text.text = text_to_print;
        text.font = someFont;
        text.fontSize = font_size;
        text.color = text_color;

        return UItextGO;
    }
}
