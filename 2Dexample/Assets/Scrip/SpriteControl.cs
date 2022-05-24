using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteControl : MonoBehaviour
{

    [SerializeField] private Sprite[] spriteArray;
    public SpriteRenderer spriteRenderer;

    void OnEnable()
    {
        Movement.buttonAction += ChangeSprite;
    }

    void OnDisable()
    {
        Movement.buttonAction -= ChangeSprite;

    }
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        
    }

    //// Update is called once per frame
    //void Update()
    //{
    //    if (Input.GetKey(KeyCode.S))
    //    {
    //        sprit++;
    //        Debug.Log(sprit);
    //        if (sprit > 3)
    //        {
    //            sprit = 0;
    //            Debug.Log("to big");
    //        }
    //    }

    //    ChangeSprite();
    //}

    void ChangeSprite(int sprit)
    {
        spriteRenderer.sprite = spriteArray[sprit];
    }
}
