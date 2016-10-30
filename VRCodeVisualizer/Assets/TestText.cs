using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TestText : MonoBehaviour {
    public Transform canvas_t;
    public Color textColor;
    public Font aFont;
    public string someStr;
    private GameObject textFunction; // 
    private int numOfTexts = 4; // this will be # of functions
    float[] xCoords = { 0, 0, (float)9.9, (float)-9.9}; // need new data 
    float[] yCoords = { (float)-1.7, (float)-1.7, (float)-1.7, (float)-1.7 }; // need new data 
    float[] zCoords = { (float)9.9, (float)-9.9, 0, 0}; // need new data 
    float[] xRot = { 0, 0, 0, 0 }; // need new data 
    float[] yRot = { 0, 180, 90, -90 }; // need new data 
    float[] zRot = { 0, 0, 0, 0 }; // need new data 
    void Start () {
        for (int i = 0; i < numOfTexts; i++)
        {
            GameObject t = GameObject.FindGameObjectWithTag("" + (i+1));
            Text text = t.GetComponent<Text>();
            text.text = someStr;

            //textFunction = CreateText(canvas_t, xCoords[i], yCoords[i], zCoords[i], xRot[i], yRot[i], zRot[i], someStr, 20, aFont, textColor);
        }
    }
	
	// Update is called once per frame
	void Update () {
	    
	}

    GameObject CreateText(Transform canvas_transform, float x, float y, float z, float rot_x, float rot_y, float rot_z, string text_to_print, int font_size, Font someFont, Color text_color)
    {
        GameObject UItextGO = new GameObject("Text2");
        UItextGO.transform.SetParent(this.transform);

        RectTransform trans = UItextGO.AddComponent<RectTransform>();
        trans.sizeDelta = new Vector2(200, 200);
        trans.anchoredPosition3D = new Vector3(x, y, z);
        trans.localScale = new Vector3((float)0.1, (float)0.1, (float)0.1);
        trans.localRotation = new Quaternion(rot_x, rot_y, rot_z, 0);

        Text text = UItextGO.AddComponent<Text>();
        text.text = text_to_print;
        text.font = someFont;
        text.fontSize = font_size;
        text.color = text_color;

        return UItextGO;
    }
}
