using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class dropzoneout : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{

	public void OnPointerEnter(PointerEventData eventData)
	{
		//Debug.Log("OnPointerEnter");
		if (eventData.pointerDrag == null)
			return;

		draggableout d = eventData.pointerDrag.GetComponent<draggableout>();
		if (d != null)
		{
			d.placeholderParent = this.transform;
		}
	}

	public void OnPointerExit(PointerEventData eventData)
	{
		//Debug.Log("OnPointerExit");
		if (eventData.pointerDrag == null)
			return;

		draggableout d = eventData.pointerDrag.GetComponent<draggableout>();
		if (d != null && d.placeholderParent == this.transform)
		{
			d.placeholderParent = d.parentToReturnTo;
		}
	}

	public void OnDrop(PointerEventData eventData)
	{
		Debug.Log(eventData.pointerDrag.name + " was dropped on " + gameObject.name);

		draggableout d = eventData.pointerDrag.GetComponent<draggableout>();
		if (d != null)
		{
			d.parentToReturnTo = this.transform;

		}

	}


}
