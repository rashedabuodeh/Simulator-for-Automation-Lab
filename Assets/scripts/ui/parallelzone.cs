using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using System.Collections;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class parallelzone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{

	public Transform rungrect = null; // Reference to the panel transform.

	public void OnPointerEnter(PointerEventData eventData)
	{
		//Debug.Log("OnPointerEnter");

				rungrect = this.transform.parent.parent.parent;
	}

	public void OnPointerExit(PointerEventData eventData)
	{
		//Debug.Log("OnPointerExit");
	}

	public void OnDrop(PointerEventData eventData)
	{
		Debug.Log(eventData.pointerDrag.name + " was dropped on " + gameObject.name);

		parallel_instruction d = eventData.pointerDrag.GetComponent<parallel_instruction>();
		if (d != null)
		{
			
			GameObject minirungobj = Instantiate(d.minirung, this.transform.parent) as GameObject;
			minirungobj.transform.SetSiblingIndex(this.transform.GetSiblingIndex());
			this.transform.SetParent(minirungobj.transform.GetChild(0).gameObject.transform);

			// change the rung height

			if (rungrect != null)
			{
				RectTransform panelRectTransform = rungrect.GetComponent<RectTransform>();

				panelRectTransform.sizeDelta = new Vector2(panelRectTransform.sizeDelta.x, 76);
			}

		}
	}
}
