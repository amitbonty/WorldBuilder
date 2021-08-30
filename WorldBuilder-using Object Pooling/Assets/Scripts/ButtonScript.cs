using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public GameObject _prefab;
    public Image _image;
    private Image _UIImage;
    public SpawnObject _spawnner;

    void Start()
    {
         _UIImage = GetComponent<Image>();
        _image = _spawnner.gameObject.GetComponent<Image>();
    }


    public void ChangeObject()
    {
        _spawnner._tagName = this.gameObject.tag;
        _image.sprite = _UIImage.sprite;
    }
}
