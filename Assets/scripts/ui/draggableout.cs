using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;

public class draggableout : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
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
        le.preferredWidth = this.GetComponent<LayoutElement>().preferredWidth;
        le.preferredHeight = this.GetComponent<LayoutElement>().preferredHeight;
        le.flexibleWidth = 0;
        le.flexibleHeight = 0;
        RectTransform Rectplaceholderout = placeholder.transform.GetComponent<RectTransform>();
        Rectplaceholderout.sizeDelta = new Vector2(50, 50);

        placeholder.transform.SetSiblingIndex(this.transform.GetSiblingIndex());

        parentToReturnTo = this.transform.parent;
        placeholderParent = parentToReturnTo;
        this.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform);
        org = placeholderParent;
        placeholder.tag = "newobj";



        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        //Debug.Log ("OnDrag");

        this.transform.position = eventData.position;

        if (placeholder.transform.parent != placeholderParent)
        {
            if (placeholderParent.transform.childCount ==0)
                placeholder.transform.SetParent(placeholderParent);
        }

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

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
        this.transform.SetParent(placeholder.transform.parent);

       

      //  if (placeholderParent == GameObject.FindGameObjectWithTag("panel").transform)
      //  { this.transform.SetParent(org); }


        this.transform.SetSiblingIndex(placeholder.transform.GetSiblingIndex());
        GetComponent<CanvasGroup>().blocksRaycasts = true;
        Destroy(placeholder);
       // Destroy(GameObject.FindGameObjectWithTag("newobj"));

        //if (this.transform.parent.childCount != 1)
        // { this.transform.SetParent(org); }

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
