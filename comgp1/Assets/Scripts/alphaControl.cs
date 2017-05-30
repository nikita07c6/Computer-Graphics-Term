using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alphaControl : MonoBehaviour {
    public Renderer ren;
    Color shellColor;
    public float alpha;
    public bool fade;

	// Use this for initialization
	void Start () {
        ren.material.color = new Color(ren.material.color.r, ren.material.color.g, ren.material.color.b, 0.0f);
        alpha = 0.2f;
    }
	
	// Update is called once per frame
	void Update () {
        setFade();
    }
    public void fadeOut()
    {
        if (alpha > 0)
        {
            alpha -= 0.01f;
            ren.material.color = new Color(ren.material.color.r, ren.material.color.g, ren.material.color.b, alpha);
        }
    }
    public void fadeIn()
    {
        if (alpha < 0.2f)
        {
            alpha += 0.01f;
            ren.material.color = new Color(ren.material.color.r, ren.material.color.g, ren.material.color.b, alpha);
        }
    }
    public void setFade()
    {
        if (fade == true)
        {
            fadeIn();
            
        }
        else
        {
            fadeOut();
           
        }
    }
    public void setFadeBool()
    {
        fade = !fade;
    }
}
