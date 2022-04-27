using System.Collections;
using System.Collections.Generic;

public class site
{
  string name;
  string adress;
  int capasity;
  int maxSupportedBandwith;
  filesystem sitemap;

  public site(){

    sitemap = new filesystem();

  }
  //web sayfasını barındıran makinenin yeniden çalıştırılması
  public void reload(){}
  //web sayfasını açmak için gerekli metod
  public void request(){}

}
