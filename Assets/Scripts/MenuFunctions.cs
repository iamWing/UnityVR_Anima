using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using Utilities;

public class MenuFunctions : MonoBehaviour {

    [SerializeField]
    private float speed , maxSize, minSize , incrementBy ,decrementBy;

    [SerializeField]
    private float maxAlpha = 1.0f;

    private float incrementAlphaBy, decrementAlphaBy;
    private Color imgColor;

    [SerializeField]
    RectTransform panel;
    [SerializeField]
    Image image;

    [SerializeField] private GameObject m_player;

    private float crtScale,crtAlpha = 0.0f;

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
        crtScale = minSize;
        imgColor = image.color;
        incrementAlphaBy = (100 / ((maxSize - minSize) / incrementBy / maxAlpha)) / 100;
        decrementAlphaBy = (100 / ((maxSize - minSize) / decrementBy / maxAlpha)) / 100;

        InvokeRepeating("IncrementScale", speed,speed);
        CancelInvoke("DecrementScale");
        print("Incrementing" + " " + incrementAlphaBy + " " + decrementAlphaBy);

        ExecuteEvents.Execute<IGvrPointerHoverEvent>(m_player, null, (x, y) => x.OnGvrPointerHover(null));

    }
    public void OnHoverExitButton()
    {
        CancelInvoke("DecrementScale");
        CancelInvoke("IncrementScale");
        panel.localScale = new Vector3(minSize, minSize, minSize);
        print("Decrementing");
    }

    private void IncrementScale()
    {
        panel.localScale = new Vector3(crtScale, crtScale, crtScale);
        image.color = new Color(imgColor.r, imgColor.g, imgColor.b, crtAlpha);
        if (crtScale < maxSize)
        {
            crtScale += incrementBy;
            crtAlpha += incrementAlphaBy;
            print(crtScale +  " " +crtAlpha);
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
        image.color = new Color(imgColor.r, imgColor.g, imgColor.b, crtAlpha);
        if (crtScale > minSize)
        {
            crtScale -= decrementBy;
            crtAlpha -= decrementAlphaBy;
            print(crtScale + " " + crtAlpha);
        }
        else
        {
            crtScale = minSize;
            CancelInvoke("DecrementScale");
            InvokeRepeating("IncrementScale", speed, speed);
        }
    }
}
