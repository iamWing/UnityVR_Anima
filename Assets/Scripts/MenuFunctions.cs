using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuFunctions : MonoBehaviour {

    [SerializeField]
    private float speed =0.05f, maxSize = 1.3f, minSize = 1.0f, incrementBy = 0.02f,decrementBy = 0.04f;
    [SerializeField]
    RectTransform panel;

    private float crtScale = 1.0f;
    
	// Use this for initialization
	void Start () {
		
	}
	
	public void OnStartJourneyButton()
    {
        SceneManager.LoadScene(1);
    }
    public void OnQuitButton()
    {
        Application.Quit();
    }
    public void OnHoverButton()
    {
        InvokeRepeating("IncrementScale", speed,speed);
        CancelInvoke("DecrementScale");
        print("Incrementing");
    }
    public void OnHoverExitButton()
    {
        CancelInvoke("DecrementScale");
        CancelInvoke("IncrementScale");
        panel.localScale = Vector3.one;
        print("Decrementing");
    }

    private void IncrementScale()
    {
        panel.localScale = new Vector3(crtScale, crtScale, crtScale);
        if (crtScale < maxSize)
        {
            crtScale += incrementBy;
            print(crtScale);
        }
        else
        {
            crtScale = maxSize;
            CancelInvoke("IncrementScale");
            InvokeRepeating("DecrementScale",speed,speed);
        }
    }
    private void DecrementScale()
    {
        panel.localScale = new Vector3(crtScale, crtScale, crtScale);
        if (crtScale > minSize)
        {
            crtScale -= decrementBy;
        }
        else
        {
            crtScale = minSize;
            CancelInvoke("DecrementScale");
            InvokeRepeating("IncrementScale", speed, speed);
        }
    }
}
