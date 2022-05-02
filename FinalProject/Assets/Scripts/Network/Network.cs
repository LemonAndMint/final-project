using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Network : MonoBehaviour
{
  public Page mainSitePage;
  site mainSite;
  public site getmainSite(){ return mainSite; }
  // Start is called before the first frame update
  void Start()
  {
    mainSite = new site(mainSitePage); 
  }

  // Update is called once per frame
  void Update()
  {
    
  }
}
