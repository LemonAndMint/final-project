using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kısayol : MonoBehaviour
{
  public Network network;
  public ScrollRect scroll;
  public Transform Background;
  public GameObject Kisayollar;
  site webSite;
  void OnMouseDown(){
    Page page;
    GameObject layout;
    //website ve page alınır 
    webSite = network.getmainSite();
    page = ((WebFile)webSite.getsiteMap().root.slot[0]).getpage();
    //pagedeki layout componenti alınır ve oluşturulur.
    layout = Instantiate(page.layout);
    layout.transform.SetParent(Background);
    
    scroll.content = layout.GetComponent<RectTransform>();
    //kısayollar kapanır
    Kisayollar.SetActive(false);
  }
}
