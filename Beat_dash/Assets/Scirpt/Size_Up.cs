using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Size_Up : MonoBehaviour
{
    // Start is called before the first frame update
    public void PointerEnter()
    {
        transform.localScale = new Vector2(1.2f, 1.2f);
    }

    public void PointerExit()
    {
        transform.localScale = new Vector2(1f, 1f);
    }
    // Update is called once per frameå

}
