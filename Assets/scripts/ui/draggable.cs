using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;

public class draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{


    public Transform parentToReturnTo = null;
    public Transform placeholderParent = null;
    public Transform org = null;
    GameObject placeholder = null;

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
  
        placeholder = new GameObject();
        
        placeholder.transform.SetParent(this.transform.parent);

       
        LayoutElement le = placeholder.AddComponent<LayoutElement>();
        le.preferredWidth = 30;
        le.preferredHeight = 30;
        le.flexibleWidth = 0;
        le.flexibleHeight = 0;

        RectTransform Rectplaceholder = placeholder.transform.GetComponent<RectTransform>();
        Rectplaceholder.sizeDelta = new Vector2(50,50);

        placeholder.transform.SetSiblingIndex(this.transform.GetSiblingIndex());

        parentToReturnTo = this.transform.parent;
        placeholderParent = parentToReturnTo;
        this.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform);
        org = parentToReturnTo;


        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        //Debug.Log ("OnDrag");

        if (placeholderParent != null)
        {
            this.transform.position = eventData.position;

            if (placeholder.transform.parent != placeholderParent)
                placeholder.transform.SetParent(placeholderParent);

            int newSiblingIndex = placeholderParent.childCount;

            for (int i = 0; i < placeholderParent.childCount; i++)
            {
                if (this.transform.position.x < placeholderParent.GetChild(i).position.x)
                {

                    newSiblingIndex = i;

                    if (placeholder.transform.GetSiblingIndex() < newSiblingIndex)
                        newSiblingIndex--;

                    break;
                }
            }

            placeholder.transform.SetSiblingIndex(newSiblingIndex);
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
        this.transform.SetParent(parentToReturnTo);

        if (placeholderParent == GameObject.FindGameObjectWithTag("Panel out").transform )
        { this.transform.SetParent(org);  }

        this.transform.SetSiblingIndex(placeholder.transform.GetSiblingIndex());
        GetComponent<CanvasGroup>().blocksRaycasts = true;
                Destroy(placeholder);

        Destroy(GameObject.Find("Canvas/menu/Basic/Panel 1(Clone)"));
        Destroy(GameObject.Find("Canvas/menu/Timers & Counters/Panel 2(Clone)"));
        Destroy(GameObject.Find("Canvas/menu/Bit/Panel 3(Clone)"));
        Destroy(GameObject.Find("Canvas/menu/Compare/Panel 4(Clone)"));
        Destroy(GameObject.Find("Canvas/menu/Math/Panel 5(Clone)"));
        Destroy(GameObject.Find("Canvas/menu/simulate/Panel 6(Clone)"));


    }
    void OnTriggerEnter2D(Collider2D other)
    {
      Destroy(placeholder);

    }


}
