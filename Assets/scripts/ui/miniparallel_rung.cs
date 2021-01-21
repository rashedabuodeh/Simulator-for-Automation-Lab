using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class miniparallel_rung : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (this.transform.childCount == 0 && this.transform.parent.GetChild(1).childCount == 0)
        { Destroy(this.transform.parent.gameObject);

            Transform rungrect = this.transform.parent.parent.parent.parent;
            RectTransform panelRectTransform = rungrect.GetComponent<RectTransform>();

            panelRectTransform.sizeDelta = new Vector2(panelRectTransform.sizeDelta.x, 38);

        }


            if (this.transform.childCount >= this.transform.parent.GetChild(1).childCount)
            {
            for (int i = 0; i <= this.transform.childCount; i++)
            {


                int rectsizex = 55;

                if (this.transform.childCount == i)
                {
                    RectTransform miniRectTransform = this.transform.GetComponent<RectTransform>();

                    miniRectTransform.sizeDelta = new Vector2(rectsizex + (37 * (i - 1)), miniRectTransform.sizeDelta.y);


                    if (this.transform.parent.childCount == 2)
                    {
                        RectTransform miniRectTransform2 = this.transform.parent.GetChild(1).GetComponent<RectTransform>();

                        miniRectTransform2.sizeDelta = new Vector2(rectsizex + (37 * (i - 1)), miniRectTransform2.sizeDelta.y);
                    }


                    RectTransform miniRectTransformparent = this.transform.parent.GetComponent<RectTransform>();

                    miniRectTransformparent.sizeDelta = new Vector2(rectsizex + 3 + (37 * (i - 1)), miniRectTransformparent.sizeDelta.y);


                    break;
                }
            }
        }
    


    }


}