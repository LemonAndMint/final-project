using System.Collections;
using System.Collections.Generic;

public class site
{
  string name;
  string adress;
  int capasity;
  int maxSupportedBandwith;
  filesystem sitemap;
  WebFile homePage;

  public site(){

    sitemap = new filesystem();

  }
  public site(Page homePageLayout){

    sitemap = new filesystem();
    //ilk önce homePageLayout alınır ve yeni bir WebFile dosyası oluşturulur
    //ardından oluşturulan WebFile dosyası "Home" sayfası olarak belirlenir.
    homePage = sitemap.createWebFile(new int[] { 0 }, "Home", homePageLayout); 

  }
  //web sayfasını barındıran makinenin yeniden çalıştırılması
  public void reload(){}
  //web sayfasını açmak için gerekli metod
  public void request(){}
 
}
